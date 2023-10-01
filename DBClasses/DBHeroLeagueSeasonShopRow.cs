public class DBHeroLeagueSeasonShopRow : ITableRowIndexer
{
    public int Index
    {
        get
        {
            return index;
        }
    }

    public int ShopTargetSeason
    {
        get
        {
            return shop_target_season;
        }
    }

    public int Reward
    {
        get
        {
            return reward;
        }
    }

    public int RewardCount
    {
        get
        {
            return reward_count;
        }
    }

    public int ExchangeCount
    {
        get
        {
            return exchange_count;
        }
    }

    public int Material
    {
        get
        {
            return material;
        }
    }

    public int MaterialCount
    {
        get
        {
            return material_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        index = reader.ReadInt32();
        shop_target_season = reader.ReadInt32();
        reward = reader.ReadInt32();
        reward_count = reader.ReadInt32();
        exchange_count = reader.ReadInt32();
        material = reader.ReadInt32();
        material_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Index;
    }

    private int index;

    private int shop_target_season;

    private int reward;

    private int reward_count;

    private int exchange_count;

    private int material;

    private int material_count;
}