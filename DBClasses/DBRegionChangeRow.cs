public class DBRegionChangeRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int RegionId
    {
        get
        {
            return region_id;
        }
    }

    public string RegionResource
    {
        get
        {
            return region_resource;
        }
    }

    public string Path
    {
        get
        {
            return path;
        }
    }

    public string ChangeRegionPrefab
    {
        get
        {
            return change_region_prefab;
        }
    }

    public string OpenType
    {
        get
        {
            return open_type;
        }
    }

    public int OpenValue
    {
        get
        {
            return open_value;
        }
    }

    public string CloseType
    {
        get
        {
            return close_type;
        }
    }

    public int CloseValue
    {
        get
        {
            return close_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        region_id = reader.ReadInt32();
        region_resource = reader.ReadString();
        path = reader.ReadString();
        change_region_prefab = reader.ReadString();
        open_type = reader.ReadString();
        open_value = reader.ReadInt32();
        close_type = reader.ReadString();
        close_value = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int region_id;

    private string region_resource;

    private string path;

    private string change_region_prefab;

    private string open_type;

    private int open_value;

    private string close_type;

    private int close_value;
}
