public class DBShopMoneyRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string Type
    {
        get
        {
            return type;
        }
    }

    public string ShopType
    {
        get
        {
            return shop_type;
        }
    }

    public int ShopDiaActive
    {
        get
        {
            return shop_dia_active;
        }
    }

    public int BuyCondition
    {
        get
        {
            return buy_condition;
        }
    }

    public string ItemIconName
    {
        get
        {
            return item_icon_name;
        }
    }

    public string ShopEventIcon
    {
        get
        {
            return shop_event_icon;
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

    public int BonusCount
    {
        get
        {
            return bonus_count;
        }
    }

    public int EventItemId
    {
        get
        {
            return event_item_id;
        }
    }

    public int EventItemCount
    {
        get
        {
            return event_item_count;
        }
    }

    public int EventBuyCount
    {
        get
        {
            return event_buy_count;
        }
    }

    public int SaleProductGroup
    {
        get
        {
            return sale_product_group;
        }
    }

    public int BonusEventGroup
    {
        get
        {
            return bonus_event_group;
        }
    }

    public int DoubleEventGroup
    {
        get
        {
            return double_event_group;
        }
    }

    public int ServerGroup
    {
        get
        {
            return server_group;
        }
    }

    public string Pricetype
    {
        get
        {
            return pricetype;
        }
    }

    public int PriceKrw
    {
        get
        {
            return price_krw;
        }
    }

    public int PriceJpy
    {
        get
        {
            return price_jpy;
        }
    }

    public float PriceUsd
    {
        get
        {
            return price_usd;
        }
    }

    public string NetmarbleItemId
    {
        get
        {
            return netmarble_item_id;
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

    public string Icon
    {
        get
        {
            return icon;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        type = reader.ReadString();
        shop_type = reader.ReadString();
        shop_dia_active = reader.ReadInt32();
        buy_condition = reader.ReadInt32();
        item_icon_name = reader.ReadString();
        shop_event_icon = reader.ReadString();
        item_id = reader.ReadInt32();
        item_count = reader.ReadInt32();
        bonus_item_id = reader.ReadInt32();
        bonus_count = reader.ReadInt32();
        event_item_id = reader.ReadInt32();
        event_item_count = reader.ReadInt32();
        event_buy_count = reader.ReadInt32();
        sale_product_group = reader.ReadInt32();
        bonus_event_group = reader.ReadInt32();
        double_event_group = reader.ReadInt32();
        server_group = reader.ReadInt32();
        pricetype = reader.ReadString();
        price_krw = reader.ReadInt32();
        price_jpy = reader.ReadInt32();
        price_usd = reader.ReadSingle();
        netmarble_item_id = reader.ReadString();
        goods_name = reader.ReadInt32();
        goods_explain = reader.ReadInt32();
        icon = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string type;

    private string shop_type;

    private int shop_dia_active;

    private int buy_condition;

    private string item_icon_name;

    private string shop_event_icon;

    private int item_id;

    private int item_count;

    private int bonus_item_id;

    private int bonus_count;

    private int event_item_id;

    private int event_item_count;

    private int event_buy_count;

    private int sale_product_group;

    private int bonus_event_group;

    private int double_event_group;

    private int server_group;

    private string pricetype;

    private int price_krw;

    private int price_jpy;

    private float price_usd;

    private string netmarble_item_id;

    private int goods_name;

    private int goods_explain;

    private string icon;
}
