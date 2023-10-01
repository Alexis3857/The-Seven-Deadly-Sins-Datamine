public class DBEventBingoGachaRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
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

    public int Rate
    {
        get
        {
            return rate;
        }
    }

    public int Grade
    {
        get
        {
            return grade;
        }
    }

    public int NeedItem
    {
        get
        {
            return need_item;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        item_id = reader.ReadInt32();
        item_count = reader.ReadInt32();
        rate = reader.ReadInt32();
        grade = reader.ReadInt32();
        need_item = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int item_id;

    private int item_count;

    private int rate;

    private int grade;

    private int need_item;
}
