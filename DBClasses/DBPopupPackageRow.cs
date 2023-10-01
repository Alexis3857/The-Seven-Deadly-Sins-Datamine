public class DBPopupPackageRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int LinkProductId
    {
        get
        {
            return link_product_id;
        }
    }

    public string Type
    {
        get
        {
            return type;
        }
    }

    public string PopupTiming
    {
        get
        {
            return popup_timing;
        }
    }

    public string PopupIcon
    {
        get
        {
            return popup_icon;
        }
    }

    public string PopupImageUrl
    {
        get
        {
            return popup_image_url;
        }
    }

    public string PopupImageName
    {
        get
        {
            return popup_image_name.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        link_product_id = reader.ReadInt32();
        type = reader.ReadString();
        popup_timing = reader.ReadString();
        popup_icon = reader.ReadString();
        popup_image_url = reader.ReadString();
        popup_image_name = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int link_product_id;

    private string type;

    private string popup_timing;

    private string popup_icon;

    private string popup_image_url;

    private int popup_image_name;
}
