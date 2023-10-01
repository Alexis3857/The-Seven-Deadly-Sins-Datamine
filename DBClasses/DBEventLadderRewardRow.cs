public class DBEventLadderRewardRow : ITableRowIndexer
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

    public int MidRewardType
    {
        get
        {
            return mid_reward_type;
        }
    }

    public int MidReward
    {
        get
        {
            return mid_reward;
        }
    }

    public int MidRewardCount
    {
        get
        {
            return mid_reward_count;
        }
    }

    public int TopRewardType
    {
        get
        {
            return top_reward_type;
        }
    }

    public int TopReward
    {
        get
        {
            return top_reward;
        }
    }

    public int TopRewardCount
    {
        get
        {
            return top_reward_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        mid_reward_type = reader.ReadInt32();
        mid_reward = reader.ReadInt32();
        mid_reward_count = reader.ReadInt32();
        top_reward_type = reader.ReadInt32();
        top_reward = reader.ReadInt32();
        top_reward_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int mid_reward_type;

    private int mid_reward;

    private int mid_reward_count;

    private int top_reward_type;

    private int top_reward;

    private int top_reward_count;
}
