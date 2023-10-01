public class DBQuestEventUtilityRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string QuestClass
    {
        get
        {
            return quest_class;
        }
    }

    public int Region
    {
        get
        {
            return region;
        }
    }

    public string QuestGroupIconPath
    {
        get
        {
            return quest_group_icon_path;
        }
    }

    public string QuestGroupIcon
    {
        get
        {
            return quest_group_icon;
        }
    }

    public string QuestGroupLocalize
    {
        get
        {
            return quest_group_localize.Localize();
        }
    }

    public List<int> ListArrayQuestGroupList
    {
        get
        {
            return list_array_quest_group_list;
        }
    }

    public int StepupMissionValue
    {
        get
        {
            return stepup_mission_value;
        }
    }

    public string GroupOpenType
    {
        get
        {
            return group_open_type;
        }
    }

    public int GroupOpenValue
    {
        get
        {
            return group_open_value;
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

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        quest_class = reader.ReadString();
        region = reader.ReadInt32();
        quest_group_icon_path = reader.ReadString();
        quest_group_icon = reader.ReadString();
        quest_group_localize = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_quest_group_list = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_quest_group_list.Add(reader.ReadInt32());
        }
        stepup_mission_value = reader.ReadInt32();
        group_open_type = reader.ReadString();
        group_open_value = reader.ReadInt32();
        reward_item_id_1 = reader.ReadInt32();
        reward_item_count_1 = reader.ReadInt32();
        reward_item_id_2 = reader.ReadInt32();
        reward_item_count_2 = reader.ReadInt32();
        reward_item_id_3 = reader.ReadInt32();
        reward_item_count_3 = reader.ReadInt32();
        reward_item_id_4 = reader.ReadInt32();
        reward_item_count_4 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string quest_class;

    private int region;

    private string quest_group_icon_path;

    private string quest_group_icon;

    private int quest_group_localize;

    private List<int> list_array_quest_group_list;

    private int stepup_mission_value;

    private string group_open_type;

    private int group_open_value;

    private int reward_item_id_1;

    private int reward_item_count_1;

    private int reward_item_id_2;

    private int reward_item_count_2;

    private int reward_item_id_3;

    private int reward_item_count_3;

    private int reward_item_id_4;

    private int reward_item_count_4;

    private List<int> list_reward_item_id;

    private List<int> list_reward_item_count;
}
