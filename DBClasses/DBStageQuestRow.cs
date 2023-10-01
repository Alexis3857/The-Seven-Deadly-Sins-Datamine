public class DBStageQuestRow : ITableRowIndexer
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

    public string TypeLocal
    {
        get
        {
            return type_local;
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

    public int Ep
    {
        get
        {
            return ep;
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

    public int Index
    {
        get
        {
            return index;
        }
    }

    public int Area
    {
        get
        {
            return area;
        }
    }

    public int StartQuestId
    {
        get
        {
            return start_quest_id;
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

    public int CharacterPositionMoveId
    {
        get
        {
            return character_position_move_id;
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

    public int BossSkillLevel1
    {
        get
        {
            return boss_skill_level_1;
        }
    }

    public List<int> ListArrayPassive1
    {
        get
        {
            return list_array_passive1;
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

    public int BossSkillLevel2
    {
        get
        {
            return boss_skill_level_2;
        }
    }

    public List<int> ListArrayPassive2
    {
        get
        {
            return list_array_passive2;
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

    public int BossSkillLevel3
    {
        get
        {
            return boss_skill_level_3;
        }
    }

    public List<int> ListArrayPassive3
    {
        get
        {
            return list_array_passive3;
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

    public int BossSkillLevel4
    {
        get
        {
            return boss_skill_level_4;
        }
    }

    public List<int> ListArrayPassive4
    {
        get
        {
            return list_array_passive4;
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

    public int TeamPower
    {
        get
        {
            return team_power;
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
                    BossSkillLevel3,
                    BossSkillLevel4
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
        id = reader.ReadInt32();
        type = reader.ReadString();
        type_local = reader.ReadString();
        stage_string = reader.ReadInt32();
        essen_hero_setting = reader.ReadInt32();
        ep = reader.ReadInt32();
        control_type = reader.ReadString();
        region = reader.ReadInt32();
        index = reader.ReadInt32();
        area = reader.ReadInt32();
        start_quest_id = reader.ReadInt32();
        stage_end_area = reader.ReadInt32();
        stage_clear_area = reader.ReadInt32();
        character_position_move_id = reader.ReadInt32();
        start_cut = reader.ReadInt32();
        end_cut = reader.ReadInt32();
        story_id_1 = reader.ReadInt32();
        story_id_2 = reader.ReadInt32();
        story_id_3 = reader.ReadInt32();
        need_stamina_item_id = reader.ReadInt32();
        need_stamina_count = reader.ReadInt32();
        user_exp = reader.ReadInt32();
        hero_exp = reader.ReadInt32();
        gold_value = reader.ReadInt32();
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
        boss_skill_level_1 = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_passive1 = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_passive1.Add(reader.ReadInt32());
        }
        boss_id_2 = reader.ReadInt32();
        boss_level_2 = reader.ReadInt32();
        boss_skill_level_2 = reader.ReadInt32();
        int num2 = reader.ReadInt32();
        list_array_passive2 = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_passive2.Add(reader.ReadInt32());
        }
        boss_id_3 = reader.ReadInt32();
        boss_level_3 = reader.ReadInt32();
        boss_skill_level_3 = reader.ReadInt32();
        int num3 = reader.ReadInt32();
        list_array_passive3 = new List<int>();
        for (int k = 0; k < num3; k++)
        {
            list_array_passive3.Add(reader.ReadInt32());
        }
        boss_id_4 = reader.ReadInt32();
        boss_level_4 = reader.ReadInt32();
        boss_skill_level_4 = reader.ReadInt32();
        int num4 = reader.ReadInt32();
        list_array_passive4 = new List<int>();
        for (int l = 0; l < num4; l++)
        {
            list_array_passive4.Add(reader.ReadInt32());
        }
        appear_cutscene_skip = reader.ReadInt32();
        play_boss_spawn = reader.ReadInt32();
        boss_entry_type = reader.ReadString();
        int num5 = reader.ReadInt32();
        list_array_ally_passive_id = new List<int>();
        for (int m = 0; m < num5; m++)
        {
            list_array_ally_passive_id.Add(reader.ReadInt32());
        }
        team_power = reader.ReadInt32();
        map_filename = reader.ReadString();
        spawn_prop_filename = reader.ReadString();
        change_map_filename = reader.ReadString();
        bgm_sound_id = reader.ReadInt32();
        boss_sound_id = reader.ReadInt32();
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

    private string type_local;

    private int stage_string;

    private int essen_hero_setting;

    private int ep;

    private string control_type;

    private int region;

    private int index;

    private int area;

    private int start_quest_id;

    private int stage_end_area;

    private int stage_clear_area;

    private int character_position_move_id;

    private int start_cut;

    private int end_cut;

    private int story_id_1;

    private int story_id_2;

    private int story_id_3;

    private int need_stamina_item_id;

    private int need_stamina_count;

    private int user_exp;

    private int hero_exp;

    private int gold_value;

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

    private int boss_skill_level_1;

    private List<int> list_array_passive1;

    private int boss_id_2;

    private int boss_level_2;

    private int boss_skill_level_2;

    private List<int> list_array_passive2;

    private int boss_id_3;

    private int boss_level_3;

    private int boss_skill_level_3;

    private List<int> list_array_passive3;

    private int boss_id_4;

    private int boss_level_4;

    private int boss_skill_level_4;

    private List<int> list_array_passive4;

    private int appear_cutscene_skip;

    private int play_boss_spawn;

    private string boss_entry_type;

    private List<int> list_array_ally_passive_id;

    private int team_power;

    private string map_filename;

    private string spawn_prop_filename;

    private string change_map_filename;

    private int bgm_sound_id;

    private int boss_sound_id;

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

    private List<int> list_boss_id;

    private List<int> list_boss_level;

    private List<int> list_boss_skill_level;

    private List<string> list_EssenCondition;

    private List<int> list_EssenConditionValue;

    private List<string> list_BanCondition;

    private List<int> list_BanConditionValue;
}
