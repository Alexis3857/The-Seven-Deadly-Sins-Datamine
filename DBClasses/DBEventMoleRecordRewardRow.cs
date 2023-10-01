public class DBEventMoleRecordRewardRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int RecordType
    {
        get
        {
            return record_type;
        }
    }

    public int RewardOrder
    {
        get
        {
            return reward_order;
        }
    }

    public int RequireValue
    {
        get
        {
            return require_value;
        }
    }

    public int ActiveValue
    {
        get
        {
            return active_value;
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
        record_type = reader.ReadInt32();
        reward_order = reader.ReadInt32();
        require_value = reader.ReadInt32();
        active_value = reader.ReadInt32();
        item_id = reader.ReadInt32();
        item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int record_type;

    private int reward_order;

    private int require_value;

    private int active_value;

    private int item_id;

    private int item_count;
}
