public class DBHeroLeagueRewardRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int RewardGroup
    {
        get
        {
            return reward_group;
        }
    }

    public int TeamCount
    {
        get
        {
            return team_count;
        }
    }

    public int RewardItemId1
    {
        get
        {
            return reward_item_id_1;
        }
    }

    public int RewardItemCount1
    {
        get
        {
            return reward_item_count_1;
        }
    }

    public int RewardItemId2
    {
        get
        {
            return reward_item_id_2;
        }
    }

    public int RewardItemCount2
    {
        get
        {
            return reward_item_count_2;
        }
    }

    public List<int> ListRewardItemId
    {
        get
        {
            if (list_reward_item_id == null)
            {
                list_reward_item_id = new List<int>()
                {
                    RewardItemId1,
                    RewardItemId2
                };
            }
            return list_reward_item_id;
        }
    }

    public List<int> ListRewardItemCount
    {
        get
        {
            if (list_reward_item_count == null)
            {
                list_reward_item_count = new List<int>()
                {
                    RewardItemCount1,
                    RewardItemCount2
                };
            }
            return list_reward_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        reward_group = reader.ReadInt32();
        team_count = reader.ReadInt32();
        reward_item_id_1 = reader.ReadInt32();
        reward_item_count_1 = reader.ReadInt32();
        reward_item_id_2 = reader.ReadInt32();
        reward_item_count_2 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int reward_group;

    private int team_count;

    private int reward_item_id_1;

    private int reward_item_count_1;

    private int reward_item_id_2;

    private int reward_item_count_2;

    private List<int> list_reward_item_id;

    private List<int> list_reward_item_count;
}