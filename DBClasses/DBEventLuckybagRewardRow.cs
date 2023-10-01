public class DBEventLuckybagRewardRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int LuckybagGroup
    {
        get
        {
            return luckybag_group;
        }
    }

    public int RewardIndex
    {
        get
        {
            return reward_index;
        }
    }

    public int LuckybagRewardRate
    {
        get
        {
            return luckybag_reward_rate;
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

    public int RewardItemId6
    {
        get
        {
            return reward_item_id_6;
        }
    }

    public int RewardItemCount6
    {
        get
        {
            return reward_item_count_6;
        }
    }

    public int RewardItemId7
    {
        get
        {
            return reward_item_id_7;
        }
    }

    public int RewardItemCount7
    {
        get
        {
            return reward_item_count_7;
        }
    }

    public int RewardItemId8
    {
        get
        {
            return reward_item_id_8;
        }
    }

    public int RewardItemCount8
    {
        get
        {
            return reward_item_count_8;
        }
    }

    public int RewardItemId9
    {
        get
        {
            return reward_item_id_9;
        }
    }

    public int RewardItemCount9
    {
        get
        {
            return reward_item_count_9;
        }
    }

    public int RewardItemId10
    {
        get
        {
            return reward_item_id_10;
        }
    }

    public int RewardItemCount10
    {
        get
        {
            return reward_item_count_10;
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
                    RewardItemId5,
                    RewardItemId6,
                    RewardItemId7,
                    RewardItemId8,
                    RewardItemId9,
                    RewardItemId10
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
                    RewardItemCount4,
                    RewardItemCount5,
                    RewardItemCount6,
                    RewardItemCount7,
                    RewardItemCount8,
                    RewardItemCount9,
                    RewardItemCount10
                };
            }
            return list_reward_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        luckybag_group = reader.ReadInt32();
        reward_index = reader.ReadInt32();
        luckybag_reward_rate = reader.ReadInt32();
        reward_item_id_1 = reader.ReadInt32();
        reward_item_count_1 = reader.ReadInt32();
        reward_item_id_2 = reader.ReadInt32();
        reward_item_count_2 = reader.ReadInt32();
        reward_item_id_3 = reader.ReadInt32();
        reward_item_count_3 = reader.ReadInt32();
        reward_item_id_4 = reader.ReadInt32();
        reward_item_count_4 = reader.ReadInt32();
        reward_item_id_5 = reader.ReadInt32();
        reward_item_count_5 = reader.ReadInt32();
        reward_item_id_6 = reader.ReadInt32();
        reward_item_count_6 = reader.ReadInt32();
        reward_item_id_7 = reader.ReadInt32();
        reward_item_count_7 = reader.ReadInt32();
        reward_item_id_8 = reader.ReadInt32();
        reward_item_count_8 = reader.ReadInt32();
        reward_item_id_9 = reader.ReadInt32();
        reward_item_count_9 = reader.ReadInt32();
        reward_item_id_10 = reader.ReadInt32();
        reward_item_count_10 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }


    private int id;

    private int luckybag_group;

    private int reward_index;

    private int luckybag_reward_rate;

    private int reward_item_id_1;

    private int reward_item_count_1;

    private int reward_item_id_2;

    private int reward_item_count_2;

    private int reward_item_id_3;

    private int reward_item_count_3;

    private int reward_item_id_4;

    private int reward_item_count_4;

    private int reward_item_id_5;

    private int reward_item_count_5;

    private int reward_item_id_6;

    private int reward_item_count_6;

    private int reward_item_id_7;

    private int reward_item_count_7;

    private int reward_item_id_8;

    private int reward_item_count_8;

    private int reward_item_id_9;

    private int reward_item_count_9;

    private int reward_item_id_10;

    private int reward_item_count_10;

    private List<int> list_reward_item_id;

    private List<int> list_reward_item_count;
}
