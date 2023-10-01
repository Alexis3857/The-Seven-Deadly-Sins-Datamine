public class DBGuildWarLowAreaRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string AreaName
    {
        get
        {
            return area_name.Localize();
        }
    }

    public string AreaIcon
    {
        get
        {
            return area_icon;
        }
    }

    public string AreaDestroyIcon
    {
        get
        {
            return area_destroy_icon;
        }
    }

    public List<int> ListArrayAreaPassiveConnect
    {
        get
        {
            return list_array_area_passive_connect;
        }
    }

    public string AreaPassiveType
    {
        get
        {
            return area_passive_type;
        }
    }

    public int AreaPassiveId
    {
        get
        {
            return area_passive_id;
        }
    }

    public string ConnectAreaPassiveType
    {
        get
        {
            return connect_area_passive_type;
        }
    }

    public int ConnectAreaPassiveId
    {
        get
        {
            return connect_area_passive_id;
        }
    }

    public string GuildWarAreaBgPath
    {
        get
        {
            return guild_war_area_bg_path;
        }
    }

    public string GuildWarAreaBg
    {
        get
        {
            return guild_war_area_bg;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        area_name = reader.ReadInt32();
        area_icon = reader.ReadString();
        area_destroy_icon = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_area_passive_connect = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_area_passive_connect.Add(reader.ReadInt32());
        }
        area_passive_type = reader.ReadString();
        area_passive_id = reader.ReadInt32();
        connect_area_passive_type = reader.ReadString();
        connect_area_passive_id = reader.ReadInt32();
        guild_war_area_bg_path = reader.ReadString();
        guild_war_area_bg = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int area_name;

    private string area_icon;

    private string area_destroy_icon;

    private List<int> list_array_area_passive_connect;

    private string area_passive_type;

    private int area_passive_id;

    private string connect_area_passive_type;

    private int connect_area_passive_id;

    private string guild_war_area_bg_path;

    private string guild_war_area_bg;
}
