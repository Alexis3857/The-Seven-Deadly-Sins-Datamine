public class DBStageMazeSeasonRewardRow : ITableRowIndexer
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

    public int RewardIndex
    {
        get
        {
            return reward_index;
        }
    }

    public int SpotGroupId
    {
        get
        {
            return spot_group_id;
        }
    }

    public int SpotGroupRewardId
    {
        get
        {
            return spot_group_reward_id;
        }
    }

    public int SpotGroupRewardValue
    {
        get
        {
            return spot_group_reward_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        season_id = reader.ReadInt32();
        reward_index = reader.ReadInt32();
        spot_group_id = reader.ReadInt32();
        spot_group_reward_id = reader.ReadInt32();
        spot_group_reward_value = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int season_id;

    private int reward_index;

    private int spot_group_id;

    private int spot_group_reward_id;

    private int spot_group_reward_value;
}
