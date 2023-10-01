public class DBFinalBossSeasonRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string SeasonType
    {
        get
        {
            return season_type;
        }
    }

    public int HallOfFameDataId
    {
        get
        {
            return hall_of_fame_data_id;
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

    public string SeasonTitle
    {
        get
        {
            return season_title.Localize();
        }
    }

    public string SeasonIcon
    {
        get
        {
            return season_icon;
        }
    }

    public string SeasonShopEnd
    {
        get
        {
            return season_shop_end;
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

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        season_type = reader.ReadString();
        hall_of_fame_data_id = reader.ReadInt32();
        season_start = reader.ReadString();
        season_end = reader.ReadString();
        season_title = reader.ReadInt32();
        season_icon = reader.ReadString();
        season_shop_end = reader.ReadString();
        large_popup = reader.ReadString();
        event_banner = reader.ReadString();
        season_info = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string season_type;

    private int hall_of_fame_data_id;

    private string season_start;

    private string season_end;

    private int season_title;

    private string season_icon;

    private string season_shop_end;

    private string large_popup;

    private string event_banner;

    private int season_info;
}
