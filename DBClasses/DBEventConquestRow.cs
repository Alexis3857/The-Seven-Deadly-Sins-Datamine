public class DBEventConquestRow
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public string EventTitle
    {
        get
        {
            return event_title.Localize();
        }
    }

    public string EventSubTitle
    {
        get
        {
            return event_sub_title.Localize();
        }
    }

    public string EventDesc
    {
        get
        {
            return event_desc.Localize();
        }
    }

    public string AllyIcon
    {
        get
        {
            return ally_icon;
        }
    }

    public string AllyName
    {
        get
        {
            return ally_name.Localize();
        }
    }

    public int AllyPosition
    {
        get
        {
            return ally_position;
        }
    }

    public int AllyMinionAtk
    {
        get
        {
            return ally_minion_atk;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        event_title = reader.ReadInt32();
        event_sub_title = reader.ReadInt32();
        event_desc = reader.ReadInt32();
        ally_icon = reader.ReadString();
        ally_name = reader.ReadInt32();
        ally_position = reader.ReadInt32();
        ally_minion_atk = reader.ReadInt32();
        return true;
    }

    private int id;

    private int event_sub_index;

    private int event_title;

    private int event_sub_title;

    private int event_desc;

    private string ally_icon;

    private int ally_name;

    private int ally_position;

    private int ally_minion_atk;
}