public class DBLoadingDefaultRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string MapFilename
    {
        get
        {
            return map_filename;
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

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        map_filename = reader.ReadString();
        before_loading_id = reader.ReadInt32();
        after_loading_id = reader.ReadInt32();
        loading_tip_group = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string map_filename;

    private int before_loading_id;

    private int after_loading_id;

    private int loading_tip_group;
}
