public class DBGuildWarBuffRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string PassiveType
    {
        get
        {
            return passive_type;
        }
    }

    public int PassiveId
    {
        get
        {
            return passive_id;
        }
    }

    public int UseCount
    {
        get
        {
            return use_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        passive_type = reader.ReadString();
        passive_id = reader.ReadInt32();
        use_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string passive_type;

    private int passive_id;

    private int use_count;
}
