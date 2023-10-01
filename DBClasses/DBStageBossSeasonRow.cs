public class DBStageBossSeasonRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string SeasonStart
    {
        get
        {
            return season_start;
        }
    }

    public string SeasonEnd
    {
        get
        {
            return season_end;
        }
    }

    public int ActiveDay
    {
        get
        {
            return active_day;
        }
    }

    public int InactiveDay
    {
        get
        {
            return inactive_day;
        }
    }

    public string SeasonTitle
    {
        get
        {
            return season_title.Localize();
        }
    }

    public string LargePopup
    {
        get
        {
            return large_popup;
        }
    }

    public string EventBanner
    {
        get
        {
            return event_banner;
        }
    }

    public string SeasonInfo
    {
        get
        {
            return season_info.Localize();
        }
    }

    public int DisasterGroupCutin
    {
        get
        {
            return disaster_group_cutin;
        }
    }

    public List<int> ListArrayExchangeEventGroup
    {
        get
        {
            return list_array_exchange_event_group;
        }
    }

    public string LobbyDisasterIconName
    {
        get
        {
            return lobby_disaster_icon_name;
        }
    }

    public string ControlType
    {
        get
        {
            return control_type;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        season_start = reader.ReadString();
        season_end = reader.ReadString();
        active_day = reader.ReadInt32();
        inactive_day = reader.ReadInt32();
        season_title = reader.ReadInt32();
        large_popup = reader.ReadString();
        event_banner = reader.ReadString();
        season_info = reader.ReadInt32();
        disaster_group_cutin = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_exchange_event_group = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_exchange_event_group.Add(reader.ReadInt32());
        }
        lobby_disaster_icon_name = reader.ReadString();
        control_type = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string season_start;

    private string season_end;

    private int active_day;

    private int inactive_day;

    private int season_title;

    private string large_popup;

    private string event_banner;

    private int season_info;

    private int disaster_group_cutin;

    private List<int> list_array_exchange_event_group;

    private string lobby_disaster_icon_name;

    private string control_type;
}
