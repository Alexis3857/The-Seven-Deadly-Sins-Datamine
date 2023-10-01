public class DBEventMissionScoreSetRow : ITableRowIndexer
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

    public int LastRewardCount
    {
        get
        {
            return last_reward_count;
        }
    }

    public int LastRewardGetCount
    {
        get
        {
            return last_reward_get_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        last_reward_count = reader.ReadInt32();
        last_reward_get_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int last_reward_count;

    private int last_reward_get_count;
}
