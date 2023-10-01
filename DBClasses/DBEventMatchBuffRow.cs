public class DBEventMatchBuffRow : ITableRowIndexer
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

    public string BlockIcon
    {
        get
        {
            return block_icon;
        }
    }

    public string BuffType
    {
        get
        {
            return buff_type;
        }
    }

    public int ValueInt1
    {
        get
        {
            return value_int_1;
        }
    }

    public int Rate
    {
        get
        {
            return rate;
        }
    }

    public List<int> ListValueInt
    {
        get
        {
            if (list_value_int == null)
            {
                list_value_int = new List<int>
                {
                    ValueInt1
                };
            }
            return list_value_int;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        block_icon = reader.ReadString();
        buff_type = reader.ReadString();
        value_int_1 = reader.ReadInt32();
        rate = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private string block_icon;

    private string buff_type;

    private int value_int_1;

    private int rate;

    private List<int> list_value_int;
}
