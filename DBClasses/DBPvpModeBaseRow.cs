public class DBPvpModeBaseRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string ModeType
    {
        get
        {
            return mode_type;
        }
    }

    public int ModeTypeValue
    {
        get
        {
            return mode_type_value;
        }
    }

    public List<int> ListArrayModePassiveId
    {
        get
        {
            return list_array_mode_passive_id;
        }
    }

    public string Name
    {
        get
        {
            return name.Localize();
        }
    }

    public string Explain
    {
        get
        {
            return explain.Localize();
        }
    }

    public string ModeIcon
    {
        get
        {
            return mode_icon;
        }
    }

    public byte FriendlyBattleModeTap
    {
        get
        {
            return friendly_battle_mode_tap;
        }
    }

    public byte FriendlyBattleMode
    {
        get
        {
            return friendly_battle_mode;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        mode_type = reader.ReadString();
        mode_type_value = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_mode_passive_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_mode_passive_id.Add(reader.ReadInt32());
        }
        name = reader.ReadInt32();
        explain = reader.ReadInt32();
        mode_icon = reader.ReadString();
        friendly_battle_mode_tap = reader.ReadByte();
        friendly_battle_mode = reader.ReadByte();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string mode_type;

    private int mode_type_value;

    private List<int> list_array_mode_passive_id;

    private int name;

    private int explain;

    private string mode_icon;

    private byte friendly_battle_mode_tap;

    private byte friendly_battle_mode;
}
