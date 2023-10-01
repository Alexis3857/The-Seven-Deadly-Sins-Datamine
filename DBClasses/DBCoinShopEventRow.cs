public class DBCoinShopEventRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ProductCategory
    {
        get
        {
            return product_category;
        }
    }

    public int ProductSale
    {
        get
        {
            return product_sale;
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

    public int ProductFreeCount
    {
        get
        {
            return product_free_count;
        }
    }

    public string PriceCoinItemType
    {
        get
        {
            return price_coin_item_type;
        }
    }

    public int PriceCoinType
    {
        get
        {
            return price_coin_type;
        }
    }

    public int PriceCount
    {
        get
        {
            return price_count;
        }
    }

    public int SkinDiscount
    {
        get
        {
            return skin_discount;
        }
    }

    public int BuyLimitedCount
    {
        get
        {
            return buy_limited_count;
        }
    }

    public int AdInfo
    {
        get
        {
            return ad_info;
        }
    }

    public int PriceCoinItemSubType
    {
        get
        {
            return price_coin_item_sub_type;
        }
    }

    public int PeriodBuyLimitedCount
    {
        get
        {
            return period_buy_limited_count;
        }
    }

    public string BuyLimitedStart
    {
        get
        {
            return buy_limited_start;
        }
    }

    public string BuyLimitedEnd
    {
        get
        {
            return buy_limited_end;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        product_category = reader.ReadInt32();
        product_sale = reader.ReadInt32();
        product_id = reader.ReadInt32();
        product_count = reader.ReadInt32();
        product_free_count = reader.ReadInt32();
        price_coin_item_type = reader.ReadString();
        price_coin_type = reader.ReadInt32();
        price_count = reader.ReadInt32();
        skin_discount = reader.ReadInt32();
        buy_limited_count = reader.ReadInt32();
        ad_info = reader.ReadInt32();
        price_coin_item_sub_type = reader.ReadInt32();
        period_buy_limited_count = reader.ReadInt32();
        buy_limited_start = reader.ReadString();
        buy_limited_end = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int product_category;

    private int product_sale;

    private int product_id;

    private int product_count;

    private int product_free_count;

    private string price_coin_item_type;

    private int price_coin_type;

    private int price_count;

    private int skin_discount;

    private int buy_limited_count;

    private int ad_info;

    private int price_coin_item_sub_type;

    private int period_buy_limited_count;

    private string buy_limited_start;

    private string buy_limited_end;
}
