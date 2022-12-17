public class DBEventGambleboxDisplayRow
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GambleboxGroup
    {
        get
        {
            return gamblebox_group;
        }
    }

    public int GambleboxCount1
    {
        get
        {
            return gamblebox_count_1;
        }
    }

    public int GambleboxCostId1
    {
        get
        {
            return gamblebox_cost_id_1;
        }
    }

    public int GambleboxCostValue1
    {
        get
        {
            return gamblebox_cost_value_1;
        }
    }

    public int GambleboxCount2
    {
        get
        {
            return gamblebox_count_2;
        }
    }

    public int GambleboxCostId2
    {
        get
        {
            return gamblebox_cost_id_2;
        }
    }

    public int GambleboxCostValue2
    {
        get
        {
            return gamblebox_cost_value_2;
        }
    }

    public string GambleBoxMBannerName
    {
        get
        {
            return gamblebox_m_banner_name;
        }
    }

    public string GambleBoxTheme
    {
        get
        {
            return gamblebox_theme.Localize();
        }
    }
    public int GambleboxTitle
    {
        get
        {
            return gamblebox_title;
        }
    }

    public string GambleboxHawkobject
    {
        get
        {
            return gamblebox_hawkobject;
        }
    }

    public int GambleBackground
    {
        get
        {
            return gamblebox_background;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        gamblebox_group = reader.ReadInt32();
        gamblebox_count_1 = reader.ReadInt32();
        gamblebox_cost_id_1 = reader.ReadInt32();
        gamblebox_cost_value_1 = reader.ReadInt32();
        gamblebox_count_2 = reader.ReadInt32();
        gamblebox_cost_id_2 = reader.ReadInt32();
        gamblebox_cost_value_2 = reader.ReadInt32();
        gamblebox_m_banner_name = reader.ReadString();
        gamblebox_theme = reader.ReadInt32();
        gamblebox_title = reader.ReadInt32();
        gamblebox_hawkobject = reader.ReadString();
        gamblebox_background = reader.ReadInt32();
        return true;
    }

    private int id;

    private int gamblebox_group;

    private int gamblebox_count_1;

    private int gamblebox_cost_id_1;

    private int gamblebox_cost_value_1;

    private int gamblebox_count_2;

    private int gamblebox_cost_id_2;

    private int gamblebox_cost_value_2;

    private string gamblebox_m_banner_name;

    private int gamblebox_theme;

    private int gamblebox_title;

    private string gamblebox_hawkobject;

    private int gamblebox_background;
}