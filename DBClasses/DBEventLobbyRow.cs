public class DBEventLobbyRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EventGroup
    {
        get
        {
            return event_group;
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

    public int LobbyUiIndex
    {
        get
        {
            return lobby_ui_index;
        }
    }

    public int UiGroup
    {
        get
        {
            return ui_group;
        }
    }

    public int UiGroupSubIndex
    {
        get
        {
            return ui_group_sub_index;
        }
    }

    public int ViewIndex
    {
        get
        {
            return view_index;
        }
    }

    public int ButtonStyle
    {
        get
        {
            return button_style;
        }
    }

    public int EventIconIndex
    {
        get
        {
            return event_icon_index;
        }
    }

    public string TitleName
    {
        get
        {
            return title_name.Localize();
        }
    }

    public string ImageName
    {
        get
        {
            return image_name;
        }
    }

    public string Description
    {
        get
        {
            return description.Localize();
        }
    }

    public string CountDescription
    {
        get
        {
            return count_description.Localize();
        }
    }

    public string BannerDescription
    {
        get
        {
            return banner_description.Localize();
        }
    }

    public int CompleteCheck
    {
        get
        {
            return complete_check;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_group = reader.ReadInt32();
        contents_type = reader.ReadString();
        event_type = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        lobby_ui_index = reader.ReadInt32();
        ui_group = reader.ReadInt32();
        ui_group_sub_index = reader.ReadInt32();
        view_index = reader.ReadInt32();
        button_style = reader.ReadInt32();
        event_icon_index = reader.ReadInt32();
        title_name = reader.ReadInt32();
        image_name = reader.ReadString();
        description = reader.ReadInt32();
        count_description = reader.ReadInt32();
        banner_description = reader.ReadInt32();
        complete_check = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_group;

    private string contents_type;

    private int event_type;

    private int event_sub_index;

    private int lobby_ui_index;

    private int ui_group;

    private int ui_group_sub_index;

    private int view_index;

    private int button_style;

    private int event_icon_index;

    private int title_name;

    private string image_name;

    private int description;

    private int count_description;

    private int banner_description;

    private int complete_check;
}
