public class DBEventBingoExchangeRow
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

    public int BingoExchangeGroup
    {
        get
        {
            return bingo_exchange_group;
        }
    }

    public int Material1
    {
        get
        {
            return material_1;
        }
    }

    public int MaterialCount1
    {
        get
        {
            return material_count_1;
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

    public int EventBingoRandomId
    {
        get
        {
            return event_bingo_random_id;
        }
    }

    public List<int> ListMaterial
    {
        get
        {
            if (list_material == null)
            {
                list_material = new List<int>
                {
                    Material1
                };
            }
            return list_material;
        }
    }

    public List<int> ListMaterialCount
    {
        get
        {
            if (list_material_count == null)
            {
                list_material_count = new List<int>
                {
                    MaterialCount1
                };
            }
            return list_material_count;
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
        bingo_exchange_group = reader.ReadInt32();
        material_1 = reader.ReadInt32();
        material_count_1 = reader.ReadInt32();
        reward_1 = reader.ReadInt32();
        reward_count_1 = reader.ReadInt32();
        event_bingo_random_id = reader.ReadInt32();
        return true;
    }

    private int id;

    private int event_sub_index;

    private int bingo_exchange_group;

    private int material_1;

    private int material_count_1;

    private int reward_1;

    private int reward_count_1;

    private int event_bingo_random_id;

    private List<int> list_material;

    private List<int> list_material_count;

    private List<int> list_reward;

    private List<int> list_reward_count;
}
