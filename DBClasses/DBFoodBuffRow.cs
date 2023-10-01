public class DBFoodBuffRow : ITableRowIndexer
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

    public int UseTimeMin
    {
        get
        {
            return use_time_min;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        passive_type = reader.ReadString();
        passive_id = reader.ReadInt32();
        use_count = reader.ReadInt32();
        use_time_min = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
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

    private int use_time_min;

    private int event_sub_index;
}
