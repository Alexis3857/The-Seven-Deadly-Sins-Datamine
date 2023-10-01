public class DBEventFortuneAttendanceRow : ITableRowIndexer
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

    public string RewardType
    {
        get
        {
            return reward_type;
        }
    }

    public int RewardSubType
    {
        get
        {
            return reward_sub_type;
        }
    }

    public string RewardTitle
    {
        get
        {
            return reward_title.Localize();
        }
    }

    public string RewardSubDesc
    {
        get
        {
            return reward_sub_desc.Localize();
        }
    }

    public int DayRandom
    {
        get
        {
            return day_random;
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
        event_sub_index = reader.ReadInt32();
        reward_type = reader.ReadString();
        reward_sub_type = reader.ReadInt32();
        reward_title = reader.ReadInt32();
        reward_sub_desc = reader.ReadInt32();
        day_random = reader.ReadInt32();
        item_id = reader.ReadInt32();
        item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private string reward_type;

    private int reward_sub_type;

    private int reward_title;

    private int reward_sub_desc;

    private int day_random;

    private int item_id;

    private int item_count;
}
