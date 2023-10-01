public class DBStageTowerModePassiveRow : ITableRowIndexer
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

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        mode_type = reader.ReadString();
        mode_type_value = reader.ReadInt32();
        name = reader.ReadInt32();
        explain = reader.ReadInt32();
        mode_icon = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string mode_type;

    private int mode_type_value;

    private int name;

    private int explain;

    private string mode_icon;
}
