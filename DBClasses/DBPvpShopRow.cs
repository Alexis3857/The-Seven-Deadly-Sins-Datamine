public class DBPvpShopRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int BasepointId
    {
        get
        {
            return basepoint_id;
        }
    }

    public int NpcId
    {
        get
        {
            return npc_id;
        }
    }

    public int LeagueType
    {
        get
        {
            return league_type;
        }
    }

    public int TabIndex
    {
        get
        {
            return tab_index;
        }
    }

    public int NeedPvpGrade
    {
        get
        {
            return need_pvp_grade;
        }
    }

    public int SellType
    {
        get
        {
            return sell_type;
        }
    }

    public int ShopItemId
    {
        get
        {
            return shop_item_id;
        }
    }

    public int ProductCount
    {
        get
        {
            return product_count;
        }
    }

    public int BuyLimitedCount
    {
        get
        {
            return buy_limited_count;
        }
    }

    public int PriceId1
    {
        get
        {
            return price_id_1;
        }
    }

    public int PriceCount1
    {
        get
        {
            return price_count_1;
        }
    }

    public int PopularItemCheck
    {
        get
        {
            return popular_item_check;
        }
    }

    public List<int> ListPriceId
    {
        get
        {
            if (list_price_id == null)
            {
                list_price_id = new List<int>
                {
                    PriceId1
                };
            }
            return list_price_id;
        }
    }

    public List<int> ListPriceCount
    {
        get
        {
            if (list_price_count == null)
            {
                list_price_count = new List<int>
                {
                    PriceCount1
                };
            }
            return list_price_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        basepoint_id = reader.ReadInt32();
        npc_id = reader.ReadInt32();
        league_type = reader.ReadInt32();
        tab_index = reader.ReadInt32();
        need_pvp_grade = reader.ReadInt32();
        sell_type = reader.ReadInt32();
        shop_item_id = reader.ReadInt32();
        product_count = reader.ReadInt32();
        buy_limited_count = reader.ReadInt32();
        price_id_1 = reader.ReadInt32();
        price_count_1 = reader.ReadInt32();
        popular_item_check = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int basepoint_id;

    private int npc_id;

    private int league_type;

    private int tab_index;

    private int need_pvp_grade;

    private int sell_type;

    private int shop_item_id;

    private int product_count;

    private int buy_limited_count;

    private int price_id_1;

    private int price_count_1;

    private int popular_item_check;

    private List<int> list_price_id;

    private List<int> list_price_count;
}
