public class DBEventExchangeRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ExchangeCategory
    {
        get
        {
            return exchange_category;
        }
    }

    public int EventSubGroup
    {
        get
        {
            return event_sub_group;
        }
    }

    public int DailyExchangeCount
    {
        get
        {
            return daily_exchange_count;
        }
    }

    public int ExchangeCount
    {
        get
        {
            return exchange_count;
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

    public int Material2
    {
        get
        {
            return material_2;
        }
    }

    public int MaterialCount2
    {
        get
        {
            return material_count_2;
        }
    }

    public int Material3
    {
        get
        {
            return material_3;
        }
    }

    public int MaterialCount3
    {
        get
        {
            return material_count_3;
        }
    }

    public int Material4
    {
        get
        {
            return material_4;
        }
    }

    public int MaterialCount4
    {
        get
        {
            return material_count_4;
        }
    }

    public int Material5
    {
        get
        {
            return material_5;
        }
    }

    public int MaterialCount5
    {
        get
        {
            return material_count_5;
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

    public List<int> ListMaterial
    {
        get
        {
            if (list_material == null)
            {
                list_material = new List<int>
                {
                    Material1,
                    Material2,
                    Material3,
                    Material4,
                    Material5
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
                    MaterialCount1,
                    MaterialCount2,
                    MaterialCount3,
                    MaterialCount4,
                    MaterialCount5
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
        exchange_category = reader.ReadInt32();
        event_sub_group = reader.ReadInt32();
        daily_exchange_count = reader.ReadInt32();
        exchange_count = reader.ReadInt32();
        material_1 = reader.ReadInt32();
        material_count_1 = reader.ReadInt32();
        material_2 = reader.ReadInt32();
        material_count_2 = reader.ReadInt32();
        material_3 = reader.ReadInt32();
        material_count_3 = reader.ReadInt32();
        material_4 = reader.ReadInt32();
        material_count_4 = reader.ReadInt32();
        material_5 = reader.ReadInt32();
        material_count_5 = reader.ReadInt32();
        reward_1 = reader.ReadInt32();
        reward_count_1 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int exchange_category;

    private int event_sub_group;

    private int daily_exchange_count;

    private int exchange_count;

    private int material_1;

    private int material_count_1;

    private int material_2;

    private int material_count_2;

    private int material_3;

    private int material_count_3;

    private int material_4;

    private int material_count_4;

    private int material_5;

    private int material_count_5;

    private int reward_1;

    private int reward_count_1;

    private List<int> list_material;

    private List<int> list_material_count;

    private List<int> list_reward;

    private List<int> list_reward_count;
}
