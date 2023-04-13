public class DBGuildorderMissionRow
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string MissionType
    {
        get
        {
            return mission_type;
        }
    }

    public string MissionName
    {
        get
        {
            return mission_name.Localize();
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

    public int RewardIap
    {
        get
        {
            return reward_iap;
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

    public List<int> ListRewardItemId
    {
        get
        {
            if (list_reward_item_id == null)
            {
                list_reward_item_id = new List<int>
                {
                    RewardItemId1,
                    RewardItemId2
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
                    RewardItemCount2
                };
            }
            return list_reward_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        mission_type = reader.ReadString();
        mission_name = reader.ReadInt32();
        mission_type_value = reader.ReadInt32();
        mission_target_value = reader.ReadInt32();
        reward_iap = reader.ReadInt32();
        reward_item_id_1 = reader.ReadInt32();
        reward_item_count_1 = reader.ReadInt32();
        reward_item_id_2 = reader.ReadInt32();
        reward_item_count_2 = reader.ReadInt32();
        return true;
    }

    private int id;

    private string mission_type;

    private int mission_name;

    private int mission_type_value;

    private int mission_target_value;

    private int reward_iap;

    private int reward_item_id_1;

    private int reward_item_count_1;

    private int reward_item_id_2;

    private int reward_item_count_2;

    private List<int> list_reward_item_id;

    private List<int> list_reward_item_count;
}