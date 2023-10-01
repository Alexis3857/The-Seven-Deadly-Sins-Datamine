public class DBGuildBossHellRewardRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int SeasonId
    {
        get
        {
            return season_id;
        }
    }

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public int SeasonGroup
    {
        get
        {
            return season_group;
        }
    }

    public int RewardOrder
    {
        get
        {
            return reward_order;
        }
    }

    public int TargetValue
    {
        get
        {
            return target_value;
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
        season_id = reader.ReadInt32();
        group_id = reader.ReadInt32();
        season_group = reader.ReadInt32();
        reward_order = reader.ReadInt32();
        target_value = reader.ReadInt32();
        reward_item_id = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int season_id;

    private int group_id;

    private int season_group;

    private int reward_order;

    private int target_value;

    private int reward_item_id;

    private int reward_item_count;
}
