public class DBLobbyHousingShopRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string ShopType
    {
        get
        {
            return shop_type;
        }
    }

    public int ProductId
    {
        get
        {
            return product_id;
        }
    }

    public int EventCheck
    {
        get
        {
            return event_check;
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

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        shop_type = reader.ReadString();
        product_id = reader.ReadInt32();
        event_check = reader.ReadInt32();
        price_id = reader.ReadInt32();
        price_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string shop_type;

    private int product_id;

    private int event_check;

    private int price_id;

    private int price_count;
}
