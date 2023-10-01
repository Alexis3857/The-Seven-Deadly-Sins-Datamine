public class DBCardpackPackageInfoRow : ITableRowIndexer
{
    public int CardpackGroupId
    {
        get
        {
            return cardpack_group_id;
        }
    }

    public string PackageImage
    {
        get
        {
            return package_image;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        cardpack_group_id = reader.ReadInt32();
        package_image = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return CardpackGroupId;
    }

    private int cardpack_group_id;

    private string package_image;
}
