public class DBEventDiceRewardRow : ITableRowIndexer
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

    public int ClearCount
    {
        get
        {
            return clear_count;
        }
    }

    public int RewardItem
    {
        get
        {
            return reward_item;
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
        clear_count = reader.ReadInt32();
        reward_item = reader.ReadInt32();
        reward_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_subindex;

    private int clear_count;

    private int reward_item;

    private int reward_count;
}
