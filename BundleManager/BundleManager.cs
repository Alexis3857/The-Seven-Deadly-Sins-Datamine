using Decryptor;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ServiceStack;
using System.IO;
using System.Reflection;
using System.Text;
using System.Runtime.InteropServices;
using SixLabors.ImageSharp.ColorSpaces;
using _7dsgcDatamine;

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
                            _assetExporter.ExportFolderFiles("jal", new List<BundleData> { bundleData });
                            break;
                        }
                    }
                }
            }
        }

        public void DownloadNew(bool isWriteChangedStrings)
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
                List<BundleData> assetList = _bundleComparer.GetNewAssetList(folder);
                folderAssetsDictionary.Add(folder, assetList);
                if (assetList.Count != 0)
                {
                    List<string> bundleNameList = _bundleComparer.GetBundleNameList(folder, assetList.Select(bundleData => bundleData.Checksum).ToList());
                    _bundleDownloader.DownloadBundlePackFile(folder, bundleNameList).Wait();
                    string bundleDirectory = Path.Join(_currentRootDirectory, "Bundles", folder);
                    foreach (FileInfo fileInfo in new DirectoryInfo(Path.Join(_currentRootDirectory, "Bundles", folder)).GetFiles())
                    {
                        BundleData? bundleData = assetList.Find((BundleData e) => e.Checksum.Equals(fileInfo.Name));
                        if (bundleData is not null)
                        {
                            if (bundleData.Encrypt)
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
                _assetExporter.ExportFolderFiles(folder, folderAssetsDictionary[folder]);
            }
            Localization.Localizer.Load(_currentRootDirectory, _previousRootDirectory);
            Localization.Localizer.WriteNewStringsToFile(_currentRootDirectory, isWriteChangedStrings);
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
            foreach (var db in databaseDictionary)
            {
                // Console.WriteLine($"Transforming {db.Key}...");
                TrasformBinaryToJson(Path.Join(_currentRootDirectory, "Database", db.Key), db.Value);
            }
            Console.WriteLine("Done !");
        }

        // Taken from https://github.com/Coded-Bots/The-Seven-Deadly-Sins-Datamining/blob/master/Program.cs#L16538

        /*
        It would be better to create an interface and use the following code

        public interface IDBClass
        {
            bool ReadToStream(BinaryReader reader);
        }

        static List<T> GetDBList<T>(string dbName) where T : IDBClass, new()
        {
            var dbList = new List<T>();
            byte[] fileContent = File.ReadAllBytes(dbName);
            var reader = new BinaryReader(new MemoryStream(fileContent));
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                var dbRow = new T();
                dbRow.ReadToStream(reader);
                dbList.Add(dbRow);
            }
            return dbList;
        }

        var testDBList = GetDBList<DBSkinBaseRow>("DB_skin_base.csv");
        string testDBString = JsonConvert.SerializeObject(testDBList, Formatting.Indented);
        File.WriteAllText("DB_skin_base.json", testDBString);
         */

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

        private Dictionary<string, List<BundleData>> folderAssetsDictionary = new Dictionary<string, List<BundleData>>();

        private Dictionary<string, Type> databaseDictionary = new Dictionary<string, Type>
        {
            { "DB_ai_customizing_Basic_Preset.csv", typeof(DBAiCustomizingBasicPresetRow)},
            { "DB_ai_customizing_condition.csv", typeof(DBAiCustomizingConditionRow)},
            { "DB_ai_customizing_cost.csv", typeof(DBAiCustomizingCostRow)},
            { "DB_ai_customizing_etc.csv", typeof(DBAiCustomizingEtcRow)},
            { "DB_ai_customizing_group.csv", typeof(DBAiCustomizingGroupRow)},
            { "DB_ai_customizing_icon.csv", typeof(DBAiCustomizingIconRow)},
            { "DB_ai_customizing_move.csv", typeof(DBAiCustomizingMoveRow)},
            { "DB_ai_customizing_move_type.csv", typeof(DBAiCustomizingMoveTypeRow)},
            { "DB_ai_customizing_skill_type.csv", typeof(DBAiCustomizingSkillTypeRow)},
            { "DB_ai_customizing_target.csv", typeof(DBAiCustomizingTargetRow)},
            { "DB_ar_characters.csv", typeof(DBArCharactersRow)},
            { "DB_ar_devices.csv", typeof(DBArDevicesRow)},
            { "DB_ar_systems.csv", typeof(DBArSystemsRow)},
            { "DB_area.csv", typeof(DBAreaRow)},
            { "DB_artifact_card.csv", typeof(DBArtifactCardRow)},
            { "DB_artifact_card_union.csv", typeof(DBArtifactCardUnionRow)},
            { "DB_artifact_category.csv", typeof(DBArtifactCategoryRow)},
            { "DB_artifact_event_group.csv", typeof(DBArtifactEventGroupRow)},
            { "DB_artifact_group.csv", typeof(DBArtifactGroupRow)},
            { "DB_artifact_union_filter_group.csv", typeof(DBArtifactUnionFilterGroupRow)},
            { "DB_attendance_hero.csv", typeof(DBAttendanceHeroRow)},
            { "DB_attendance_package.csv", typeof(DBAttendancePackageRow)},
            { "DB_basepoint_collision_npc.csv", typeof(DBBasepointCollisionNpcRow)},
            { "DB_basepoint_fellow_reward.csv", typeof(DBBasepointFellowRewardRow)},
            { "DB_basepoint_interactive_ani.csv", typeof(DBBasepointInteractiveAniRow)},
            { "DB_basepoint_npc.csv", typeof(DBBasepointNpcRow)},
            { "DB_basepoint_npc_move.csv", typeof(DBBasepointNpcMoveRow)},
            { "DB_basepoint_npc_talk.csv", typeof(DBBasepointNpcTalkRow)},
            { "DB_basepoint_random_shop.csv", typeof(DBBasepointRandomShopRow)},
            { "DB_basepoint_shop.csv", typeof(DBBasepointShopRow)},
            { "DB_birthday.csv", typeof(DBBirthdayRow)},
            { "DB_blind_content.csv", typeof(DBBlindContentRow)},
            { "DB_box_item_info.csv", typeof(DBBoxItemInfoRow)},
            { "DB_bundle_discount_package.csv", typeof(DBBundleDiscountPackageRow)},
            { "DB_cardpack_artifact_event.csv", typeof(DBCardpackArtifactEventRow)},
            { "DB_cardpack_artifact_info.csv", typeof(DBCardpackArtifactInfoRow)},
            { "DB_cardpack_package_info.csv", typeof(DBCardpackPackageInfoRow)},
            { "DB_chapter.csv", typeof(DBChapterRow)},
            { "DB_chapter_change.csv", typeof(DBChapterChangeRow)},
            { "DB_chapter_group.csv", typeof(DBChapterGroupRow)},
            { "DB_character_localize_info.csv", typeof(DBCharacterLocalizeInfoRow)},
            { "DB_coin_shop.csv", typeof(DBCoinShopRow)},
            { "DB_coin_shop_event.csv", typeof(DBCoinShopEventRow)},
            { "DB_coin_shop_setting.csv", typeof(DBCoinShopSettingRow)},
            { "DB_config_game.csv", typeof(DBConfigGameRow)},
            { "DB_const_manastone_random.csv", typeof(DBConstManastoneRandomRow)},
            { "DB_constellation_base.csv", typeof(DBConstellationBaseRow)},
            { "DB_constellation_ignore_team.csv", typeof(DBConstellationIgnoreTeamRow)},
            { "DB_constellation_stone.csv", typeof(DBConstellationStoneRow)},
            { "DB_content_ad.csv", typeof(DBContentAdRow)},
            { "DB_content_ad_roulette.csv", typeof(DBContentAdRouletteRow)},
            { "DB_content_control.csv", typeof(DBContentControlRow)},
            { "DB_content_link.csv", typeof(DBContentLinkRow)},
            { "DB_contents_passive.csv", typeof(DBContentsPassiveRow)},
            { "DB_control_another.csv", typeof(DBControlAnotherRow)},
            { "DB_cooking_list.csv", typeof(DBCookingListRow)},
            { "DB_cooking_material.csv", typeof(DBCookingMaterialRow)},
            { "DB_cooking_recipe.csv", typeof(DBCookingRecipeRow)},
            { "DB_costume_base.csv", typeof(DBCostumeBaseRow)},
            { "DB_costume_change_sfx.csv", typeof(DBCostumeChangeSfxRow)},
            { "DB_costume_craft.csv", typeof(DBCostumeCraftRow)},
            { "DB_costume_shop.csv", typeof(DBCostumeShopRow)},
            { "DB_costume_shop_group.csv", typeof(DBCostumeShopGroupRow)},
            { "DB_costume_shop_package.csv", typeof(DBCostumeShopPackageRow)},
            { "DB_costume_shop_setting.csv", typeof(DBCostumeShopSettingRow)},
            { "DB_costume_stat.csv", typeof(DBCostumeStatRow)},
            { "DB_craft_costume_upgrade.csv", typeof(DBCraftCostumeUpgradeRow)},
            { "DB_craft_costume_upgrade_finish.csv", typeof(DBCraftCostumeUpgradeFinishRow)},
            { "DB_shop_creaturecolosseum.csv", typeof(DBShopCreaturecolosseumRow)},
            { "DB_creaturecolosseum_season.csv", typeof(DBCreaturecolosseumSeasonRow)},
            { "DB_creature_passive.csv", typeof(DBCreaturePassiveRow)},
            { "DB_daily_attendance.csv", typeof(DBDailyAttendanceRow)},
            { "DB_direct_selector.csv", typeof(DBDirectSelectorRow)},
            { "DB_event.csv", typeof(DBEventRow)},
            { "DB_event_additional_payment.csv", typeof(DBEventAdditionalPaymentRow)},
            { "DB_event_altar_reward.csv", typeof(DBEventAltarRewardRow)},
            { "DB_event_attendance.csv", typeof(DBEventAttendanceRow)},
            { "DB_event_auto_boxReward.csv", typeof(DBEventAutoBoxrewardRow)},
            { "DB_event_auto_boxSlot.csv", typeof(DBEventAutoBoxslotRow)},
            { "DB_event_auto_buff.csv", typeof(DBEventAutoBuffRow)},
            { "DB_event_auto_group.csv", typeof(DBEventAutoGroupRow)},
            { "DB_event_auto_hero.csv", typeof(DBEventAutoHeroRow)},
            { "DB_event_auto_levelup.csv", typeof(DBEventAutoLevelupRow)},
            { "DB_event_auto_monster.csv", typeof(DBEventAutoMonsterRow)},
            { "DB_event_auto_setting.csv", typeof(DBEventAutoSettingRow)},
            { "DB_event_auto_stage.csv", typeof(DBEventAutoStageRow)},
            { "DB_event_balloondart_balloon.csv", typeof(DBEventBalloondartBalloonRow)},
            { "DB_event_balloondart_chance.csv", typeof(DBEventBalloondartChanceRow)},
            { "DB_event_balloondart_pin.csv", typeof(DBEventBalloondartPinRow)},
            { "DB_event_balloondart_reward.csv", typeof(DBEventBalloondartRewardRow)},
            { "DB_event_balloondart_score.csv", typeof(DBEventBalloondartScoreRow)},
            { "DB_event_balloondart_special.csv", typeof(DBEventBalloondartSpecialRow)},
            { "DB_event_balloondart_stage.csv", typeof(DBEventBalloondartStageRow)},
            { "DB_event_bingo.csv", typeof(DBEventBingoRow)},
            { "DB_event_bingo_exchange.csv", typeof(DBEventBingoExchangeRow)},
            { "DB_event_bingo_random.csv", typeof(DBEventBingoRandomRow)},
            { "DB_event_bingo_reward.csv", typeof(DBEventBingoRewardRow)},
            { "DB_event_boss_mission.csv", typeof(DBEventBossMissionRow)},
            { "DB_event_buff.csv", typeof(DBEventBuffRow)},
            { "DB_event_buff_lobby.csv", typeof(DBEventBuffLobbyRow)},
            { "DB_event_challenge_destroy.csv", typeof(DBEventChallengeDestroyRow)},
            { "DB_event_challenge_destroyscore.csv", typeof(DBEventChallengeDestroyscoreRow)},
            { "DB_event_cheer_finish.csv", typeof(DBEventCheerFinishRow)},
            { "DB_event_cheer_gauge.csv", typeof(DBEventCheerGaugeRow)},
            { "DB_event_cheer_group.csv", typeof(DBEventCheerGroupRow)},
            { "DB_event_cheer_reward.csv", typeof(DBEventCheerRewardRow)},
            { "DB_event_confirm_box.csv", typeof(DBEventConfirmBoxRow)},
            { "DB_event_confirm_config.csv", typeof(DBEventConfirmConfigRow)},
            { "DB_event_confirm_note.csv", typeof(DBEventConfirmNoteRow)},
            { "DB_event_confirm_reward.csv", typeof(DBEventConfirmRewardRow)},
            { "DB_event_confirm_score.csv", typeof(DBEventConfirmScoreRow)},
            { "DB_event_confirm_image.csv", typeof(DBEventConfirmImageRow)},
            { "DB_event_conquest.csv", typeof(DBEventConquestRow)},
            { "DB_event_conquest_character.csv", typeof(DBEventConquestCharacterRow)},
            { "DB_event_conquest_cut_in.csv", typeof(DBEventConquestCutInRow)},
            { "DB_event_conquest_cutscene.csv", typeof(DBEventConquestCutsceneRow)},
            { "DB_event_conquest_enemy.csv", typeof(DBEventConquestEnemyRow)},
            { "DB_event_conquest_fever.csv", typeof(DBEventConquestFeverRow)},
            { "DB_event_conquest_localization.csv", typeof(DBEventConquestLocalizationRow)},
            { "DB_event_conquest_production.csv", typeof(DBEventConquestProductionRow)},
            { "DB_event_conquest_reward.csv", typeof(DBEventConquestRewardRow)},
            { "DB_event_conquest_tile.csv", typeof(DBEventConquestTileRow)},
            { "DB_event_crafts.csv", typeof(DBEventCraftsRow)},
            { "DB_event_crafts_localization.csv", typeof(DBEventCraftsLocalizationRow)},
            { "DB_event_crafts_material.csv", typeof(DBEventCraftsMaterialRow)},
            { "DB_event_dice.csv", typeof(DBEventDiceRow)},
            { "DB_event_dice_mission.csv", typeof(DBEventDiceMissionRow)},
            { "DB_event_dice_question.csv", typeof(DBEventDiceQuestionRow)},
            { "DB_event_dice_reward.csv", typeof(DBEventDiceRewardRow)},
            { "DB_event_disaster_triple.csv", typeof(DBEventDisasterTripleRow)},
            { "DB_event_donation.csv", typeof(DBEventDonationRow)},
            { "DB_event_exchange.csv", typeof(DBEventExchangeRow)},
            { "DB_event_exchange_box.csv", typeof(DBEventExchangeBoxRow)},
            { "DB_event_exchange_box_setting.csv", typeof(DBEventExchangeBoxSettingRow)},
            { "DB_event_exchange_card_group.csv", typeof(DBEventExchangeCardGroupRow)},
            { "DB_event_exchange_card_reward.csv", typeof(DBEventExchangeCardRewardRow)},
            { "DB_event_exchange_card_setting.csv", typeof(DBEventExchangeCardSettingRow)},
            { "DB_event_fortune_attendance.csv", typeof(DBEventFortuneAttendanceRow)},
            { "DB_event_furniture.csv", typeof(DBEventFurnitureRow)},
            { "DB_event_gamblebox_display.csv", typeof(DBEventGambleboxDisplayRow)},
            { "DB_event_gamblebox_group.csv", typeof(DBEventGambleboxGroupRow)},
            { "DB_event_growth.csv", typeof(DBEventGrowthRow)},
            { "DB_event_king_amber.csv", typeof(DBEventKingAmberRow)},
            { "DB_event_ladder_reward.csv", typeof(DBEventLadderRewardRow)},
            { "DB_event_lobby.csv", typeof(DBEventLobbyRow)},
            { "DB_event_lobby_gift.csv", typeof(DBEventLobbyGiftRow)},
            { "DB_event_luckybag_reward.csv", typeof(DBEventLuckybagRewardRow)},
            { "DB_event_luckybag_set.csv", typeof(DBEventLuckybagSetRow)},
            { "DB_event_luckybox.csv", typeof(DBEventLuckyboxRow)},
            { "DB_event_match_block.csv", typeof(DBEventMatchBlockRow)},
            { "DB_event_match_buff.csv", typeof(DBEventMatchBuffRow)},
            { "DB_event_match_config.csv", typeof(DBEventMatchConfigRow)},
            { "DB_event_match_hawk.csv", typeof(DBEventMatchHawkRow)},
            { "DB_event_match_matchreward.csv", typeof(DBEventMatchMatchrewardRow)},
            { "DB_event_match_scorereward.csv", typeof(DBEventMatchScorerewardRow)},
            { "DB_event_mission.csv", typeof(DBEventMissionRow)},
            { "DB_event_mission_achievepoint.csv", typeof(DBEventMissionAchievepointRow)},
            { "DB_event_mission_chapter.csv", typeof(DBEventMissionChapterRow)},
            { "DB_event_mission_reward.csv", typeof(DBEventMissionRewardRow)},
            { "DB_event_mission_score.csv", typeof(DBEventMissionScoreRow)},
            { "DB_event_mission_score_set.csv", typeof(DBEventMissionScoreSetRow)},
            { "DB_event_mole_game_hawk.csv", typeof(DBEventMoleGameHawkRow)},
            { "DB_event_mole_game_note.csv", typeof(DBEventMoleGameNoteRow)},
            { "DB_event_mole_record_reward.csv", typeof(DBEventMoleRecordRewardRow)},
            { "DB_event_mole_score_reward.csv", typeof(DBEventMoleScoreRewardRow)},
            { "DB_event_monthly_setting.csv", typeof(DBEventMonthlySettingRow)},
            { "DB_event_monthly_story.csv", typeof(DBEventMonthlyStoryRow)},
            { "DB_event_payback.csv", typeof(DBEventPaybackRow)},
            { "DB_event_playcount.csv", typeof(DBEventPlaycountRow)},
            { "DB_event_predict_npc_act.csv", typeof(DBEventPredictNpcActRow)},
            { "DB_event_predict_reward.csv", typeof(DBEventPredictRewardRow)},
            { "DB_event_predict_setting.csv", typeof(DBEventPredictSettingRow)},
            { "DB_event_predict_special_reward.csv", typeof(DBEventPredictSpecialRewardRow)},
            { "DB_event_predict_upgrade.csv", typeof(DBEventPredictUpgradeRow)},
            { "DB_event_provision_cutscene.csv", typeof(DBEventProvisionCutsceneRow)},
            { "DB_event_provision_localization.csv", typeof(DBEventProvisionLocalizationRow)},
            { "DB_event_provision_reward.csv", typeof(DBEventProvisionRewardRow)},
            { "DB_event_provision_section.csv", typeof(DBEventProvisionSectionRow)},
            { "DB_event_pvp_wincount.csv", typeof(DBEventPvpWincountRow)},
            { "DB_event_pvp_wincount_week.csv", typeof(DBEventPvpWincountWeekRow)},
            { "DB_event_random_box_draw_rate.csv", typeof(DBEventRandomBoxDrawRateRow)},
            { "DB_event_random_box_reward.csv", typeof(DBEventRandomBoxRewardRow)},
            { "DB_event_random_box_stage.csv", typeof(DBEventRandomBoxStageRow)},
            { "DB_event_rhitta_reward.csv", typeof(DBEventRhittaRewardRow)},
            { "DB_event_road_hawk.csv", typeof(DBEventRoadHawkRow)},
            { "DB_event_road_reaction.csv", typeof(DBEventRoadReactionRow)},
            { "DB_event_road_scorereward.csv", typeof(DBEventRoadScorerewardRow)},
            { "DB_event_road_stage.csv", typeof(DBEventRoadStageRow)},
            { "DB_event_road_tile.csv", typeof(DBEventRoadTileRow)},
            { "DB_event_setup.csv", typeof(DBEventSetupRow)},
            { "DB_event_time_mission.csv", typeof(DBEventTimeMissionRow)},
            { "DB_event_treasure_hunt_finish.csv", typeof(DBEventTreasureHuntFinishRow)},
            { "DB_event_treasure_hunt_group.csv", typeof(DBEventTreasureHuntGroupRow)},
            { "DB_event_treasure_hunt_point.csv", typeof(DBEventTreasureHuntPointRow)},
            { "DB_event_treasure_hunt_setting.csv", typeof(DBEventTreasureHuntSettingRow)},
            { "DB_event_wishbox.csv", typeof(DBEventWishboxRow)},
            { "DB_evolution_break_base.csv", typeof(DBEvolutionBreakBaseRow)},
            { "DB_evolution_break_max.csv", typeof(DBEvolutionBreakMaxRow)},
            { "DB_evolution_exchange.csv", typeof(DBEvolutionExchangeRow)},
            { "DB_exp.csv", typeof(DBExpRow)},
            { "DB_fade_inout.csv", typeof(DBFadeInoutRow)},
            { "DB_fate.csv", typeof(DBFateRow)},
            { "DB_fate_monster.csv", typeof(DBFateMonsterRow)},
            { "DB_final_boss_hall_of_fame.csv", typeof(DBFinalBossHallOfFameRow)},
            { "DB_final_boss_hall_of_fame_list.csv", typeof(DBFinalBossHallOfFameListRow)},
            { "DB_final_boss_season.csv", typeof(DBFinalBossSeasonRow)},
            { "DB_final_boss_setting.csv", typeof(DBFinalBossSettingRow)},
            { "DB_final_boss_shop.csv", typeof(DBFinalBossShopRow)},
            { "DB_first_buy_bonus.csv", typeof(DBFirstBuyBonusRow)},
            { "DB_food_buff.csv", typeof(DBFoodBuffRow)},
            { "DB_food_hero_eat_category_info.csv", typeof(DBFoodHeroEatCategoryInfoRow)},
            { "DB_forum_control.csv", typeof(DBForumControlRow)},
            { "DB_free_package_reward.csv", typeof(DBFreePackageRewardRow)},
            { "DB_friend_visit_hero.csv", typeof(DBFriendVisitHeroRow)},
            { "DB_frozen_content.csv", typeof(DBFrozenContentRow)},
            { "DB_gamble_bonus_reward.csv", typeof(DBGambleBonusRewardRow)},
            { "DB_gamble_choice.csv", typeof(DBGambleChoiceRow)},
            { "DB_gamble_display.csv", typeof(DBGambleDisplayRow)},
            { "DB_gamble_group.csv", typeof(DBGambleGroupRow)},
            { "DB_gamble_payback.csv", typeof(DBGamblePaybackRow)},
            { "DB_gamble_payback_reward.csv", typeof(DBGamblePaybackRewardRow)},
            { "DB_gamble_rating_per.csv", typeof(DBGambleRatingPerRow)},
            { "DB_gamble_rotation_set.csv", typeof(DBGambleRotationSetRow)},
            { "DB_gamble_sign.csv", typeof(DBGambleSignRow)},
            { "DB_gamble_sound.csv", typeof(DBGambleSoundRow)},
            { "DB_gamble_time_switch.csv", typeof(DBGambleTimeSwitchRow)},
            { "DB_game_center_achievement.csv", typeof(DBGameCenterAchievementRow)},
            { "DB_game_center_leaderboard.csv", typeof(DBGameCenterLeaderboardRow)},
            { "DB_global_channel_setting.csv", typeof(DBGlobalChannelSettingRow)},
            { "DB_grim_book_category.csv", typeof(DBGrimBookCategoryRow)},
            { "DB_grim_book_content.csv", typeof(DBGrimBookContentRow)},
            { "DB_grim_book_talk.csv", typeof(DBGrimBookTalkRow)},
            { "DB_guest_gift.csv", typeof(DBGuestGiftRow)},
            { "DB_guest_interactive_talk.csv", typeof(DBGuestInteractiveTalkRow)},
            { "DB_guide_recommend_list.csv", typeof(DBGuideRecommendListRow)},
            { "DB_guidelist_reward.csv", typeof(DBGuidelistRewardRow)},
            { "DB_guild_attendance.csv", typeof(DBGuildAttendanceRow)},
            { "DB_guild_base.csv", typeof(DBGuildBaseRow)},
            { "DB_guild_boss_battlescore_info.csv", typeof(DBGuildBossBattlescoreInfoRow)},
            { "DB_guild_boss_guild_reward.csv", typeof(DBGuildBossGuildRewardRow)},
            { "DB_guild_boss_hell_mission.csv", typeof(DBGuildBossHellMissionRow)},
            { "DB_guild_boss_hell_reward.csv", typeof(DBGuildBossHellRewardRow)},
            { "DB_guild_boss_mission.csv", typeof(DBGuildBossMissionRow)},
            { "DB_guild_boss_personal_reward.csv", typeof(DBGuildBossPersonalRewardRow)},
            { "DB_guild_boss_season.csv", typeof(DBGuildBossSeasonRow)},
            { "DB_guild_donation.csv", typeof(DBGuildDonationRow)},
            { "DB_guild_exp_boost.csv", typeof(DBGuildExpBoostRow)},
            { "DB_guild_group_mission.csv", typeof(DBGuildGroupMissionRow)},
            { "DB_guild_mark.csv", typeof(DBGuildMarkRow)},
            { "DB_guild_mission.csv", typeof(DBGuildMissionRow)},
            { "DB_guildorder_bonusreward_group.csv", typeof(DBGuildorderBonusrewardGroupRow)},
            { "DB_guildorder_mileagebonus.csv", typeof(DBGuildorderMileagebonusRow)},
            { "DB_guildorder_mission.csv", typeof(DBGuildorderMissionRow)},
            { "DB_guildorder_rewardbox.csv", typeof(DBGuildorderRewardboxRow)},
            { "DB_guild_rank_reward.csv", typeof(DBGuildRankRewardRow)},
            { "DB_guild_shop.csv", typeof(DBGuildShopRow)},
            { "DB_guild_skill.csv", typeof(DBGuildSkillRow)},
            { "DB_guild_war_area.csv", typeof(DBGuildWarAreaRow)},
            { "DB_guild_war_area_buff.csv", typeof(DBGuildWarAreaBuffRow)},
            { "DB_guild_war_buff.csv", typeof(DBGuildWarBuffRow)},
            { "DB_guild_war_config.csv", typeof(DBGuildWarConfigRow)},
            { "DB_guild_war_league_sign.csv", typeof(DBGuildWarLeagueSignRow)},
            { "DB_guild_war_low_area.csv", typeof(DBGuildWarLowAreaRow)},
            { "DB_guild_war_low_play_reward.csv", typeof(DBGuildWarLowPlayRewardRow)},
            { "DB_guild_war_low_point_reward.csv", typeof(DBGuildWarLowPointRewardRow)},
            { "DB_guild_war_low_season.csv", typeof(DBGuildWarLowSeasonRow)},
            { "DB_guild_war_low_tier.csv", typeof(DBGuildWarLowTierRow)},
            { "DB_guild_war_low_win_reward.csv", typeof(DBGuildWarLowWinRewardRow)},
            { "DB_guild_war_rank_reward.csv", typeof(DBGuildWarRankRewardRow)},
            { "DB_guild_war_region.csv", typeof(DBGuildWarRegionRow)},
            { "DB_guild_war_season.csv", typeof(DBGuildWarSeasonRow)},
            { "DB_hawk_slot.csv", typeof(DBHawkSlotRow)},
            { "DB_head_costume_resource.csv", typeof(DBHeadCostumeResourceRow)},
            { "DB_hero_base.csv", typeof(DBHeroBaseRow)},
            { "DB_hero_capacity_ment.csv", typeof(DBHeroCapacityMentRow)},
            { "DB_hero_contents_passive.csv", typeof(DBHeroContentsPassiveRow)},
            { "DB_hero_detail.csv", typeof(DBHeroDetailRow)},
            { "DB_hero_filter_group.csv", typeof(DBHeroFilterGroupRow)},
            { "DB_hero_group_name.csv", typeof(DBHeroGroupNameRow)},
            { "DB_hero_growth_point_info.csv", typeof(DBHeroGrowthPointInfoRow)},
            { "DB_hero_job_group.csv", typeof(DBHeroJobGroupRow)},
            { "DB_hero_league_buff.csv", typeof(DBHeroLeagueBuffRow)},
            { "DB_hero_league_defence.csv", typeof(DBHeroLeagueDefenceRow)},
            { "DB_hero_league_info.csv", typeof(DBHeroLeagueInfoRow)},
            { "DB_hero_league_npc_name.csv", typeof(DBHeroLeagueNpcNameRow)},
            { "DB_hero_league_rank.csv", typeof(DBHeroLeagueRankRow)},
            { "DB_hero_league_reward.csv", typeof(DBHeroLeagueRewardRow)},
            { "DB_hero_league_season.csv", typeof(DBHeroLeagueSeasonRow)},
            { "DB_hero_league_season_shop.csv", typeof(DBHeroLeagueSeasonShopRow)},
            { "DB_hero_league_stage.csv", typeof(DBHeroLeagueStageRow)},
            { "DB_hero_lovepoint_reward.csv", typeof(DBHeroLovepointRewardRow)},
            { "DB_hero_lovepoint_share.csv", typeof(DBHeroLovepointShareRow)},
            { "DB_interactive.csv", typeof(DBInteractiveRow)},
            { "DB_interactive_item.csv", typeof(DBInteractiveItemRow)},
            { "DB_interactive_talk.csv", typeof(DBInteractiveTalkRow)},
            { "DB_interactive_vr.csv", typeof(DBInteractiveVrRow)},
            { "DB_item_gotcha_display.csv", typeof(DBItemGotchaDisplayRow)},
            { "DB_item_gotcha_group.csv", typeof(DBItemGotchaGroupRow)},
            { "DB_item_gotcha_rating_per.csv", typeof(DBItemGotchaRatingPerRow)},
            { "DB_item_gotcha_sign.csv", typeof(DBItemGotchaSignRow)},
            { "DB_item_info.csv", typeof(DBItemInfoRow)},
            { "DB_item_type_desc.csv", typeof(DBItemTypeDescRow)},
            { "DB_item_type_desc_irregular.csv", typeof(DBItemTypeDescIrregularRow)},
            { "DB_journal.csv", typeof(DBJournalRow)},
            { "DB_jukebox_list.csv", typeof(DBJukeboxListRow)},
            { "DB_king_amber.csv", typeof(DBKingAmberRow)},
            { "DB_levelup_package.csv", typeof(DBLevelupPackageRow)},
            { "DB_loading_default.csv", typeof(DBLoadingDefaultRow)},
            { "DB_loading_scene.csv", typeof(DBLoadingSceneRow)},
            { "DB_loading_setting.csv", typeof(DBLoadingSettingRow)},
            { "DB_loading_tip.csv", typeof(DBLoadingTipRow)},
            { "DB_lobby_housing_buff.csv", typeof(DBLobbyHousingBuffRow)},
            { "DB_lobby_housing_furniture_base.csv", typeof(DBLobbyHousingFurnitureBaseRow)},
            { "DB_lobby_housing_shop.csv", typeof(DBLobbyHousingShopRow)},
            { "DB_lobby_npc_reward.csv", typeof(DBLobbyNpcRewardRow)},
            { "DB_lose_guide.csv", typeof(DBLoseGuideRow)},
            { "DB_mailbox.csv", typeof(DBMailboxRow)},
            { "DB_material_change.csv", typeof(DBMaterialChangeRow)},
            { "DB_material_fusion_config.csv", typeof(DBMaterialFusionConfigRow)},
            { "DB_material_info.csv", typeof(DBMaterialInfoRow)},
            { "DB_maze_need_hero.csv", typeof(DBMazeNeedHeroRow)},
            { "DB_maze_replay_bonus.csv", typeof(DBMazeReplayBonusRow)},
            { "DB_maze_season.csv", typeof(DBMazeSeasonRow)},
            { "DB_maze_season_shop_grade.csv", typeof(DBMazeSeasonShopGradeRow)},
            { "DB_maze_season_shop.csv", typeof(DBMazeSeasonShopRow)},
            { "DB_maze_shop_buff.csv", typeof(DBMazeShopBuffRow)},
            { "DB_maze_shop.csv", typeof(DBMazeShopRow)},
            { "DB_mercenary_npc_setting.csv", typeof(DBMercenaryNpcSettingRow)},
            { "DB_mission.csv", typeof(DBMissionRow)},
            { "DB_mission_achievepoint.csv", typeof(DBMissionAchievepointRow)},
            { "DB_mission_play_title.csv", typeof(DBMissionPlayTitleRow)},
            { "DB_mission_play_title_group.csv", typeof(DBMissionPlayTitleGroupRow)},
            { "DB_monster_ai.csv", typeof(DBMonsterAiRow)},
            { "DB_monster_base.csv", typeof(DBMonsterBaseRow)},
            { "DB_monster_resource.csv", typeof(DBMonsterResourceRow)},
            { "DB_monster_skill.csv", typeof(DBMonsterSkillRow)},
            { "DB_musical_base.csv", typeof(DBMusicalBaseRow)},
            { "DB_normal_package.csv", typeof(DBNormalPackageRow)},
            { "DB_notice.csv", typeof(DBNoticeRow)},
            { "DB_npc_info.csv", typeof(DBNpcInfoRow)},
            { "DB_npc_prop.csv", typeof(DBNpcPropRow)},
            { "DB_package_weapon_growth.csv", typeof(DBPackageWeaponGrowthRow)},
            { "DB_package_week_setup.csv", typeof(DBPackageWeekSetupRow)},
            { "DB_pass_design_setting.csv", typeof(DBPassDesignSettingRow)},
            { "DB_pass_mission_rank.csv", typeof(DBPassMissionRankRow)},
            { "DB_pass_mission_rank_reward.csv", typeof(DBPassMissionRankRewardRow)},
            { "DB_pass_mission_reward.csv", typeof(DBPassMissionRewardRow)},
            { "DB_patrol.csv", typeof(DBPatrolRow)},
            { "DB_patrol_time_reward.csv", typeof(DBPatrolTimeRewardRow)},
            { "DB_popup_package.csv", typeof(DBPopupPackageRow)},
            { "DB_pvp_chaos_base.csv", typeof(DBPvpChaosBaseRow)},
            { "DB_pvp_chaos_hero_cost.csv", typeof(DBPvpChaosHeroCostRow)},
            { "DB_pvp_chaos_rank_reward.csv", typeof(DBPvpChaosRankRewardRow)},
            { "DB_pvp_low_league_reward_group.csv", typeof(DBPvpLowLeagueRewardGroupRow)},
            { "DB_pvp_low_league_rule_setting.csv", typeof(DBPvpLowLeagueRuleSettingRow)},
            { "DB_pvp_mode_base.csv", typeof(DBPvpModeBaseRow)},
            { "DB_pvp_npc_name.csv", typeof(DBPvpNpcNameRow)},
            { "DB_pvp_point.csv", typeof(DBPvpPointRow)},
            { "DB_pvp_reward.csv", typeof(DBPvpRewardRow)},
            { "DB_pvp_rule_setting.csv", typeof(DBPvpRuleSettingRow)},
            { "DB_pvp_season_base.csv", typeof(DBPvpSeasonBaseRow)},
            { "DB_pvp_season_reward_group.csv", typeof(DBPvpSeasonRewardGroupRow)},
            { "DB_pvp_shop.csv", typeof(DBPvpShopRow)},
            { "DB_pvp_show.csv", typeof(DBPvpShowRow)},
            { "DB_pvp_smash_reward.csv", typeof(DBPvpSmashRewardRow)},
            { "DB_pvp_smash_shop.csv", typeof(DBPvpSmashShopRow)},
            { "DB_pvp_smash_shop_grade.csv", typeof(DBPvpSmashShopGradeRow)},
            { "DB_pvp_smash_shop_reward.csv", typeof(DBPvpSmashShopRewardRow)},
            { "DB_pvp_top_rank.csv", typeof(DBPvpTopRankRow)},
            { "DB_pvp_tournament_reward.csv", typeof(DBPvpTournamentRewardRow)},
            { "DB_pvp_user_report.csv", typeof(DBPvpUserReportRow)},
            { "DB_quest.csv", typeof(DBQuestRow)},
            { "DB_quest_character.csv", typeof(DBQuestCharacterRow)},
            { "DB_quest_character_costume.csv", typeof(DBQuestCharacterCostumeRow)},
            { "DB_quest_event_stepup_group.csv", typeof(DBQuestEventStepupGroupRow)},
            { "DB_quest_event_utility.csv", typeof(DBQuestEventUtilityRow)},
            { "DB_quest_extra.csv", typeof(DBQuestExtraRow)},
            { "DB_quest_sound.csv", typeof(DBQuestSoundRow)},
            { "DB_quest_talk.csv", typeof(DBQuestTalkRow)},
            { "DB_rating.csv", typeof(DBRatingRow)},
            { "DB_recommend_team.csv", typeof(DBRecommendTeamRow)},
            { "DB_region.csv", typeof(DBRegionRow)},
            { "DB_region_change.csv", typeof(DBRegionChangeRow)},
            { "DB_region_sub_matching.csv", typeof(DBRegionSubMatchingRow)},
            { "DB_selected_exchange_info.csv", typeof(DBSelectedExchangeInfoRow)},
            { "DB_sell_item_info.csv", typeof(DBSellItemInfoRow)},
            { "DB_sequence.csv", typeof(DBSequenceRow)},
            { "DB_set_costume.csv", typeof(DBSetCostumeRow)},
            { "DB_sfx.csv", typeof(DBSfxRow)},
            { "DB_shop_choice_package.csv", typeof(DBShopChoicePackageRow)},
            { "DB_shop_consume.csv", typeof(DBShopConsumeRow)},
            { "DB_shop_hawk_mileage.csv", typeof(DBShopHawkMileageRow)},
            { "DB_shop_hub.csv", typeof(DBShopHubRow)},
            { "DB_shop_menu.csv", typeof(DBShopMenuRow)},
            { "DB_shop_money.csv", typeof(DBShopMoneyRow)},
            { "DB_shop_package.csv", typeof(DBShopPackageRow)},
            { "DB_shop_yggdrasil_mileage.csv", typeof(DBShopYggdrasilMileageRow)},
            { "DB_situation_package.csv", typeof(DBSituationPackageRow)},
            { "DB_skill_card_base.csv", typeof(DBSkillCardBaseRow)},
            { "DB_skill_card_buff.csv", typeof(DBSkillCardBuffRow)},
            { "DB_skill_card_bullet.csv", typeof(DBSkillCardBulletRow)},
            { "DB_skill_card_option.csv", typeof(DBSkillCardOptionRow)},
            { "DB_skill_card_resource.csv", typeof(DBSkillCardResourceRow)},
            { "DB_skill_passive.csv", typeof(DBSkillPassiveRow)},
            { "DB_skill_passive_condition_icon.csv", typeof(DBSkillPassiveConditionIconRow)},
            { "DB_skill_search_group.csv", typeof(DBSkillSearchGroupRow)},
            { "DB_skill_search_info.csv", typeof(DBSkillSearchInfoRow)},
            { "DB_skin_ani.csv", typeof(DBSkinAniRow)},
            { "DB_skin_awaken.csv", typeof(DBSkinAwakenRow)},
            { "DB_skin_awaken_resource.csv", typeof(DBSkinAwakenResourceRow)},
            { "DB_skin_awaken_stat.csv", typeof(DBSkinAwakenStatRow)},
            { "DB_skin_base.csv", typeof(DBSkinBaseRow)},
            { "DB_skin_costume_resource.csv", typeof(DBSkinCostumeResourceRow)},
            { "DB_skin_evolution.csv", typeof(DBSkinEvolutionRow)},
            { "DB_skin_exclusive_passive.csv", typeof(DBSkinExclusivePassiveRow)},
            { "DB_skin_skill.csv", typeof(DBSkinSkillRow)},
            { "DB_skin_skill_levelup.csv", typeof(DBSkinSkillLevelupRow)},
            { "DB_skin_transcend.csv", typeof(DBSkinTranscendRow)},
            { "DB_sns_reward.csv", typeof(DBSnsRewardRow)},
            { "DB_sound.csv", typeof(DBSoundRow)},
            { "DB_stage.csv", typeof(DBStageRow)},
            { "DB_stage_ancient.csv", typeof(DBStageAncientRow)},
            { "DB_stage_ancient_boss_desc.csv", typeof(DBStageAncientBossDescRow)},
            { "DB_stage_ancient_mission.csv", typeof(DBStageAncientMissionRow)},
            { "DB_stage_ancient_mission_buff.csv", typeof(DBStageAncientMissionBuffRow)},
            { "DB_stage_ancient_rank_reward.csv", typeof(DBStageAncientRankRewardRow)},
            { "DB_stage_ancient_reward.csv", typeof(DBStageAncientRewardRow)},
            { "DB_stage_boss.csv", typeof(DBStageBossRow)},
            { "DB_stage_boss_destroy.csv", typeof(DBStageBossDestroyRow)},
            { "DB_stage_boss_season.csv", typeof(DBStageBossSeasonRow)},
            { "DB_stage_challenge_boss.csv", typeof(DBStageChallengeBossRow)},
            { "DB_stage_challenge_boss_desc.csv", typeof(DBStageChallengeBossDescRow)},
            { "DB_stage_challenge_boss_event.csv", typeof(DBStageChallengeBossEventRow)},
            { "DB_stage_challenge_boss_group.csv", typeof(DBStageChallengeBossGroupRow)},
            { "DB_stage_conquest.csv", typeof(DBStageConquestRow)},
            { "DB_stage_creaturenest.csv", typeof(DBStageCreaturenestRow)},
            { "DB_stage_creaturenest_gauge.csv", typeof(DBStageCreaturenestGaugeRow)},
            { "DB_stage_creaturenest_info.csv", typeof(DBStageCreaturenestInfoRow)},
            { "DB_stage_descent_boss.csv", typeof(DBStageDescentBossRow)},
            { "DB_stage_descent_boss_group.csv", typeof(DBStageDescentBossGroupRow)},
            { "DB_stage_destroy.csv", typeof(DBStageDestroyRow)},
            { "DB_stage_destroy_common.csv", typeof(DBStageDestroyCommonRow)},
            { "DB_stage_destroy_desc.csv", typeof(DBStageDestroyDescRow)},
            { "DB_stage_event_monthly.csv", typeof(DBStageEventMonthlyRow)},
            { "DB_stage_event_tower.csv", typeof(DBStageEventTowerRow)},
            { "DB_stage_event_tower_season.csv", typeof(DBStageEventTowerSeasonRow)},
            { "DB_stage_extra.csv", typeof(DBStageExtraRow)},
            { "DB_stage_final_boss.csv", typeof(DBStageFinalBossRow)},
            { "DB_stage_final_boss_battlescore.csv", typeof(DBStageFinalBossBattlescoreRow)},
            { "DB_stage_final_boss_event.csv", typeof(DBStageFinalBossEventRow)},
            { "DB_stage_final_boss_group.csv", typeof(DBStageFinalBossGroupRow)},
            { "DB_stage_final_boss_mission.csv", typeof(DBStageFinalBossMissionRow)},
            { "DB_stage_final_boss_rank_reward.csv", typeof(DBStageFinalBossRankRewardRow)},
            { "DB_stage_final_boss_score_group.csv", typeof(DBStageFinalBossScoreGroupRow)},
            { "DB_stage_final_boss_scorereward.csv", typeof(DBStageFinalBossScorerewardRow)},
            { "DB_stage_final_boss_vow.csv", typeof(DBStageFinalBossVowRow)},
            { "DB_stage_free.csv", typeof(DBStageFreeRow)},
            { "DB_stage_global_drop.csv", typeof(DBStageGlobalDropRow)},
            { "DB_stage_global_type.csv", typeof(DBStageGlobalTypeRow)},
            { "DB_stage_guild_war.csv", typeof(DBStageGuildWarRow)},
            { "DB_stage_guild_war_low.csv", typeof(DBStageGuildWarLowRow)},
            { "DB_stage_limited.csv", typeof(DBStageLimitedRow)},
            { "DB_stage_maze.csv", typeof(DBStageMazeRow)},
            { "DB_stage_maze_passive.csv", typeof(DBStageMazePassiveRow)},
            { "DB_stage_maze_season_reward.csv", typeof(DBStageMazeSeasonRewardRow)},
            { "DB_stage_maze_spot.csv", typeof(DBStageMazeSpotRow)},
            { "DB_stage_memorial.csv", typeof(DBStageMemorialRow)},
            { "DB_stage_npc_base.csv", typeof(DBStageNpcBaseRow)},
            { "DB_stage_npc_setting.csv", typeof(DBStageNpcSettingRow)},
            { "DB_stage_play_count.csv", typeof(DBStagePlayCountRow)},
            { "DB_stage_quest.csv", typeof(DBStageQuestRow)},
            { "DB_stage_reverse.csv", typeof(DBStageReverseRow)},
            { "DB_stage_reverse_group.csv", typeof(DBStageReverseGroupRow)},
            { "DB_stage_reverse_group_reward.csv", typeof(DBStageReverseGroupRewardRow)},
            { "DB_stage_reverse_mission.csv", typeof(DBStageReverseMissionRow)},
            { "DB_stage_reverse_season_reward.csv", typeof(DBStageReverseSeasonRewardRow)},
            { "DB_stage_run.csv", typeof(DBStageRunRow)},
            { "DB_stage_single_siege.csv", typeof(DBStageSingleSiegeRow)},
            { "DB_stage_single_siege_desc.csv", typeof(DBStageSingleSiegeDescRow)},
            { "DB_stage_subdue_boss.csv", typeof(DBStageSubdueBossRow)},
            { "DB_stage_subdue_boss_group.csv", typeof(DBStageSubdueBossGroupRow)},
            { "DB_stage_subdue_boss_reward.csv", typeof(DBStageSubdueBossRewardRow)},
            { "DB_stage_subdue_tag.csv", typeof(DBStageSubdueTagRow)},
            { "DB_stage_tournament.csv", typeof(DBStageTournamentRow)},
            { "DB_stage_tournament_team_info.csv", typeof(DBStageTournamentTeamInfoRow)},
            { "DB_stage_tower.csv", typeof(DBStageTowerRow)},
            { "DB_stage_tower_mode_passive.csv", typeof(DBStageTowerModePassiveRow)},
            { "DB_stage_tower_season.csv", typeof(DBStageTowerSeasonRow)},
            { "DB_stage_training.csv", typeof(DBStageTrainingRow)},
            { "DB_stage_training_group.csv", typeof(DBStageTrainingGroupRow)},
            { "DB_stage_training_play_count.csv", typeof(DBStageTrainingPlayCountRow)},
            { "DB_stage_training_task.csv", typeof(DBStageTrainingTaskRow)},
            { "DB_stage_training_task_open.csv", typeof(DBStageTrainingTaskOpenRow)},
            { "DB_stage_type.csv", typeof(DBStageTypeRow)},
            { "DB_stage_week.csv", typeof(DBStageWeekRow)},
            { "DB_stage_week_buff.csv", typeof(DBStageWeekBuffRow)},
            { "DB_stage_week_random_stage.csv", typeof(DBStageWeekRandomStageRow)},
            { "DB_stage_week_reward.csv", typeof(DBStageWeekRewardRow)},
            { "DB_stage_week_setup.csv", typeof(DBStageWeekSetupRow)},
            { "DB_stage_yggdrasil_tower.csv", typeof(DBStageYggdrasilTowerRow)},
            { "DB_stamp_chat.csv", typeof(DBStampChatRow)},
            { "DB_stepup_gamble_bonus_reward.csv", typeof(DBStepupGambleBonusRewardRow)},
            { "DB_stepup_gamble_info.csv", typeof(DBStepupGambleInfoRow)},
            { "DB_stepup_mileage.csv", typeof(DBStepupMileageRow)},
            { "DB_stepup_mileage_bonus_reward.csv", typeof(DBStepupMileageBonusRewardRow)},
            { "DB_stepup_set.csv", typeof(DBStepupSetRow)},
            { "DB_storyreview_area.csv", typeof(DBStoryreviewAreaRow)},
            { "DB_storyreview_list.csv", typeof(DBStoryreviewListRow)},
            { "DB_storyreview_root.csv", typeof(DBStoryreviewRootRow)},
            { "DB_storyreview_stage.csv", typeof(DBStoryreviewStageRow)},
            { "DB_time_stepup_package.csv", typeof(DBTimeStepupPackageRow)},
            { "DB_town_change.csv", typeof(DBTownChangeRow)},
            { "DB_town_donation_value_config.csv", typeof(DBTownDonationValueConfigRow)},
            { "DB_training_mission_reward.csv", typeof(DBTrainingMissionRewardRow)},
            { "DB_training_stage_mission.csv", typeof(DBTrainingStageMissionRow)},
            { "DB_tutorial_reward.csv", typeof(DBTutorialRewardRow)},
            { "DB_upgrade_rating.csv", typeof(DBUpgradeRatingRow)},
            { "DB_video.csv", typeof(DBVideoRow)},
            { "DB_weapon_auto_setting.csv", typeof(DBWeaponAutoSettingRow)},
            { "DB_weapon_base.csv", typeof(DBWeaponBaseRow)},
            { "DB_weapon_base_change.csv", typeof(DBWeaponBaseChangeRow)},
            { "DB_weapon_carve_base.csv", typeof(DBWeaponCarveBaseRow)},
            { "DB_weapon_costume_resource.csv", typeof(DBWeaponCostumeResourceRow)},
            { "DB_weapon_event_set.csv", typeof(DBWeaponEventSetRow)},
            { "DB_weapon_evolution.csv", typeof(DBWeaponEvolutionRow)},
            { "DB_weapon_grind.csv", typeof(DBWeaponGrindRow)},
            { "DB_weapon_growth.csv", typeof(DBWeaponGrowthRow)},
            { "DB_weapon_magic.csv", typeof(DBWeaponMagicRow)},
            { "DB_weapon_option.csv", typeof(DBWeaponOptionRow)},
            { "DB_weapon_option_change.csv", typeof(DBWeaponOptionChangeRow)},
            { "DB_weapon_set.csv", typeof(DBWeaponSetRow)},
            { "DB_weapon_upgrade.csv", typeof(DBWeaponUpgradeRow)},
            { "DB_welcome_attendance.csv", typeof(DBWelcomeAttendanceRow)}
        };
    }
}