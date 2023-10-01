public class DBStageAncientRankRewardRow : ITableRowIndexer
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

    public string RankType
    {
        get
        {
            return rank_type;
        }
    }

    public int RankValueMin
    {
        get
        {
            return rank_value_min;
        }
    }

    public int RankValueMax
    {
        get
        {
            return rank_value_max;
        }
    }

    public int RankPercentageMin
    {
        get
        {
            return rank_percentage_min;
        }
    }

    public int RankPercentageMax
    {
        get
        {
            return rank_percentage_max;
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
        rank_type = reader.ReadString();
        rank_value_min = reader.ReadInt32();
        rank_value_max = reader.ReadInt32();
        rank_percentage_min = reader.ReadInt32();
        rank_percentage_max = reader.ReadInt32();
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

    private string rank_type;

    private int rank_value_min;

    private int rank_value_max;

    private int rank_percentage_min;

    private int rank_percentage_max;

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
