public class DBKingAmberRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int Grade
    {
        get
        {
            return grade;
        }
    }

    public string Type
    {
        get
        {
            return type;
        }
    }

    public string TypeName
    {
        get
        {
            return type_name.Localize();
        }
    }

    public string SubType
    {
        get
        {
            return sub_type;
        }
    }

    public string SubTypeName
    {
        get
        {
            return sub_type_name.Localize();
        }
    }

    public string TitleIcon
    {
        get
        {
            return title_icon;
        }
    }

    public int MaterialId
    {
        get
        {
            return material_id;
        }
    }

    public int MaterialCount
    {
        get
        {
            return material_count;
        }
    }

    public int RewardId1
    {
        get
        {
            return reward_id_1;
        }
    }

    public int RewardCount1
    {
        get
        {
            return reward_count_1;
        }
    }

    public int RewardId2
    {
        get
        {
            return reward_id_2;
        }
    }

    public int RewardCount2
    {
        get
        {
            return reward_count_2;
        }
    }

    public int RewardId3
    {
        get
        {
            return reward_id_3;
        }
    }

    public int RewardCount3
    {
        get
        {
            return reward_count_3;
        }
    }

    public int RewardId4
    {
        get
        {
            return reward_id_4;
        }
    }

    public int RewardCount4
    {
        get
        {
            return reward_count_4;
        }
    }

    public int RewardId5
    {
        get
        {
            return reward_id_5;
        }
    }

    public int RewardCount5
    {
        get
        {
            return reward_count_5;
        }
    }

    public int RewardId6
    {
        get
        {
            return reward_id_6;
        }
    }

    public int RewardCount6
    {
        get
        {
            return reward_count_6;
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
                    RewardId1,
                    RewardId2,
                    RewardId3,
                    RewardId4,
                    RewardId5,
                    RewardId6
                };
            }
            return list_reward_id;
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
                    RewardCount4,
                    RewardCount5,
                    RewardCount6
                };
            }
            return list_reward_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        grade = reader.ReadInt32();
        type = reader.ReadString();
        type_name = reader.ReadInt32();
        sub_type = reader.ReadString();
        sub_type_name = reader.ReadInt32();
        title_icon = reader.ReadString();
        material_id = reader.ReadInt32();
        material_count = reader.ReadInt32();
        reward_id_1 = reader.ReadInt32();
        reward_count_1 = reader.ReadInt32();
        reward_id_2 = reader.ReadInt32();
        reward_count_2 = reader.ReadInt32();
        reward_id_3 = reader.ReadInt32();
        reward_count_3 = reader.ReadInt32();
        reward_id_4 = reader.ReadInt32();
        reward_count_4 = reader.ReadInt32();
        reward_id_5 = reader.ReadInt32();
        reward_count_5 = reader.ReadInt32();
        reward_id_6 = reader.ReadInt32();
        reward_count_6 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int grade;

    private string type;

    private int type_name;

    private string sub_type;

    private int sub_type_name;

    private string title_icon;

    private int material_id;

    private int material_count;

    private int reward_id_1;

    private int reward_count_1;

    private int reward_id_2;

    private int reward_count_2;

    private int reward_id_3;

    private int reward_count_3;

    private int reward_id_4;

    private int reward_count_4;

    private int reward_id_5;

    private int reward_count_5;

    private int reward_id_6;

    private int reward_count_6;

    private List<int> list_reward_id;

    private List<int> list_reward_count;
}
