public class DBBasepointRandomShopRow : ITableRowIndexer
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

    public int ItemId
    {
        get
        {
            return item_id;
        }
    }

    public string SlotType
    {
        get
        {
            return slot_type;
        }
    }

    public int ItemPerRate
    {
        get
        {
            return item_per_rate;
        }
    }

    public int ShopCostGoldPer
    {
        get
        {
            return shop_cost_gold_per;
        }
    }

    public int ShopCostDiaPer
    {
        get
        {
            return shop_cost_dia_per;
        }
    }

    public int ShopCostGold
    {
        get
        {
            return shop_cost_gold;
        }
    }

    public int ShopCostDia
    {
        get
        {
            return shop_cost_dia;
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

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        basepoint_id = reader.ReadInt32();
        item_id = reader.ReadInt32();
        slot_type = reader.ReadString();
        item_per_rate = reader.ReadInt32();
        shop_cost_gold_per = reader.ReadInt32();
        shop_cost_dia_per = reader.ReadInt32();
        shop_cost_gold = reader.ReadInt32();
        shop_cost_dia = reader.ReadInt32();
        product_count = reader.ReadInt32();
        buy_limited_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int basepoint_id;

    private int item_id;

    private string slot_type;

    private int item_per_rate;

    private int shop_cost_gold_per;

    private int shop_cost_dia_per;

    private int shop_cost_gold;

    private int shop_cost_dia;

    private int product_count;

    private int buy_limited_count;
}
