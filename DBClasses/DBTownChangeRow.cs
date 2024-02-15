public class DBTownChangeRow : ITableRowIndexer
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

    public string Path
    {
        get
        {
            return path;
        }
    }

    public string MapResource
    {
        get
        {
            return map_resource;
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

    public string TownName
    {
        get
        {
            return town_name.Localize();
        }
    }

    public string TownIcon
    {
        get
        {
            return town_icon;
        }
    }

    public string TownEmblemChange
    {
        get
        {
            return town_emblem_change;
        }
    }

    public string TownMinimapChange
    {
        get
        {
            return town_minimap_change;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        town_id = reader.ReadInt32();
        path = reader.ReadString();
        map_resource = reader.ReadString();
        open_type = reader.ReadString();
        open_value = reader.ReadInt32();
        town_name = reader.ReadInt32();
        town_icon = reader.ReadString();
        town_emblem_change = reader.ReadString();
        town_minimap_change = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int town_id;

    private string path;

    private string map_resource;

    private string open_type;

    private int open_value;

    private int town_name;

    private string town_icon;

    private string town_emblem_change;

    private string town_minimap_change;
}
