public class DBPassMissionRewardRow : ITableRowIndexer
{
    public int MissionId
    {
        get
        {
            return mission_id;
        }
    }

    public int Stack0RewardPoint
    {
        get
        {
            return stack_0_reward_point;
        }
    }

    public int Stack0RewardItemId
    {
        get
        {
            return stack_0_reward_item_id;
        }
    }

    public int Stack0RewardItemCount
    {
        get
        {
            return stack_0_reward_item_count;
        }
    }

    public int Stack0RewardItemCountEvent
    {
        get
        {
            return stack_0_reward_item_count_event;
        }
    }

    public int Stack1RewardPoint
    {
        get
        {
            return stack_1_reward_point;
        }
    }

    public int Stack1RewardItemId
    {
        get
        {
            return stack_1_reward_item_id;
        }
    }

    public int Stack1RewardItemCount
    {
        get
        {
            return stack_1_reward_item_count;
        }
    }

    public int Stack1RewardItemCountEvent
    {
        get
        {
            return stack_1_reward_item_count_event;
        }
    }

    public int Stack2RewardPoint
    {
        get
        {
            return stack_2_reward_point;
        }
    }

    public int Stack2RewardItemId
    {
        get
        {
            return stack_2_reward_item_id;
        }
    }

    public int Stack2RewardItemCount
    {
        get
        {
            return stack_2_reward_item_count;
        }
    }

    public int Stack2RewardItemCountEvent
    {
        get
        {
            return stack_2_reward_item_count_event;
        }
    }

    public int Stack3RewardPoint
    {
        get
        {
            return stack_3_reward_point;
        }
    }

    public int Stack3RewardItemId
    {
        get
        {
            return stack_3_reward_item_id;
        }
    }

    public int Stack3RewardItemCount
    {
        get
        {
            return stack_3_reward_item_count;
        }
    }

    public int Stack3RewardItemCountEvent
    {
        get
        {
            return stack_3_reward_item_count_event;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        mission_id = reader.ReadInt32();
        stack_0_reward_point = reader.ReadInt32();
        stack_0_reward_item_id = reader.ReadInt32();
        stack_0_reward_item_count = reader.ReadInt32();
        stack_0_reward_item_count_event = reader.ReadInt32();
        stack_1_reward_point = reader.ReadInt32();
        stack_1_reward_item_id = reader.ReadInt32();
        stack_1_reward_item_count = reader.ReadInt32();
        stack_1_reward_item_count_event = reader.ReadInt32();
        stack_2_reward_point = reader.ReadInt32();
        stack_2_reward_item_id = reader.ReadInt32();
        stack_2_reward_item_count = reader.ReadInt32();
        stack_2_reward_item_count_event = reader.ReadInt32();
        stack_3_reward_point = reader.ReadInt32();
        stack_3_reward_item_id = reader.ReadInt32();
        stack_3_reward_item_count = reader.ReadInt32();
        stack_3_reward_item_count_event = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return MissionId;
    }

    private int mission_id;

    private int stack_0_reward_point;

    private int stack_0_reward_item_id;

    private int stack_0_reward_item_count;

    private int stack_0_reward_item_count_event;

    private int stack_1_reward_point;

    private int stack_1_reward_item_id;

    private int stack_1_reward_item_count;

    private int stack_1_reward_item_count_event;

    private int stack_2_reward_point;

    private int stack_2_reward_item_id;

    private int stack_2_reward_item_count;

    private int stack_2_reward_item_count_event;

    private int stack_3_reward_point;

    private int stack_3_reward_item_id;

    private int stack_3_reward_item_count;

    private int stack_3_reward_item_count_event;
}
