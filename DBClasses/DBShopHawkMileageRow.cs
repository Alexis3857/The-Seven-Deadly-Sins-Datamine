public class DBShopHawkMileageRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public int ProductCategory
    {
        get
        {
            return product_category;
        }
    }

    public int ProductId
    {
        get
        {
            return product_id;
        }
    }

    public int ProductCount
    {
        get
        {
            return product_count;
        }
    }

    public List<string> ListArrayShowHeroName
    {
        get
        {
            return list_array_show_hero_name;
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

    public int BuyLimitedPeriodCount
    {
        get
        {
            return buy_limited_period_count;
        }
    }

    public int ViewIndex
    {
        get
        {
            return view_index;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        product_category = reader.ReadInt32();
        product_id = reader.ReadInt32();
        product_count = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_show_hero_name = new List<string>();
        for (int i = 0; i < num; i++)
        {
            list_array_show_hero_name.Add(reader.ReadString());
        }
        price_id = reader.ReadInt32();
        price_count = reader.ReadInt32();
        buy_limited_daily_count = reader.ReadInt32();
        buy_limited_period_count = reader.ReadInt32();
        view_index = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int product_category;

    private int product_id;

    private int product_count;

    private List<string> list_array_show_hero_name;

    private int price_id;

    private int price_count;

    private int buy_limited_daily_count;

    private int buy_limited_period_count;

    private int view_index;
}
