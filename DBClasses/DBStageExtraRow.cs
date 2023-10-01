public class DBStageExtraRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public string ExtraType
    {
        get
        {
            return extra_type;
        }
    }

    public int StageLink
    {
        get
        {
            return stage_link;
        }
    }

    public string ControlType
    {
        get
        {
            return control_type;
        }
    }

    public int Region
    {
        get
        {
            return region;
        }
    }

    public int Area
    {
        get
        {
            return area;
        }
    }

    public string ExtraStageName
    {
        get
        {
            return extra_stage_name.Localize();
        }
    }

    public string ExtraIconInfo
    {
        get
        {
            return extra_icon_info;
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

    public int EventBannerLink
    {
        get
        {
            return event_banner_link;
        }
    }

    public string OpenType
    {
        get
        {
            return open_type;
        }
    }

    public int OpenId
    {
        get
        {
            return open_id;
        }
    }

    public string RewardDesc
    {
        get
        {
            return reward_desc.Localize();
        }
    }

    public string RewardImage
    {
        get
        {
            return reward_image;
        }
    }

    public int ContentsQuicklink
    {
        get
        {
            return contents_quicklink;
        }
    }

    public int StageFirstTimeLinkId
    {
        get
        {
            return stage_first_time_link_id;
        }
    }

    public int StartNpc
    {
        get
        {
            return start_npc;
        }
    }

    public int EndNpc
    {
        get
        {
            return end_npc;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        group_id = reader.ReadInt32();
        extra_type = reader.ReadString();
        stage_link = reader.ReadInt32();
        control_type = reader.ReadString();
        region = reader.ReadInt32();
        area = reader.ReadInt32();
        extra_stage_name = reader.ReadInt32();
        extra_icon_info = reader.ReadString();
        large_popup = reader.ReadString();
        event_banner = reader.ReadString();
        event_banner_link = reader.ReadInt32();
        open_type = reader.ReadString();
        open_id = reader.ReadInt32();
        reward_desc = reader.ReadInt32();
        reward_image = reader.ReadString();
        contents_quicklink = reader.ReadInt32();
        stage_first_time_link_id = reader.ReadInt32();
        start_npc = reader.ReadInt32();
        end_npc = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int group_id;

    private string extra_type;

    private int stage_link;

    private string control_type;

    private int region;

    private int area;

    private int extra_stage_name;

    private string extra_icon_info;

    private string large_popup;

    private string event_banner;

    private int event_banner_link;

    private string open_type;

    private int open_id;

    private int reward_desc;

    private string reward_image;

    private int contents_quicklink;

    private int stage_first_time_link_id;

    private int start_npc;

    private int end_npc;
}
