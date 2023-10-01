public class DBEventPvpWincountRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public int Week
    {
        get
        {
            return week;
        }
    }

    public int RewardIndex
    {
        get
        {
            return reward_index;
        }
    }

    public int WinCount
    {
        get
        {
            return win_count;
        }
    }

    public int RewardItem1
    {
        get
        {
            return reward_item_1;
        }
    }

    public int RewardCount1
    {
        get
        {
            return reward_count_1;
        }
    }

    public int RewardItem2
    {
        get
        {
            return reward_item_2;
        }
    }

    public int RewardCount2
    {
        get
        {
            return reward_count_2;
        }
    }

    public int RewardItem3
    {
        get
        {
            return reward_item_3;
        }
    }

    public int RewardCount3
    {
        get
        {
            return reward_count_3;
        }
    }

    public List<int> ListRewardItem
    {
        get
        {
            if (list_reward_item == null)
            {
                list_reward_item = new List<int>
                {
                    RewardItem1,
                    RewardItem2,
                    RewardItem3
                };
            }
            return list_reward_item;
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
                    RewardCount3
                };
            }
            return list_reward_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        group_id = reader.ReadInt32();
        week = reader.ReadInt32();
        reward_index = reader.ReadInt32();
        win_count = reader.ReadInt32();
        reward_item_1 = reader.ReadInt32();
        reward_count_1 = reader.ReadInt32();
        reward_item_2 = reader.ReadInt32();
        reward_count_2 = reader.ReadInt32();
        reward_item_3 = reader.ReadInt32();
        reward_count_3 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int group_id;

    private int week;

    private int reward_index;

    private int win_count;

    private int reward_item_1;

    private int reward_count_1;

    private int reward_item_2;

    private int reward_count_2;

    private int reward_item_3;

    private int reward_count_3;

    private List<int> list_reward_item;

    private List<int> list_reward_count;
}
