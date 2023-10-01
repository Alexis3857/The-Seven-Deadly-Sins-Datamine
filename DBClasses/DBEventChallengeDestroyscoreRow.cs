public class DBEventChallengeDestroyscoreRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ChallengeDestroyId
    {
        get
        {
            return challenge_destroy_id;
        }
    }

    public int RewardNeedCount
    {
        get
        {
            return reward_need_count;
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
        challenge_destroy_id = reader.ReadInt32();
        reward_need_count = reader.ReadInt32();
        reward_item_id = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int challenge_destroy_id;

    private int reward_need_count;

    private int reward_item_id;

    private int reward_item_count;
}
