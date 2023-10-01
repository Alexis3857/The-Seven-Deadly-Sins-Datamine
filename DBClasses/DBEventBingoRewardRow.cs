public class DBEventBingoRewardRow : ITableRowIndexer
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

    public int BingoEventType
    {
        get
        {
            return bingo_event_type;
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

    public int RewardRate
    {
        get
        {
            return reward_rate;
        }
    }

    public int RewardType
    {
        get
        {
            return reward_type;
        }
    }

    public int FixReward
    {
        get
        {
            return fix_reward;
        }
    }

    public int FinalRewardId
    {
        get
        {
            return final_reward_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        bingo_event_type = reader.ReadInt32();
        reward_item_id = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        reward_rate = reader.ReadInt32();
        reward_type = reader.ReadInt32();
        fix_reward = reader.ReadInt32();
        final_reward_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int bingo_event_type;

    private int reward_item_id;

    private int reward_item_count;

    private int reward_rate;

    private int reward_type;

    private int fix_reward;

    private int final_reward_id;
}
