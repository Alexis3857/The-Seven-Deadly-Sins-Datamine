public class DBEventAutoBuffRow : ITableRowIndexer
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

    public string BuffType
    {
        get
        {
            return buff_type;
        }
    }

    public int BuffValue
    {
        get
        {
            return buff_value;
        }
    }

    public int BuffCount
    {
        get
        {
            return buff_count;
        }
    }

    public int Rate
    {
        get
        {
            return rate;
        }
    }

    public int BuffEffectId
    {
        get
        {
            return buff_effect_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        buff_type = reader.ReadString();
        buff_value = reader.ReadInt32();
        buff_count = reader.ReadInt32();
        rate = reader.ReadInt32();
        buff_effect_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private string buff_type;

    private int buff_value;

    private int buff_count;

    private int rate;

    private int buff_effect_id;
}
