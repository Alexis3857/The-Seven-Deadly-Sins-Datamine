public class DBShopConsumeRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string ItemIconName
    {
        get
        {
            return item_icon_name;
        }
    }

    public int Category
    {
        get
        {
            return category;
        }
    }

    public int ItemActive
    {
        get
        {
            return item_active;
        }
    }

    public int ShowIndex
    {
        get
        {
            return show_index;
        }
    }

    public string ConsumeType
    {
        get
        {
            return consume_type;
        }
    }

    public int ItemId
    {
        get
        {
            return item_id;
        }
    }

    public int ItemCount
    {
        get
        {
            return item_count;
        }
    }

    public int BonusItemId
    {
        get
        {
            return bonus_item_id;
        }
    }

    public int BonusItemCount
    {
        get
        {
            return bonus_item_count;
        }
    }

    public int PriceItemId
    {
        get
        {
            return price_item_id;
        }
    }

    public int Price
    {
        get
        {
            return price;
        }
    }

    public int EventOn
    {
        get
        {
            return event_on;
        }
    }

    public string GoodsName
    {
        get
        {
            return goods_name.Localize();
        }
    }

    public string GoodsExplain
    {
        get
        {
            return goods_explain.Localize();
        }
    }

    public string GoodsCount
    {
        get
        {
            return goods_count.Localize();
        }
    }

    public int ItemParamIndex
    {
        get
        {
            return item_param_index;
        }
    }

    public string BuyType
    {
        get
        {
            return buy_type;
        }
    }

    public int BuyLimitedCount
    {
        get
        {
            return buy_limited_count;
        }
    }

    public int BonusLimitedCount
    {
        get
        {
            return bonus_limited_count;
        }
    }

    public string BuyStartDate
    {
        get
        {
            return buy_start_date;
        }
    }

    public string BuyEndDate
    {
        get
        {
            return buy_end_date;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        item_icon_name = reader.ReadString();
        category = reader.ReadInt32();
        item_active = reader.ReadInt32();
        show_index = reader.ReadInt32();
        consume_type = reader.ReadString();
        item_id = reader.ReadInt32();
        item_count = reader.ReadInt32();
        bonus_item_id = reader.ReadInt32();
        bonus_item_count = reader.ReadInt32();
        price_item_id = reader.ReadInt32();
        price = reader.ReadInt32();
        event_on = reader.ReadInt32();
        goods_name = reader.ReadInt32();
        goods_explain = reader.ReadInt32();
        goods_count = reader.ReadInt32();
        item_param_index = reader.ReadInt32();
        buy_type = reader.ReadString();
        buy_limited_count = reader.ReadInt32();
        bonus_limited_count = reader.ReadInt32();
        buy_start_date = reader.ReadString();
        buy_end_date = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string item_icon_name;

    private int category;

    private int item_active;

    private int show_index;

    private string consume_type;

    private int item_id;

    private int item_count;

    private int bonus_item_id;

    private int bonus_item_count;

    private int price_item_id;

    private int price;

    private int event_on;

    private int goods_name;

    private int goods_explain;

    private int goods_count;

    private int item_param_index;

    private string buy_type;

    private int buy_limited_count;

    private int bonus_limited_count;

    private string buy_start_date;

    private string buy_end_date;
}
