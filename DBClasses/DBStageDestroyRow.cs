public class DBStageDestroyRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 1120U;
        }
    }

    public int Id
    {
        get
        {
            return base.DecryptInt32(id);
        }
    }

    public string Type
    {
        get
        {
            return type;
        }
    }

    public string StageString
    {
        get
        {
            return stage_string.Localize();
        }
    }

    public string ControlType
    {
        get
        {
            return control_type;
        }
    }

    public int Region
    {
        get
        {
            return base.DecryptInt32(region);
        }
    }

    public int GroupId
    {
        get
        {
            return base.DecryptInt32(group_id);
        }
    }

    public int EventType
    {
        get
        {
            return base.DecryptInt32(event_type);
        }
    }

    public int EventSubIndex
    {
        get
        {
            return base.DecryptInt32(event_sub_index);
        }
    }

    public int DestroyIndex
    {
        get
        {
            return base.DecryptInt32(destroy_index);
        }
    }

    public int AreaSwitching
    {
        get
        {
            return base.DecryptInt32(area_switching);
        }
    }

    public int NeedQuestId
    {
        get
        {
            return base.DecryptInt32(need_quest_id);
        }
    }

    public int NeedMainStageId
    {
        get
        {
            return base.DecryptInt32(need_main_stage_id);
        }
    }

    public List<string> ListArrayContentsCheck
    {
        get
        {
            return list_array_contents_check;
        }
    }

    public int Difficulty
    {
        get
        {
            return base.DecryptInt32(difficulty);
        }
    }

    public int DifficultyLock
    {
        get
        {
            return base.DecryptInt32(difficulty_lock);
        }
    }

    public string DifficultyString
    {
        get
        {
            return difficulty_string.Localize();
        }
    }

    public byte BossHellCheck
    {
        get
        {
            return boss_hell_check;
        }
    }

    public string InfoImage
    {
        get
        {
            return info_image;
        }
    }

    public string InfoGuide
    {
        get
        {
            return info_guide.Localize();
        }
    }

    public int StartCut
    {
        get
        {
            return base.DecryptInt32(start_cut);
        }
    }

    public int EndCut
    {
        get
        {
            return base.DecryptInt32(end_cut);
        }
    }

    public int BgmSoundId1
    {
        get
        {
            return base.DecryptInt32(bgm_sound_id_1);
        }
    }

    public int AmbientSoundId1
    {
        get
        {
            return base.DecryptInt32(ambient_sound_id_1);
        }
    }

    public int BgmSoundId2
    {
        get
        {
            return base.DecryptInt32(bgm_sound_id_2);
        }
    }

    public int AmbientSoundId2
    {
        get
        {
            return base.DecryptInt32(ambient_sound_id_2);
        }
    }

    public int BgmSoundId3
    {
        get
        {
            return base.DecryptInt32(bgm_sound_id_3);
        }
    }

    public int AmbientSoundId3
    {
        get
        {
            return base.DecryptInt32(ambient_sound_id_3);
        }
    }

    public int BgmSoundId4
    {
        get
        {
            return base.DecryptInt32(bgm_sound_id_4);
        }
    }

    public int AmbientSoundId4
    {
        get
        {
            return base.DecryptInt32(ambient_sound_id_4);
        }
    }

    public int BgmSoundId5
    {
        get
        {
            return base.DecryptInt32(bgm_sound_id_5);
        }
    }

    public int AmbientSoundId5
    {
        get
        {
            return base.DecryptInt32(ambient_sound_id_5);
        }
    }

    public int StoryId1
    {
        get
        {
            return base.DecryptInt32(story_id_1);
        }
    }

    public int StoryId2
    {
        get
        {
            return base.DecryptInt32(story_id_2);
        }
    }

    public int StoryId3
    {
        get
        {
            return base.DecryptInt32(story_id_3);
        }
    }

    public int NeedStaminaItemId
    {
        get
        {
            return base.DecryptInt32(need_stamina_item_id);
        }
    }

    public int NeedStaminaCount
    {
        get
        {
            return base.DecryptInt32(need_stamina_count);
        }
    }

    public int SwitchingBasepointId
    {
        get
        {
            return base.DecryptInt32(switching_basepoint_id);
        }
    }

    public int DestroyFellowExp
    {
        get
        {
            return base.DecryptInt32(destroy_fellow_exp);
        }
    }

    public int DestroyBuffId
    {
        get
        {
            return base.DecryptInt32(destroy_buff_id);
        }
    }

    public int DestroyBossId
    {
        get
        {
            return base.DecryptInt32(destroy_boss_id);
        }
    }

    public int DestroyRoomBossId
    {
        get
        {
            return base.DecryptInt32(destroy_room_boss_id);
        }
    }

    public string AreaIcon
    {
        get
        {
            return area_icon;
        }
    }

    public string RoomFileName
    {
        get
        {
            return room_file_name;
        }
    }

    public string RoomSpawnPropFilename
    {
        get
        {
            return room_spawn_prop_filename;
        }
    }

    public string BgResourcePath
    {
        get
        {
            return bg_resource_path;
        }
    }

    public string StageBgResource
    {
        get
        {
            return stage_bg_resource;
        }
    }

    public int RoomBgmSoundId
    {
        get
        {
            return base.DecryptInt32(room_bgm_sound_id);
        }
    }

    public int UserExp
    {
        get
        {
            return base.DecryptInt32(user_exp);
        }
    }

    public int HeroExp
    {
        get
        {
            return base.DecryptInt32(hero_exp);
        }
    }

    public int GoldValue
    {
        get
        {
            return base.DecryptInt32(gold_value);
        }
    }

    public int GroupItemRateAdd
    {
        get
        {
            return base.DecryptInt32(group_item_rate_add);
        }
    }

    public int DropItemBossMinCount
    {
        get
        {
            return base.DecryptInt32(drop_item_boss_min_count);
        }
    }

    public int DropItemBossMaxCount
    {
        get
        {
            return base.DecryptInt32(drop_item_boss_max_count);
        }
    }

    public int MonsterMaterialPer
    {
        get
        {
            return base.DecryptInt32(monster_material_per);
        }
    }

    public int DropItemId1
    {
        get
        {
            return base.DecryptInt32(drop_item_id_1);
        }
    }

    public int DropItemValue1
    {
        get
        {
            return base.DecryptInt32(drop_item_value_1);
        }
    }

    public int DropItemPer1
    {
        get
        {
            return base.DecryptInt32(drop_item_per_1);
        }
    }

    public int DropItemBox1
    {
        get
        {
            return base.DecryptInt32(drop_item_box_1);
        }
    }

    public int DropItemId2
    {
        get
        {
            return base.DecryptInt32(drop_item_id_2);
        }
    }

    public int DropItemValue2
    {
        get
        {
            return base.DecryptInt32(drop_item_value_2);
        }
    }

    public int DropItemPer2
    {
        get
        {
            return base.DecryptInt32(drop_item_per_2);
        }
    }

    public int DropItemBox2
    {
        get
        {
            return base.DecryptInt32(drop_item_box_2);
        }
    }

    public int DropItemId3
    {
        get
        {
            return base.DecryptInt32(drop_item_id_3);
        }
    }

    public int DropItemValue3
    {
        get
        {
            return base.DecryptInt32(drop_item_value_3);
        }
    }

    public int DropItemPer3
    {
        get
        {
            return base.DecryptInt32(drop_item_per_3);
        }
    }

    public int DropItemBox3
    {
        get
        {
            return base.DecryptInt32(drop_item_box_3);
        }
    }

    public int DropItemId4
    {
        get
        {
            return base.DecryptInt32(drop_item_id_4);
        }
    }

    public int DropItemValue4
    {
        get
        {
            return base.DecryptInt32(drop_item_value_4);
        }
    }

    public int DropItemPer4
    {
        get
        {
            return base.DecryptInt32(drop_item_per_4);
        }
    }

    public int DropItemBox4
    {
        get
        {
            return base.DecryptInt32(drop_item_box_4);
        }
    }

    public int DropItemId5
    {
        get
        {
            return base.DecryptInt32(drop_item_id_5);
        }
    }

    public int DropItemValue5
    {
        get
        {
            return base.DecryptInt32(drop_item_value_5);
        }
    }

    public int DropItemPer5
    {
        get
        {
            return base.DecryptInt32(drop_item_per_5);
        }
    }

    public int DropItemBox5
    {
        get
        {
            return base.DecryptInt32(drop_item_box_5);
        }
    }

    public int DropItemId6
    {
        get
        {
            return base.DecryptInt32(drop_item_id_6);
        }
    }

    public int DropItemValue6
    {
        get
        {
            return base.DecryptInt32(drop_item_value_6);
        }
    }

    public int DropItemPer6
    {
        get
        {
            return base.DecryptInt32(drop_item_per_6);
        }
    }

    public int DropItemBox6
    {
        get
        {
            return base.DecryptInt32(drop_item_box_6);
        }
    }

    public int DropItemId7
    {
        get
        {
            return base.DecryptInt32(drop_item_id_7);
        }
    }

    public int DropItemValue7
    {
        get
        {
            return base.DecryptInt32(drop_item_value_7);
        }
    }

    public int DropItemPer7
    {
        get
        {
            return base.DecryptInt32(drop_item_per_7);
        }
    }

    public int DropItemBox7
    {
        get
        {
            return base.DecryptInt32(drop_item_box_7);
        }
    }

    public int DropItemId8
    {
        get
        {
            return base.DecryptInt32(drop_item_id_8);
        }
    }

    public int DropItemValue8
    {
        get
        {
            return base.DecryptInt32(drop_item_value_8);
        }
    }

    public int DropItemPer8
    {
        get
        {
            return base.DecryptInt32(drop_item_per_8);
        }
    }

    public int DropItemBox8
    {
        get
        {
            return base.DecryptInt32(drop_item_box_8);
        }
    }

    public int DropItemId9
    {
        get
        {
            return base.DecryptInt32(drop_item_id_9);
        }
    }

    public int DropItemValue9
    {
        get
        {
            return base.DecryptInt32(drop_item_value_9);
        }
    }

    public int DropItemPer9
    {
        get
        {
            return base.DecryptInt32(drop_item_per_9);
        }
    }

    public int DropItemBox9
    {
        get
        {
            return base.DecryptInt32(drop_item_box_9);
        }
    }

    public int DropItemId10
    {
        get
        {
            return base.DecryptInt32(drop_item_id_10);
        }
    }

    public int DropItemValue10
    {
        get
        {
            return base.DecryptInt32(drop_item_value_10);
        }
    }

    public int DropItemPer10
    {
        get
        {
            return base.DecryptInt32(drop_item_per_10);
        }
    }

    public int DropItemBox10
    {
        get
        {
            return base.DecryptInt32(drop_item_box_10);
        }
    }

    public int DropItemId11
    {
        get
        {
            return base.DecryptInt32(drop_item_id_11);
        }
    }

    public int DropItemValue11
    {
        get
        {
            return base.DecryptInt32(drop_item_value_11);
        }
    }

    public int DropItemPer11
    {
        get
        {
            return base.DecryptInt32(drop_item_per_11);
        }
    }

    public int DropItemBox11
    {
        get
        {
            return base.DecryptInt32(drop_item_box_11);
        }
    }

    public int DropItemId12
    {
        get
        {
            return base.DecryptInt32(drop_item_id_12);
        }
    }

    public int DropItemValue12
    {
        get
        {
            return base.DecryptInt32(drop_item_value_12);
        }
    }

    public int DropItemPer12
    {
        get
        {
            return base.DecryptInt32(drop_item_per_12);
        }
    }

    public int DropItemBox12
    {
        get
        {
            return base.DecryptInt32(drop_item_box_12);
        }
    }

    public int DropItemId13
    {
        get
        {
            return base.DecryptInt32(drop_item_id_13);
        }
    }

    public int DropItemValue13
    {
        get
        {
            return base.DecryptInt32(drop_item_value_13);
        }
    }

    public int DropItemPer13
    {
        get
        {
            return base.DecryptInt32(drop_item_per_13);
        }
    }

    public int DropItemBox13
    {
        get
        {
            return base.DecryptInt32(drop_item_box_13);
        }
    }

    public int DropItemId14
    {
        get
        {
            return base.DecryptInt32(drop_item_id_14);
        }
    }

    public int DropItemValue14
    {
        get
        {
            return base.DecryptInt32(drop_item_value_14);
        }
    }

    public int DropItemPer14
    {
        get
        {
            return base.DecryptInt32(drop_item_per_14);
        }
    }

    public int DropItemBox14
    {
        get
        {
            return base.DecryptInt32(drop_item_box_14);
        }
    }

    public int DropItemId15
    {
        get
        {
            return base.DecryptInt32(drop_item_id_15);
        }
    }

    public int DropItemValue15
    {
        get
        {
            return base.DecryptInt32(drop_item_value_15);
        }
    }

    public int DropItemPer15
    {
        get
        {
            return base.DecryptInt32(drop_item_per_15);
        }
    }

    public int DropItemBox15
    {
        get
        {
            return base.DecryptInt32(drop_item_box_15);
        }
    }

    public int DropItemId16
    {
        get
        {
            return base.DecryptInt32(drop_item_id_16);
        }
    }

    public int DropItemValue16
    {
        get
        {
            return base.DecryptInt32(drop_item_value_16);
        }
    }

    public int DropItemPer16
    {
        get
        {
            return base.DecryptInt32(drop_item_per_16);
        }
    }

    public int DropItemBox16
    {
        get
        {
            return base.DecryptInt32(drop_item_box_16);
        }
    }

    public int DropItemId17
    {
        get
        {
            return base.DecryptInt32(drop_item_id_17);
        }
    }

    public int DropItemValue17
    {
        get
        {
            return base.DecryptInt32(drop_item_value_17);
        }
    }

    public int DropItemPer17
    {
        get
        {
            return base.DecryptInt32(drop_item_per_17);
        }
    }

    public int DropItemBox17
    {
        get
        {
            return base.DecryptInt32(drop_item_box_17);
        }
    }

    public int DropItemId18
    {
        get
        {
            return base.DecryptInt32(drop_item_id_18);
        }
    }

    public int DropItemValue18
    {
        get
        {
            return base.DecryptInt32(drop_item_value_18);
        }
    }

    public int DropItemPer18
    {
        get
        {
            return base.DecryptInt32(drop_item_per_18);
        }
    }

    public int DropItemBox18
    {
        get
        {
            return base.DecryptInt32(drop_item_box_18);
        }
    }

    public int ChiefDropItemId1
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_id_1);
        }
    }

    public int ChiefDropItemValue1
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_value_1);
        }
    }

    public int ChiefDropItemPer1
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_per_1);
        }
    }

    public int ChiefDropItemBox1
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_box_1);
        }
    }

    public int ChiefDropItemId2
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_id_2);
        }
    }

    public int ChiefDropItemValue2
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_value_2);
        }
    }

    public int ChiefDropItemPer2
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_per_2);
        }
    }

    public int ChiefDropItemBox2
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_box_2);
        }
    }

    public int ChiefDropItemId3
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_id_3);
        }
    }

    public int ChiefDropItemValue3
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_value_3);
        }
    }

    public int ChiefDropItemPer3
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_per_3);
        }
    }

    public int ChiefDropItemBox3
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_box_3);
        }
    }

    public int ChiefDropItemId4
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_id_4);
        }
    }

    public int ChiefDropItemValue4
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_value_4);
        }
    }

    public int ChiefDropItemPer4
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_per_4);
        }
    }

    public int ChiefDropItemBox4
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_box_4);
        }
    }

    public int ChiefDropItemId5
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_id_5);
        }
    }

    public int ChiefDropItemValue5
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_value_5);
        }
    }

    public int ChiefDropItemPer5
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_per_5);
        }
    }

    public int ChiefDropItemBox5
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_box_5);
        }
    }

    public int ChiefDropItemId6
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_id_6);
        }
    }

    public int ChiefDropItemValue6
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_value_6);
        }
    }

    public int ChiefDropItemPer6
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_per_6);
        }
    }

    public int ChiefDropItemBox6
    {
        get
        {
            return base.DecryptInt32(chief_drop_item_box_6);
        }
    }

    public int AddDropItemId1
    {
        get
        {
            return base.DecryptInt32(add_drop_item_id_1);
        }
    }

    public int AddDropItemValue1
    {
        get
        {
            return base.DecryptInt32(add_drop_item_value_1);
        }
    }

    public int AddDropItemPer1
    {
        get
        {
            return base.DecryptInt32(add_drop_item_per_1);
        }
    }

    public int AddDropItemBox1
    {
        get
        {
            return base.DecryptInt32(add_drop_item_box_1);
        }
    }

    public byte BossHitLookEnemyCheck
    {
        get
        {
            return boss_hit_look_enemy_check;
        }
    }

    public int PhaseShiftCinemaTwoBoss
    {
        get
        {
            return base.DecryptInt32(phase_shift_cinema_two_boss);
        }
    }

    public string StagePlacement
    {
        get
        {
            return stage_placement;
        }
    }

    public int LimitContentsMatchPassiveGroup
    {
        get
        {
            return base.DecryptInt32(limit_contents_match_passive_group);
        }
    }

    public string SituationBehaviorTreeName
    {
        get
        {
            return situation_behavior_tree_name;
        }
    }

    public List<int> ListArrayDestroyTag
    {
        get
        {
            return list_array_destroy_tag;
        }
    }

    public int BossAtkIncPer1
    {
        get
        {
            return base.DecryptInt32(boss_atk_inc_per_1);
        }
    }

    public int BossDefIncPer1
    {
        get
        {
            return base.DecryptInt32(boss_def_inc_per_1);
        }
    }

    public int BossHpIncPer1
    {
        get
        {
            return base.DecryptInt32(boss_hp_inc_per_1);
        }
    }

    public int BossId1
    {
        get
        {
            return base.DecryptInt32(boss_id_1);
        }
    }

    public int BossLevel1
    {
        get
        {
            return base.DecryptInt32(boss_level_1);
        }
    }

    public int MonsterAiId1
    {
        get
        {
            return base.DecryptInt32(monster_ai_id_1);
        }
    }

    public int BossSkillLevel1
    {
        get
        {
            return base.DecryptInt32(boss_skill_level_1);
        }
    }

    public List<int> ListArraySkillADrawPerList1
    {
        get
        {
            return list_array_skill_a_draw_per_list1;
        }
    }

    public List<int> ListArraySkillBDrawPerList1
    {
        get
        {
            return list_array_skill_b_draw_per_list1;
        }
    }

    public List<int> ListArrayPassive1
    {
        get
        {
            return list_array_passive1;
        }
    }

    public int BossAtkIncPer2
    {
        get
        {
            return base.DecryptInt32(boss_atk_inc_per_2);
        }
    }

    public int BossDefIncPer2
    {
        get
        {
            return base.DecryptInt32(boss_def_inc_per_2);
        }
    }

    public int BossHpIncPer2
    {
        get
        {
            return base.DecryptInt32(boss_hp_inc_per_2);
        }
    }

    public int BossId2
    {
        get
        {
            return base.DecryptInt32(boss_id_2);
        }
    }

    public int BossLevel2
    {
        get
        {
            return base.DecryptInt32(boss_level_2);
        }
    }

    public int MonsterAiId2
    {
        get
        {
            return base.DecryptInt32(monster_ai_id_2);
        }
    }

    public int BossSkillLevel2
    {
        get
        {
            return base.DecryptInt32(boss_skill_level_2);
        }
    }

    public List<int> ListArraySkillADrawPerList2
    {
        get
        {
            return list_array_skill_a_draw_per_list2;
        }
    }

    public List<int> ListArraySkillBDrawPerList2
    {
        get
        {
            return list_array_skill_b_draw_per_list2;
        }
    }

    public List<int> ListArrayPassive2
    {
        get
        {
            return list_array_passive2;
        }
    }

    public int BossAtkIncPer3
    {
        get
        {
            return base.DecryptInt32(boss_atk_inc_per_3);
        }
    }

    public int BossDefIncPer3
    {
        get
        {
            return base.DecryptInt32(boss_def_inc_per_3);
        }
    }

    public int BossHpIncPer3
    {
        get
        {
            return base.DecryptInt32(boss_hp_inc_per_3);
        }
    }

    public int BossId3
    {
        get
        {
            return base.DecryptInt32(boss_id_3);
        }
    }

    public int BossLevel3
    {
        get
        {
            return base.DecryptInt32(boss_level_3);
        }
    }

    public int MonsterAiId3
    {
        get
        {
            return base.DecryptInt32(monster_ai_id_3);
        }
    }

    public int BossSkillLevel3
    {
        get
        {
            return base.DecryptInt32(boss_skill_level_3);
        }
    }

    public List<int> ListArraySkillADrawPerList3
    {
        get
        {
            return list_array_skill_a_draw_per_list3;
        }
    }

    public List<int> ListArraySkillBDrawPerList3
    {
        get
        {
            return list_array_skill_b_draw_per_list3;
        }
    }

    public List<int> ListArrayPassive3
    {
        get
        {
            return list_array_passive3;
        }
    }

    public int PlayBossSpawn
    {
        get
        {
            return base.DecryptInt32(play_boss_spawn);
        }
    }

    public string BossEntryType
    {
        get
        {
            return boss_entry_type;
        }
    }

    public int TeamPower
    {
        get
        {
            return base.DecryptInt32(team_power);
        }
    }

    public string MapFilename
    {
        get
        {
            return map_filename;
        }
    }

    public string SpawnPropFilename
    {
        get
        {
            return spawn_prop_filename;
        }
    }

    public string ChangeMapFilename
    {
        get
        {
            return change_map_filename;
        }
    }

    public int BgmSoundId
    {
        get
        {
            return base.DecryptInt32(bgm_sound_id);
        }
    }

    public int BossSoundId
    {
        get
        {
            return base.DecryptInt32(boss_sound_id);
        }
    }

    public string Essencondition1
    {
        get
        {
            return EssenCondition_1;
        }
    }

    public int Essenconditionvalue1
    {
        get
        {
            return base.DecryptInt32(EssenConditionValue_1);
        }
    }

    public string Essencondition2
    {
        get
        {
            return EssenCondition_2;
        }
    }

    public int Essenconditionvalue2
    {
        get
        {
            return base.DecryptInt32(EssenConditionValue_2);
        }
    }

    public string Essencondition3
    {
        get
        {
            return EssenCondition_3;
        }
    }

    public int Essenconditionvalue3
    {
        get
        {
            return base.DecryptInt32(EssenConditionValue_3);
        }
    }

    public string Essencondition4
    {
        get
        {
            return EssenCondition_4;
        }
    }

    public int Essenconditionvalue4
    {
        get
        {
            return base.DecryptInt32(EssenConditionValue_4);
        }
    }

    public string Bancondition1
    {
        get
        {
            return BanCondition_1;
        }
    }

    public int Banconditionvalue1
    {
        get
        {
            return base.DecryptInt32(BanConditionValue_1);
        }
    }

    public string Bancondition2
    {
        get
        {
            return BanCondition_2;
        }
    }

    public int Banconditionvalue2
    {
        get
        {
            return base.DecryptInt32(BanConditionValue_2);
        }
    }

    public string Bancondition3
    {
        get
        {
            return BanCondition_3;
        }
    }

    public int Banconditionvalue3
    {
        get
        {
            return base.DecryptInt32(BanConditionValue_3);
        }
    }

    public string Bancondition4
    {
        get
        {
            return BanCondition_4;
        }
    }

    public int Banconditionvalue4
    {
        get
        {
            return base.DecryptInt32(BanConditionValue_4);
        }
    }

    public string Bancondition5
    {
        get
        {
            return BanCondition_5;
        }
    }

    public int Banconditionvalue5
    {
        get
        {
            return base.DecryptInt32(BanConditionValue_5);
        }
    }

    public string Bancondition6
    {
        get
        {
            return BanCondition_6;
        }
    }

    public int Banconditionvalue6
    {
        get
        {
            return base.DecryptInt32(BanConditionValue_6);
        }
    }

    public int SeasonId
    {
        get
        {
            return base.DecryptInt32(season_id);
        }
    }

    public string InfoImageBg
    {
        get
        {
            return info_image_bg;
        }
    }

    public string InviteText
    {
        get
        {
            return invite_text.Localize();
        }
    }

    public int GuideStageSubType
    {
        get
        {
            return base.DecryptInt32(guide_stage_sub_type);
        }
    }

    public List<int> ListBgmSoundId
    {
        get
        {
            if (list_bgm_sound_id == null)
            {
                list_bgm_sound_id = new List<int>
                {
                    BgmSoundId1,
                    BgmSoundId2,
                    BgmSoundId3,
                    BgmSoundId4,
                    BgmSoundId5
                };
            }
            return list_bgm_sound_id;
        }
    }

    public List<int> ListAmbientSoundId
    {
        get
        {
            if (list_ambient_sound_id == null)
            {
                list_ambient_sound_id = new List<int>
                {
                    AmbientSoundId1,
                    AmbientSoundId2,
                    AmbientSoundId3,
                    AmbientSoundId4,
                    AmbientSoundId5
                };
            }
            return list_ambient_sound_id;
        }
    }

    public List<int> ListStoryId
    {
        get
        {
            if (list_story_id == null)
            {
                list_story_id = new List<int>
                {
                    StoryId1,
                    StoryId2,
                    StoryId3
                };
            }
            return list_story_id;
        }
    }

    public List<int> ListDropItemId
    {
        get
        {
            if (list_drop_item_id == null)
            {
                list_drop_item_id = new List<int>
                {
                    DropItemId1,
                    DropItemId2,
                    DropItemId3,
                    DropItemId4,
                    DropItemId5,
                    DropItemId6,
                    DropItemId7,
                    DropItemId8,
                    DropItemId9,
                    DropItemId10,
                    DropItemId11,
                    DropItemId12,
                    DropItemId13,
                    DropItemId14,
                    DropItemId15,
                    DropItemId16,
                    DropItemId17,
                    DropItemId18
                };
            }
            return list_drop_item_id;
        }
    }

    public List<int> ListDropItemValue
    {
        get
        {
            if (list_drop_item_value == null)
            {
                list_drop_item_value = new List<int>
                {
                    DropItemValue1,
                    DropItemValue2,
                    DropItemValue3,
                    DropItemValue4,
                    DropItemValue5,
                    DropItemValue6,
                    DropItemValue7,
                    DropItemValue8,
                    DropItemValue9,
                    DropItemValue10,
                    DropItemValue11,
                    DropItemValue12,
                    DropItemValue13,
                    DropItemValue14,
                    DropItemValue15,
                    DropItemValue16,
                    DropItemValue17,
                    DropItemValue18
                };
            }
            return list_drop_item_value;
        }
    }

    public List<int> ListDropItemPer
    {
        get
        {
            if (list_drop_item_per == null)
            {
                list_drop_item_per = new List<int>
                {
                    DropItemPer1,
                    DropItemPer2,
                    DropItemPer3,
                    DropItemPer4,
                    DropItemPer5,
                    DropItemPer6,
                    DropItemPer7,
                    DropItemPer8,
                    DropItemPer9,
                    DropItemPer10,
                    DropItemPer11,
                    DropItemPer12,
                    DropItemPer13,
                    DropItemPer14,
                    DropItemPer15,
                    DropItemPer16,
                    DropItemPer17,
                    DropItemPer18
                };
            }
            return list_drop_item_per;
        }
    }

    public List<int> ListDropItemBox
    {
        get
        {
            if (list_drop_item_box == null)
            {
                list_drop_item_box = new List<int>
                {
                    DropItemBox1,
                    DropItemBox2,
                    DropItemBox3,
                    DropItemBox4,
                    DropItemBox5,
                    DropItemBox6,
                    DropItemBox7,
                    DropItemBox8,
                    DropItemBox9,
                    DropItemBox10,
                    DropItemBox11,
                    DropItemBox12,
                    DropItemBox13,
                    DropItemBox14,
                    DropItemBox15,
                    DropItemBox16,
                    DropItemBox17,
                    DropItemBox18
                };
            }
            return list_drop_item_box;
        }
    }

    public List<int> ListChiefDropItemId
    {
        get
        {
            if (list_chief_drop_item_id == null)
            {
                list_chief_drop_item_id = new List<int>
                {
                    ChiefDropItemId1,
                    ChiefDropItemId2,
                    ChiefDropItemId3,
                    ChiefDropItemId4,
                    ChiefDropItemId5,
                    ChiefDropItemId6
                };
            }
            return list_chief_drop_item_id;
        }
    }

    public List<int> ListChiefDropItemValue
    {
        get
        {
            if (list_chief_drop_item_value == null)
            {
                list_chief_drop_item_value = new List<int>
                {
                    ChiefDropItemValue1,
                    ChiefDropItemValue2,
                    ChiefDropItemValue3,
                    ChiefDropItemValue4,
                    ChiefDropItemValue5,
                    ChiefDropItemValue6
                };
            }
            return list_chief_drop_item_value;
        }
    }

    public List<int> ListChiefDropItemPer
    {
        get
        {
            if (list_chief_drop_item_per == null)
            {
                list_chief_drop_item_per = new List<int>
                {
                    ChiefDropItemPer1,
                    ChiefDropItemPer2,
                    ChiefDropItemPer3,
                    ChiefDropItemPer4,
                    ChiefDropItemPer5,
                    ChiefDropItemPer6
                };
            }
            return list_chief_drop_item_per;
        }
    }

    public List<int> ListChiefDropItemBox
    {
        get
        {
            if (list_chief_drop_item_box == null)
            {
                list_chief_drop_item_box = new List<int>
                {
                    ChiefDropItemBox1,
                    ChiefDropItemBox2,
                    ChiefDropItemBox3,
                    ChiefDropItemBox4,
                    ChiefDropItemBox5,
                    ChiefDropItemBox6
                };
            }
            return list_chief_drop_item_box;
        }
    }

    public List<int> ListBossAtkIncPer
    {
        get
        {
            if (list_boss_atk_inc_per == null)
            {
                list_boss_atk_inc_per = new List<int>
                {
                    BossAtkIncPer1,
                    BossAtkIncPer2,
                    BossAtkIncPer3
                };
            }
            return list_boss_atk_inc_per;
        }
    }

    public List<int> ListBossDefIncPer
    {
        get
        {
            if (list_boss_def_inc_per == null)
            {
                list_boss_def_inc_per = new List<int>
                {
                    BossDefIncPer1,
                    BossDefIncPer2,
                    BossDefIncPer3
                };
            }
            return list_boss_def_inc_per;
        }
    }

    public List<int> ListBossHpIncPer
    {
        get
        {
            if (list_boss_hp_inc_per == null)
            {
                list_boss_hp_inc_per = new List<int>
                {
                    BossHpIncPer1,
                    BossHpIncPer2,
                    BossHpIncPer3
                };
            }
            return list_boss_hp_inc_per;
        }
    }

    public List<int> ListBossId
    {
        get
        {
            if (list_boss_id == null)
            {
                list_boss_id = new List<int>
                {
                    BossId1,
                    BossId2,
                    BossId3
                };
            }
            return list_boss_id;
        }
    }

    public List<int> ListBossLevel
    {
        get
        {
            if (list_boss_level == null)
            {
                list_boss_level = new List<int>
                {
                    BossLevel1,
                    BossLevel2,
                    BossLevel3
                };
            }
            return list_boss_level;
        }
    }

    public List<int> ListMonsterAiId
    {
        get
        {
            if (list_monster_ai_id == null)
            {
                list_monster_ai_id = new List<int>
                {
                    MonsterAiId1,
                    MonsterAiId2,
                    MonsterAiId3
                };
            }
            return list_monster_ai_id;
        }
    }

    public List<int> ListBossSkillLevel
    {
        get
        {
            if (list_boss_skill_level == null)
            {
                list_boss_skill_level = new List<int>
                {
                    BossSkillLevel1,
                    BossSkillLevel2,
                    BossSkillLevel3
                };
            }
            return list_boss_skill_level;
        }
    }

    public List<string> ListEssencondition
    {
        get
        {
            if (list_EssenCondition == null)
            {
                list_EssenCondition = new List<string>
                {
                    Essencondition1,
                    Essencondition2,
                    Essencondition3,
                    Essencondition4
                };
            }
            return list_EssenCondition;
        }
    }

    public List<int> ListEssenconditionvalue
    {
        get
        {
            if (list_EssenConditionValue == null)
            {
                list_EssenConditionValue = new List<int>
                {
                    Essenconditionvalue1,
                    Essenconditionvalue2,
                    Essenconditionvalue3,
                    Essenconditionvalue4
                };
            }
            return list_EssenConditionValue;
        }
    }

    public List<string> ListBancondition
    {
        get
        {
            if (list_BanCondition == null)
            {
                list_BanCondition = new List<string>
                {
                    Bancondition1,
                    Bancondition2,
                    Bancondition3,
                    Bancondition4,
                    Bancondition5,
                    Bancondition6
                };
            }
            return list_BanCondition;
        }
    }

    public List<int> ListBanconditionvalue
    {
        get
        {
            if (list_BanConditionValue == null)
            {
                list_BanConditionValue = new List<int>
                {
                    Banconditionvalue1,
                    Banconditionvalue2,
                    Banconditionvalue3,
                    Banconditionvalue4,
                    Banconditionvalue5,
                    Banconditionvalue6
                };
            }
            return list_BanConditionValue;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadBytes(4);
        type = reader.ReadString();
        stage_string = reader.ReadInt32();
        control_type = reader.ReadString();
        region = reader.ReadBytes(4);
        group_id = reader.ReadBytes(4);
        event_type = reader.ReadBytes(4);
        event_sub_index = reader.ReadBytes(4);
        destroy_index = reader.ReadBytes(4);
        area_switching = reader.ReadBytes(4);
        need_quest_id = reader.ReadBytes(4);
        need_main_stage_id = reader.ReadBytes(4);
        int num = reader.ReadInt32();
        list_array_contents_check = new List<string>();
        for (int i = 0; i < num; i++)
        {
            list_array_contents_check.Add(reader.ReadString());
        }
        difficulty = reader.ReadBytes(4);
        difficulty_lock = reader.ReadBytes(4);
        difficulty_string = reader.ReadInt32();
        boss_hell_check = reader.ReadByte();
        info_image = reader.ReadString();
        info_guide = reader.ReadInt32();
        start_cut = reader.ReadBytes(4);
        end_cut = reader.ReadBytes(4);
        bgm_sound_id_1 = reader.ReadBytes(4);
        ambient_sound_id_1 = reader.ReadBytes(4);
        bgm_sound_id_2 = reader.ReadBytes(4);
        ambient_sound_id_2 = reader.ReadBytes(4);
        bgm_sound_id_3 = reader.ReadBytes(4);
        ambient_sound_id_3 = reader.ReadBytes(4);
        bgm_sound_id_4 = reader.ReadBytes(4);
        ambient_sound_id_4 = reader.ReadBytes(4);
        bgm_sound_id_5 = reader.ReadBytes(4);
        ambient_sound_id_5 = reader.ReadBytes(4);
        story_id_1 = reader.ReadBytes(4);
        story_id_2 = reader.ReadBytes(4);
        story_id_3 = reader.ReadBytes(4);
        need_stamina_item_id = reader.ReadBytes(4);
        need_stamina_count = reader.ReadBytes(4);
        switching_basepoint_id = reader.ReadBytes(4);
        destroy_fellow_exp = reader.ReadBytes(4);
        destroy_buff_id = reader.ReadBytes(4);
        destroy_boss_id = reader.ReadBytes(4);
        destroy_room_boss_id = reader.ReadBytes(4);
        area_icon = reader.ReadString();
        room_file_name = reader.ReadString();
        room_spawn_prop_filename = reader.ReadString();
        bg_resource_path = reader.ReadString();
        stage_bg_resource = reader.ReadString();
        room_bgm_sound_id = reader.ReadBytes(4);
        user_exp = reader.ReadBytes(4);
        hero_exp = reader.ReadBytes(4);
        gold_value = reader.ReadBytes(4);
        group_item_rate_add = reader.ReadBytes(4);
        drop_item_boss_min_count = reader.ReadBytes(4);
        drop_item_boss_max_count = reader.ReadBytes(4);
        monster_material_per = reader.ReadBytes(4);
        drop_item_id_1 = reader.ReadBytes(4);
        drop_item_value_1 = reader.ReadBytes(4);
        drop_item_per_1 = reader.ReadBytes(4);
        drop_item_box_1 = reader.ReadBytes(4);
        drop_item_id_2 = reader.ReadBytes(4);
        drop_item_value_2 = reader.ReadBytes(4);
        drop_item_per_2 = reader.ReadBytes(4);
        drop_item_box_2 = reader.ReadBytes(4);
        drop_item_id_3 = reader.ReadBytes(4);
        drop_item_value_3 = reader.ReadBytes(4);
        drop_item_per_3 = reader.ReadBytes(4);
        drop_item_box_3 = reader.ReadBytes(4);
        drop_item_id_4 = reader.ReadBytes(4);
        drop_item_value_4 = reader.ReadBytes(4);
        drop_item_per_4 = reader.ReadBytes(4);
        drop_item_box_4 = reader.ReadBytes(4);
        drop_item_id_5 = reader.ReadBytes(4);
        drop_item_value_5 = reader.ReadBytes(4);
        drop_item_per_5 = reader.ReadBytes(4);
        drop_item_box_5 = reader.ReadBytes(4);
        drop_item_id_6 = reader.ReadBytes(4);
        drop_item_value_6 = reader.ReadBytes(4);
        drop_item_per_6 = reader.ReadBytes(4);
        drop_item_box_6 = reader.ReadBytes(4);
        drop_item_id_7 = reader.ReadBytes(4);
        drop_item_value_7 = reader.ReadBytes(4);
        drop_item_per_7 = reader.ReadBytes(4);
        drop_item_box_7 = reader.ReadBytes(4);
        drop_item_id_8 = reader.ReadBytes(4);
        drop_item_value_8 = reader.ReadBytes(4);
        drop_item_per_8 = reader.ReadBytes(4);
        drop_item_box_8 = reader.ReadBytes(4);
        drop_item_id_9 = reader.ReadBytes(4);
        drop_item_value_9 = reader.ReadBytes(4);
        drop_item_per_9 = reader.ReadBytes(4);
        drop_item_box_9 = reader.ReadBytes(4);
        drop_item_id_10 = reader.ReadBytes(4);
        drop_item_value_10 = reader.ReadBytes(4);
        drop_item_per_10 = reader.ReadBytes(4);
        drop_item_box_10 = reader.ReadBytes(4);
        drop_item_id_11 = reader.ReadBytes(4);
        drop_item_value_11 = reader.ReadBytes(4);
        drop_item_per_11 = reader.ReadBytes(4);
        drop_item_box_11 = reader.ReadBytes(4);
        drop_item_id_12 = reader.ReadBytes(4);
        drop_item_value_12 = reader.ReadBytes(4);
        drop_item_per_12 = reader.ReadBytes(4);
        drop_item_box_12 = reader.ReadBytes(4);
        drop_item_id_13 = reader.ReadBytes(4);
        drop_item_value_13 = reader.ReadBytes(4);
        drop_item_per_13 = reader.ReadBytes(4);
        drop_item_box_13 = reader.ReadBytes(4);
        drop_item_id_14 = reader.ReadBytes(4);
        drop_item_value_14 = reader.ReadBytes(4);
        drop_item_per_14 = reader.ReadBytes(4);
        drop_item_box_14 = reader.ReadBytes(4);
        drop_item_id_15 = reader.ReadBytes(4);
        drop_item_value_15 = reader.ReadBytes(4);
        drop_item_per_15 = reader.ReadBytes(4);
        drop_item_box_15 = reader.ReadBytes(4);
        drop_item_id_16 = reader.ReadBytes(4);
        drop_item_value_16 = reader.ReadBytes(4);
        drop_item_per_16 = reader.ReadBytes(4);
        drop_item_box_16 = reader.ReadBytes(4);
        drop_item_id_17 = reader.ReadBytes(4);
        drop_item_value_17 = reader.ReadBytes(4);
        drop_item_per_17 = reader.ReadBytes(4);
        drop_item_box_17 = reader.ReadBytes(4);
        drop_item_id_18 = reader.ReadBytes(4);
        drop_item_value_18 = reader.ReadBytes(4);
        drop_item_per_18 = reader.ReadBytes(4);
        drop_item_box_18 = reader.ReadBytes(4);
        chief_drop_item_id_1 = reader.ReadBytes(4);
        chief_drop_item_value_1 = reader.ReadBytes(4);
        chief_drop_item_per_1 = reader.ReadBytes(4);
        chief_drop_item_box_1 = reader.ReadBytes(4);
        chief_drop_item_id_2 = reader.ReadBytes(4);
        chief_drop_item_value_2 = reader.ReadBytes(4);
        chief_drop_item_per_2 = reader.ReadBytes(4);
        chief_drop_item_box_2 = reader.ReadBytes(4);
        chief_drop_item_id_3 = reader.ReadBytes(4);
        chief_drop_item_value_3 = reader.ReadBytes(4);
        chief_drop_item_per_3 = reader.ReadBytes(4);
        chief_drop_item_box_3 = reader.ReadBytes(4);
        chief_drop_item_id_4 = reader.ReadBytes(4);
        chief_drop_item_value_4 = reader.ReadBytes(4);
        chief_drop_item_per_4 = reader.ReadBytes(4);
        chief_drop_item_box_4 = reader.ReadBytes(4);
        chief_drop_item_id_5 = reader.ReadBytes(4);
        chief_drop_item_value_5 = reader.ReadBytes(4);
        chief_drop_item_per_5 = reader.ReadBytes(4);
        chief_drop_item_box_5 = reader.ReadBytes(4);
        chief_drop_item_id_6 = reader.ReadBytes(4);
        chief_drop_item_value_6 = reader.ReadBytes(4);
        chief_drop_item_per_6 = reader.ReadBytes(4);
        chief_drop_item_box_6 = reader.ReadBytes(4);
        add_drop_item_id_1 = reader.ReadBytes(4);
        add_drop_item_value_1 = reader.ReadBytes(4);
        add_drop_item_per_1 = reader.ReadBytes(4);
        add_drop_item_box_1 = reader.ReadBytes(4);
        boss_hit_look_enemy_check = reader.ReadByte();
        phase_shift_cinema_two_boss = reader.ReadBytes(4);
        stage_placement = reader.ReadString();
        limit_contents_match_passive_group = reader.ReadBytes(4);
        situation_behavior_tree_name = reader.ReadString();
        int num2 = reader.ReadInt32();
        list_array_destroy_tag = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_destroy_tag.Add(reader.ReadInt32());
        }
        boss_atk_inc_per_1 = reader.ReadBytes(4);
        boss_def_inc_per_1 = reader.ReadBytes(4);
        boss_hp_inc_per_1 = reader.ReadBytes(4);
        boss_id_1 = reader.ReadBytes(4);
        boss_level_1 = reader.ReadBytes(4);
        monster_ai_id_1 = reader.ReadBytes(4);
        boss_skill_level_1 = reader.ReadBytes(4);
        int num3 = reader.ReadInt32();
        list_array_skill_a_draw_per_list1 = new List<int>();
        for (int k = 0; k < num3; k++)
        {
            list_array_skill_a_draw_per_list1.Add(reader.ReadInt32());
        }
        int num4 = reader.ReadInt32();
        list_array_skill_b_draw_per_list1 = new List<int>();
        for (int l = 0; l < num4; l++)
        {
            list_array_skill_b_draw_per_list1.Add(reader.ReadInt32());
        }
        int num5 = reader.ReadInt32();
        list_array_passive1 = new List<int>();
        for (int m = 0; m < num5; m++)
        {
            list_array_passive1.Add(reader.ReadInt32());
        }
        boss_atk_inc_per_2 = reader.ReadBytes(4);
        boss_def_inc_per_2 = reader.ReadBytes(4);
        boss_hp_inc_per_2 = reader.ReadBytes(4);
        boss_id_2 = reader.ReadBytes(4);
        boss_level_2 = reader.ReadBytes(4);
        monster_ai_id_2 = reader.ReadBytes(4);
        boss_skill_level_2 = reader.ReadBytes(4);
        int num6 = reader.ReadInt32();
        list_array_skill_a_draw_per_list2 = new List<int>();
        for (int n = 0; n < num6; n++)
        {
            list_array_skill_a_draw_per_list2.Add(reader.ReadInt32());
        }
        int num7 = reader.ReadInt32();
        list_array_skill_b_draw_per_list2 = new List<int>();
        for (int num8 = 0; num8 < num7; num8++)
        {
            list_array_skill_b_draw_per_list2.Add(reader.ReadInt32());
        }
        int num9 = reader.ReadInt32();
        list_array_passive2 = new List<int>();
        for (int num10 = 0; num10 < num9; num10++)
        {
            list_array_passive2.Add(reader.ReadInt32());
        }
        boss_atk_inc_per_3 = reader.ReadBytes(4);
        boss_def_inc_per_3 = reader.ReadBytes(4);
        boss_hp_inc_per_3 = reader.ReadBytes(4);
        boss_id_3 = reader.ReadBytes(4);
        boss_level_3 = reader.ReadBytes(4);
        monster_ai_id_3 = reader.ReadBytes(4);
        boss_skill_level_3 = reader.ReadBytes(4);
        int num11 = reader.ReadInt32();
        list_array_skill_a_draw_per_list3 = new List<int>();
        for (int num12 = 0; num12 < num11; num12++)
        {
            list_array_skill_a_draw_per_list3.Add(reader.ReadInt32());
        }
        int num13 = reader.ReadInt32();
        list_array_skill_b_draw_per_list3 = new List<int>();
        for (int num14 = 0; num14 < num13; num14++)
        {
            list_array_skill_b_draw_per_list3.Add(reader.ReadInt32());
        }
        int num15 = reader.ReadInt32();
        list_array_passive3 = new List<int>();
        for (int num16 = 0; num16 < num15; num16++)
        {
            list_array_passive3.Add(reader.ReadInt32());
        }
        play_boss_spawn = reader.ReadBytes(4);
        boss_entry_type = reader.ReadString();
        team_power = reader.ReadBytes(4);
        map_filename = reader.ReadString();
        spawn_prop_filename = reader.ReadString();
        change_map_filename = reader.ReadString();
        bgm_sound_id = reader.ReadBytes(4);
        boss_sound_id = reader.ReadBytes(4);
        EssenCondition_1 = reader.ReadString();
        EssenConditionValue_1 = reader.ReadBytes(4);
        EssenCondition_2 = reader.ReadString();
        EssenConditionValue_2 = reader.ReadBytes(4);
        EssenCondition_3 = reader.ReadString();
        EssenConditionValue_3 = reader.ReadBytes(4);
        EssenCondition_4 = reader.ReadString();
        EssenConditionValue_4 = reader.ReadBytes(4);
        BanCondition_1 = reader.ReadString();
        BanConditionValue_1 = reader.ReadBytes(4);
        BanCondition_2 = reader.ReadString();
        BanConditionValue_2 = reader.ReadBytes(4);
        BanCondition_3 = reader.ReadString();
        BanConditionValue_3 = reader.ReadBytes(4);
        BanCondition_4 = reader.ReadString();
        BanConditionValue_4 = reader.ReadBytes(4);
        BanCondition_5 = reader.ReadString();
        BanConditionValue_5 = reader.ReadBytes(4);
        BanCondition_6 = reader.ReadString();
        BanConditionValue_6 = reader.ReadBytes(4);
        season_id = reader.ReadBytes(4);
        info_image_bg = reader.ReadString();
        invite_text = reader.ReadInt32();
        guide_stage_sub_type = reader.ReadBytes(4);
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private byte[] id;

    private string type;

    private int stage_string;

    private string control_type;

    private byte[] region;

    private byte[] group_id;

    private byte[] event_type;

    private byte[] event_sub_index;

    private byte[] destroy_index;

    private byte[] area_switching;

    private byte[] need_quest_id;

    private byte[] need_main_stage_id;

    private List<string> list_array_contents_check;

    private byte[] difficulty;

    private byte[] difficulty_lock;

    private int difficulty_string;

    private byte boss_hell_check;

    private string info_image;

    private int info_guide;

    private byte[] start_cut;

    private byte[] end_cut;

    private byte[] bgm_sound_id_1;

    private byte[] ambient_sound_id_1;

    private byte[] bgm_sound_id_2;

    private byte[] ambient_sound_id_2;

    private byte[] bgm_sound_id_3;

    private byte[] ambient_sound_id_3;

    private byte[] bgm_sound_id_4;

    private byte[] ambient_sound_id_4;

    private byte[] bgm_sound_id_5;

    private byte[] ambient_sound_id_5;

    private byte[] story_id_1;

    private byte[] story_id_2;

    private byte[] story_id_3;

    private byte[] need_stamina_item_id;

    private byte[] need_stamina_count;

    private byte[] switching_basepoint_id;

    private byte[] destroy_fellow_exp;

    private byte[] destroy_buff_id;

    private byte[] destroy_boss_id;

    private byte[] destroy_room_boss_id;

    private string area_icon;

    private string room_file_name;

    private string room_spawn_prop_filename;

    private string bg_resource_path;

    private string stage_bg_resource;

    private byte[] room_bgm_sound_id;

    private byte[] user_exp;

    private byte[] hero_exp;

    private byte[] gold_value;

    private byte[] group_item_rate_add;

    private byte[] drop_item_boss_min_count;

    private byte[] drop_item_boss_max_count;

    private byte[] monster_material_per;

    private byte[] drop_item_id_1;

    private byte[] drop_item_value_1;

    private byte[] drop_item_per_1;

    private byte[] drop_item_box_1;

    private byte[] drop_item_id_2;

    private byte[] drop_item_value_2;

    private byte[] drop_item_per_2;

    private byte[] drop_item_box_2;

    private byte[] drop_item_id_3;

    private byte[] drop_item_value_3;

    private byte[] drop_item_per_3;

    private byte[] drop_item_box_3;

    private byte[] drop_item_id_4;

    private byte[] drop_item_value_4;

    private byte[] drop_item_per_4;

    private byte[] drop_item_box_4;

    private byte[] drop_item_id_5;

    private byte[] drop_item_value_5;

    private byte[] drop_item_per_5;

    private byte[] drop_item_box_5;

    private byte[] drop_item_id_6;

    private byte[] drop_item_value_6;

    private byte[] drop_item_per_6;

    private byte[] drop_item_box_6;

    private byte[] drop_item_id_7;

    private byte[] drop_item_value_7;

    private byte[] drop_item_per_7;

    private byte[] drop_item_box_7;

    private byte[] drop_item_id_8;

    private byte[] drop_item_value_8;

    private byte[] drop_item_per_8;

    private byte[] drop_item_box_8;

    private byte[] drop_item_id_9;

    private byte[] drop_item_value_9;

    private byte[] drop_item_per_9;

    private byte[] drop_item_box_9;

    private byte[] drop_item_id_10;

    private byte[] drop_item_value_10;

    private byte[] drop_item_per_10;

    private byte[] drop_item_box_10;

    private byte[] drop_item_id_11;

    private byte[] drop_item_value_11;

    private byte[] drop_item_per_11;

    private byte[] drop_item_box_11;

    private byte[] drop_item_id_12;

    private byte[] drop_item_value_12;

    private byte[] drop_item_per_12;

    private byte[] drop_item_box_12;

    private byte[] drop_item_id_13;

    private byte[] drop_item_value_13;

    private byte[] drop_item_per_13;

    private byte[] drop_item_box_13;

    private byte[] drop_item_id_14;

    private byte[] drop_item_value_14;

    private byte[] drop_item_per_14;

    private byte[] drop_item_box_14;

    private byte[] drop_item_id_15;

    private byte[] drop_item_value_15;

    private byte[] drop_item_per_15;

    private byte[] drop_item_box_15;

    private byte[] drop_item_id_16;

    private byte[] drop_item_value_16;

    private byte[] drop_item_per_16;

    private byte[] drop_item_box_16;

    private byte[] drop_item_id_17;

    private byte[] drop_item_value_17;

    private byte[] drop_item_per_17;

    private byte[] drop_item_box_17;

    private byte[] drop_item_id_18;

    private byte[] drop_item_value_18;

    private byte[] drop_item_per_18;

    private byte[] drop_item_box_18;

    private byte[] chief_drop_item_id_1;

    private byte[] chief_drop_item_value_1;

    private byte[] chief_drop_item_per_1;

    private byte[] chief_drop_item_box_1;

    private byte[] chief_drop_item_id_2;

    private byte[] chief_drop_item_value_2;

    private byte[] chief_drop_item_per_2;

    private byte[] chief_drop_item_box_2;

    private byte[] chief_drop_item_id_3;

    private byte[] chief_drop_item_value_3;

    private byte[] chief_drop_item_per_3;

    private byte[] chief_drop_item_box_3;

    private byte[] chief_drop_item_id_4;

    private byte[] chief_drop_item_value_4;

    private byte[] chief_drop_item_per_4;

    private byte[] chief_drop_item_box_4;

    private byte[] chief_drop_item_id_5;

    private byte[] chief_drop_item_value_5;

    private byte[] chief_drop_item_per_5;

    private byte[] chief_drop_item_box_5;

    private byte[] chief_drop_item_id_6;

    private byte[] chief_drop_item_value_6;

    private byte[] chief_drop_item_per_6;

    private byte[] chief_drop_item_box_6;

    private byte[] add_drop_item_id_1;

    private byte[] add_drop_item_value_1;

    private byte[] add_drop_item_per_1;

    private byte[] add_drop_item_box_1;

    private byte boss_hit_look_enemy_check;

    private byte[] phase_shift_cinema_two_boss;

    private string stage_placement;

    private byte[] limit_contents_match_passive_group;

    private string situation_behavior_tree_name;

    private List<int> list_array_destroy_tag;

    private byte[] boss_atk_inc_per_1;

    private byte[] boss_def_inc_per_1;

    private byte[] boss_hp_inc_per_1;

    private byte[] boss_id_1;

    private byte[] boss_level_1;

    private byte[] monster_ai_id_1;

    private byte[] boss_skill_level_1;

    private List<int> list_array_skill_a_draw_per_list1;

    private List<int> list_array_skill_b_draw_per_list1;

    private List<int> list_array_passive1;

    private byte[] boss_atk_inc_per_2;

    private byte[] boss_def_inc_per_2;

    private byte[] boss_hp_inc_per_2;

    private byte[] boss_id_2;

    private byte[] boss_level_2;

    private byte[] monster_ai_id_2;

    private byte[] boss_skill_level_2;

    private List<int> list_array_skill_a_draw_per_list2;

    private List<int> list_array_skill_b_draw_per_list2;

    private List<int> list_array_passive2;

    private byte[] boss_atk_inc_per_3;

    private byte[] boss_def_inc_per_3;

    private byte[] boss_hp_inc_per_3;

    private byte[] boss_id_3;

    private byte[] boss_level_3;

    private byte[] monster_ai_id_3;

    private byte[] boss_skill_level_3;

    private List<int> list_array_skill_a_draw_per_list3;

    private List<int> list_array_skill_b_draw_per_list3;

    private List<int> list_array_passive3;

    private byte[] play_boss_spawn;

    private string boss_entry_type;

    private byte[] team_power;

    private string map_filename;

    private string spawn_prop_filename;

    private string change_map_filename;

    private byte[] bgm_sound_id;

    private byte[] boss_sound_id;

    private string EssenCondition_1;

    private byte[] EssenConditionValue_1;

    private string EssenCondition_2;

    private byte[] EssenConditionValue_2;

    private string EssenCondition_3;

    private byte[] EssenConditionValue_3;

    private string EssenCondition_4;

    private byte[] EssenConditionValue_4;

    private string BanCondition_1;

    private byte[] BanConditionValue_1;

    private string BanCondition_2;

    private byte[] BanConditionValue_2;

    private string BanCondition_3;

    private byte[] BanConditionValue_3;

    private string BanCondition_4;

    private byte[] BanConditionValue_4;

    private string BanCondition_5;

    private byte[] BanConditionValue_5;

    private string BanCondition_6;

    private byte[] BanConditionValue_6;

    private byte[] season_id;

    private string info_image_bg;

    private int invite_text;

    private byte[] guide_stage_sub_type;

    private List<int> list_bgm_sound_id;

    private List<int> list_ambient_sound_id;

    private List<int> list_story_id;

    private List<int> list_drop_item_id;

    private List<int> list_drop_item_value;

    private List<int> list_drop_item_per;

    private List<int> list_drop_item_box;

    private List<int> list_chief_drop_item_id;

    private List<int> list_chief_drop_item_value;

    private List<int> list_chief_drop_item_per;

    private List<int> list_chief_drop_item_box;

    private List<int> list_boss_atk_inc_per;

    private List<int> list_boss_def_inc_per;

    private List<int> list_boss_hp_inc_per;

    private List<int> list_boss_id;

    private List<int> list_boss_level;

    private List<int> list_monster_ai_id;

    private List<int> list_boss_skill_level;

    private List<string> list_EssenCondition;

    private List<int> list_EssenConditionValue;

    private List<string> list_BanCondition;

    private List<int> list_BanConditionValue;
}
