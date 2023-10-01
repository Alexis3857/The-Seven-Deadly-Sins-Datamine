public class DBMaterialChangeRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int TownId
    {
        get
        {
            return town_id;
        }
    }

    public string MaterialResource
    {
        get
        {
            return material_resource;
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
        town_id = reader.ReadInt32();
        material_resource = reader.ReadString();
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

    private int town_id;

    private string material_resource;

    private string open_type;

    private int open_value;

    private string close_type;

    private int close_value;
}
