public class DBStageCreaturenestGaugeRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int Type
    {
        get
        {
            return type;
        }
    }

    public string Name
    {
        get
        {
            return name.Localize();
        }
    }

    public string Icon
    {
        get
        {
            return icon;
        }
    }

    public List<int> ListArrayAllyPassive
    {
        get
        {
            return list_array_ally_passive;
        }
    }

    public List<int> ListArrayEnnemyPassive
    {
        get
        {
            return list_array_enemy_passive;
        }
    }

    public string Desc
    {
        get
        {
            return desc.Localize();
        }
    }

    public int GaugeMax
    {
        get
        {
            return gauge_max;
        }
    }

    public int GaugeStart
    {
        get
        {
            return gauge_start;
        }
    }

    public List<int> ListArrayGaugeVal
    {
        get
        {
            return list_array_gauge_val;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        type = reader.ReadInt32();
        name = reader.ReadInt32();
        icon = reader.ReadString();
        list_array_ally_passive = new List<int>();
        int num = reader.ReadInt32();
        for (int i = 0; i < num; i++)
        {
            list_array_ally_passive.Add(reader.ReadInt32());
        }
        list_array_enemy_passive = new List<int>();
        int num2 = reader.ReadInt32();
        for (int i = 0; i < num2; i++)
        {
            list_array_enemy_passive.Add(reader.ReadInt32());
        }
        desc = reader.ReadInt32();
        gauge_max = reader.ReadInt32();
        gauge_start = reader.ReadInt32();
        list_array_gauge_val = new List<int>();
        int num3 = reader.ReadInt32();
        for (int i = 0; i < num3; i++)
        {
            list_array_gauge_val.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int type;

    private int name;

    private string icon;

    private List<int> list_array_ally_passive;

    private List<int> list_array_enemy_passive;

    private int desc;

    private int gauge_max;

    private int gauge_start;

    private List<int> list_array_gauge_val;
}