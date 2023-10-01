public class DBLevelupPackageRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ProductId
    {
        get
        {
            return product_id;
        }
    }

    public int RewardIndex
    {
        get
        {
            return reward_index;
        }
    }

    public int UserRank
    {
        get
        {
            return user_rank;
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

    public List<int> ListRewardItemId
    {
        get
        {
            if (list_reward_item_id == null)
            {
                list_reward_item_id = new List<int>
                {
                    RewardItemId1
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
                list_reward_item_count = new List<int>
                {
                    RewardItemCount1
                };
            }
            return list_reward_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        product_id = reader.ReadInt32();
        reward_index = reader.ReadInt32();
        user_rank = reader.ReadInt32();
        reward_item_id_1 = reader.ReadInt32();
        reward_item_count_1 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int product_id;

    private int reward_index;

    private int user_rank;

    private int reward_item_id_1;

    private int reward_item_count_1;

    private List<int> list_reward_item_id;

    private List<int> list_reward_item_count;
}
