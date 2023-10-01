public class DBEventPredictSettingRow : ITableRowIndexer
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

    public string EventNameLocal
    {
        get
        {
            return event_name_local;
        }
    }

    public int DailyLimit
    {
        get
        {
            return daily_limit;
        }
    }

    public int UpgradeCount
    {
        get
        {
            return upgrade_count;
        }
    }

    public int ScoreCount
    {
        get
        {
            return score_count;
        }
    }

    public int GetScoreCount
    {
        get
        {
            return get_score_count;
        }
    }

    public int RewardStepCount
    {
        get
        {
            return reward_step_count;
        }
    }

    public int RewardStepMax
    {
        get
        {
            return reward_step_max;
        }
    }

    public int StartItemId
    {
        get
        {
            return start_item_id;
        }
    }

    public int StartItemCount
    {
        get
        {
            return start_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        event_name_local = reader.ReadString();
        daily_limit = reader.ReadInt32();
        upgrade_count = reader.ReadInt32();
        score_count = reader.ReadInt32();
        get_score_count = reader.ReadInt32();
        reward_step_count = reader.ReadInt32();
        reward_step_max = reader.ReadInt32();
        start_item_id = reader.ReadInt32();
        start_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private string event_name_local;

    private int daily_limit;

    private int upgrade_count;

    private int score_count;

    private int get_score_count;

    private int reward_step_count;

    private int reward_step_max;

    private int start_item_id;

    private int start_item_count;
}
