public class DBGuildBossSeasonRow : ITableRowIndexer
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

    public int SeasonGroup
    {
        get
        {
            return season_group;
        }
    }

    public List<int> ListArrayPlayableGroup
    {
        get
        {
            return list_array_playable_group;
        }
    }

    public string SeasonStart
    {
        get
        {
            return season_start;
        }
    }

    public string EventLargePopupName
    {
        get
        {
            return event_large_popup_name;
        }
    }

    public string EventLargePopupEnd
    {
        get
        {
            return event_large_popup_end;
        }
    }

    public string SeasonTitle
    {
        get
        {
            return season_title.Localize();
        }
    }

    public string SeasonSubtitle
    {
        get
        {
            return season_subtitle.Localize();
        }
    }

    public string MissionTitle
    {
        get
        {
            return mission_title.Localize();
        }
    }

    public int HelpWindow
    {
        get
        {
            return help_window;
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

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        season_id = reader.ReadInt32();
        season_group = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_playable_group = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_playable_group.Add(reader.ReadInt32());
        }
        season_start = reader.ReadString();
        event_large_popup_name = reader.ReadString();
        event_large_popup_end = reader.ReadString();
        season_title = reader.ReadInt32();
        season_subtitle = reader.ReadInt32();
        mission_title = reader.ReadInt32();
        help_window = reader.ReadInt32();
        event_banner = reader.ReadString();
        season_info = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int season_id;

    private int season_group;

    private List<int> list_array_playable_group;

    private string season_start;

    private string event_large_popup_name;

    private string event_large_popup_end;

    private int season_title;

    private int season_subtitle;

    private int mission_title;

    private int help_window;

    private string event_banner;

    private int season_info;
}
