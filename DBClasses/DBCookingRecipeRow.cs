public class DBCookingRecipeRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string Icon
    {
        get
        {
            return icon;
        }
    }

    public int MaxExp
    {
        get
        {
            return max_exp;
        }
    }

    public int MaterialId
    {
        get
        {
            return material_id;
        }
    }

    public int CostTime
    {
        get
        {
            return cost_time;
        }
    }

    public int RewardId
    {
        get
        {
            return reward_id;
        }
    }

    public int RewardCount1
    {
        get
        {
            return reward_count_1;
        }
    }

    public int RewardCount2
    {
        get
        {
            return reward_count_2;
        }
    }

    public int RewardCount3
    {
        get
        {
            return reward_count_3;
        }
    }

    public int RewardCount4
    {
        get
        {
            return reward_count_4;
        }
    }

    public int RewardCount5
    {
        get
        {
            return reward_count_5;
        }
    }

    public int CookingListLink
    {
        get
        {
            return cooking_list_link;
        }
    }

    public int CookingItemView
    {
        get
        {
            return cooking_item_view;
        }
    }

    public int CookingPvpTop100DefTeamBuff
    {
        get
        {
            return cooking_pvp_top_100_def_team_buff;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
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
                    RewardCount5
                };
            }
            return list_reward_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        icon = reader.ReadString();
        max_exp = reader.ReadInt32();
        material_id = reader.ReadInt32();
        cost_time = reader.ReadInt32();
        reward_id = reader.ReadInt32();
        reward_count_1 = reader.ReadInt32();
        reward_count_2 = reader.ReadInt32();
        reward_count_3 = reader.ReadInt32();
        reward_count_4 = reader.ReadInt32();
        reward_count_5 = reader.ReadInt32();
        cooking_list_link = reader.ReadInt32();
        cooking_item_view = reader.ReadInt32();
        cooking_pvp_top_100_def_team_buff = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string icon;

    private int max_exp;

    private int material_id;

    private int cost_time;

    private int reward_id;

    private int reward_count_1;

    private int reward_count_2;

    private int reward_count_3;

    private int reward_count_4;

    private int reward_count_5;

    private int cooking_list_link;

    private int cooking_item_view;

    private int cooking_pvp_top_100_def_team_buff;

    private int event_sub_index;

    private List<int> list_reward_count;
}
