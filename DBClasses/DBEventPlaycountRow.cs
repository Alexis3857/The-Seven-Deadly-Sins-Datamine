public class DBEventPlaycountRow : ITableRowIndexer
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

    public int EventSubType
    {
        get
        {
            return event_sub_type;
        }
    }

    public int PlayCount
    {
        get
        {
            return play_count;
        }
    }

    public int Reward1
    {
        get
        {
            return reward_1;
        }
    }

    public int RewardCount1
    {
        get
        {
            return reward_count_1;
        }
    }

    public int Reward2
    {
        get
        {
            return reward_2;
        }
    }

    public int RewardCount2
    {
        get
        {
            return reward_count_2;
        }
    }

    public int Reward3
    {
        get
        {
            return reward_3;
        }
    }

    public int RewardCount3
    {
        get
        {
            return reward_count_3;
        }
    }

    public int Reward4
    {
        get
        {
            return reward_4;
        }
    }

    public int RewardCount4
    {
        get
        {
            return reward_count_4;
        }
    }

    public List<int> ListReward
    {
        get
        {
            if (list_reward == null)
            {
                list_reward = new List<int>
                {
                    Reward1,
                    Reward2,
                    Reward3,
                    Reward4
                };
            }
            return list_reward;
        }
    }

    public List<int> ListRewardCount
    {
        get
        {
            if (list_reward_count == null)
            {
                list_reward_count = new List<int>
                {
                    RewardCount1,
                    RewardCount2,
                    RewardCount3,
                    RewardCount4
                };
            }
            return list_reward_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        event_sub_type = reader.ReadInt32();
        play_count = reader.ReadInt32();
        reward_1 = reader.ReadInt32();
        reward_count_1 = reader.ReadInt32();
        reward_2 = reader.ReadInt32();
        reward_count_2 = reader.ReadInt32();
        reward_3 = reader.ReadInt32();
        reward_count_3 = reader.ReadInt32();
        reward_4 = reader.ReadInt32();
        reward_count_4 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int event_sub_type;

    private int play_count;

    private int reward_1;

    private int reward_count_1;

    private int reward_2;

    private int reward_count_2;

    private int reward_3;

    private int reward_count_3;

    private int reward_4;

    private int reward_count_4;

    private List<int> list_reward;

    private List<int> list_reward_count;
}
