public class DBEventMissionScoreRow : ITableRowIndexer
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

    public int RewardOrder
    {
        get
        {
            return reward_order;
        }
    }

    public int EventPointId
    {
        get
        {
            return event_point_id;
        }
    }

    public int RewardNeedCount
    {
        get
        {
            return reward_need_count;
        }
    }

    public int RewardItemId
    {
        get
        {
            return reward_item_id;
        }
    }

    public int LastRewardCheck
    {
        get
        {
            return last_reward_check;
        }
    }

    public int RewardItemCount
    {
        get
        {
            return reward_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        reward_order = reader.ReadInt32();
        event_point_id = reader.ReadInt32();
        reward_need_count = reader.ReadInt32();
        reward_item_id = reader.ReadInt32();
        last_reward_check = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int reward_order;

    private int event_point_id;

    private int reward_need_count;

    private int reward_item_id;

    private int last_reward_check;

    private int reward_item_count;
}
