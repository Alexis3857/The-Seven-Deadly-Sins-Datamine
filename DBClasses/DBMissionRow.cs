public class DBMissionRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int Category
    {
        get
        {
            return category;
        }
    }

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public int GroupIndex
    {
        get
        {
            return group_index;
        }
    }

    public int ChainId
    {
        get
        {
            return chain_id;
        }
    }

    public int ChainIndex
    {
        get
        {
            return chain_index;
        }
    }

    public string MissionType
    {
        get
        {
            return mission_type;
        }
    }

    public int MissionTypeValue
    {
        get
        {
            return mission_type_value;
        }
    }

    public int MissionTargetValue
    {
        get
        {
            return mission_target_value;
        }
    }

    public int AlarmType
    {
        get
        {
            return alarm_type;
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

    public int RewardAchievepointValue
    {
        get
        {
            return reward_achievepoint_Value;
        }
    }

    public int LocalizeDisplayType
    {
        get
        {
            return localize_display_type;
        }
    }

    public string MissionName
    {
        get
        {
            return mission_name.Localize();
        }
    }

    public int MissionQuickLink
    {
        get
        {
            return mission_quick_link;
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
                    RewardItemId1
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
                    RewardItemCount1
                };
            }
            return list_reward_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        category = reader.ReadInt32();
        group_id = reader.ReadInt32();
        group_index = reader.ReadInt32();
        chain_id = reader.ReadInt32();
        chain_index = reader.ReadInt32();
        mission_type = reader.ReadString();
        mission_type_value = reader.ReadInt32();
        mission_target_value = reader.ReadInt32();
        alarm_type = reader.ReadInt32();
        reward_item_id_1 = reader.ReadInt32();
        reward_item_count_1 = reader.ReadInt32();
        reward_achievepoint_Value = reader.ReadInt32();
        localize_display_type = reader.ReadInt32();
        mission_name = reader.ReadInt32();
        mission_quick_link = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int category;

    private int group_id;

    private int group_index;

    private int chain_id;

    private int chain_index;

    private string mission_type;

    private int mission_type_value;

    private int mission_target_value;

    private int alarm_type;

    private int reward_item_id_1;

    private int reward_item_count_1;

    private int reward_achievepoint_Value;

    private int localize_display_type;

    private int mission_name;

    private int mission_quick_link;

    private List<int> list_reward_item_id;

    private List<int> list_reward_item_count;
}
