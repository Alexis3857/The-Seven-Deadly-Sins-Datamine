public class DBStageReverseGroupRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int SeasonId
    {
        get
        {
            return season_id;
        }
    }

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public string ReverseAreaName
    {
        get
        {
            return reverse_area_name.Localize();
        }
    }

    public string MapResourcePath
    {
        get
        {
            return map_resource_path;
        }
    }

    public string MapResource
    {
        get
        {
            return map_resource;
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
        season_id = reader.ReadInt32();
        group_id = reader.ReadInt32();
        reverse_area_name = reader.ReadInt32();
        map_resource_path = reader.ReadString();
        map_resource = reader.ReadString();
        open_value = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int season_id;

    private int group_id;

    private int reverse_area_name;

    private string map_resource_path;

    private string map_resource;

    private int open_value;
}
