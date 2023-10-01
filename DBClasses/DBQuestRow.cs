public class DBQuestRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string QuestName
    {
        get
        {
            return quest_name.Localize();
        }
    }

    public int Region
    {
        get
        {
            return region;
        }
    }

    public int QuestBasepointId
    {
        get
        {
            return quest_basepoint_id;
        }
    }

    public string QuestClass
    {
        get
        {
            return quest_class;
        }
    }

    public int AnotherEpisode
    {
        get
        {
            return another_episode;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public int RepeatCheck
    {
        get
        {
            return repeat_check;
        }
    }

    public int NextStoryQuest
    {
        get
        {
            return next_story_quest;
        }
    }

    public int NeedBaseFellowLevel
    {
        get
        {
            return need_base_fellow_level;
        }
    }

    public string OpenClass1
    {
        get
        {
            return open_class_1;
        }
    }

    public string OpenType1
    {
        get
        {
            return open_type_1;
        }
    }

    public int OpenValue1
    {
        get
        {
            return open_value_1;
        }
    }

    public int FellowQuestGroup
    {
        get
        {
            return fellow_quest_group;
        }
    }

    public int QuestGroup
    {
        get
        {
            return quest_group;
        }
    }

    public List<int> ListArrayResetQuestGroupOnClear
    {
        get
        {
            return list_array_reset_quest_group_on_clear;
        }
    }

    public List<int> ListArrayOpenCheckQuestGroup
    {
        get
        {
            return list_array_open_check_quest_group;
        }
    }

    public int MatchingAreaEndId
    {
        get
        {
            return matching_area_end_id;
        }
    }

    public int ContentsOpenArea
    {
        get
        {
            return contents_open_area;
        }
    }

    public List<string> ListArrayContentsCheck
    {
        get
        {
            return list_array_contents_check;
        }
    }

    public int AutoStart
    {
        get
        {
            return auto_start;
        }
    }

    public int StartAreaId
    {
        get
        {
            return start_area_id;
        }
    }

    public int StartNpcId
    {
        get
        {
            return start_npc_id;
        }
    }

    public int AutoStoryCut
    {
        get
        {
            return auto_story_cut;
        }
    }

    public int AutoEnd
    {
        get
        {
            return auto_end;
        }
    }

    public int PassTown
    {
        get
        {
            return pass_town;
        }
    }

    public int EndAreaId
    {
        get
        {
            return end_area_id;
        }
    }

    public int EndNpcId
    {
        get
        {
            return end_npc_id;
        }
    }

    public string QuestType
    {
        get
        {
            return quest_type;
        }
    }

    public string QuestInfoAlarm
    {
        get
        {
            return quest_info_alarm.Localize();
        }
    }

    public int QuestInfoAlarmGroup
    {
        get
        {
            return quest_info_alarm_group;
        }
    }

    public string PlayStageType
    {
        get
        {
            return play_stage_type;
        }
    }

    public List<int> ListArrayPlayStageId
    {
        get
        {
            return list_array_play_stage_id;
        }
    }

    public List<int> ListArrayCheckRegionArea
    {
        get
        {
            return list_array_check_region_area;
        }
    }

    public List<int> ListArrayNeedId
    {
        get
        {
            return list_array_need_id;
        }
    }

    public string NeedType
    {
        get
        {
            return need_type;
        }
    }

    public List<int> ListArrayNeedCount
    {
        get
        {
            return list_array_need_count;
        }
    }

    public int NeedItemKeep
    {
        get
        {
            return need_item_keep;
        }
    }

    public int GiveQuestItemId
    {
        get
        {
            return give_quest_item_id;
        }
    }

    public int GiveQuestItemCount
    {
        get
        {
            return give_quest_item_count;
        }
    }

    public List<int> ListArrayCountNpc
    {
        get
        {
            return list_array_count_npc;
        }
    }

    public List<string> ListArrayCountNpcMenu
    {
        get
        {
            return list_array_count_npc_menu;
        }
    }

    public int ItemInfoLink
    {
        get
        {
            return item_info_link;
        }
    }

    public int LobbyQuestRoute
    {
        get
        {
            return lobby_quest_route;
        }
    }

    public int LoopQuestId
    {
        get
        {
            return loop_quest_id;
        }
    }

    public int QuestInfoGroupCheck
    {
        get
        {
            return quest_info_group_check;
        }
    }

    public string QuestInfo
    {
        get
        {
            return quest_info.Localize();
        }
    }

    public string IconInfo1Resource
    {
        get
        {
            return icon_info_1_resource;
        }
    }

    public int IconInfo1ItemId
    {
        get
        {
            return icon_info_1_item_id;
        }
    }

    public string IconInfo1
    {
        get
        {
            return icon_info_1;
        }
    }

    public int NeedUserRank
    {
        get
        {
            return need_user_rank;
        }
    }

    public int StartStoryCut
    {
        get
        {
            return start_story_cut;
        }
    }

    public int EndStoryCut
    {
        get
        {
            return end_story_cut;
        }
    }

    public int CharacterPositionMoveId
    {
        get
        {
            return character_position_move_id;
        }
    }

    public int UserExp
    {
        get
        {
            return user_exp;
        }
    }

    public int BaseFellowId
    {
        get
        {
            return base_fellow_id;
        }
    }

    public int BaseFellowExp
    {
        get
        {
            return base_fellow_exp;
        }
    }

    public int RewardItemId1
    {
        get
        {
            return reward_item_id_1;
        }
    }

    public int RewardItemCount1
    {
        get
        {
            return reward_item_count_1;
        }
    }

    public int RewardItemHeroLv1
    {
        get
        {
            return reward_item_hero_lv_1;
        }
    }

    public int RewardItemId2
    {
        get
        {
            return reward_item_id_2;
        }
    }

    public int RewardItemCount2
    {
        get
        {
            return reward_item_count_2;
        }
    }

    public int RewardItemHeroLv2
    {
        get
        {
            return reward_item_hero_lv_2;
        }
    }

    public int RewardItemId3
    {
        get
        {
            return reward_item_id_3;
        }
    }

    public int RewardItemCount3
    {
        get
        {
            return reward_item_count_3;
        }
    }

    public int RewardItemHeroLv3
    {
        get
        {
            return reward_item_hero_lv_3;
        }
    }

    public int RewardItemId4
    {
        get
        {
            return reward_item_id_4;
        }
    }

    public int RewardItemCount4
    {
        get
        {
            return reward_item_count_4;
        }
    }

    public int RewardItemHeroLv4
    {
        get
        {
            return reward_item_hero_lv_4;
        }
    }

    public List<string> ListOpenClass
    {
        get
        {
            if (list_open_class == null)
            {
                list_open_class = new List<string>
                {
                    OpenClass1
                };
            }
            return list_open_class;
        }
    }

    public List<string> ListOpenType
    {
        get
        {
            if (list_open_type == null)
            {
                list_open_type = new List<string>
                {
                    OpenType1
                };
            }
            return list_open_type;
        }
    }

    public List<int> ListOpenValue
    {
        get
        {
            if (list_open_value == null)
            {
                list_open_value = new List<int>
                {
                    OpenValue1
                };
            }
            return list_open_value;
        }
    }

    public List<string> ListIconInfo
    {
        get
        {
            if (list_icon_info == null)
            {
                list_icon_info = new List<string>
                {
                    IconInfo1
                };
            }
            return list_icon_info;
        }
    }

    public List<int> ListRewardItemId
    {
        get
        {
            if (list_reward_item_id == null)
            {
                list_reward_item_id = new List<int>
                {
                    RewardItemId1,
                    RewardItemId2,
                    RewardItemId3,
                    RewardItemId4
                };
            }
            return list_reward_item_id;
        }
    }

    public List<int> ListRewardItemCount
    {
        get
        {
            if (list_reward_item_count == null)
            {
                list_reward_item_count = new List<int>
                {
                    RewardItemCount1,
                    RewardItemCount2,
                    RewardItemCount3,
                    RewardItemCount4
                };
            }
            return list_reward_item_count;
        }
    }

    public List<int> ListRewardItemHeroLv
    {
        get
        {
            if (list_reward_item_hero_lv == null)
            {
                list_reward_item_hero_lv = new List<int>
                {
                    RewardItemHeroLv1,
                    RewardItemHeroLv2,
                    RewardItemHeroLv3,
                    RewardItemHeroLv4
                };
            }
            return list_reward_item_hero_lv;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        quest_name = reader.ReadInt32();
        region = reader.ReadInt32();
        quest_basepoint_id = reader.ReadInt32();
        quest_class = reader.ReadString();
        another_episode = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        repeat_check = reader.ReadInt32();
        next_story_quest = reader.ReadInt32();
        need_base_fellow_level = reader.ReadInt32();
        open_class_1 = reader.ReadString();
        open_type_1 = reader.ReadString();
        open_value_1 = reader.ReadInt32();
        fellow_quest_group = reader.ReadInt32();
        quest_group = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_reset_quest_group_on_clear = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_reset_quest_group_on_clear.Add(reader.ReadInt32());
        }
        int num2 = reader.ReadInt32();
        list_array_open_check_quest_group = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_open_check_quest_group.Add(reader.ReadInt32());
        }
        matching_area_end_id = reader.ReadInt32();
        contents_open_area = reader.ReadInt32();
        int num3 = reader.ReadInt32();
        list_array_contents_check = new List<string>();
        for (int k = 0; k < num3; k++)
        {
            list_array_contents_check.Add(reader.ReadString());
        }
        auto_start = reader.ReadInt32();
        start_area_id = reader.ReadInt32();
        start_npc_id = reader.ReadInt32();
        auto_story_cut = reader.ReadInt32();
        auto_end = reader.ReadInt32();
        pass_town = reader.ReadInt32();
        end_area_id = reader.ReadInt32();
        end_npc_id = reader.ReadInt32();
        quest_type = reader.ReadString();
        quest_info_alarm = reader.ReadInt32();
        quest_info_alarm_group = reader.ReadInt32();
        play_stage_type = reader.ReadString();
        int num4 = reader.ReadInt32();
        list_array_play_stage_id = new List<int>();
        for (int l = 0; l < num4; l++)
        {
            list_array_play_stage_id.Add(reader.ReadInt32());
        }
        int num5 = reader.ReadInt32();
        list_array_check_region_area = new List<int>();
        for (int m = 0; m < num5; m++)
        {
            list_array_check_region_area.Add(reader.ReadInt32());
        }
        int num6 = reader.ReadInt32();
        list_array_need_id = new List<int>();
        for (int n = 0; n < num6; n++)
        {
            list_array_need_id.Add(reader.ReadInt32());
        }
        need_type = reader.ReadString();
        int num7 = reader.ReadInt32();
        list_array_need_count = new List<int>();
        for (int num8 = 0; num8 < num7; num8++)
        {
            list_array_need_count.Add(reader.ReadInt32());
        }
        need_item_keep = reader.ReadInt32();
        give_quest_item_id = reader.ReadInt32();
        give_quest_item_count = reader.ReadInt32();
        int num9 = reader.ReadInt32();
        list_array_count_npc = new List<int>();
        for (int num10 = 0; num10 < num9; num10++)
        {
            list_array_count_npc.Add(reader.ReadInt32());
        }
        int num11 = reader.ReadInt32();
        list_array_count_npc_menu = new List<string>();
        for (int num12 = 0; num12 < num11; num12++)
        {
            list_array_count_npc_menu.Add(reader.ReadString());
        }
        item_info_link = reader.ReadInt32();
        lobby_quest_route = reader.ReadInt32();
        loop_quest_id = reader.ReadInt32();
        quest_info_group_check = reader.ReadInt32();
        quest_info = reader.ReadInt32();
        icon_info_1_resource = reader.ReadString();
        icon_info_1_item_id = reader.ReadInt32();
        icon_info_1 = reader.ReadString();
        need_user_rank = reader.ReadInt32();
        start_story_cut = reader.ReadInt32();
        end_story_cut = reader.ReadInt32();
        character_position_move_id = reader.ReadInt32();
        user_exp = reader.ReadInt32();
        base_fellow_id = reader.ReadInt32();
        base_fellow_exp = reader.ReadInt32();
        reward_item_id_1 = reader.ReadInt32();
        reward_item_count_1 = reader.ReadInt32();
        reward_item_hero_lv_1 = reader.ReadInt32();
        reward_item_id_2 = reader.ReadInt32();
        reward_item_count_2 = reader.ReadInt32();
        reward_item_hero_lv_2 = reader.ReadInt32();
        reward_item_id_3 = reader.ReadInt32();
        reward_item_count_3 = reader.ReadInt32();
        reward_item_hero_lv_3 = reader.ReadInt32();
        reward_item_id_4 = reader.ReadInt32();
        reward_item_count_4 = reader.ReadInt32();
        reward_item_hero_lv_4 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int quest_name;

    private int region;

    private int quest_basepoint_id;

    private string quest_class;

    private int another_episode;

    private int event_sub_index;

    private int repeat_check;

    private int next_story_quest;

    private int need_base_fellow_level;

    private string open_class_1;

    private string open_type_1;

    private int open_value_1;

    private int fellow_quest_group;

    private int quest_group;

    private List<int> list_array_reset_quest_group_on_clear;

    private List<int> list_array_open_check_quest_group;

    private int matching_area_end_id;

    private int contents_open_area;

    private List<string> list_array_contents_check;

    private int auto_start;

    private int start_area_id;

    private int start_npc_id;

    private int auto_story_cut;

    private int auto_end;

    private int pass_town;

    private int end_area_id;

    private int end_npc_id;

    private string quest_type;

    private int quest_info_alarm;

    private int quest_info_alarm_group;

    private string play_stage_type;

    private List<int> list_array_play_stage_id;

    private List<int> list_array_check_region_area;

    private List<int> list_array_need_id;

    private string need_type;

    private List<int> list_array_need_count;

    private int need_item_keep;

    private int give_quest_item_id;

    private int give_quest_item_count;

    private List<int> list_array_count_npc;

    private List<string> list_array_count_npc_menu;

    private int item_info_link;

    private int lobby_quest_route;

    private int loop_quest_id;

    private int quest_info_group_check;

    private int quest_info;

    private string icon_info_1_resource;

    private int icon_info_1_item_id;

    private string icon_info_1;

    private int need_user_rank;

    private int start_story_cut;

    private int end_story_cut;

    private int character_position_move_id;

    private int user_exp;

    private int base_fellow_id;

    private int base_fellow_exp;

    private int reward_item_id_1;

    private int reward_item_count_1;

    private int reward_item_hero_lv_1;

    private int reward_item_id_2;

    private int reward_item_count_2;

    private int reward_item_hero_lv_2;

    private int reward_item_id_3;

    private int reward_item_count_3;

    private int reward_item_hero_lv_3;

    private int reward_item_id_4;

    private int reward_item_count_4;

    private int reward_item_hero_lv_4;

    private List<string> list_open_class;

    private List<string> list_open_type;

    private List<int> list_open_value;

    private List<string> list_icon_info;

    private List<int> list_reward_item_id;

    private List<int> list_reward_item_count;

    private List<int> list_reward_item_hero_lv;
}
