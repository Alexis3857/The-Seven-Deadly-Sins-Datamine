public class DBGuildRankRewardRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
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

    public List<int> ListRewardId
    {
        get
        {
            if (list_reward_id == null)
            {
                list_reward_id = new List<int>
                {
                    RewardId1,
                    RewardId2
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
                    RewardCount2
                };
            }
            return list_reward_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        rank_type = reader.ReadString();
        rank_value_min = reader.ReadInt32();
        rank_value_max = reader.ReadInt32();
        rank_percentage_min = reader.ReadInt32();
        rank_percentage_max = reader.ReadInt32();
        reward_id_1 = reader.ReadInt32();
        reward_count_1 = reader.ReadInt32();
        reward_id_2 = reader.ReadInt32();
        reward_count_2 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string rank_type;

    private int rank_value_min;

    private int rank_value_max;

    private int rank_percentage_min;

    private int rank_percentage_max;

    private int reward_id_1;

    private int reward_count_1;

    private int reward_id_2;

    private int reward_count_2;

    private List<int> list_reward_id;

    private List<int> list_reward_count;
}
