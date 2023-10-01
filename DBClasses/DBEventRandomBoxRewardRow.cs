public class DBEventRandomBoxRewardRow : ITableRowIndexer
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

    public int BoxType
    {
        get
        {
            return box_type;
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

    public int LimitRewardCount
    {
        get
        {
            return limit_reward_count;
        }
    }

    public int InclusionRate
    {
        get
        {
            return inclusion_rate;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        box_type = reader.ReadInt32();
        reward_item_id = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        limit_reward_count = reader.ReadInt32();
        inclusion_rate = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int box_type;

    private int reward_item_id;

    private int reward_item_count;

    private int limit_reward_count;

    private int inclusion_rate;
}
