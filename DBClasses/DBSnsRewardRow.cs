public class DBSnsRewardRow : ITableRowIndexer
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

    public int ShareCount
    {
        get
        {
            return share_count;
        }
    }

    public int EventType
    {
        get
        {
            return event_type;
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

    public string ShareImgName
    {
        get
        {
            return share_img_name;
        }
    }

    public string ShareDesc
    {
        get
        {
            return share_desc.Localize();
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
                    Reward1
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
        share_count = reader.ReadInt32();
        event_type = reader.ReadInt32();
        reward_1 = reader.ReadInt32();
        reward_count_1 = reader.ReadInt32();
        share_img_name = reader.ReadString();
        share_desc = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int share_count;

    private int event_type;

    private int reward_1;

    private int reward_count_1;

    private string share_img_name;

    private int share_desc;

    private List<int> list_reward;

    private List<int> list_reward_count;
}
