public class DBGuildorderBonusrewardGroupRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int BonusrewardGroup
    {
        get
        {
            return bonusreward_group;
        }
    }

    public int RewardItemId
    {
        get
        {
            return reward_item_id;
        }
    }

    public int RewardItemCount
    {
        get
        {
            return reward_item_count;
        }
    }

    public int GambleRate
    {
        get
        {
            return gamble_rate;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        bonusreward_group = reader.ReadInt32();
        reward_item_id = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        gamble_rate = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int bonusreward_group;

    private int reward_item_id;

    private int reward_item_count;

    private int gamble_rate;
}