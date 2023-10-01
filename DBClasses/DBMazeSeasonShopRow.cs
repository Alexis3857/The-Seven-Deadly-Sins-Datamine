public class DBMazeSeasonShopRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ProductSeason
    {
        get
        {
            return product_season;
        }
    }

    public int ProductPage
    {
        get
        {
            return product_page;
        }
    }

    public int ShopGrade
    {
        get
        {
            return shop_grade;
        }
    }

    public int RewardItemId
    {
        get
        {
            return reward_item_id;
        }
    }

    public int RewardItemCount
    {
        get
        {
            return reward_item_count;
        }
    }

    public int ProductType
    {
        get
        {
            return product_type;
        }
    }

    public string ProductTypeName
    {
        get
        {
            return product_type_name.Localize();
        }
    }

    public int PriceId
    {
        get
        {
            return price_id;
        }
    }

    public int PriceCount
    {
        get
        {
            return price_count;
        }
    }

    public int BuyLimitedDailyCount
    {
        get
        {
            return buy_limited_daily_count;
        }
    }

    public int BuyLimitedSeasonCount
    {
        get
        {
            return buy_limited_season_count;
        }
    }

    public int ProductCondition
    {
        get
        {
            return product_condition;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        product_season = reader.ReadInt32();
        product_page = reader.ReadInt32();
        shop_grade = reader.ReadInt32();
        reward_item_id = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        product_type = reader.ReadInt32();
        product_type_name = reader.ReadInt32();
        price_id = reader.ReadInt32();
        price_count = reader.ReadInt32();
        buy_limited_daily_count = reader.ReadInt32();
        buy_limited_season_count = reader.ReadInt32();
        product_condition = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int product_season;

    private int product_page;

    private int shop_grade;

    private int reward_item_id;

    private int reward_item_count;

    private int product_type;

    private int product_type_name;

    private int price_id;

    private int price_count;

    private int buy_limited_daily_count;

    private int buy_limited_season_count;

    private int product_condition;
}