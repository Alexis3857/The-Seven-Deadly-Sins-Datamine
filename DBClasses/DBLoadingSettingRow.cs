public class DBLoadingSettingRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string ContentsType
    {
        get
        {
            return contents_type;
        }
    }

    public string Type
    {
        get
        {
            return type;
        }
    }

    public int StageID
    {
        get
        {
            return stage_ID;
        }
    }

    public int BeforeLoadingId
    {
        get
        {
            return before_loading_id;
        }
    }

    public int AfterLoadingId
    {
        get
        {
            return after_loading_id;
        }
    }

    public int LoadingTipGroup
    {
        get
        {
            return loading_tip_group;
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
        contents_type = reader.ReadString();
        type = reader.ReadString();
        stage_ID = reader.ReadInt32();
        before_loading_id = reader.ReadInt32();
        after_loading_id = reader.ReadInt32();
        loading_tip_group = reader.ReadInt32();
        open_type = reader.ReadString();
        open_value = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string contents_type;

    private string type;

    private int stage_ID;

    private int before_loading_id;

    private int after_loading_id;

    private int loading_tip_group;

    private string open_type;

    private int open_value;
}
