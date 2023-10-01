public class DBEventRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string EventName
    {
        get
        {
            return event_name.Localize();
        }
    }

    public string EventDesc
    {
        get
        {
            return event_desc.Localize();
        }
    }

    public List<int> ListArrayEventItem
    {
        get
        {
            return list_array_event_item;
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

    public int EventQuickLink
    {
        get
        {
            return event_quick_link;
        }
    }

    public int RateTypeCheck
    {
        get
        {
            return rate_type_check;
        }
    }

    public int MissionGroup
    {
        get
        {
            return mission_group;
        }
    }

    public int MissionHide
    {
        get
        {
            return mission_hide;
        }
    }

    public List<int> ListArrayExchangeEventGroup
    {
        get
        {
            return list_array_exchange_event_group;
        }
    }

    public int EventChapter
    {
        get
        {
            return event_chapter;
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

    public int WorldBannerOn
    {
        get
        {
            return world_banner_on;
        }
    }

    public string EventIconInfo
    {
        get
        {
            return event_icon_info;
        }
    }

    public string LobbyEventIconName
    {
        get
        {
            return lobby_event_icon_name;
        }
    }

    public int LobbyEventIconSize
    {
        get
        {
            return lobby_event_icon_size;
        }
    }

    public int WorldDirectMove
    {
        get
        {
            return world_direct_move;
        }
    }

    public int StageDirectMove
    {
        get
        {
            return stage_direct_move;
        }
    }

    public string EventFirstTimeMainTitle
    {
        get
        {
            return event_first_time_main_title.Localize();
        }
    }

    public string EventFirstTimeDescTitle
    {
        get
        {
            return event_first_time_desc_title.Localize();
        }
    }

    public string EventFirstTimeDescSub
    {
        get
        {
            return event_first_time_desc_sub.Localize();
        }
    }

    public int EventFirstTimeLink
    {
        get
        {
            return event_first_time_link;
        }
    }

    public int EventFirstTimeLinkId
    {
        get
        {
            return event_first_time_link_id;
        }
    }

    public string EventLargePopupName
    {
        get
        {
            return event_large_popup_name;
        }
    }

    public int EventVideoLinkId
    {
        get
        {
            return event_video_link_id;
        }
    }

    public int EventQuestVideo
    {
        get
        {
            return event_quest_video;
        }
    }

    public string EventUiSlotName
    {
        get
        {
            return event_ui_slot_name;
        }
    }

    public int ContentOpenPopup
    {
        get
        {
            return content_open_popup;
        }
    }

    public string ContentOpenPopupIcon
    {
        get
        {
            return content_open_popup_icon;
        }
    }

    public string ContentOpenPopupLocal
    {
        get
        {
            return content_open_popup_local;
        }
    }

    public int EventLargePopupQuicklink
    {
        get
        {
            return event_large_popup_quicklink;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_name = reader.ReadInt32();
        event_desc = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_event_item = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_event_item.Add(reader.ReadInt32());
        }
        event_type = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        event_quick_link = reader.ReadInt32();
        rate_type_check = reader.ReadInt32();
        mission_group = reader.ReadInt32();
        mission_hide = reader.ReadInt32();
        int num2 = reader.ReadInt32();
        list_array_exchange_event_group = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_exchange_event_group.Add(reader.ReadInt32());
        }
        event_chapter = reader.ReadInt32();
        region = reader.ReadInt32();
        area = reader.ReadInt32();
        world_banner_on = reader.ReadInt32();
        event_icon_info = reader.ReadString();
        lobby_event_icon_name = reader.ReadString();
        lobby_event_icon_size = reader.ReadInt32();
        world_direct_move = reader.ReadInt32();
        stage_direct_move = reader.ReadInt32();
        event_first_time_main_title = reader.ReadInt32();
        event_first_time_desc_title = reader.ReadInt32();
        event_first_time_desc_sub = reader.ReadInt32();
        event_first_time_link = reader.ReadInt32();
        event_first_time_link_id = reader.ReadInt32();
        event_large_popup_name = reader.ReadString();
        event_video_link_id = reader.ReadInt32();
        event_quest_video = reader.ReadInt32();
        event_ui_slot_name = reader.ReadString();
        content_open_popup = reader.ReadInt32();
        content_open_popup_icon = reader.ReadString();
        content_open_popup_local = reader.ReadString();
        event_large_popup_quicklink = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_name;

    private int event_desc;

    private List<int> list_array_event_item;

    private int event_type;

    private int event_sub_index;

    private int event_quick_link;

    private int rate_type_check;

    private int mission_group;

    private int mission_hide;

    private List<int> list_array_exchange_event_group;

    private int event_chapter;

    private int region;

    private int area;

    private int world_banner_on;

    private string event_icon_info;

    private string lobby_event_icon_name;

    private int lobby_event_icon_size;

    private int world_direct_move;

    private int stage_direct_move;

    private int event_first_time_main_title;

    private int event_first_time_desc_title;

    private int event_first_time_desc_sub;

    private int event_first_time_link;

    private int event_first_time_link_id;

    private string event_large_popup_name;

    private int event_video_link_id;

    private int event_quest_video;

    private string event_ui_slot_name;

    private int content_open_popup;

    private string content_open_popup_icon;

    private string content_open_popup_local;

    private int event_large_popup_quicklink;
}
