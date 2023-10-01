public class DBGuildWarLowPlayRewardRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int PlayCount
    {
        get
        {
            return play_count;
        }
    }

    public int RewardId
    {
        get
        {
            return reward_id;
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
        play_count = reader.ReadInt32();
        reward_id = reader.ReadInt32();
        reward_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int play_count;

    private int reward_id;

    private int reward_count;
}
