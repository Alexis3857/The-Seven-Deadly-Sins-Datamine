public class DBShopHubRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string LinkShopName
    {
        get
        {
            return Link_shop_name.Localize();
        }
    }

    public string LinkShop
    {
        get
        {
            return link_shop;
        }
    }

    public string ContentMenu
    {
        get
        {
            return Content_menu;
        }
    }

    public string ShopButtonImage
    {
        get
        {
            return shop_button_image;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        Link_shop_name = reader.ReadInt32();
        link_shop = reader.ReadString();
        Content_menu = reader.ReadString();
        shop_button_image = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int Link_shop_name;

    private string link_shop;

    private string Content_menu;

    private string shop_button_image;
}
