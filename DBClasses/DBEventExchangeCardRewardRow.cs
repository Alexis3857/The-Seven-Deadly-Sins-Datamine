public class DBEventExchangeCardRewardRow : ITableRowIndexer
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

    public int ItemGroup
    {
        get
        {
            return item_group;
        }
    }

    public int RewardGrade
    {
        get
        {
            return reward_grade;
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

    public List<int> ListArrayJackpotOrder
    {
        get
        {
            return list_array_jackpot_order;
        }
    }

    public int JackpotValue
    {
        get
        {
            return jackpot_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        item_group = reader.ReadInt32();
        reward_grade = reader.ReadInt32();
        item_id = reader.ReadInt32();
        item_count = reader.ReadInt32();
        rate = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_jackpot_order = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_jackpot_order.Add(reader.ReadInt32());
        }
        jackpot_value = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int item_group;

    private int reward_grade;

    private int item_id;

    private int item_count;

    private int rate;

    private List<int> list_array_jackpot_order;

    private int jackpot_value;
}
