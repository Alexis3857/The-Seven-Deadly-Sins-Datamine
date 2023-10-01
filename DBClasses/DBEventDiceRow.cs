public class DBEventDiceRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EventSubindex
    {
        get
        {
            return event_subindex;
        }
    }

    public int BaseNum
    {
        get
        {
            return base_num;
        }
    }

    public string BaseType
    {
        get
        {
            return base_type;
        }
    }

    public int BaseValue
    {
        get
        {
            return base_value;
        }
    }

    public int RewardCount
    {
        get
        {
            return reward_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_subindex = reader.ReadInt32();
        base_num = reader.ReadInt32();
        base_type = reader.ReadString();
        base_value = reader.ReadInt32();
        reward_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_subindex;

    private int base_num;

    private string base_type;

    private int base_value;

    private int reward_count;
}
