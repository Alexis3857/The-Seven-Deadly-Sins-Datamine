public class DBStageReverseSeasonRewardRow : ITableRowIndexer
{
    public int SeasonId
    {
        get
        {
            return season_id;
        }
    }

    public string ReverseSeasonName
    {
        get
        {
            return reverse_season_name.Localize();
        }
    }

    public int StarRewardCount1
    {
        get
        {
            return star_reward_count_1;
        }
    }

    public int StarRewardId1
    {
        get
        {
            return star_reward_id_1;
        }
    }

    public int StarRewardValue1
    {
        get
        {
            return star_reward_value_1;
        }
    }

    public int StarRewardCount2
    {
        get
        {
            return star_reward_count_2;
        }
    }

    public int StarRewardId2
    {
        get
        {
            return star_reward_id_2;
        }
    }

    public int StarRewardValue2
    {
        get
        {
            return star_reward_value_2;
        }
    }

    public int StarRewardCount3
    {
        get
        {
            return star_reward_count_3;
        }
    }

    public int StarRewardId3
    {
        get
        {
            return star_reward_id_3;
        }
    }

    public int StarRewardValue3
    {
        get
        {
            return star_reward_value_3;
        }
    }

    public int StarRewardCount4
    {
        get
        {
            return star_reward_count_4;
        }
    }

    public int StarRewardId4
    {
        get
        {
            return star_reward_id_4;
        }
    }

    public int StarRewardValue4
    {
        get
        {
            return star_reward_value_4;
        }
    }

    public int StarRewardCount5
    {
        get
        {
            return star_reward_count_5;
        }
    }

    public int StarRewardId5
    {
        get
        {
            return star_reward_id_5;
        }
    }

    public int StarRewardValue5
    {
        get
        {
            return star_reward_value_5;
        }
    }

    public int StarRewardCount6
    {
        get
        {
            return star_reward_count_6;
        }
    }

    public int StarRewardId6
    {
        get
        {
            return star_reward_id_6;
        }
    }

    public int StarRewardValue6
    {
        get
        {
            return star_reward_value_6;
        }
    }

    public List<int> ListStarRewardCount
    {
        get
        {
            if (list_star_reward_count == null)
            {
                list_star_reward_count = new List<int>
                {
                    StarRewardCount1,
                    StarRewardCount2,
                    StarRewardCount3,
                    StarRewardCount4,
                    StarRewardCount5,
                    StarRewardCount6
                };
            }
            return list_star_reward_count;
        }
    }

    public List<int> ListStarRewardId
    {
        get
        {
            if (list_star_reward_id == null)
            {
                list_star_reward_id = new List<int>
                {
                    StarRewardId1,
                    StarRewardId2,
                    StarRewardId3,
                    StarRewardId4,
                    StarRewardId5,
                    StarRewardId6
                };
            }
            return list_star_reward_id;
        }
    }

    public List<int> ListStarRewardValue
    {
        get
        {
            if (list_star_reward_value == null)
            {
                list_star_reward_value = new List<int>
                {
                    StarRewardValue1,
                    StarRewardValue2,
                    StarRewardValue3,
                    StarRewardValue4,
                    StarRewardValue5,
                    StarRewardValue6
                };
            }
            return list_star_reward_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        season_id = reader.ReadInt32();
        reverse_season_name = reader.ReadInt32();
        star_reward_count_1 = reader.ReadInt32();
        star_reward_id_1 = reader.ReadInt32();
        star_reward_value_1 = reader.ReadInt32();
        star_reward_count_2 = reader.ReadInt32();
        star_reward_id_2 = reader.ReadInt32();
        star_reward_value_2 = reader.ReadInt32();
        star_reward_count_3 = reader.ReadInt32();
        star_reward_id_3 = reader.ReadInt32();
        star_reward_value_3 = reader.ReadInt32();
        star_reward_count_4 = reader.ReadInt32();
        star_reward_id_4 = reader.ReadInt32();
        star_reward_value_4 = reader.ReadInt32();
        star_reward_count_5 = reader.ReadInt32();
        star_reward_id_5 = reader.ReadInt32();
        star_reward_value_5 = reader.ReadInt32();
        star_reward_count_6 = reader.ReadInt32();
        star_reward_id_6 = reader.ReadInt32();
        star_reward_value_6 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return SeasonId;
    }

    private int season_id;

    private int reverse_season_name;

    private int star_reward_count_1;

    private int star_reward_id_1;

    private int star_reward_value_1;

    private int star_reward_count_2;

    private int star_reward_id_2;

    private int star_reward_value_2;

    private int star_reward_count_3;

    private int star_reward_id_3;

    private int star_reward_value_3;

    private int star_reward_count_4;

    private int star_reward_id_4;

    private int star_reward_value_4;

    private int star_reward_count_5;

    private int star_reward_id_5;

    private int star_reward_value_5;

    private int star_reward_count_6;

    private int star_reward_id_6;

    private int star_reward_value_6;

    private List<int> list_star_reward_count;

    private List<int> list_star_reward_id;

    private List<int> list_star_reward_value;
}
