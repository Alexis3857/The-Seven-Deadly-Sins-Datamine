public class DBPvpRewardRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int LeagueType
    {
        get
        {
            return league_type;
        }
    }

    public int RankType
    {
        get
        {
            return rank_type;
        }
    }

    public int RankNum
    {
        get
        {
            return rank_num;
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

    public int RewardSeasonPoint
    {
        get
        {
            return reward_season_point;
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
        league_type = reader.ReadInt32();
        rank_type = reader.ReadInt32();
        rank_num = reader.ReadInt32();
        rank_min = reader.ReadInt32();
        rank_max = reader.ReadInt32();
        reward_id_1 = reader.ReadInt32();
        reward_count_1 = reader.ReadInt32();
        reward_id_2 = reader.ReadInt32();
        reward_count_2 = reader.ReadInt32();
        reward_season_point = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int league_type;

    private int rank_type;

    private int rank_num;

    private int rank_min;

    private int rank_max;

    private int reward_id_1;

    private int reward_count_1;

    private int reward_id_2;

    private int reward_count_2;

    private int reward_season_point;

    private List<int> list_reward_id;

    private List<int> list_reward_count;
}
