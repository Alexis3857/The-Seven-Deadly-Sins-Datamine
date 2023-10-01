public class DBEventMoleGameHawkRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int MoleType
    {
        get
        {
            return mole_type;
        }
    }

    public int Hp
    {
        get
        {
            return hp;
        }
    }

    public int KillPoint
    {
        get
        {
            return kill_point;
        }
    }

    public int TouchPoint
    {
        get
        {
            return touch_point;
        }
    }

    public string Image
    {
        get
        {
            return image;
        }
    }

    public int RewardType1
    {
        get
        {
            return reward_type_1;
        }
    }

    public int RewardValue1
    {
        get
        {
            return reward_value_1;
        }
    }

    public int RewardRate1
    {
        get
        {
            return reward_rate_1;
        }
    }

    public int RewardType2
    {
        get
        {
            return reward_type_2;
        }
    }

    public int RewardValue2
    {
        get
        {
            return reward_value_2;
        }
    }

    public int RewardRate2
    {
        get
        {
            return reward_rate_2;
        }
    }

    public int RewardType3
    {
        get
        {
            return reward_type_3;
        }
    }

    public int RewardValue3
    {
        get
        {
            return reward_value_3;
        }
    }

    public int RewardRate3
    {
        get
        {
            return reward_rate_3;
        }
    }

    public List<int> ListRewardType
    {
        get
        {
            if (list_reward_type == null)
            {
                list_reward_type = new List<int>
                {
                    RewardType1,
                    RewardType2,
                    RewardType3
                };
            }
            return list_reward_type;
        }
    }

    public List<int> ListRewardValue
    {
        get
        {
            if (list_reward_value == null)
            {
                list_reward_value = new List<int>
                {
                    RewardValue1,
                    RewardValue2,
                    RewardValue3
                };
            }
            return list_reward_value;
        }
    }

    public List<int> ListRewardRate
    {
        get
        {
            if (list_reward_rate == null)
            {
                list_reward_rate = new List<int>
                {
                    RewardRate1,
                    RewardRate2,
                    RewardRate3
                };
            }
            return list_reward_rate;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        mole_type = reader.ReadInt32();
        hp = reader.ReadInt32();
        kill_point = reader.ReadInt32();
        touch_point = reader.ReadInt32();
        image = reader.ReadString();
        reward_type_1 = reader.ReadInt32();
        reward_value_1 = reader.ReadInt32();
        reward_rate_1 = reader.ReadInt32();
        reward_type_2 = reader.ReadInt32();
        reward_value_2 = reader.ReadInt32();
        reward_rate_2 = reader.ReadInt32();
        reward_type_3 = reader.ReadInt32();
        reward_value_3 = reader.ReadInt32();
        reward_rate_3 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int mole_type;

    private int hp;

    private int kill_point;

    private int touch_point;

    private string image;

    private int reward_type_1;

    private int reward_value_1;

    private int reward_rate_1;

    private int reward_type_2;

    private int reward_value_2;

    private int reward_rate_2;

    private int reward_type_3;

    private int reward_value_3;

    private int reward_rate_3;

    private List<int> list_reward_type;

    private List<int> list_reward_value;

    private List<int> list_reward_rate;
}
