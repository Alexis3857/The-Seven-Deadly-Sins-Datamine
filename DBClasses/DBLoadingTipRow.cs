public class DBLoadingTipRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string LoadingTipLocalize
    {
        get
        {
            return loading_tip_localize.Localize();
        }
    }

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public string OpenType
    {
        get
        {
            return open_type;
        }
    }

    public int OpenValue
    {
        get
        {
            return open_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        loading_tip_localize = reader.ReadInt32();
        group_id = reader.ReadInt32();
        open_type = reader.ReadString();
        open_value = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int loading_tip_localize;

    private int group_id;

    private string open_type;

    private int open_value;
}
