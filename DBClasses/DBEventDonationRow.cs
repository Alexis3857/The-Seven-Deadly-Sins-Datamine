public class DBEventDonationRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int BasepointId
    {
        get
        {
            return basepoint_id;
        }
    }

    public int RewardCondition1
    {
        get
        {
            return reward_condition_1;
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

    public int RewardCondition2
    {
        get
        {
            return reward_condition_2;
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

    public int RewardCondition3
    {
        get
        {
            return reward_condition_3;
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

    public int RewardCondition4
    {
        get
        {
            return reward_condition_4;
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

    public int RewardCondition5
    {
        get
        {
            return reward_condition_5;
        }
    }

    public int RewardItemId5
    {
        get
        {
            return reward_item_id_5;
        }
    }

    public int RewardItemCount5
    {
        get
        {
            return reward_item_count_5;
        }
    }

    public List<int> ListRewardCondition
    {
        get
        {
            if (list_reward_condition == null)
            {
                list_reward_condition = new List<int>
                {
                    RewardCondition1,
                    RewardCondition2,
                    RewardCondition3,
                    RewardCondition4,
                    RewardCondition5
                };
            }
            return list_reward_condition;
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
                    RewardItemId4,
                    RewardItemId5
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
                    RewardItemCount3
                };
            }
            return list_reward_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        basepoint_id = reader.ReadInt32();
        reward_condition_1 = reader.ReadInt32();
        reward_item_id_1 = reader.ReadInt32();
        reward_item_count_1 = reader.ReadInt32();
        reward_condition_2 = reader.ReadInt32();
        reward_item_id_2 = reader.ReadInt32();
        reward_item_count_2 = reader.ReadInt32();
        reward_condition_3 = reader.ReadInt32();
        reward_item_id_3 = reader.ReadInt32();
        reward_item_count_3 = reader.ReadInt32();
        reward_condition_4 = reader.ReadInt32();
        reward_item_id_4 = reader.ReadInt32();
        reward_item_count_4 = reader.ReadInt32();
        reward_condition_5 = reader.ReadInt32();
        reward_item_id_5 = reader.ReadInt32();
        reward_item_count_5 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int basepoint_id;

    private int reward_condition_1;

    private int reward_item_id_1;

    private int reward_item_count_1;

    private int reward_condition_2;

    private int reward_item_id_2;

    private int reward_item_count_2;

    private int reward_condition_3;

    private int reward_item_id_3;

    private int reward_item_count_3;

    private int reward_condition_4;

    private int reward_item_id_4;

    private int reward_item_count_4;

    private int reward_condition_5;

    private int reward_item_id_5;

    private int reward_item_count_5;

    private List<int> list_reward_condition;

    private List<int> list_reward_item_id;

    private List<int> list_reward_item_count;
}
