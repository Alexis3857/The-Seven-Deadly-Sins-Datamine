public class DBStageAncientRewardRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public string RewardType
    {
        get
        {
            return reward_type;
        }
    }

    public int Point
    {
        get
        {
            return point;
        }
    }

    public int RewardOrder
    {
        get
        {
            return reward_order;
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

    public int RewardId2
    {
        get
        {
            return reward_id_2;
        }
    }

    public int RewardCount2
    {
        get
        {
            return reward_count_2;
        }
    }

    public int RewardId3
    {
        get
        {
            return reward_id_3;
        }
    }

    public int RewardCount3
    {
        get
        {
            return reward_count_3;
        }
    }

    public int RewardId4
    {
        get
        {
            return reward_id_4;
        }
    }

    public int RewardCount4
    {
        get
        {
            return reward_count_4;
        }
    }

    public int RewardId5
    {
        get
        {
            return reward_id_5;
        }
    }

    public int RewardCount5
    {
        get
        {
            return reward_count_5;
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
                    RewardId1,
                    RewardId2,
                    RewardId3,
                    RewardId4,
                    RewardId5
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
                    RewardCount1,
                    RewardCount2,
                    RewardCount3,
                    RewardCount4,
                    RewardCount5
                };
            }
            return list_reward_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        group_id = reader.ReadInt32();
        reward_type = reader.ReadString();
        point = reader.ReadInt32();
        reward_order = reader.ReadInt32();
        reward_id_1 = reader.ReadInt32();
        reward_count_1 = reader.ReadInt32();
        reward_id_2 = reader.ReadInt32();
        reward_count_2 = reader.ReadInt32();
        reward_id_3 = reader.ReadInt32();
        reward_count_3 = reader.ReadInt32();
        reward_id_4 = reader.ReadInt32();
        reward_count_4 = reader.ReadInt32();
        reward_id_5 = reader.ReadInt32();
        reward_count_5 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int group_id;

    private string reward_type;

    private int point;

    private int reward_order;

    private int reward_id_1;

    private int reward_count_1;

    private int reward_id_2;

    private int reward_count_2;

    private int reward_id_3;

    private int reward_count_3;

    private int reward_id_4;

    private int reward_count_4;

    private int reward_id_5;

    private int reward_count_5;

    private List<int> list_reward_id;

    private List<int> list_reward_count;
}
