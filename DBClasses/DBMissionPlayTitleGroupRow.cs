public class DBMissionPlayTitleGroupRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
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

    public int Category
    {
        get
        {
            return category;
        }
    }

    public int Rarity
    {
        get
        {
            return rarity;
        }
    }

    public int Limited
    {
        get
        {
            return limited;
        }
    }

    public int ToolControlCheck
    {
        get
        {
            return tool_control_check;
        }
    }

    public string PassiveType
    {
        get
        {
            return passive_type;
        }
    }

    public List<int> ListArrayPassiveId
    {
        get
        {
            return list_array_passive_id;
        }
    }

    public int HiddenTitle
    {
        get
        {
            return hidden_title;
        }
    }

    public List<float> ListArrayPassiveValue
    {
        get
        {
            return list_array_passive_value;
        }
    }

    public int PlayTitlePoint
    {
        get
        {
            return play_title_point;
        }
    }

    public string PlayTitleIcon
    {
        get
        {
            return play_title_icon;
        }
    }

    public string PlayTitle
    {
        get
        {
            return play_title.Localize();
        }
    }

    public string PlayTitleMissionName
    {
        get
        {
            return play_title_mission_name.Localize();
        }
    }

    public string PlayTitleMissionDesc
    {
        get
        {
            return play_title_mission_desc.Localize();
        }
    }

    public string PlayTitlePassiveDesc
    {
        get
        {
            return play_title_passive_desc.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        active_start = reader.ReadString();
        active_end = reader.ReadString();
        category = reader.ReadInt32();
        rarity = reader.ReadInt32();
        limited = reader.ReadInt32();
        tool_control_check = reader.ReadInt32();
        passive_type = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_passive_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_passive_id.Add(reader.ReadInt32());
        }
        hidden_title = reader.ReadInt32();
        int num2 = reader.ReadInt32();
        list_array_passive_value = new List<float>();
        for (int i = 0; i < num2; i++)
        {
            list_array_passive_value.Add(reader.ReadSingle());
        }
        play_title_point = reader.ReadInt32();
        play_title_icon = reader.ReadString();
        play_title = reader.ReadInt32();
        play_title_mission_name = reader.ReadInt32();
        play_title_mission_desc = reader.ReadInt32();
        play_title_passive_desc = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string active_start;

    private string active_end;

    private int category;

    private int rarity;

    private int limited;

    private int tool_control_check;

    private string passive_type;

    private List<int> list_array_passive_id;

    private int hidden_title;

    private List<float> list_array_passive_value;

    private int play_title_point;

    private string play_title_icon;

    private int play_title;

    private int play_title_mission_name;

    private int play_title_mission_desc;

    private int play_title_passive_desc;
}
