public class DBEventGrowthRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ExposurePriority
    {
        get
        {
            return exposure_priority;
        }
    }

    public string TitleName
    {
        get
        {
            return title_name.Localize();
        }
    }

    public string ContentsType
    {
        get
        {
            return contents_type;
        }
    }

    public int EventType
    {
        get
        {
            return event_type;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public string StartTime
    {
        get
        {
            return start_time;
        }
    }

    public string EndTime
    {
        get
        {
            return end_time;
        }
    }

    public string ImageName
    {
        get
        {
            return image_name;
        }
    }

    public int ContentLink
    {
        get
        {
            return content_link;
        }
    }

    public int FocusGuide
    {
        get
        {
            return focus_guide;
        }
    }

    public int TimeExposure
    {
        get
        {
            return time_exposure;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        exposure_priority = reader.ReadInt32();
        title_name = reader.ReadInt32();
        contents_type = reader.ReadString();
        event_type = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        start_time = reader.ReadString();
        end_time = reader.ReadString();
        image_name = reader.ReadString();
        content_link = reader.ReadInt32();
        focus_guide = reader.ReadInt32();
        time_exposure = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int exposure_priority;

    private int title_name;

    private string contents_type;

    private int event_type;

    private int event_sub_index;

    private string start_time;

    private string end_time;

    private string image_name;

    private int content_link;

    private int focus_guide;

    private int time_exposure;
}
