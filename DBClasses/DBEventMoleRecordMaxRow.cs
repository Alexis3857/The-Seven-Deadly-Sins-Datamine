public class DBEventMoleRecordMaxRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int RecordType
    {
        get
        {
            return record_type;
        }
    }

    public int RecordLimit
    {
        get
        {
            return record_limit;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        record_type = reader.ReadInt32();
        record_limit = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int record_type;

    private int record_limit;
}
