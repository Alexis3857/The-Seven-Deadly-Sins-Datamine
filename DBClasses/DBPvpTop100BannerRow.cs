public class DBPvpTop100BannerRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string BannerImage
    {
        get
        {
            return banner_image;
        }
    }

    public string BannerTitleLocal
    {
        get
        {
            return banner_title_local.Localize();
        }
    }

    public string BannerDescLocal
    {
        get
        {
            return banner_desc_local.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        banner_image = reader.ReadString();
        banner_title_local = reader.ReadInt32();
        banner_desc_local = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string banner_image;

    private int banner_title_local;

    private int banner_desc_local;
}
