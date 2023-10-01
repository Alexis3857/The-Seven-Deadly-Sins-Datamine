public class DBEventPredictSpecialRewardRow : ITableRowIndexer
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

    public int Step
    {
        get
        {
            return step;
        }
    }

    public int NeedScore
    {
        get
        {
            return need_score;
        }
    }

    public int RewardItem
    {
        get
        {
            return reward_item;
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
        step = reader.ReadInt32();
        need_score = reader.ReadInt32();
        reward_item = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int step;

    private int need_score;

    private int reward_item;

    private int reward_item_count;
}
