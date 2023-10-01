public class DBBasepointNpcRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int NpcInfoId
    {
        get
        {
            return npc_info_id;
        }
    }

    public string NpcName
    {
        get
        {
            return npc_name.Localize();
        }
    }

    public string NpcRole
    {
        get
        {
            return npc_role;
        }
    }

    public List<int> ListArrayLinkNpcId
    {
        get
        {
            return list_array_link_npc_id;
        }
    }

    public int HeroGroup
    {
        get
        {
            return hero_group;
        }
    }

    public int GuestId
    {
        get
        {
            return guest_id;
        }
    }

    public int BasepointId
    {
        get
        {
            return basepoint_id;
        }
    }

    public int BasepointIndex
    {
        get
        {
            return basepoint_index;
        }
    }

    public int NpcSkinChange
    {
        get
        {
            return npc_skin_change;
        }
    }

    public int UseSubCostume
    {
        get
        {
            return use_sub_costume;
        }
    }

    public int OpenBasepointFellow
    {
        get
        {
            return open_basepoint_fellow;
        }
    }

    public string OpenType
    {
        get
        {
            return open_type;
        }
    }

    public int OpenValue
    {
        get
        {
            return open_value;
        }
    }

    public string CloseType
    {
        get
        {
            return close_type;
        }
    }

    public int CloseValue
    {
        get
        {
            return close_value;
        }
    }

    public int ShadowState
    {
        get
        {
            return shadow_state;
        }
    }

    public int PositionId
    {
        get
        {
            return position_id;
        }
    }

    public string ContentsMenu1
    {
        get
        {
            return contents_menu_1;
        }
    }

    public string ContentsMenu2
    {
        get
        {
            return contents_menu_2;
        }
    }

    public string ContentsMenu3
    {
        get
        {
            return contents_menu_3;
        }
    }

    public string ContentsMenu4
    {
        get
        {
            return contents_menu_4;
        }
    }

    public string ContentsMenu5
    {
        get
        {
            return contents_menu_5;
        }
    }

    public string ContentsMenu6
    {
        get
        {
            return contents_menu_6;
        }
    }

    public string ContentsMenu7
    {
        get
        {
            return contents_menu_7;
        }
    }

    public int ActiveQuestId
    {
        get
        {
            return active_quest_id;
        }
    }

    public int StageQuestId
    {
        get
        {
            return stage_quest_id;
        }
    }

    public int QuestCountGroup
    {
        get
        {
            return quest_count_group;
        }
    }

    public int RewardId1
    {
        get
        {
            return reward_id_1;
        }
    }

    public int RewardCount1
    {
        get
        {
            return reward_count_1;
        }
    }

    public int DailyRewardIndex
    {
        get
        {
            return daily_reward_index;
        }
    }

    public int DailyRewardId1
    {
        get
        {
            return daily_reward_id_1;
        }
    }

    public int DailyRewardCount1
    {
        get
        {
            return daily_reward_count_1;
        }
    }

    public int LowOptionBlind
    {
        get
        {
            return low_option_blind;
        }
    }

    public List<string> ListContentsMenu
    {
        get
        {
            if (list_contents_menu == null)
            {
                list_contents_menu = new List<string>
                {
                    ContentsMenu1,
                    ContentsMenu2,
                    ContentsMenu3,
                    ContentsMenu4,
                    ContentsMenu5,
                    ContentsMenu6,
                    ContentsMenu7
                };
            }
            return list_contents_menu;
        }
    }

    public List<int> ListRewardId
    {
        get
        {
            if (list_reward_id == null)
            {
                list_reward_id = new List<int>
                {
                    RewardId1
                };
            }
            return list_reward_id;
        }
    }

    public List<int> ListRewardCount
    {
        get
        {
            if (list_reward_count == null)
            {
                list_reward_count = new List<int>
                {
                    RewardCount1
                };
            }
            return list_reward_count;
        }
    }

    public List<int> ListDailyRewardId
    {
        get
        {
            if (list_daily_reward_id == null)
            {
                list_daily_reward_id = new List<int>
                {
                    DailyRewardId1
                };
            }
            return list_daily_reward_id;
        }
    }

    public List<int> ListDailyRewardCount
    {
        get
        {
            if (list_daily_reward_count == null)
            {
                list_daily_reward_count = new List<int>
                {
                    DailyRewardCount1
                };
            }
            return list_daily_reward_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        npc_info_id = reader.ReadInt32();
        npc_name = reader.ReadInt32();
        npc_role = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_link_npc_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_link_npc_id.Add(reader.ReadInt32());
        }
        hero_group = reader.ReadInt32();
        guest_id = reader.ReadInt32();
        basepoint_id = reader.ReadInt32();
        basepoint_index = reader.ReadInt32();
        npc_skin_change = reader.ReadInt32();
        use_sub_costume = reader.ReadInt32();
        open_basepoint_fellow = reader.ReadInt32();
        open_type = reader.ReadString();
        open_value = reader.ReadInt32();
        close_type = reader.ReadString();
        close_value = reader.ReadInt32();
        shadow_state = reader.ReadInt32();
        position_id = reader.ReadInt32();
        contents_menu_1 = reader.ReadString();
        contents_menu_2 = reader.ReadString();
        contents_menu_3 = reader.ReadString();
        contents_menu_4 = reader.ReadString();
        contents_menu_5 = reader.ReadString();
        contents_menu_6 = reader.ReadString();
        contents_menu_7 = reader.ReadString();
        active_quest_id = reader.ReadInt32();
        stage_quest_id = reader.ReadInt32();
        quest_count_group = reader.ReadInt32();
        reward_id_1 = reader.ReadInt32();
        reward_count_1 = reader.ReadInt32();
        daily_reward_index = reader.ReadInt32();
        daily_reward_id_1 = reader.ReadInt32();
        daily_reward_count_1 = reader.ReadInt32();
        low_option_blind = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int npc_info_id;

    private int npc_name;

    private string npc_role;

    private List<int> list_array_link_npc_id;

    private int hero_group;

    private int guest_id;

    private int basepoint_id;

    private int basepoint_index;

    private int npc_skin_change;

    private int use_sub_costume;

    private int open_basepoint_fellow;

    private string open_type;

    private int open_value;

    private string close_type;

    private int close_value;

    private int shadow_state;

    private int position_id;

    private string contents_menu_1;

    private string contents_menu_2;

    private string contents_menu_3;

    private string contents_menu_4;

    private string contents_menu_5;

    private string contents_menu_6;

    private string contents_menu_7;

    private int active_quest_id;

    private int stage_quest_id;

    private int quest_count_group;

    private int reward_id_1;

    private int reward_count_1;

    private int daily_reward_index;

    private int daily_reward_id_1;

    private int daily_reward_count_1;

    private int low_option_blind;

    private List<string> list_contents_menu;

    private List<int> list_reward_id;

    private List<int> list_reward_count;

    private List<int> list_daily_reward_id;

    private List<int> list_daily_reward_count;
}
