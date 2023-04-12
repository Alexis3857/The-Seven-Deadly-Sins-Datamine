using Decryptor;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ServiceStack;
using System.Reflection;
using System.Text;

namespace BundleManager
{
    public class BundleManager
    {
        public BundleManager(string patchRelativeSub, string patchVersion, string decryptionKey, string previousDirectoryVersion)
        {
            _currentRootDirectory = Path.Join(Directory.GetCurrentDirectory(), "JP", patchVersion);
            _previousRootDirectory = Path.Join(Directory.GetCurrentDirectory(), "JP", previousDirectoryVersion);
            _bundleDownloader = new BundleDownloader(patchRelativeSub, patchVersion);
            _bundleDecryptor = new BundleDecryptor(decryptionKey);
            _assetExporter = new AssetExporter(_currentRootDirectory);
            _bundleComparer = new BundleComparer(_currentRootDirectory, _previousRootDirectory);
        }

        // Downloads only the mandatory files to be used next time
        public void DownloadBaseOnly()
        {
            Console.WriteLine("\nDownloading bundles...");
            string bmdataDirectory = Path.Join(_currentRootDirectory, "Bmdata");
            if (!Directory.Exists(bmdataDirectory))
            {
                Directory.CreateDirectory(bmdataDirectory);
            }
            if (!Directory.Exists(Path.Join(bmdataDirectory, "Exported")))
            {
                Directory.CreateDirectory(Path.Join(bmdataDirectory, "Exported"));
            }
            foreach (string folder in _folderList)
            {
                byte[] bmdata = _bundleDownloader.DownloadBmdataFile(folder).Result;
                File.WriteAllBytes(Path.Join(bmdataDirectory, folder), _bundleDecryptor.Decrypt(bmdata));
                _assetExporter.ExportBmdataFile(folder);
                if (folder.Equals("jal"))
                {
                    BinaryReader reader = new BinaryReader(File.Open(Path.Join(bmdataDirectory, "Exported", "jal_BundleData.bytes"), FileMode.Open));
                    int count = reader.ReadInt32();
                    for (int i = 0; i < count; i++)
                    {
                        BundleData bundleData = new BundleData(reader);
                        if (bundleData.Name.Equals("localizestring_japanese"))
                        {
                            reader = new BinaryReader(File.Open(Path.Join(bmdataDirectory, "Exported", "jal_BundlePackData.bytes"), FileMode.Open));
                            count = reader.ReadInt32();
                            for (int j = 0; j < count; j++)
                            {
                                BundlePackData bundlePackData = new BundlePackData(reader);
                                if (bundlePackData.IncludeBundles.Contains(bundleData.Checksum))
                                {
                                    _bundleDownloader.DownloadBundlePackFile(folder, new List<string> { bundlePackData.Name }).Wait();
                                    break;
                                }
                            }
                            string localizeFilePath = Path.Join(_currentRootDirectory, "Bundles", folder, bundleData.Checksum);
                            File.WriteAllBytes(localizeFilePath, GetRepairedFile(localizeFilePath));
                            Console.WriteLine("\nExporting localization...");
                            _assetExporter.ExportFolderFiles("jal", new Dictionary<string, BundleData>
                            {
                                { bundleData.Checksum, bundleData }
                            });
                            break;
                        }
                    }
                }
            }
        }

        public void Process()
        {
            Console.WriteLine("\nDownloading bundles...");
            string bmdataDirectory = Path.Join(_currentRootDirectory, "Bmdata");
            if (!Directory.Exists(bmdataDirectory))
            {
                Directory.CreateDirectory(bmdataDirectory);
            }
            if (!Directory.Exists(Path.Join(bmdataDirectory, "Exported")))
            {
                Directory.CreateDirectory(Path.Join(bmdataDirectory, "Exported"));
            }
            foreach (string folder in _folderList)
            {
                byte[] bmdata = _bundleDownloader.DownloadBmdataFile(folder).Result;
                File.WriteAllBytes(Path.Join(bmdataDirectory, folder), _bundleDecryptor.Decrypt(bmdata));
                _assetExporter.ExportBmdataFile(folder);
                Dictionary<string, BundleData> checksumAssetsDictionary = _bundleComparer.GetNewChecksumAssetsDictionary(folder);
                folderChecksumAssetsDictionary.Add(folder, checksumAssetsDictionary);
                if (checksumAssetsDictionary.Count != 0)
                {
                    List<string> bundleNameList = _bundleComparer.GetBundleNameList(folder, checksumAssetsDictionary.Keys.ToList());
                    _bundleDownloader.DownloadBundlePackFile(folder, bundleNameList).Wait();
                    foreach (FileInfo fileInfo in new DirectoryInfo(Path.Join(_currentRootDirectory, "Bundles", folder)).GetFiles())
                    {
                        if (checksumAssetsDictionary.ContainsKey(fileInfo.Name))
                        {
                            if (checksumAssetsDictionary[fileInfo.Name].Encrypt)
                            {
                                byte[] decryptedAsset = _bundleDecryptor.Decrypt(File.ReadAllBytes(fileInfo.FullName));
                                File.WriteAllBytes(fileInfo.FullName, decryptedAsset);
                            }
                            else
                            {
                                File.WriteAllBytes(fileInfo.FullName, GetRepairedFile(fileInfo.FullName));
                            }
                        }
                        else
                        {
                            File.Delete(fileInfo.FullName);
                        }
                    }
                }
            }
            Console.WriteLine("\nExporting assets...");
            foreach (string folder in _folderList)
            {
                _assetExporter.ExportFolderFiles(folder, folderChecksumAssetsDictionary[folder]);
            }
            Localization.Localizer.Load(_currentRootDirectory, _previousRootDirectory);
            Localization.Localizer.WriteNewStringsToFile(_currentRootDirectory);
            TransformDatabase();
        }

        // The assets have fake headers that have to be deleted so they can be loaded
        private byte[] GetRepairedFile(string fileName)
        {
            byte[] fileContent = File.ReadAllBytes(fileName);
            try
            {
                if (Encoding.UTF8.GetString(fileContent, 0, 12).Equals("UnityArchive"))
                {
                    int bundleSize = BitConverter.ToInt32(fileContent, 0x37);
                    return fileContent[^bundleSize..].ToArray();  // Extract last bundleSize bytes from fileContent array
                }
            }
            catch
            {
                Console.WriteLine("Failed to repair " + fileName);
            }
            return fileContent;
        }

        // The database contains binary files that have to be transformed in order to be understood 
        private void TransformDatabase()
        {
            Console.WriteLine("\nTransforming the database...");
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_ai_customizing_Basic_Preset.csv"), typeof(DBAiCustomizingBasicPresetRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_ai_customizing_condition.csv"), typeof(DBAiCustomizingConditionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_ai_customizing_cost.csv"), typeof(DBAiCustomizingCostRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_ai_customizing_etc.csv"), typeof(DBAiCustomizingEtcRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_ai_customizing_group.csv"), typeof(DBAiCustomizingGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_ai_customizing_icon.csv"), typeof(DBAiCustomizingIconRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_ai_customizing_move.csv"), typeof(DBAiCustomizingMoveRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_ai_customizing_move_type.csv"), typeof(DBAiCustomizingMoveTypeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_ai_customizing_skill_type.csv"), typeof(DBAiCustomizingSkillTypeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_ai_customizing_target.csv"), typeof(DBAiCustomizingTargetRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_ar_characters.csv"), typeof(DBArCharactersRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_ar_devices.csv"), typeof(DBArDevicesRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_ar_systems.csv"), typeof(DBArSystemsRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_area.csv"), typeof(DBAreaRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_artifact_card.csv"), typeof(DBArtifactCardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_artifact_card_union.csv"), typeof(DBArtifactCardUnionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_artifact_category.csv"), typeof(DBArtifactCategoryRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_artifact_event_group.csv"), typeof(DBArtifactEventGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_artifact_group.csv"), typeof(DBArtifactGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_attendance_hero.csv"), typeof(DBAttendanceHeroRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_attendance_package.csv"), typeof(DBAttendancePackageRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_basepoint_collision_npc.csv"), typeof(DBBasepointCollisionNpcRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_basepoint_fellow_reward.csv"), typeof(DBBasepointFellowRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_basepoint_interactive_ani.csv"), typeof(DBBasepointInteractiveAniRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_basepoint_npc.csv"), typeof(DBBasepointNpcRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_basepoint_npc_move.csv"), typeof(DBBasepointNpcMoveRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_basepoint_npc_talk.csv"), typeof(DBBasepointNpcTalkRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_basepoint_random_shop.csv"), typeof(DBBasepointRandomShopRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_basepoint_shop.csv"), typeof(DBBasepointShopRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_birthday.csv"), typeof(DBBirthdayRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_blind_content.csv"), typeof(DBBlindContentRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_box_item_info.csv"), typeof(DBBoxItemInfoRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_bundle_discount_package.csv"), typeof(DBBundleDiscountPackageRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_cardpack_artifact_event.csv"), typeof(DBCardpackArtifactEventRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_cardpack_artifact_info.csv"), typeof(DBCardpackArtifactInfoRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_cardpack_package_info.csv"), typeof(DBCardpackPackageInfoRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_chapter.csv"), typeof(DBChapterRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_chapter_change.csv"), typeof(DBChapterChangeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_chapter_group.csv"), typeof(DBChapterGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_character_localize_info.csv"), typeof(DBCharacterLocalizeInfoRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_coin_shop.csv"), typeof(DBCoinShopRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_coin_shop_event.csv"), typeof(DBCoinShopEventRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_coin_shop_setting.csv"), typeof(DBCoinShopSettingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_config_game.csv"), typeof(DBConfigGameRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_const_manastone_random.csv"), typeof(DBConstManastoneRandomRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_constellation_base.csv"), typeof(DBConstellationBaseRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_constellation_ignore_team.csv"), typeof(DBConstellationIgnoreTeamRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_constellation_stone.csv"), typeof(DBConstellationStoneRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_content_ad.csv"), typeof(DBContentAdRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_content_ad_roulette.csv"), typeof(DBContentAdRouletteRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_content_control.csv"), typeof(DBContentControlRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_content_link.csv"), typeof(DBContentLinkRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_contents_passive.csv"), typeof(DBContentsPassiveRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_control_another.csv"), typeof(DBControlAnotherRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_cooking_list.csv"), typeof(DBCookingListRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_cooking_material.csv"), typeof(DBCookingMaterialRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_cooking_recipe.csv"), typeof(DBCookingRecipeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_costume_base.csv"), typeof(DBCostumeBaseRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_costume_change_sfx.csv"), typeof(DBCostumeChangeSfxRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_costume_craft.csv"), typeof(DBCostumeCraftRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_costume_shop.csv"), typeof(DBCostumeShopRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_costume_shop_group.csv"), typeof(DBCostumeShopGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_costume_shop_package.csv"), typeof(DBCostumeShopPackageRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_costume_shop_setting.csv"), typeof(DBCostumeShopSettingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_costume_stat.csv"), typeof(DBCostumeStatRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_creature_passive.csv"), typeof(DBCreaturePassiveRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_daily_attendance.csv"), typeof(DBDailyAttendanceRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_direct_selector.csv"), typeof(DBDirectSelectorRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event.csv"), typeof(DBEventRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_additional_payment.csv"), typeof(DBEventAdditionalPaymentRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_altar_reward.csv"), typeof(DBEventAltarRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_attendance.csv"), typeof(DBEventAttendanceRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_auto_boxReward.csv"), typeof(DBEventAutoBoxrewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_auto_boxSlot.csv"), typeof(DBEventAutoBoxslotRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_auto_buff.csv"), typeof(DBEventAutoBuffRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_auto_group.csv"), typeof(DBEventAutoGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_auto_hero.csv"), typeof(DBEventAutoHeroRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_auto_levelup.csv"), typeof(DBEventAutoLevelupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_auto_monster.csv"), typeof(DBEventAutoMonsterRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_auto_setting.csv"), typeof(DBEventAutoSettingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_auto_stage.csv"), typeof(DBEventAutoStageRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_bingo.csv"), typeof(DBEventBingoRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_bingo_exchange.csv"), typeof(DBEventBingoExchangeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_bingo_random.csv"), typeof(DBEventBingoRandomRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_bingo_reward.csv"), typeof(DBEventBingoRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_boss_mission.csv"), typeof(DBEventBossMissionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_buff.csv"), typeof(DBEventBuffRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_buff_lobby.csv"), typeof(DBEventBuffLobbyRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_challenge_destroy.csv"), typeof(DBEventChallengeDestroyRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_challenge_destroyscore.csv"), typeof(DBEventChallengeDestroyscoreRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_cheer_finish.csv"), typeof(DBEventCheerFinishRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_cheer_gauge.csv"), typeof(DBEventCheerGaugeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_cheer_group.csv"), typeof(DBEventCheerGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_cheer_reward.csv"), typeof(DBEventCheerRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_conquest.csv"), typeof(DBEventConquestRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_conquest_cutscene.csv"), typeof(DBEventConquestCutsceneRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_conquest_enemy.csv"), typeof(DBEventConquestEnemyRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_conquest_fever.csv"), typeof(DBEventConquestFeverRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_conquest_localization.csv"), typeof(DBEventConquestLocalizationRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_conquest_production.csv"), typeof(DBEventConquestProductionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_conquest_reward.csv"), typeof(DBEventConquestRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_conquest_tile.csv"), typeof(DBEventConquestTileRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_crafts.csv"), typeof(DBEventCraftsRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_crafts_localization.csv"), typeof(DBEventCraftsLocalizationRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_crafts_material.csv"), typeof(DBEventCraftsMaterialRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_dice.csv"), typeof(DBEventDiceRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_dice_mission.csv"), typeof(DBEventDiceMissionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_dice_question.csv"), typeof(DBEventDiceQuestionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_dice_reward.csv"), typeof(DBEventDiceRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_disaster_triple.csv"), typeof(DBEventDisasterTripleRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_donation.csv"), typeof(DBEventDonationRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_exchange.csv"), typeof(DBEventExchangeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_exchange_box.csv"), typeof(DBEventExchangeBoxRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_exchange_box_setting.csv"), typeof(DBEventExchangeBoxSettingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_exchange_card_group.csv"), typeof(DBEventExchangeCardGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_exchange_card_reward.csv"), typeof(DBEventExchangeCardRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_exchange_card_setting.csv"), typeof(DBEventExchangeCardSettingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_fortune_attendance.csv"), typeof(DBEventFortuneAttendanceRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_furniture.csv"), typeof(DBEventFurnitureRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_gamblebox_display.csv"), typeof(DBEventGambleboxDisplayRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_gamblebox_group.csv"), typeof(DBEventGambleboxGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_growth.csv"), typeof(DBEventGrowthRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_king_amber.csv"), typeof(DBEventKingAmberRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_ladder_reward.csv"), typeof(DBEventLadderRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_lobby.csv"), typeof(DBEventLobbyRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_lobby_gift.csv"), typeof(DBEventLobbyGiftRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_luckybag_reward.csv"), typeof(DBEventLuckybagRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_luckybag_set.csv"), typeof(DBEventLuckybagSetRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_luckybox.csv"), typeof(DBEventLuckyboxRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_match_block.csv"), typeof(DBEventMatchBlockRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_match_buff.csv"), typeof(DBEventMatchBuffRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_match_config.csv"), typeof(DBEventMatchConfigRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_match_hawk.csv"), typeof(DBEventMatchHawkRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_match_matchreward.csv"), typeof(DBEventMatchMatchrewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_match_scorereward.csv"), typeof(DBEventMatchScorerewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_mission.csv"), typeof(DBEventMissionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_mission_achievepoint.csv"), typeof(DBEventMissionAchievepointRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_mission_chapter.csv"), typeof(DBEventMissionChapterRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_mission_reward.csv"), typeof(DBEventMissionRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_mission_score.csv"), typeof(DBEventMissionScoreRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_mission_score_set.csv"), typeof(DBEventMissionScoreSetRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_mole_game_hawk.csv"), typeof(DBEventMoleGameHawkRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_mole_game_note.csv"), typeof(DBEventMoleGameNoteRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_mole_record_reward.csv"), typeof(DBEventMoleRecordRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_mole_score_reward.csv"), typeof(DBEventMoleScoreRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_monthly_setting.csv"), typeof(DBEventMonthlySettingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_monthly_story.csv"), typeof(DBEventMonthlyStoryRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_payback.csv"), typeof(DBEventPaybackRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_playcount.csv"), typeof(DBEventPlaycountRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_predict_npc_act.csv"), typeof(DBEventPredictNpcActRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_predict_reward.csv"), typeof(DBEventPredictRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_predict_setting.csv"), typeof(DBEventPredictSettingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_predict_special_reward.csv"), typeof(DBEventPredictSpecialRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_predict_upgrade.csv"), typeof(DBEventPredictUpgradeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_provision_cutscene.csv"), typeof(DBEventProvisionCutsceneRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_provision_localization.csv"), typeof(DBEventProvisionLocalizationRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_provision_reward.csv"), typeof(DBEventProvisionRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_provision_section.csv"), typeof(DBEventProvisionSectionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_pvp_wincount.csv"), typeof(DBEventPvpWincountRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_pvp_wincount_week.csv"), typeof(DBEventPvpWincountWeekRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_random_box_draw_rate.csv"), typeof(DBEventRandomBoxDrawRateRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_random_box_reward.csv"), typeof(DBEventRandomBoxRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_random_box_stage.csv"), typeof(DBEventRandomBoxStageRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_rhitta_reward.csv"), typeof(DBEventRhittaRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_road_hawk.csv"), typeof(DBEventRoadHawkRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_road_reaction.csv"), typeof(DBEventRoadReactionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_road_scorereward.csv"), typeof(DBEventRoadScorerewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_road_stage.csv"), typeof(DBEventRoadStageRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_road_tile.csv"), typeof(DBEventRoadTileRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_setup.csv"), typeof(DBEventSetupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_time_mission.csv"), typeof(DBEventTimeMissionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_treasure_hunt_finish.csv"), typeof(DBEventTreasureHuntFinishRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_treasure_hunt_group.csv"), typeof(DBEventTreasureHuntGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_treasure_hunt_point.csv"), typeof(DBEventTreasureHuntPointRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_treasure_hunt_setting.csv"), typeof(DBEventTreasureHuntSettingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_event_wishbox.csv"), typeof(DBEventWishboxRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_evolution_break_base.csv"), typeof(DBEvolutionBreakBaseRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_evolution_break_max.csv"), typeof(DBEvolutionBreakMaxRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_evolution_exchange.csv"), typeof(DBEvolutionExchangeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_exp.csv"), typeof(DBExpRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_fade_inout.csv"), typeof(DBFadeInoutRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_fate.csv"), typeof(DBFateRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_fate_monster.csv"), typeof(DBFateMonsterRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_final_boss_hall_of_fame.csv"), typeof(DBFinalBossHallOfFameRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_final_boss_hall_of_fame_list.csv"), typeof(DBFinalBossHallOfFameListRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_final_boss_season.csv"), typeof(DBFinalBossSeasonRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_final_boss_setting.csv"), typeof(DBFinalBossSettingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_final_boss_shop.csv"), typeof(DBFinalBossShopRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_first_buy_bonus.csv"), typeof(DBFirstBuyBonusRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_food_buff.csv"), typeof(DBFoodBuffRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_food_hero_eat_category_info.csv"), typeof(DBFoodHeroEatCategoryInfoRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_forum_control.csv"), typeof(DBForumControlRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_free_package_reward.csv"), typeof(DBFreePackageRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_friend_visit_hero.csv"), typeof(DBFriendVisitHeroRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_frozen_content.csv"), typeof(DBFrozenContentRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_gamble_bonus_reward.csv"), typeof(DBGambleBonusRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_gamble_choice.csv"), typeof(DBGambleChoiceRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_gamble_display.csv"), typeof(DBGambleDisplayRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_gamble_group.csv"), typeof(DBGambleGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_gamble_payback.csv"), typeof(DBGamblePaybackRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_gamble_payback_reward.csv"), typeof(DBGamblePaybackRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_gamble_rating_per.csv"), typeof(DBGambleRatingPerRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_gamble_rotation_set.csv"), typeof(DBGambleRotationSetRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_gamble_sign.csv"), typeof(DBGambleSignRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_gamble_sound.csv"), typeof(DBGambleSoundRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_gamble_time_switch.csv"), typeof(DBGambleTimeSwitchRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_game_center_achievement.csv"), typeof(DBGameCenterAchievementRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_game_center_leaderboard.csv"), typeof(DBGameCenterLeaderboardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_global_channel_setting.csv"), typeof(DBGlobalChannelSettingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_grim_book_category.csv"), typeof(DBGrimBookCategoryRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_grim_book_content.csv"), typeof(DBGrimBookContentRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_grim_book_talk.csv"), typeof(DBGrimBookTalkRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guest_gift.csv"), typeof(DBGuestGiftRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guest_interactive_talk.csv"), typeof(DBGuestInteractiveTalkRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guide_recommend_list.csv"), typeof(DBGuideRecommendListRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guidelist_reward.csv"), typeof(DBGuidelistRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_attendance.csv"), typeof(DBGuildAttendanceRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_base.csv"), typeof(DBGuildBaseRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_boss_battlescore_info.csv"), typeof(DBGuildBossBattlescoreInfoRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_boss_guild_reward.csv"), typeof(DBGuildBossGuildRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_boss_hell_mission.csv"), typeof(DBGuildBossHellMissionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_boss_hell_reward.csv"), typeof(DBGuildBossHellRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_boss_mission.csv"), typeof(DBGuildBossMissionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_boss_personal_reward.csv"), typeof(DBGuildBossPersonalRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_boss_season.csv"), typeof(DBGuildBossSeasonRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_donation.csv"), typeof(DBGuildDonationRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_exp_boost.csv"), typeof(DBGuildExpBoostRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_group_mission.csv"), typeof(DBGuildGroupMissionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_mark.csv"), typeof(DBGuildMarkRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_mission.csv"), typeof(DBGuildMissionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guildorder_bonusreward_group.csv"), typeof(DBGuildorderBonusrewardGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guildorder_mission.csv"), typeof(DBGuildorderMissionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guildorder_rewardbox.csv"), typeof(DBGuildorderRewardboxRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_rank_reward.csv"), typeof(DBGuildRankRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_shop.csv"), typeof(DBGuildShopRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_skill.csv"), typeof(DBGuildSkillRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_war_area.csv"), typeof(DBGuildWarAreaRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_war_area_buff.csv"), typeof(DBGuildWarAreaBuffRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_war_buff.csv"), typeof(DBGuildWarBuffRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_war_config.csv"), typeof(DBGuildWarConfigRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_war_league_sign.csv"), typeof(DBGuildWarLeagueSignRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_war_low_area.csv"), typeof(DBGuildWarLowAreaRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_war_low_play_reward.csv"), typeof(DBGuildWarLowPlayRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_war_low_point_reward.csv"), typeof(DBGuildWarLowPointRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_war_low_season.csv"), typeof(DBGuildWarLowSeasonRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_war_low_tier.csv"), typeof(DBGuildWarLowTierRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_war_low_win_reward.csv"), typeof(DBGuildWarLowWinRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_war_rank_reward.csv"), typeof(DBGuildWarRankRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_war_region.csv"), typeof(DBGuildWarRegionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_guild_war_season.csv"), typeof(DBGuildWarSeasonRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_hawk_slot.csv"), typeof(DBHawkSlotRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_head_costume_resource.csv"), typeof(DBHeadCostumeResourceRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_hero_base.csv"), typeof(DBHeroBaseRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_hero_capacity_ment.csv"), typeof(DBHeroCapacityMentRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_hero_contents_passive.csv"), typeof(DBHeroContentsPassiveRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_hero_detail.csv"), typeof(DBHeroDetailRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_hero_filter_group.csv"), typeof(DBHeroFilterGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_hero_group_name.csv"), typeof(DBHeroGroupNameRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_hero_growth_point_info.csv"), typeof(DBHeroGrowthPointInfoRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_hero_job_group.csv"), typeof(DBHeroJobGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_hero_lovepoint_reward.csv"), typeof(DBHeroLovepointRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_hero_lovepoint_share.csv"), typeof(DBHeroLovepointShareRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_interactive.csv"), typeof(DBInteractiveRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_interactive_item.csv"), typeof(DBInteractiveItemRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_interactive_talk.csv"), typeof(DBInteractiveTalkRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_interactive_vr.csv"), typeof(DBInteractiveVrRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_item_gotcha_display.csv"), typeof(DBItemGotchaDisplayRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_item_gotcha_group.csv"), typeof(DBItemGotchaGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_item_gotcha_rating_per.csv"), typeof(DBItemGotchaRatingPerRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_item_gotcha_sign.csv"), typeof(DBItemGotchaSignRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_item_info.csv"), typeof(DBItemInfoRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_item_type_desc.csv"), typeof(DBItemTypeDescRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_item_type_desc_irregular.csv"), typeof(DBItemTypeDescIrregularRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_journal.csv"), typeof(DBJournalRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_jukebox_list.csv"), typeof(DBJukeboxListRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_king_amber.csv"), typeof(DBKingAmberRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_levelup_package.csv"), typeof(DBLevelupPackageRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_loading_default.csv"), typeof(DBLoadingDefaultRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_loading_scene.csv"), typeof(DBLoadingSceneRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_loading_setting.csv"), typeof(DBLoadingSettingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_loading_tip.csv"), typeof(DBLoadingTipRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_lobby_housing_buff.csv"), typeof(DBLobbyHousingBuffRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_lobby_housing_furniture_base.csv"), typeof(DBLobbyHousingFurnitureBaseRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_lobby_housing_shop.csv"), typeof(DBLobbyHousingShopRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_lobby_npc_reward.csv"), typeof(DBLobbyNpcRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_lose_guide.csv"), typeof(DBLoseGuideRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_mailbox.csv"), typeof(DBMailboxRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_material_change.csv"), typeof(DBMaterialChangeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_material_fusion_config.csv"), typeof(DBMaterialFusionConfigRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_material_info.csv"), typeof(DBMaterialInfoRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_maze_need_hero.csv"), typeof(DBMazeNeedHeroRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_maze_replay_bonus.csv"), typeof(DBMazeReplayBonusRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_maze_season.csv"), typeof(DBMazeSeasonRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_maze_season_shop.csv"), typeof(DBMazeSeasonShopRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_maze_shop.csv"), typeof(DBMazeShopRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_mercenary_npc_setting.csv"), typeof(DBMercenaryNpcSettingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_mission.csv"), typeof(DBMissionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_mission_achievepoint.csv"), typeof(DBMissionAchievepointRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_mission_play_title.csv"), typeof(DBMissionPlayTitleRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_mission_play_title_group.csv"), typeof(DBMissionPlayTitleGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_monster_ai.csv"), typeof(DBMonsterAiRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_monster_base.csv"), typeof(DBMonsterBaseRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_monster_resource.csv"), typeof(DBMonsterResourceRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_monster_skill.csv"), typeof(DBMonsterSkillRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_musical_base.csv"), typeof(DBMusicalBaseRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_normal_package.csv"), typeof(DBNormalPackageRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_notice.csv"), typeof(DBNoticeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_npc_info.csv"), typeof(DBNpcInfoRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_npc_prop.csv"), typeof(DBNpcPropRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_package_weapon_growth.csv"), typeof(DBPackageWeaponGrowthRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_package_week_setup.csv"), typeof(DBPackageWeekSetupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pass_design_setting.csv"), typeof(DBPassDesignSettingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pass_mission_rank.csv"), typeof(DBPassMissionRankRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pass_mission_rank_reward.csv"), typeof(DBPassMissionRankRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pass_mission_reward.csv"), typeof(DBPassMissionRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_patrol.csv"), typeof(DBPatrolRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_patrol_time_reward.csv"), typeof(DBPatrolTimeRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_popup_package.csv"), typeof(DBPopupPackageRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pvp_low_league_reward_group.csv"), typeof(DBPvpLowLeagueRewardGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pvp_low_league_rule_setting.csv"), typeof(DBPvpLowLeagueRuleSettingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pvp_mode_base.csv"), typeof(DBPvpModeBaseRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pvp_npc_name.csv"), typeof(DBPvpNpcNameRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pvp_point.csv"), typeof(DBPvpPointRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pvp_reward.csv"), typeof(DBPvpRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pvp_rule_setting.csv"), typeof(DBPvpRuleSettingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pvp_season_base.csv"), typeof(DBPvpSeasonBaseRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pvp_season_reward_group.csv"), typeof(DBPvpSeasonRewardGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pvp_shop.csv"), typeof(DBPvpShopRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pvp_show.csv"), typeof(DBPvpShowRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pvp_smash_reward.csv"), typeof(DBPvpSmashRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pvp_smash_shop.csv"), typeof(DBPvpSmashShopRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pvp_smash_shop_grade.csv"), typeof(DBPvpSmashShopGradeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pvp_smash_shop_reward.csv"), typeof(DBPvpSmashShopRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pvp_top_rank.csv"), typeof(DBPvpTopRankRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pvp_tournament_reward.csv"), typeof(DBPvpTournamentRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_pvp_user_report.csv"), typeof(DBPvpUserReportRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_quest.csv"), typeof(DBQuestRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_quest_character.csv"), typeof(DBQuestCharacterRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_quest_character_costume.csv"), typeof(DBQuestCharacterCostumeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_quest_event_stepup_group.csv"), typeof(DBQuestEventStepupGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_quest_event_utility.csv"), typeof(DBQuestEventUtilityRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_quest_extra.csv"), typeof(DBQuestExtraRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_quest_sound.csv"), typeof(DBQuestSoundRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_quest_talk.csv"), typeof(DBQuestTalkRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_rating.csv"), typeof(DBRatingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_recommend_team.csv"), typeof(DBRecommendTeamRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_region.csv"), typeof(DBRegionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_region_change.csv"), typeof(DBRegionChangeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_region_sub_matching.csv"), typeof(DBRegionSubMatchingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_selected_exchange_info.csv"), typeof(DBSelectedExchangeInfoRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_sell_item_info.csv"), typeof(DBSellItemInfoRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_sequence.csv"), typeof(DBSequenceRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_set_costume.csv"), typeof(DBSetCostumeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_sfx.csv"), typeof(DBSfxRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_shop_choice_package.csv"), typeof(DBShopChoicePackageRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_shop_consume.csv"), typeof(DBShopConsumeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_shop_hawk_mileage.csv"), typeof(DBShopHawkMileageRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_shop_hub.csv"), typeof(DBShopHubRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_shop_menu.csv"), typeof(DBShopMenuRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_shop_money.csv"), typeof(DBShopMoneyRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_shop_package.csv"), typeof(DBShopPackageRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_shop_yggdrasil_mileage.csv"), typeof(DBShopYggdrasilMileageRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_situation_package.csv"), typeof(DBSituationPackageRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_skill_card_base.csv"), typeof(DBSkillCardBaseRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_skill_card_buff.csv"), typeof(DBSkillCardBuffRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_skill_card_bullet.csv"), typeof(DBSkillCardBulletRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_skill_card_option.csv"), typeof(DBSkillCardOptionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_skill_card_resource.csv"), typeof(DBSkillCardResourceRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_skill_passive.csv"), typeof(DBSkillPassiveRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_skill_passive_condition_icon.csv"), typeof(DBSkillPassiveConditionIconRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_skill_search_group.csv"), typeof(DBSkillSearchGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_skill_search_info.csv"), typeof(DBSkillSearchInfoRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_skin_ani.csv"), typeof(DBSkinAniRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_skin_awaken.csv"), typeof(DBSkinAwakenRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_skin_awaken_resource.csv"), typeof(DBSkinAwakenResourceRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_skin_awaken_stat.csv"), typeof(DBSkinAwakenStatRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_skin_base.csv"), typeof(DBSkinBaseRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_skin_costume_resource.csv"), typeof(DBSkinCostumeResourceRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_skin_evolution.csv"), typeof(DBSkinEvolutionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_skin_exclusive_passive.csv"), typeof(DBSkinExclusivePassiveRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_skin_skill.csv"), typeof(DBSkinSkillRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_skin_skill_levelup.csv"), typeof(DBSkinSkillLevelupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_skin_transcend.csv"), typeof(DBSkinTranscendRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_sns_reward.csv"), typeof(DBSnsRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_sound.csv"), typeof(DBSoundRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage.csv"), typeof(DBStageRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_ancient.csv"), typeof(DBStageAncientRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_ancient_boss_desc.csv"), typeof(DBStageAncientBossDescRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_ancient_mission.csv"), typeof(DBStageAncientMissionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_ancient_mission_buff.csv"), typeof(DBStageAncientMissionBuffRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_ancient_rank_reward.csv"), typeof(DBStageAncientRankRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_ancient_reward.csv"), typeof(DBStageAncientRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_boss.csv"), typeof(DBStageBossRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_boss_destroy.csv"), typeof(DBStageBossDestroyRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_boss_season.csv"), typeof(DBStageBossSeasonRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_challenge_boss.csv"), typeof(DBStageChallengeBossRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_challenge_boss_desc.csv"), typeof(DBStageChallengeBossDescRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_challenge_boss_event.csv"), typeof(DBStageChallengeBossEventRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_challenge_boss_group.csv"), typeof(DBStageChallengeBossGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_creaturenest.csv"), typeof(DBStageCreaturenestRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_creaturenest_gauge.csv"), typeof(DBStageCreaturenestGaugeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_creaturenest_info.csv"), typeof(DBStageCreaturenestInfoRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_descent_boss.csv"), typeof(DBStageDescentBossRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_descent_boss_group.csv"), typeof(DBStageDescentBossGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_destroy.csv"), typeof(DBStageDestroyRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_destroy_common.csv"), typeof(DBStageDestroyCommonRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_destroy_desc.csv"), typeof(DBStageDestroyDescRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_event_monthly.csv"), typeof(DBStageEventMonthlyRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_event_tower.csv"), typeof(DBStageEventTowerRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_event_tower_season.csv"), typeof(DBStageEventTowerSeasonRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_extra.csv"), typeof(DBStageExtraRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_final_boss.csv"), typeof(DBStageFinalBossRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_final_boss_battlescore.csv"), typeof(DBStageFinalBossBattlescoreRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_final_boss_event.csv"), typeof(DBStageFinalBossEventRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_final_boss_group.csv"), typeof(DBStageFinalBossGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_final_boss_mission.csv"), typeof(DBStageFinalBossMissionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_final_boss_rank_reward.csv"), typeof(DBStageFinalBossRankRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_final_boss_score_group.csv"), typeof(DBStageFinalBossScoreGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_final_boss_scorereward.csv"), typeof(DBStageFinalBossScorerewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_final_boss_vow.csv"), typeof(DBStageFinalBossVowRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_free.csv"), typeof(DBStageFreeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_global_drop.csv"), typeof(DBStageGlobalDropRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_global_type.csv"), typeof(DBStageGlobalTypeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_guild_war.csv"), typeof(DBStageGuildWarRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_guild_war_low.csv"), typeof(DBStageGuildWarLowRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_limited.csv"), typeof(DBStageLimitedRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_maze.csv"), typeof(DBStageMazeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_maze_passive.csv"), typeof(DBStageMazePassiveRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_maze_season_reward.csv"), typeof(DBStageMazeSeasonRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_maze_spot.csv"), typeof(DBStageMazeSpotRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_memorial.csv"), typeof(DBStageMemorialRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_npc_base.csv"), typeof(DBStageNpcBaseRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_npc_setting.csv"), typeof(DBStageNpcSettingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_play_count.csv"), typeof(DBStagePlayCountRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_quest.csv"), typeof(DBStageQuestRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_reverse.csv"), typeof(DBStageReverseRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_reverse_group.csv"), typeof(DBStageReverseGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_reverse_group_reward.csv"), typeof(DBStageReverseGroupRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_reverse_mission.csv"), typeof(DBStageReverseMissionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_reverse_season_reward.csv"), typeof(DBStageReverseSeasonRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_run.csv"), typeof(DBStageRunRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_single_siege.csv"), typeof(DBStageSingleSiegeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_single_siege_desc.csv"), typeof(DBStageSingleSiegeDescRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_subdue_boss.csv"), typeof(DBStageSubdueBossRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_subdue_boss_group.csv"), typeof(DBStageSubdueBossGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_subdue_boss_reward.csv"), typeof(DBStageSubdueBossRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_subdue_tag.csv"), typeof(DBStageSubdueTagRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_tournament.csv"), typeof(DBStageTournamentRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_tournament_team_info.csv"), typeof(DBStageTournamentTeamInfoRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_tower.csv"), typeof(DBStageTowerRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_tower_mode_passive.csv"), typeof(DBStageTowerModePassiveRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_tower_season.csv"), typeof(DBStageTowerSeasonRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_training.csv"), typeof(DBStageTrainingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_training_group.csv"), typeof(DBStageTrainingGroupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_training_play_count.csv"), typeof(DBStageTrainingPlayCountRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_training_task.csv"), typeof(DBStageTrainingTaskRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_training_task_open.csv"), typeof(DBStageTrainingTaskOpenRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_type.csv"), typeof(DBStageTypeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_week.csv"), typeof(DBStageWeekRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_week_buff.csv"), typeof(DBStageWeekBuffRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_week_random_stage.csv"), typeof(DBStageWeekRandomStageRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_week_reward.csv"), typeof(DBStageWeekRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_week_setup.csv"), typeof(DBStageWeekSetupRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stage_yggdrasil_tower.csv"), typeof(DBStageYggdrasilTowerRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stamp_chat.csv"), typeof(DBStampChatRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stepup_gamble_bonus_reward.csv"), typeof(DBStepupGambleBonusRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stepup_gamble_info.csv"), typeof(DBStepupGambleInfoRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stepup_mileage.csv"), typeof(DBStepupMileageRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stepup_mileage_bonus_reward.csv"), typeof(DBStepupMileageBonusRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_stepup_set.csv"), typeof(DBStepupSetRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_storyreview_area.csv"), typeof(DBStoryreviewAreaRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_storyreview_list.csv"), typeof(DBStoryreviewListRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_storyreview_root.csv"), typeof(DBStoryreviewRootRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_storyreview_stage.csv"), typeof(DBStoryreviewStageRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_time_stepup_package.csv"), typeof(DBTimeStepupPackageRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_town_change.csv"), typeof(DBTownChangeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_town_donation_value_config.csv"), typeof(DBTownDonationValueConfigRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_training_mission_reward.csv"), typeof(DBTrainingMissionRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_training_stage_mission.csv"), typeof(DBTrainingStageMissionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_tutorial_reward.csv"), typeof(DBTutorialRewardRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_upgrade_rating.csv"), typeof(DBUpgradeRatingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_video.csv"), typeof(DBVideoRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_weapon_auto_setting.csv"), typeof(DBWeaponAutoSettingRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_weapon_base.csv"), typeof(DBWeaponBaseRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_weapon_base_change.csv"), typeof(DBWeaponBaseChangeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_weapon_carve_base.csv"), typeof(DBWeaponCarveBaseRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_weapon_costume_resource.csv"), typeof(DBWeaponCostumeResourceRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_weapon_event_set.csv"), typeof(DBWeaponEventSetRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_weapon_evolution.csv"), typeof(DBWeaponEvolutionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_weapon_grind.csv"), typeof(DBWeaponGrindRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_weapon_growth.csv"), typeof(DBWeaponGrowthRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_weapon_magic.csv"), typeof(DBWeaponMagicRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_weapon_option.csv"), typeof(DBWeaponOptionRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_weapon_option_change.csv"), typeof(DBWeaponOptionChangeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_weapon_set.csv"), typeof(DBWeaponSetRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_weapon_upgrade.csv"), typeof(DBWeaponUpgradeRow));
            TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", "DB_welcome_attendance.csv"), typeof(DBWelcomeAttendanceRow));
            Console.WriteLine("Done !");
        }

        // Taken from https://github.com/Coded-Bots/The-Seven-Deadly-Sins-Datamining/blob/master/Program.cs#L16538
        private void TrasformBinaryToJson(string fileName, Type typeInstance)
        {
            try
            {
                byte[] fileContent = File.ReadAllBytes(fileName);
                BinaryReader reader = new BinaryReader(new MemoryStream(fileContent));
                int count = reader.ReadInt32();
                List<string> csv = new List<string>();
                for (int i = 0; i < count; i++)
                {
                    MethodInfo methodInfo = typeInstance.GetMethod("ReadToStream");
                    ParameterInfo[] parameterInfo = methodInfo.GetParameters();
                    object classInstance = Activator.CreateInstance(typeInstance, null);
                    var result = methodInfo.Invoke(classInstance, new object[] { reader });
                    csv.Add(classInstance.ToJson());
                }
                JToken parsedJson = JToken.Parse("[" + string.Join(",", csv.ToArray()) + "]");
                string beautified = parsedJson.ToString(Formatting.Indented);
                File.WriteAllText(fileName.Replace(".csv", ".json"), beautified);
                if (fileContent.Length != reader.BaseStream.Position)
                {
                    Console.WriteLine("Diff position : " + fileName);
                }
                File.Delete(fileName);
            }
            catch
            {
                Console.WriteLine($"{fileName} crashed");
            }
        }

        private readonly string _previousRootDirectory;

        private readonly string _currentRootDirectory;

        /* The folders of the game :
         * b = database
         * jal = localization
         * jas = sounds
         * jau = banners images
         * m = models and any other image of the game
         * s = character voices
         * w = weapons models
         */

        private readonly string[] _folderList = { "b", "jal", "jas", "jau", "m", "s", "w" };

        private readonly BundleDownloader _bundleDownloader;

        private readonly BundleDecryptor _bundleDecryptor;

        private readonly BundleComparer _bundleComparer;

        private readonly AssetExporter _assetExporter;

        private Dictionary<string, Dictionary<string, BundleData>> folderChecksumAssetsDictionary = new Dictionary<string, Dictionary<string, BundleData>>();
    }
}