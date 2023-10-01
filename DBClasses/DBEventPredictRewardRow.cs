public class DBEventPredictRewardRow : ITableRowIndexer
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

    public int RewardGrade
    {
        get
        {
            return reward_grade;
        }
    }

    public int RewardOrder
    {
        get
        {
            return reward_order;
        }
    }

    public int RewardItemId
    {
        get
        {
            return reward_item_id;
        }
    }

    public int RewardItemCount
    {
        get
        {
            return reward_item_count;
        }
    }

    public int Rate
    {
        get
        {
            return rate;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        reward_grade = reader.ReadInt32();
        reward_order = reader.ReadInt32();
        reward_item_id = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        rate = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int reward_grade;

    private int reward_order;

    private int reward_item_id;

    private int reward_item_count;

    private int rate;
}
