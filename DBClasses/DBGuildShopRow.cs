public class DBGuildShopRow : ITableRowIndexer
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

    public int UsableGuildLevel
    {
        get
        {
            return usable_guild_level;
        }
    }

    public int ShopItemId
    {
        get
        {
            return shop_item_id;
        }
    }

    public int ShopPriceId
    {
        get
        {
            return shop_price_id;
        }
    }

    public int ProductCount
    {
        get
        {
            return product_count;
        }
    }

    public int BuyLimitCount
    {
        get
        {
            return buy_limit_count;
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

    public int PopularItemCheck
    {
        get
        {
            return popular_item_check;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        basepoint_id = reader.ReadInt32();
        npc_id = reader.ReadInt32();
        usable_guild_level = reader.ReadInt32();
        shop_item_id = reader.ReadInt32();
        shop_price_id = reader.ReadInt32();
        product_count = reader.ReadInt32();
        buy_limit_count = reader.ReadInt32();
        price_id = reader.ReadInt32();
        price_count = reader.ReadInt32();
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

    private int usable_guild_level;

    private int shop_item_id;

    private int shop_price_id;

    private int product_count;

    private int buy_limit_count;

    private int price_id;

    private int price_count;

    private int popular_item_check;
}
