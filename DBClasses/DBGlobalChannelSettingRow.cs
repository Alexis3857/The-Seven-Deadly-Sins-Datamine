public class DBGlobalChannelSettingRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string LangSystem
    {
        get
        {
            return lang_system;
        }
    }

    public string LangCode
    {
        get
        {
            return lang_code;
        }
    }

    public int ChMin
    {
        get
        {
            return ch_min;
        }
    }

    public int ChMax
    {
        get
        {
            return ch_max;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        lang_system = reader.ReadString();
        lang_code = reader.ReadString();
        ch_min = reader.ReadInt32();
        ch_max = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string lang_system;

    private string lang_code;

    private int ch_min;

    private int ch_max;
}
