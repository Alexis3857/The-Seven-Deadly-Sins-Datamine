public class DBCostumeShopGroupRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string MenuType
    {
        get
        {
            return menu_type;
        }
    }

    public string MenuTitle
    {
        get
        {
            return menu_title.Localize();
        }
    }

    public string ScrollType
    {
        get
        {
            return scroll_type;
        }
    }

    public int ShopType
    {
        get
        {
            return shop_type;
        }
    }

    public string BannerImage
    {
        get
        {
            return banner_image;
        }
    }

    public int CostumeStoryId
    {
        get
        {
            return costume_story_id;
        }
    }

    public int CostumeResale
    {
        get
        {
            return costume_resale;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        menu_type = reader.ReadString();
        menu_title = reader.ReadInt32();
        scroll_type = reader.ReadString();
        shop_type = reader.ReadInt32();
        banner_image = reader.ReadString();
        costume_story_id = reader.ReadInt32();
        costume_resale = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string menu_type;

    private int menu_title;

    private string scroll_type;

    private int shop_type;

    private string banner_image;

    private int costume_story_id;

    private int costume_resale;
}
