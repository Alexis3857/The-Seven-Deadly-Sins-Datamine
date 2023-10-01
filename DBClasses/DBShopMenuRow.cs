public class DBShopMenuRow : ITableRowIndexer
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

    public string ShopTitle
    {
        get
        {
            return shop_title.Localize();
        }
    }

    public string ShopDesc
    {
        get
        {
            return shop_desc.Localize();
        }
    }

    public List<int> ListArrayEventKey
    {
        get
        {
            return list_array_event_key;
        }
    }

    public string ShopBannerName
    {
        get
        {
            return shop_banner_name;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        shop_type = reader.ReadString();
        shop_title = reader.ReadInt32();
        shop_desc = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_event_key = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_event_key.Add(reader.ReadInt32());
        }
        shop_banner_name = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string shop_type;

    private int shop_title;

    private int shop_desc;

    private List<int> list_array_event_key;

    private string shop_banner_name;
}
