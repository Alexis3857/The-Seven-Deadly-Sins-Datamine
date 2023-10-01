public class DBGamblePaybackRewardRow : ITableRowIndexer
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

    public int RewardOrder
    {
        get
        {
            return reward_order;
        }
    }

    public int PaybackPoint
    {
        get
        {
            return payback_point;
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

    public int CheckFever
    {
        get
        {
            return check_fever;
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
                    RewardItem1
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
                    RewardCount1
                };
            }
            return list_reward_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        reward_order = reader.ReadInt32();
        payback_point = reader.ReadInt32();
        reward_item_1 = reader.ReadInt32();
        reward_count_1 = reader.ReadInt32();
        check_fever = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int reward_order;

    private int payback_point;

    private int reward_item_1;

    private int reward_count_1;

    private int check_fever;

    private List<int> list_reward_item;

    private List<int> list_reward_count;
}
