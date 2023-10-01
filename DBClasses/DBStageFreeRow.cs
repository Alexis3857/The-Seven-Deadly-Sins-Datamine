public class DBStageFreeRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
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

    public int EssenHeroSetting
    {
        get
        {
            return essen_hero_setting;
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
            return region;
        }
    }

    public int FreeIndex
    {
        get
        {
            return free_index;
        }
    }

    public int LimitIndex
    {
        get
        {
            return limit_index;
        }
    }

    public string NeedStageType
    {
        get
        {
            return need_stage_type;
        }
    }

    public int NeedStageId
    {
        get
        {
            return need_stage_id;
        }
    }

    public int NeedBaseFellowId
    {
        get
        {
            return need_base_fellow_id;
        }
    }

    public int NeedBaseFellowLevel
    {
        get
        {
            return need_base_fellow_level;
        }
    }

    public int NeedHeroId
    {
        get
        {
            return need_hero_id;
        }
    }

    public int NeedQuestId
    {
        get
        {
            return need_quest_id;
        }
    }

    public int Area
    {
        get
        {
            return area;
        }
    }

    public int Difficulty
    {
        get
        {
            return difficulty;
        }
    }

    public string DifficultyString
    {
        get
        {
            return difficulty_string.Localize();
        }
    }

    public int StageEndArea
    {
        get
        {
            return stage_end_area;
        }
    }

    public int StageClearArea
    {
        get
        {
            return stage_clear_area;
        }
    }

    public int PreStartCut
    {
        get
        {
            return pre_start_cut;
        }
    }

    public int StartCut
    {
        get
        {
            return start_cut;
        }
    }

    public int EndCut
    {
        get
        {
            return end_cut;
        }
    }

    public int StoryId1
    {
        get
        {
            return story_id_1;
        }
    }

    public int StoryId2
    {
        get
        {
            return story_id_2;
        }
    }

    public int StoryId3
    {
        get
        {
            return story_id_3;
        }
    }

    public int NeedStaminaItemId
    {
        get
        {
            return need_stamina_item_id;
        }
    }

    public int NeedStaminaCount
    {
        get
        {
            return need_stamina_count;
        }
    }

    public int TeamPower
    {
        get
        {
            return team_power;
        }
    }

    public int MonsterCount
    {
        get
        {
            return monster_count;
        }
    }

    public int MonsterAtkIncPer
    {
        get
        {
            return monster_atk_inc_per;
        }
    }

    public int MonsterDefIncPer
    {
        get
        {
            return monster_def_inc_per;
        }
    }

    public int MonsterHpIncPer
    {
        get
        {
            return monster_hp_inc_per;
        }
    }

    public int MonsterLevel
    {
        get
        {
            return monster_level;
        }
    }

    public int MonsterId1
    {
        get
        {
            return monster_id_1;
        }
    }

    public int MonsterId2
    {
        get
        {
            return monster_id_2;
        }
    }

    public int MonsterId3
    {
        get
        {
            return monster_id_3;
        }
    }

    public int MonsterId4
    {
        get
        {
            return monster_id_4;
        }
    }

    public int MonsterId5
    {
        get
        {
            return monster_id_5;
        }
    }

    public int MonsterId6
    {
        get
        {
            return monster_id_6;
        }
    }

    public int MonsterId7
    {
        get
        {
            return monster_id_7;
        }
    }

    public int MonsterId8
    {
        get
        {
            return monster_id_8;
        }
    }

    public int MonsterMaterialBox1
    {
        get
        {
            return monster_material_box_1;
        }
    }

    public int IsTurnPivot
    {
        get
        {
            return is_turn_pivot;
        }
    }

    public int SetBossEliteUi
    {
        get
        {
            return set_boss_elite_ui;
        }
    }

    public string StagePlacement
    {
        get
        {
            return stage_placement;
        }
    }

    public int StageHeroEntryAll
    {
        get
        {
            return stage_hero_entry_all;
        }
    }

    public int MonsterSpecialSkillPlay
    {
        get
        {
            return monster_special_skill_play;
        }
    }

    public int MonsterAiId
    {
        get
        {
            return monster_ai_id;
        }
    }

    public int BossAtkIncPer
    {
        get
        {
            return boss_atk_inc_per;
        }
    }

    public int BossDefIncPer
    {
        get
        {
            return boss_def_inc_per;
        }
    }

    public int BossHpIncPer
    {
        get
        {
            return boss_hp_inc_per;
        }
    }

    public int BossId1
    {
        get
        {
            return boss_id_1;
        }
    }

    public int BossLevel1
    {
        get
        {
            return boss_level_1;
        }
    }

    public List<int> ListArrayPassive1
    {
        get
        {
            return list_array_passive1;
        }
    }

    public int BossMaterialBox1
    {
        get
        {
            return boss_material_box_1;
        }
    }

    public int BossId2
    {
        get
        {
            return boss_id_2;
        }
    }

    public int BossLevel2
    {
        get
        {
            return boss_level_2;
        }
    }

    public List<int> ListArrayPassive2
    {
        get
        {
            return list_array_passive2;
        }
    }

    public int BossMaterialBox2
    {
        get
        {
            return boss_material_box_2;
        }
    }

    public int BossId3
    {
        get
        {
            return boss_id_3;
        }
    }

    public int BossLevel3
    {
        get
        {
            return boss_level_3;
        }
    }

    public List<int> ListArrayPassive3
    {
        get
        {
            return list_array_passive3;
        }
    }

    public int BossMaterialBox3
    {
        get
        {
            return boss_material_box_3;
        }
    }

    public int BossId4
    {
        get
        {
            return boss_id_4;
        }
    }

    public int BossLevel4
    {
        get
        {
            return boss_level_4;
        }
    }

    public List<int> ListArrayPassive4
    {
        get
        {
            return list_array_passive4;
        }
    }

    public int BossMaterialBox4
    {
        get
        {
            return boss_material_box_4;
        }
    }

    public int PlayBossSpawn
    {
        get
        {
            return play_boss_spawn;
        }
    }

    public string BossEntryType
    {
        get
        {
            return boss_entry_type;
        }
    }

    public List<int> ListArrayAllyPassiveId
    {
        get
        {
            return list_array_ally_passive_id;
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
            return bgm_sound_id;
        }
    }

    public int BossSoundId
    {
        get
        {
            return boss_sound_id;
        }
    }

    public int UserExp
    {
        get
        {
            return user_exp;
        }
    }

    public int HeroExp
    {
        get
        {
            return hero_exp;
        }
    }

    public int GoldValue
    {
        get
        {
            return gold_value;
        }
    }

    public int FirstRewardId
    {
        get
        {
            return first_reward_id;
        }
    }

    public int FirstRewardValue
    {
        get
        {
            return first_reward_value;
        }
    }

    public int DropItemNormalMinCount
    {
        get
        {
            return drop_item_normal_min_count;
        }
    }

    public int DropItemNormalMaxCount
    {
        get
        {
            return drop_item_normal_max_count;
        }
    }

    public int DropItemBossMinCount
    {
        get
        {
            return drop_item_boss_min_count;
        }
    }

    public int DropItemBossMaxCount
    {
        get
        {
            return drop_item_boss_max_count;
        }
    }

    public int MonsterMaterialPer
    {
        get
        {
            return monster_material_per;
        }
    }

    public int DropItemId1
    {
        get
        {
            return drop_item_id_1;
        }
    }

    public int DropItemValue1
    {
        get
        {
            return drop_item_value_1;
        }
    }

    public int DropItemEvolutionCount1
    {
        get
        {
            return drop_item_evolution_count_1;
        }
    }

    public int DropItemPer1
    {
        get
        {
            return drop_item_per_1;
        }
    }

    public int DropItemBox1
    {
        get
        {
            return drop_item_box_1;
        }
    }

    public int DropItemId2
    {
        get
        {
            return drop_item_id_2;
        }
    }

    public int DropItemValue2
    {
        get
        {
            return drop_item_value_2;
        }
    }

    public int DropItemEvolutionCount2
    {
        get
        {
            return drop_item_evolution_count_2;
        }
    }

    public int DropItemPer2
    {
        get
        {
            return drop_item_per_2;
        }
    }

    public int DropItemBox2
    {
        get
        {
            return drop_item_box_2;
        }
    }

    public int DropItemId3
    {
        get
        {
            return drop_item_id_3;
        }
    }

    public int DropItemValue3
    {
        get
        {
            return drop_item_value_3;
        }
    }

    public int DropItemEvolutionCount3
    {
        get
        {
            return drop_item_evolution_count_3;
        }
    }

    public int DropItemPer3
    {
        get
        {
            return drop_item_per_3;
        }
    }

    public int DropItemBox3
    {
        get
        {
            return drop_item_box_3;
        }
    }

    public int DropItemId4
    {
        get
        {
            return drop_item_id_4;
        }
    }

    public int DropItemValue4
    {
        get
        {
            return drop_item_value_4;
        }
    }

    public int DropItemEvolutionCount4
    {
        get
        {
            return drop_item_evolution_count_4;
        }
    }

    public int DropItemPer4
    {
        get
        {
            return drop_item_per_4;
        }
    }

    public int DropItemBox4
    {
        get
        {
            return drop_item_box_4;
        }
    }

    public int DropItemId5
    {
        get
        {
            return drop_item_id_5;
        }
    }

    public int DropItemValue5
    {
        get
        {
            return drop_item_value_5;
        }
    }

    public int DropItemEvolutionCount5
    {
        get
        {
            return drop_item_evolution_count_5;
        }
    }

    public int DropItemPer5
    {
        get
        {
            return drop_item_per_5;
        }
    }

    public int DropItemBox5
    {
        get
        {
            return drop_item_box_5;
        }
    }

    public int DropItemId6
    {
        get
        {
            return drop_item_id_6;
        }
    }

    public int DropItemValue6
    {
        get
        {
            return drop_item_value_6;
        }
    }

    public int DropItemEvolutionCount6
    {
        get
        {
            return drop_item_evolution_count_6;
        }
    }

    public int DropItemPer6
    {
        get
        {
            return drop_item_per_6;
        }
    }

    public int DropItemBox6
    {
        get
        {
            return drop_item_box_6;
        }
    }

    public int DropItemId7
    {
        get
        {
            return drop_item_id_7;
        }
    }

    public int DropItemValue7
    {
        get
        {
            return drop_item_value_7;
        }
    }

    public int DropItemEvolutionCount7
    {
        get
        {
            return drop_item_evolution_count_7;
        }
    }

    public int DropItemPer7
    {
        get
        {
            return drop_item_per_7;
        }
    }

    public int DropItemBox7
    {
        get
        {
            return drop_item_box_7;
        }
    }

    public int DropItemId8
    {
        get
        {
            return drop_item_id_8;
        }
    }

    public int DropItemValue8
    {
        get
        {
            return drop_item_value_8;
        }
    }

    public int DropItemEvolutionCount8
    {
        get
        {
            return drop_item_evolution_count_8;
        }
    }

    public int DropItemPer8
    {
        get
        {
            return drop_item_per_8;
        }
    }

    public int DropItemBox8
    {
        get
        {
            return drop_item_box_8;
        }
    }

    public int DropItemId9
    {
        get
        {
            return drop_item_id_9;
        }
    }

    public int DropItemValue9
    {
        get
        {
            return drop_item_value_9;
        }
    }

    public int DropItemEvolutionCount9
    {
        get
        {
            return drop_item_evolution_count_9;
        }
    }

    public int DropItemPer9
    {
        get
        {
            return drop_item_per_9;
        }
    }

    public int DropItemBox9
    {
        get
        {
            return drop_item_box_9;
        }
    }

    public int DropItemId10
    {
        get
        {
            return drop_item_id_10;
        }
    }

    public int DropItemValue10
    {
        get
        {
            return drop_item_value_10;
        }
    }

    public int DropItemEvolutionCount10
    {
        get
        {
            return drop_item_evolution_count_10;
        }
    }

    public int DropItemPer10
    {
        get
        {
            return drop_item_per_10;
        }
    }

    public int DropItemBox10
    {
        get
        {
            return drop_item_box_10;
        }
    }

    public int DropItemId11
    {
        get
        {
            return drop_item_id_11;
        }
    }

    public int DropItemValue11
    {
        get
        {
            return drop_item_value_11;
        }
    }

    public int DropItemEvolutionCount11
    {
        get
        {
            return drop_item_evolution_count_11;
        }
    }

    public int DropItemPer11
    {
        get
        {
            return drop_item_per_11;
        }
    }

    public int DropItemBox11
    {
        get
        {
            return drop_item_box_11;
        }
    }

    public int DropItemId12
    {
        get
        {
            return drop_item_id_12;
        }
    }

    public int DropItemValue12
    {
        get
        {
            return drop_item_value_12;
        }
    }

    public int DropItemEvolutionCount12
    {
        get
        {
            return drop_item_evolution_count_12;
        }
    }

    public int DropItemPer12
    {
        get
        {
            return drop_item_per_12;
        }
    }

    public int DropItemBox12
    {
        get
        {
            return drop_item_box_12;
        }
    }

    public int DropItemId13
    {
        get
        {
            return drop_item_id_13;
        }
    }

    public int DropItemValue13
    {
        get
        {
            return drop_item_value_13;
        }
    }

    public int DropItemEvolutionCount13
    {
        get
        {
            return drop_item_evolution_count_13;
        }
    }

    public int DropItemPer13
    {
        get
        {
            return drop_item_per_13;
        }
    }

    public int DropItemBox13
    {
        get
        {
            return drop_item_box_13;
        }
    }

    public int DropItemId14
    {
        get
        {
            return drop_item_id_14;
        }
    }

    public int DropItemValue14
    {
        get
        {
            return drop_item_value_14;
        }
    }

    public int DropItemEvolutionCount14
    {
        get
        {
            return drop_item_evolution_count_14;
        }
    }

    public int DropItemPer14
    {
        get
        {
            return drop_item_per_14;
        }
    }

    public int DropItemBox14
    {
        get
        {
            return drop_item_box_14;
        }
    }

    public int DropItemId15
    {
        get
        {
            return drop_item_id_15;
        }
    }

    public int DropItemValue15
    {
        get
        {
            return drop_item_value_15;
        }
    }

    public int DropItemEvolutionCount15
    {
        get
        {
            return drop_item_evolution_count_15;
        }
    }

    public int DropItemPer15
    {
        get
        {
            return drop_item_per_15;
        }
    }

    public int DropItemBox15
    {
        get
        {
            return drop_item_box_15;
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
            return EssenConditionValue_1;
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
            return EssenConditionValue_2;
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
            return EssenConditionValue_3;
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
            return EssenConditionValue_4;
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
            return BanConditionValue_1;
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
            return BanConditionValue_2;
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
            return BanConditionValue_3;
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
            return BanConditionValue_4;
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
            return BanConditionValue_5;
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
            return BanConditionValue_6;
        }
    }

    public int NpcTeamId
    {
        get
        {
            return npc_team_id;
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

    public List<int> ListMonsterId
    {
        get
        {
            if (list_monster_id == null)
            {
                list_monster_id = new List<int>
                {
                    MonsterId1,
                    MonsterId2,
                    MonsterId3,
                    MonsterId4,
                    MonsterId5,
                    MonsterId6,
                    MonsterId7,
                    MonsterId8
                };
            }
            return list_monster_id;
        }
    }

    public List<int> ListMonsterMaterialBox
    {
        get
        {
            if (list_monster_material_box == null)
            {
                list_monster_material_box = new List<int>
                {
                    MonsterMaterialBox1
                };
            }
            return list_monster_material_box;
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
                    BossId3,
                    BossId4
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
                    BossLevel3,
                    BossLevel4
                };
            }
            return list_boss_level;
        }
    }

    public List<int> ListBossMaterialBox
    {
        get
        {
            if (list_boss_material_box == null)
            {
                list_boss_material_box = new List<int>
                {
                    BossMaterialBox1,
                    BossMaterialBox2,
                    BossMaterialBox3,
                    BossMaterialBox4
                };
            }
            return list_boss_material_box;
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
                    DropItemId15
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
                    DropItemValue15
                };
            }
            return list_drop_item_value;
        }
    }

    public List<int> ListDropItemEvolutionCount
    {
        get
        {
            if (list_drop_item_evolution_count == null)
            {
                list_drop_item_evolution_count = new List<int>
                {
                    DropItemEvolutionCount1,
                    DropItemEvolutionCount2,
                    DropItemEvolutionCount3,
                    DropItemEvolutionCount4,
                    DropItemEvolutionCount5,
                    DropItemEvolutionCount6,
                    DropItemEvolutionCount7,
                    DropItemEvolutionCount8,
                    DropItemEvolutionCount9,
                    DropItemEvolutionCount10,
                    DropItemEvolutionCount11,
                    DropItemEvolutionCount12,
                    DropItemEvolutionCount13,
                    DropItemEvolutionCount14,
                    DropItemEvolutionCount15
                };
            }
            return list_drop_item_evolution_count;
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
                    DropItemPer15
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
                    DropItemBox15
                };
            }
            return list_drop_item_box;
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
        id = reader.ReadInt32();
        type = reader.ReadString();
        stage_string = reader.ReadInt32();
        essen_hero_setting = reader.ReadInt32();
        control_type = reader.ReadString();
        region = reader.ReadInt32();
        free_index = reader.ReadInt32();
        limit_index = reader.ReadInt32();
        need_stage_type = reader.ReadString();
        need_stage_id = reader.ReadInt32();
        need_base_fellow_id = reader.ReadInt32();
        need_base_fellow_level = reader.ReadInt32();
        need_hero_id = reader.ReadInt32();
        need_quest_id = reader.ReadInt32();
        area = reader.ReadInt32();
        difficulty = reader.ReadInt32();
        difficulty_string = reader.ReadInt32();
        stage_end_area = reader.ReadInt32();
        stage_clear_area = reader.ReadInt32();
        pre_start_cut = reader.ReadInt32();
        start_cut = reader.ReadInt32();
        end_cut = reader.ReadInt32();
        story_id_1 = reader.ReadInt32();
        story_id_2 = reader.ReadInt32();
        story_id_3 = reader.ReadInt32();
        need_stamina_item_id = reader.ReadInt32();
        need_stamina_count = reader.ReadInt32();
        team_power = reader.ReadInt32();
        monster_count = reader.ReadInt32();
        monster_atk_inc_per = reader.ReadInt32();
        monster_def_inc_per = reader.ReadInt32();
        monster_hp_inc_per = reader.ReadInt32();
        monster_level = reader.ReadInt32();
        monster_id_1 = reader.ReadInt32();
        monster_id_2 = reader.ReadInt32();
        monster_id_3 = reader.ReadInt32();
        monster_id_4 = reader.ReadInt32();
        monster_id_5 = reader.ReadInt32();
        monster_id_6 = reader.ReadInt32();
        monster_id_7 = reader.ReadInt32();
        monster_id_8 = reader.ReadInt32();
        monster_material_box_1 = reader.ReadInt32();
        is_turn_pivot = reader.ReadInt32();
        set_boss_elite_ui = reader.ReadInt32();
        stage_placement = reader.ReadString();
        stage_hero_entry_all = reader.ReadInt32();
        monster_special_skill_play = reader.ReadInt32();
        monster_ai_id = reader.ReadInt32();
        boss_atk_inc_per = reader.ReadInt32();
        boss_def_inc_per = reader.ReadInt32();
        boss_hp_inc_per = reader.ReadInt32();
        boss_id_1 = reader.ReadInt32();
        boss_level_1 = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_passive1 = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_passive1.Add(reader.ReadInt32());
        }
        boss_material_box_1 = reader.ReadInt32();
        boss_id_2 = reader.ReadInt32();
        boss_level_2 = reader.ReadInt32();
        int num2 = reader.ReadInt32();
        list_array_passive2 = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_passive2.Add(reader.ReadInt32());
        }
        boss_material_box_2 = reader.ReadInt32();
        boss_id_3 = reader.ReadInt32();
        boss_level_3 = reader.ReadInt32();
        int num3 = reader.ReadInt32();
        list_array_passive3 = new List<int>();
        for (int k = 0; k < num3; k++)
        {
            list_array_passive3.Add(reader.ReadInt32());
        }
        boss_material_box_3 = reader.ReadInt32();
        boss_id_4 = reader.ReadInt32();
        boss_level_4 = reader.ReadInt32();
        int num4 = reader.ReadInt32();
        list_array_passive4 = new List<int>();
        for (int l = 0; l < num4; l++)
        {
            list_array_passive4.Add(reader.ReadInt32());
        }
        boss_material_box_4 = reader.ReadInt32();
        play_boss_spawn = reader.ReadInt32();
        boss_entry_type = reader.ReadString();
        int num5 = reader.ReadInt32();
        list_array_ally_passive_id = new List<int>();
        for (int m = 0; m < num5; m++)
        {
            list_array_ally_passive_id.Add(reader.ReadInt32());
        }
        map_filename = reader.ReadString();
        spawn_prop_filename = reader.ReadString();
        change_map_filename = reader.ReadString();
        bgm_sound_id = reader.ReadInt32();
        boss_sound_id = reader.ReadInt32();
        user_exp = reader.ReadInt32();
        hero_exp = reader.ReadInt32();
        gold_value = reader.ReadInt32();
        first_reward_id = reader.ReadInt32();
        first_reward_value = reader.ReadInt32();
        drop_item_normal_min_count = reader.ReadInt32();
        drop_item_normal_max_count = reader.ReadInt32();
        drop_item_boss_min_count = reader.ReadInt32();
        drop_item_boss_max_count = reader.ReadInt32();
        monster_material_per = reader.ReadInt32();
        drop_item_id_1 = reader.ReadInt32();
        drop_item_value_1 = reader.ReadInt32();
        drop_item_evolution_count_1 = reader.ReadInt32();
        drop_item_per_1 = reader.ReadInt32();
        drop_item_box_1 = reader.ReadInt32();
        drop_item_id_2 = reader.ReadInt32();
        drop_item_value_2 = reader.ReadInt32();
        drop_item_evolution_count_2 = reader.ReadInt32();
        drop_item_per_2 = reader.ReadInt32();
        drop_item_box_2 = reader.ReadInt32();
        drop_item_id_3 = reader.ReadInt32();
        drop_item_value_3 = reader.ReadInt32();
        drop_item_evolution_count_3 = reader.ReadInt32();
        drop_item_per_3 = reader.ReadInt32();
        drop_item_box_3 = reader.ReadInt32();
        drop_item_id_4 = reader.ReadInt32();
        drop_item_value_4 = reader.ReadInt32();
        drop_item_evolution_count_4 = reader.ReadInt32();
        drop_item_per_4 = reader.ReadInt32();
        drop_item_box_4 = reader.ReadInt32();
        drop_item_id_5 = reader.ReadInt32();
        drop_item_value_5 = reader.ReadInt32();
        drop_item_evolution_count_5 = reader.ReadInt32();
        drop_item_per_5 = reader.ReadInt32();
        drop_item_box_5 = reader.ReadInt32();
        drop_item_id_6 = reader.ReadInt32();
        drop_item_value_6 = reader.ReadInt32();
        drop_item_evolution_count_6 = reader.ReadInt32();
        drop_item_per_6 = reader.ReadInt32();
        drop_item_box_6 = reader.ReadInt32();
        drop_item_id_7 = reader.ReadInt32();
        drop_item_value_7 = reader.ReadInt32();
        drop_item_evolution_count_7 = reader.ReadInt32();
        drop_item_per_7 = reader.ReadInt32();
        drop_item_box_7 = reader.ReadInt32();
        drop_item_id_8 = reader.ReadInt32();
        drop_item_value_8 = reader.ReadInt32();
        drop_item_evolution_count_8 = reader.ReadInt32();
        drop_item_per_8 = reader.ReadInt32();
        drop_item_box_8 = reader.ReadInt32();
        drop_item_id_9 = reader.ReadInt32();
        drop_item_value_9 = reader.ReadInt32();
        drop_item_evolution_count_9 = reader.ReadInt32();
        drop_item_per_9 = reader.ReadInt32();
        drop_item_box_9 = reader.ReadInt32();
        drop_item_id_10 = reader.ReadInt32();
        drop_item_value_10 = reader.ReadInt32();
        drop_item_evolution_count_10 = reader.ReadInt32();
        drop_item_per_10 = reader.ReadInt32();
        drop_item_box_10 = reader.ReadInt32();
        drop_item_id_11 = reader.ReadInt32();
        drop_item_value_11 = reader.ReadInt32();
        drop_item_evolution_count_11 = reader.ReadInt32();
        drop_item_per_11 = reader.ReadInt32();
        drop_item_box_11 = reader.ReadInt32();
        drop_item_id_12 = reader.ReadInt32();
        drop_item_value_12 = reader.ReadInt32();
        drop_item_evolution_count_12 = reader.ReadInt32();
        drop_item_per_12 = reader.ReadInt32();
        drop_item_box_12 = reader.ReadInt32();
        drop_item_id_13 = reader.ReadInt32();
        drop_item_value_13 = reader.ReadInt32();
        drop_item_evolution_count_13 = reader.ReadInt32();
        drop_item_per_13 = reader.ReadInt32();
        drop_item_box_13 = reader.ReadInt32();
        drop_item_id_14 = reader.ReadInt32();
        drop_item_value_14 = reader.ReadInt32();
        drop_item_evolution_count_14 = reader.ReadInt32();
        drop_item_per_14 = reader.ReadInt32();
        drop_item_box_14 = reader.ReadInt32();
        drop_item_id_15 = reader.ReadInt32();
        drop_item_value_15 = reader.ReadInt32();
        drop_item_evolution_count_15 = reader.ReadInt32();
        drop_item_per_15 = reader.ReadInt32();
        drop_item_box_15 = reader.ReadInt32();
        EssenCondition_1 = reader.ReadString();
        EssenConditionValue_1 = reader.ReadInt32();
        EssenCondition_2 = reader.ReadString();
        EssenConditionValue_2 = reader.ReadInt32();
        EssenCondition_3 = reader.ReadString();
        EssenConditionValue_3 = reader.ReadInt32();
        EssenCondition_4 = reader.ReadString();
        EssenConditionValue_4 = reader.ReadInt32();
        BanCondition_1 = reader.ReadString();
        BanConditionValue_1 = reader.ReadInt32();
        BanCondition_2 = reader.ReadString();
        BanConditionValue_2 = reader.ReadInt32();
        BanCondition_3 = reader.ReadString();
        BanConditionValue_3 = reader.ReadInt32();
        BanCondition_4 = reader.ReadString();
        BanConditionValue_4 = reader.ReadInt32();
        BanCondition_5 = reader.ReadString();
        BanConditionValue_5 = reader.ReadInt32();
        BanCondition_6 = reader.ReadString();
        BanConditionValue_6 = reader.ReadInt32();
        npc_team_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string type;

    private int stage_string;

    private int essen_hero_setting;

    private string control_type;

    private int region;

    private int free_index;

    private int limit_index;

    private string need_stage_type;

    private int need_stage_id;

    private int need_base_fellow_id;

    private int need_base_fellow_level;

    private int need_hero_id;

    private int need_quest_id;

    private int area;

    private int difficulty;

    private int difficulty_string;

    private int stage_end_area;

    private int stage_clear_area;

    private int pre_start_cut;

    private int start_cut;

    private int end_cut;

    private int story_id_1;

    private int story_id_2;

    private int story_id_3;

    private int need_stamina_item_id;

    private int need_stamina_count;

    private int team_power;

    private int monster_count;

    private int monster_atk_inc_per;

    private int monster_def_inc_per;

    private int monster_hp_inc_per;

    private int monster_level;

    private int monster_id_1;

    private int monster_id_2;

    private int monster_id_3;

    private int monster_id_4;

    private int monster_id_5;

    private int monster_id_6;

    private int monster_id_7;

    private int monster_id_8;

    private int monster_material_box_1;

    private int is_turn_pivot;

    private int set_boss_elite_ui;

    private string stage_placement;

    private int stage_hero_entry_all;

    private int monster_special_skill_play;

    private int monster_ai_id;

    private int boss_atk_inc_per;

    private int boss_def_inc_per;

    private int boss_hp_inc_per;

    private int boss_id_1;

    private int boss_level_1;

    private List<int> list_array_passive1;

    private int boss_material_box_1;

    private int boss_id_2;

    private int boss_level_2;

    private List<int> list_array_passive2;

    private int boss_material_box_2;

    private int boss_id_3;

    private int boss_level_3;

    private List<int> list_array_passive3;

    private int boss_material_box_3;

    private int boss_id_4;

    private int boss_level_4;

    private List<int> list_array_passive4;

    private int boss_material_box_4;

    private int play_boss_spawn;

    private string boss_entry_type;

    private List<int> list_array_ally_passive_id;

    private string map_filename;

    private string spawn_prop_filename;

    private string change_map_filename;

    private int bgm_sound_id;

    private int boss_sound_id;

    private int user_exp;

    private int hero_exp;

    private int gold_value;

    private int first_reward_id;

    private int first_reward_value;

    private int drop_item_normal_min_count;

    private int drop_item_normal_max_count;

    private int drop_item_boss_min_count;

    private int drop_item_boss_max_count;

    private int monster_material_per;

    private int drop_item_id_1;

    private int drop_item_value_1;

    private int drop_item_evolution_count_1;

    private int drop_item_per_1;

    private int drop_item_box_1;

    private int drop_item_id_2;

    private int drop_item_value_2;

    private int drop_item_evolution_count_2;

    private int drop_item_per_2;

    private int drop_item_box_2;

    private int drop_item_id_3;

    private int drop_item_value_3;

    private int drop_item_evolution_count_3;

    private int drop_item_per_3;

    private int drop_item_box_3;

    private int drop_item_id_4;

    private int drop_item_value_4;

    private int drop_item_evolution_count_4;

    private int drop_item_per_4;

    private int drop_item_box_4;

    private int drop_item_id_5;

    private int drop_item_value_5;

    private int drop_item_evolution_count_5;

    private int drop_item_per_5;

    private int drop_item_box_5;

    private int drop_item_id_6;

    private int drop_item_value_6;

    private int drop_item_evolution_count_6;

    private int drop_item_per_6;

    private int drop_item_box_6;

    private int drop_item_id_7;

    private int drop_item_value_7;

    private int drop_item_evolution_count_7;

    private int drop_item_per_7;

    private int drop_item_box_7;

    private int drop_item_id_8;

    private int drop_item_value_8;

    private int drop_item_evolution_count_8;

    private int drop_item_per_8;

    private int drop_item_box_8;

    private int drop_item_id_9;

    private int drop_item_value_9;

    private int drop_item_evolution_count_9;

    private int drop_item_per_9;

    private int drop_item_box_9;

    private int drop_item_id_10;

    private int drop_item_value_10;

    private int drop_item_evolution_count_10;

    private int drop_item_per_10;

    private int drop_item_box_10;

    private int drop_item_id_11;

    private int drop_item_value_11;

    private int drop_item_evolution_count_11;

    private int drop_item_per_11;

    private int drop_item_box_11;

    private int drop_item_id_12;

    private int drop_item_value_12;

    private int drop_item_evolution_count_12;

    private int drop_item_per_12;

    private int drop_item_box_12;

    private int drop_item_id_13;

    private int drop_item_value_13;

    private int drop_item_evolution_count_13;

    private int drop_item_per_13;

    private int drop_item_box_13;

    private int drop_item_id_14;

    private int drop_item_value_14;

    private int drop_item_evolution_count_14;

    private int drop_item_per_14;

    private int drop_item_box_14;

    private int drop_item_id_15;

    private int drop_item_value_15;

    private int drop_item_evolution_count_15;

    private int drop_item_per_15;

    private int drop_item_box_15;

    private string EssenCondition_1;

    private int EssenConditionValue_1;

    private string EssenCondition_2;

    private int EssenConditionValue_2;

    private string EssenCondition_3;

    private int EssenConditionValue_3;

    private string EssenCondition_4;

    private int EssenConditionValue_4;

    private string BanCondition_1;

    private int BanConditionValue_1;

    private string BanCondition_2;

    private int BanConditionValue_2;

    private string BanCondition_3;

    private int BanConditionValue_3;

    private string BanCondition_4;

    private int BanConditionValue_4;

    private string BanCondition_5;

    private int BanConditionValue_5;

    private string BanCondition_6;

    private int BanConditionValue_6;

    private int npc_team_id;

    private List<int> list_story_id;

    private List<int> list_monster_id;

    private List<int> list_monster_material_box;

    private List<int> list_boss_id;

    private List<int> list_boss_level;

    private List<int> list_boss_material_box;

    private List<int> list_drop_item_id;

    private List<int> list_drop_item_value;

    private List<int> list_drop_item_evolution_count;

    private List<int> list_drop_item_per;

    private List<int> list_drop_item_box;

    private List<string> list_EssenCondition;

    private List<int> list_EssenConditionValue;

    private List<string> list_BanCondition;

    private List<int> list_BanConditionValue;
}
