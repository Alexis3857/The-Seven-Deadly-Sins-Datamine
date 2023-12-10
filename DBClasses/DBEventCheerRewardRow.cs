public class DBEventCheerRewardRow : ITableRowIndexer
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

    public int RewardGroup
    {
        get
        {
            return reward_group;
        }
    }

    public int RewardLevel
    {
        get
        {
            return reward_level;
        }
    }

    public int LevelRequirement
    {
        get
        {
            return level_requirement;
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
        event_sub_index = reader.ReadInt32();
        reward_group = reader.ReadInt32();
        reward_level = reader.ReadInt32();
        level_requirement = reader.ReadInt32();
        item_id = reader.ReadInt32();
        item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int reward_group;

    private int reward_level;

    private int level_requirement;

    private int item_id;

    private int item_count;
}
