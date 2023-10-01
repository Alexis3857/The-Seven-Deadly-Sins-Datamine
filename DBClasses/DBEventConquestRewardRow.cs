public class DBEventConquestRewardRow : ITableRowIndexer
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

    public int ProductionIndex
    {
        get
        {
            return production_index;
        }
    }

    public int RewardIndex
    {
        get
        {
            return reward_index;
        }
    }

    public int ConditionLevel
    {
        get
        {
            return condition_level;
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
        production_index = reader.ReadInt32();
        reward_index = reader.ReadInt32();
        condition_level = reader.ReadInt32();
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

    private int production_index;

    private int reward_index;

    private int condition_level;

    private int reward_item_id;

    private int reward_item_count;
}