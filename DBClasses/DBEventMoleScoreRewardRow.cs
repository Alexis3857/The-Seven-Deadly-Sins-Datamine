public class DBEventMoleScoreRewardRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int RewardOrder
    {
        get
        {
            return reward_order;
        }
    }

    public int RequireScore
    {
        get
        {
            return require_score;
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
        reward_order = reader.ReadInt32();
        require_score = reader.ReadInt32();
        item_id = reader.ReadInt32();
        item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int reward_order;

    private int require_score;

    private int item_id;

    private int item_count;
}
