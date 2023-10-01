public class DBEventExchangeBoxRow : ITableRowIndexer
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

    public int ItemGroup
    {
        get
        {
            return item_group;
        }
    }

    public int ItemSpecial
    {
        get
        {
            return item_special;
        }
    }

    public int ItemCount
    {
        get
        {
            return item_count;
        }
    }

    public int ExchangeCount
    {
        get
        {
            return exchange_count;
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

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        item_id = reader.ReadInt32();
        item_group = reader.ReadInt32();
        item_special = reader.ReadInt32();
        item_count = reader.ReadInt32();
        exchange_count = reader.ReadInt32();
        rate = reader.ReadInt32();
        grade = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int item_id;

    private int item_group;

    private int item_special;

    private int item_count;

    private int exchange_count;

    private int rate;

    private int grade;
}
