public class DBCookingListRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int MaterialId1
    {
        get
        {
            return material_id_1;
        }
    }

    public int MaterialId2
    {
        get
        {
            return material_id_2;
        }
    }

    public int MaterialId3
    {
        get
        {
            return material_id_3;
        }
    }

    public int RewardId1
    {
        get
        {
            return reward_id_1;
        }
    }

    public int RewardCountMin1
    {
        get
        {
            return reward_count_min_1;
        }
    }

    public int RewardCountMax1
    {
        get
        {
            return reward_count_max_1;
        }
    }

    public int RewardCountMin2
    {
        get
        {
            return reward_count_min_2;
        }
    }

    public int RewardCountMax2
    {
        get
        {
            return reward_count_max_2;
        }
    }

    public int QuestIndex
    {
        get
        {
            return quest_index;
        }
    }

    public int QuestItemCount
    {
        get
        {
            return quest_item_count;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public List<int> ListMaterialId
    {
        get
        {
            if (list_material_id == null)
            {
                list_material_id = new List<int>
                {
                    MaterialId1,
                    MaterialId2,
                    MaterialId3
                };
            }
            return list_material_id;
        }
    }

    public List<int> ListRewardId
    {
        get
        {
            if (list_reward_id == null)
            {
                list_reward_id = new List<int>
                {
                    RewardId1
                };
            }
            return list_reward_id;
        }
    }

    public List<int> ListRewardCountMin
    {
        get
        {
            if (list_reward_count_min == null)
            {
                list_reward_count_min = new List<int>
                {
                    RewardCountMin1,
                    RewardCountMin2
                };
            }
            return list_reward_count_min;
        }
    }

    public List<int> ListRewardCountMax
    {
        get
        {
            if (list_reward_count_max == null)
            {
                list_reward_count_max = new List<int>
                {
                    RewardCountMax1,
                    RewardCountMax2
                };
            }
            return list_reward_count_max;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        material_id_1 = reader.ReadInt32();
        material_id_2 = reader.ReadInt32();
        material_id_3 = reader.ReadInt32();
        reward_id_1 = reader.ReadInt32();
        reward_count_min_1 = reader.ReadInt32();
        reward_count_max_1 = reader.ReadInt32();
        reward_count_min_2 = reader.ReadInt32();
        reward_count_max_2 = reader.ReadInt32();
        quest_index = reader.ReadInt32();
        quest_item_count = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int material_id_1;

    private int material_id_2;

    private int material_id_3;

    private int reward_id_1;

    private int reward_count_min_1;

    private int reward_count_max_1;

    private int reward_count_min_2;

    private int reward_count_max_2;

    private int quest_index;

    private int quest_item_count;

    private int event_sub_index;

    private List<int> list_material_id;

    private List<int> list_reward_id;

    private List<int> list_reward_count_min;

    private List<int> list_reward_count_max;
}
