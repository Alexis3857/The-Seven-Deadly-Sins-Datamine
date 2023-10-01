public class DBEventAltarRewardRow : ITableRowIndexer
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

    public int RewardType
    {
        get
        {
            return reward_type;
        }
    }

    public int RewardNeedItemId
    {
        get
        {
            return reward_need_item_id;
        }
    }

    public int RewardNeedItemCount
    {
        get
        {
            return reward_need_item_count;
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

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        reward_type = reader.ReadInt32();
        reward_need_item_id = reader.ReadInt32();
        reward_need_item_count = reader.ReadInt32();
        reward_item_id = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int reward_type;

    private int reward_need_item_id;

    private int reward_need_item_count;

    private int reward_item_id;

    private int reward_item_count;
}
