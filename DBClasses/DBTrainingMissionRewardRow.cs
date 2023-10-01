public class DBTrainingMissionRewardRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int Difficulty
    {
        get
        {
            return difficulty;
        }
    }

    public int MissionClearValue
    {
        get
        {
            return mission_clear_value;
        }
    }

    public int FirstClearValue
    {
        get
        {
            return first_clear_value;
        }
    }

    public int MissionRewardBox
    {
        get
        {
            return mission_reward_box;
        }
    }

    public int RewardItemId
    {
        get
        {
            return reward_item_id;
        }
    }

    public int RewardValue
    {
        get
        {
            return reward_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        difficulty = reader.ReadInt32();
        mission_clear_value = reader.ReadInt32();
        first_clear_value = reader.ReadInt32();
        mission_reward_box = reader.ReadInt32();
        reward_item_id = reader.ReadInt32();
        reward_value = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int difficulty;

    private int mission_clear_value;

    private int first_clear_value;

    private int mission_reward_box;

    private int reward_item_id;

    private int reward_value;
}
