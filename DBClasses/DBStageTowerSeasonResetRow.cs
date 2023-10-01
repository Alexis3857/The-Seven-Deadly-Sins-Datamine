public class DBStageTowerSeasonResetRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string InitDay
    {
        get
        {
            return init_day;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        init_day = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string init_day;
}
