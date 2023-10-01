public class DBGuildWarRankRewardRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GuildwarType
    {
        get
        {
            return guildwar_type;
        }
    }

    public int Season
    {
        get
        {
            return season;
        }
    }

    public int LeagueType
    {
        get
        {
            return league_type;
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

    public int WinReward
    {
        get
        {
            return win_reward;
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

    public int CostumeRewardId1
    {
        get
        {
            return costume_reward_id_1;
        }
    }

    public int CostumeRewardId2
    {
        get
        {
            return costume_reward_id_2;
        }
    }

    public int CostumeRewardId3
    {
        get
        {
            return costume_reward_id_3;
        }
    }

    public int CostumeRewardId4
    {
        get
        {
            return costume_reward_id_4;
        }
    }

    public int CostumeRewardId5
    {
        get
        {
            return costume_reward_id_5;
        }
    }

    public int CostumeRewardId6
    {
        get
        {
            return costume_reward_id_6;
        }
    }

    public int CostumeRewardId7
    {
        get
        {
            return costume_reward_id_7;
        }
    }

    public int CostumeRewardId8
    {
        get
        {
            return costume_reward_id_8;
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

    public List<int> ListCostumeRewardId
    {
        get
        {
            if (list_costume_reward_id == null)
            {
                list_costume_reward_id = new List<int>
                {
                    CostumeRewardId1,
                    CostumeRewardId2,
                    CostumeRewardId3,
                    CostumeRewardId4,
                    CostumeRewardId5,
                    CostumeRewardId6,
                    CostumeRewardId7,
                    CostumeRewardId8
                };
            }
            return list_costume_reward_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        guildwar_type = reader.ReadInt32();
        season = reader.ReadInt32();
        league_type = reader.ReadInt32();
        rank_type = reader.ReadString();
        rank_value_min = reader.ReadInt32();
        rank_value_max = reader.ReadInt32();
        rank_percentage_min = reader.ReadInt32();
        rank_percentage_max = reader.ReadInt32();
        win_reward = reader.ReadInt32();
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
        costume_reward_id_1 = reader.ReadInt32();
        costume_reward_id_2 = reader.ReadInt32();
        costume_reward_id_3 = reader.ReadInt32();
        costume_reward_id_4 = reader.ReadInt32();
        costume_reward_id_5 = reader.ReadInt32();
        costume_reward_id_6 = reader.ReadInt32();
        costume_reward_id_7 = reader.ReadInt32();
        costume_reward_id_8 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int guildwar_type;

    private int season;

    private int league_type;

    private string rank_type;

    private int rank_value_min;

    private int rank_value_max;

    private int rank_percentage_min;

    private int rank_percentage_max;

    private int win_reward;

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

    private int costume_reward_id_1;

    private int costume_reward_id_2;

    private int costume_reward_id_3;

    private int costume_reward_id_4;

    private int costume_reward_id_5;

    private int costume_reward_id_6;

    private int costume_reward_id_7;

    private int costume_reward_id_8;

    private List<int> list_reward_id;

    private List<int> list_reward_count;

    private List<int> list_costume_reward_id;
}
