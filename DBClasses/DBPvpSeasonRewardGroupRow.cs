public class DBPvpSeasonRewardGroupRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int RankMin
    {
        get
        {
            return rank_min;
        }
    }

    public int RankMax
    {
        get
        {
            return rank_max;
        }
    }

    public string RankIcon
    {
        get
        {
            return rank_icon;
        }
    }

    public int RewardGroup
    {
        get
        {
            return reward_group;
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
                    RewardId3
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
                    RewardCount3
                };
            }
            return list_reward_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        rank_min = reader.ReadInt32();
        rank_max = reader.ReadInt32();
        rank_icon = reader.ReadString();
        reward_group = reader.ReadInt32();
        reward_id_1 = reader.ReadInt32();
        reward_count_1 = reader.ReadInt32();
        reward_id_2 = reader.ReadInt32();
        reward_count_2 = reader.ReadInt32();
        reward_id_3 = reader.ReadInt32();
        reward_count_3 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int rank_min;

    private int rank_max;

    private string rank_icon;

    private int reward_group;

    private int reward_id_1;

    private int reward_count_1;

    private int reward_id_2;

    private int reward_count_2;

    private int reward_id_3;

    private int reward_count_3;

    private List<int> list_reward_id;

    private List<int> list_reward_count;
}
