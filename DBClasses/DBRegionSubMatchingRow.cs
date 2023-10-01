public class DBRegionSubMatchingRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int Region
    {
        get
        {
            return region;
        }
    }

    public int MatchingRegionSub
    {
        get
        {
            return matching_region_sub;
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

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        region = reader.ReadInt32();
        matching_region_sub = reader.ReadInt32();
        open_type = reader.ReadString();
        open_value = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int region;

    private int matching_region_sub;

    private string open_type;

    private int open_value;
}
