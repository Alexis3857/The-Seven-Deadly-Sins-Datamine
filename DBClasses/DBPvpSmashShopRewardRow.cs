public class DBPvpSmashShopRewardRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int RewardOrder
    {
        get
        {
            return reward_order;
        }
    }

    public int NeedBuyCount
    {
        get
        {
            return need_buy_count;
        }
    }

    public int RewardItemId
    {
        get
        {
            return reward_item_id;
        }
    }

    public int RewardCount
    {
        get
        {
            return reward_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        reward_order = reader.ReadInt32();
        need_buy_count = reader.ReadInt32();
        reward_item_id = reader.ReadInt32();
        reward_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int reward_order;

    private int need_buy_count;

    private int reward_item_id;

    private int reward_count;
}
