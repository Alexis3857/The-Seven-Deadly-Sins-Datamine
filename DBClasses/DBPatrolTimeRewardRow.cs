public class DBPatrolTimeRewardRow : ITableRowIndexer
{
    public int Index
    {
        get
        {
            return index;
        }
    }

    public int RewardOpenQuestId
    {
        get
        {
            return reward_open_quest_id;
        }
    }

    public int NeedRewardTime
    {
        get
        {
            return need_reward_time;
        }
    }

    public int GroupRotationId
    {
        get
        {
            return group_rotation_id;
        }
    }

    public int RewardItemId1
    {
        get
        {
            return reward_item_id_1;
        }
    }

    public int RewardItemValue1
    {
        get
        {
            return reward_item_value_1;
        }
    }

    public int RewardItemId2
    {
        get
        {
            return reward_item_id_2;
        }
    }

    public int RewardItemValue2
    {
        get
        {
            return reward_item_value_2;
        }
    }

    public int RewardItemId3
    {
        get
        {
            return reward_item_id_3;
        }
    }

    public int RewardItemValue3
    {
        get
        {
            return reward_item_value_3;
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
                    RewardItemId3
                };
            }
            return list_reward_item_id;
        }
    }

    public List<int> ListRewardItemValue
    {
        get
        {
            if (list_reward_item_value == null)
            {
                list_reward_item_value = new List<int>
                {
                    RewardItemValue1,
                    RewardItemValue2,
                    RewardItemValue3
                };
            }
            return list_reward_item_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        index = reader.ReadInt32();
        reward_open_quest_id = reader.ReadInt32();
        need_reward_time = reader.ReadInt32();
        group_rotation_id = reader.ReadInt32();
        reward_item_id_1 = reader.ReadInt32();
        reward_item_value_1 = reader.ReadInt32();
        reward_item_id_2 = reader.ReadInt32();
        reward_item_value_2 = reader.ReadInt32();
        reward_item_id_3 = reader.ReadInt32();
        reward_item_value_3 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Index;
    }

    private int index;

    private int reward_open_quest_id;

    private int need_reward_time;

    private int group_rotation_id;

    private int reward_item_id_1;

    private int reward_item_value_1;

    private int reward_item_id_2;

    private int reward_item_value_2;

    private int reward_item_id_3;

    private int reward_item_value_3;

    private List<int> list_reward_item_id;

    private List<int> list_reward_item_value;
}
