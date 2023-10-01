public class DBStageSubdueBossGroupRow : ITableRowIndexer
{
    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public string ActiveStart
    {
        get
        {
            return active_start;
        }
    }

    public string ActiveEnd
    {
        get
        {
            return active_end;
        }
    }

    public int PlayCountResetTime
    {
        get
        {
            return play_count_reset_time;
        }
    }

    public int PlayCount
    {
        get
        {
            return play_count;
        }
    }

    public string GroupString
    {
        get
        {
            return group_string.Localize();
        }
    }

    public string StageString
    {
        get
        {
            return stage_string.Localize();
        }
    }

    public string GroupBgResource
    {
        get
        {
            return group_bg_resource;
        }
    }

    public string LobbyBgResourcePath
    {
        get
        {
            return lobby_bg_resource_path;
        }
    }

    public string LobbyBgResource
    {
        get
        {
            return lobby_bg_resource;
        }
    }

    public int BannerPriority
    {
        get
        {
            return banner_priority;
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

    public string BannerInfo
    {
        get
        {
            return banner_info.Localize();
        }
    }

    public int SubdueGroupCutin
    {
        get
        {
            return subdue_group_cutin;
        }
    }

    public int SubdueMainLobbyButton
    {
        get
        {
            return subdue_main_lobby_button;
        }
    }

    public string LobbySubdueIconName
    {
        get
        {
            return lobby_subdue_icon_name;
        }
    }

    public List<int> ListArrayExchangeEventGroup
    {
        get
        {
            return list_array_exchange_event_group;
        }
    }

    public string InfoImageBg
    {
        get
        {
            return info_image_bg;
        }
    }

    public string InviteText
    {
        get
        {
            return invite_text.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        group_id = reader.ReadInt32();
        active_start = reader.ReadString();
        active_end = reader.ReadString();
        play_count_reset_time = reader.ReadInt32();
        play_count = reader.ReadInt32();
        group_string = reader.ReadInt32();
        stage_string = reader.ReadInt32();
        group_bg_resource = reader.ReadString();
        lobby_bg_resource_path = reader.ReadString();
        lobby_bg_resource = reader.ReadString();
        banner_priority = reader.ReadInt32();
        large_popup = reader.ReadString();
        event_banner = reader.ReadString();
        banner_info = reader.ReadInt32();
        subdue_group_cutin = reader.ReadInt32();
        subdue_main_lobby_button = reader.ReadInt32();
        lobby_subdue_icon_name = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_exchange_event_group = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_exchange_event_group.Add(reader.ReadInt32());
        }
        info_image_bg = reader.ReadString();
        invite_text = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return GroupId;
    }

    private int group_id;

    private string active_start;

    private string active_end;

    private int play_count_reset_time;

    private int play_count;

    private int group_string;

    private int stage_string;

    private string group_bg_resource;

    private string lobby_bg_resource_path;

    private string lobby_bg_resource;

    private int banner_priority;

    private string large_popup;

    private string event_banner;

    private int banner_info;

    private int subdue_group_cutin;

    private int subdue_main_lobby_button;

    private string lobby_subdue_icon_name;

    private List<int> list_array_exchange_event_group;

    private string info_image_bg;

    private int invite_text;
}
