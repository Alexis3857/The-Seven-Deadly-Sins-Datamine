public class DBFinalBossSettingRow : ITableRowIndexer
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

    public int GroupActive
    {
        get
        {
            return group_active;
        }
    }

    public string ActiveStart
    {
        get
        {
            return active_start;
        }
    }

    public string ActiveEnd
    {
        get
        {
            return active_end;
        }
    }

    public int SeasonId
    {
        get
        {
            return season_id;
        }
    }

    public int SeasonShopBossItem1
    {
        get
        {
            return season_shop_boss_item_1;
        }
    }

    public int SeasonShopBossItem2
    {
        get
        {
            return season_shop_boss_item_2;
        }
    }

    public int SeasonShopBossItem3
    {
        get
        {
            return season_shop_boss_item_3;
        }
    }

    public int ScoreRewardOn
    {
        get
        {
            return score_reward_on;
        }
    }

    public int ScoreRewardCount
    {
        get
        {
            return score_reward_count;
        }
    }

    public List<int> ListSeasonShopBossItem
    {
        get
        {
            if (list_season_shop_boss_item == null)
            {
                list_season_shop_boss_item = new List<int>
                {
                    SeasonShopBossItem1,
                    SeasonShopBossItem2,
                    SeasonShopBossItem3
                };
            }
            return list_season_shop_boss_item;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        group_id = reader.ReadInt32();
        group_active = reader.ReadInt32();
        active_start = reader.ReadString();
        active_end = reader.ReadString();
        season_id = reader.ReadInt32();
        season_shop_boss_item_1 = reader.ReadInt32();
        season_shop_boss_item_2 = reader.ReadInt32();
        season_shop_boss_item_3 = reader.ReadInt32();
        score_reward_on = reader.ReadInt32();
        score_reward_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int group_id;

    private int group_active;

    private string active_start;

    private string active_end;

    private int season_id;

    private int season_shop_boss_item_1;

    private int season_shop_boss_item_2;

    private int season_shop_boss_item_3;

    private int score_reward_on;

    private int score_reward_count;

    private List<int> list_season_shop_boss_item;
}
