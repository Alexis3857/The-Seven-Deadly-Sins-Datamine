public class DBBasepointShopRow : ITableRowIndexer
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

    public int ProductId
    {
        get
        {
            return product_id;
        }
    }

    public int NeedFellowLevel
    {
        get
        {
            return need_fellow_level;
        }
    }

    public int NeedFellowLevelEvent
    {
        get
        {
            return need_fellow_level_event;
        }
    }

    public int ExposeFellowTab
    {
        get
        {
            return expose_fellow_tab;
        }
    }

    public int ProductCount
    {
        get
        {
            return product_count;
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

    public int BuyLimitedCount
    {
        get
        {
            return buy_limited_count;
        }
    }

    public int BuyLimitedCountEvent
    {
        get
        {
            return buy_limited_count_event;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        basepoint_id = reader.ReadInt32();
        npc_id = reader.ReadInt32();
        product_id = reader.ReadInt32();
        need_fellow_level = reader.ReadInt32();
        need_fellow_level_event = reader.ReadInt32();
        expose_fellow_tab = reader.ReadInt32();
        product_count = reader.ReadInt32();
        price_id = reader.ReadInt32();
        price_count = reader.ReadInt32();
        buy_limited_count = reader.ReadInt32();
        buy_limited_count_event = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int basepoint_id;

    private int npc_id;

    private int product_id;

    private int need_fellow_level;

    private int need_fellow_level_event;

    private int expose_fellow_tab;

    private int product_count;

    private int price_id;

    private int price_count;

    private int buy_limited_count;

    private int buy_limited_count_event;
}
