public class DBEventConquestRow : ITableRowIndexer
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

    public int CheckUseRecommendRoute
    {
        get
        {
            return check_use_recommend_route;
        }
    }

    public int CheckCharacter
    {
        get
        {
            return check_character;
        }
    }

    public int CheckFog
    {
        get
        {
            return check_fog;
        }
    }

    public float FogMaskingRate
    {
        get
        {
            return fog_masking_rate;
        }
    }

    public float FogAfterMaskingRate
    {
        get
        {
            return fog_after_masking_rate;
        }
    }

    public float FogMaskingSize
    {
        get
        {
            return fog_masking_size;
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
        check_use_recommend_route = reader.ReadInt32();
        check_character = reader.ReadInt32();
        check_fog = reader.ReadInt32();
        fog_masking_rate = reader.ReadSingle();
        fog_after_masking_rate = reader.ReadSingle();
        fog_masking_size = reader.ReadSingle();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
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

    private int check_use_recommend_route;

    private int check_character;

    private int check_fog;

    private float fog_masking_rate;

    private float fog_after_masking_rate;

    private float fog_masking_size;
}