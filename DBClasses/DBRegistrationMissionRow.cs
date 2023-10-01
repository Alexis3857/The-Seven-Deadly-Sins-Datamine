public class DBRegistrationMissionRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string Os
    {
        get
        {
            return os;
        }
    }

    public int ItemId
    {
        get
        {
            return item_id;
        }
    }

    public int ItemCount
    {
        get
        {
            return item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        os = reader.ReadString();
        item_id = reader.ReadInt32();
        item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string os;

    private int item_id;

    private int item_count;
}
