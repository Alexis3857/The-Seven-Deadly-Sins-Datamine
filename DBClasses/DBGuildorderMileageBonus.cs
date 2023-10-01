public class DBGuildorderMileagebonusRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int MileageStep
    {
        get
        {
            return mileage_step;
        }
    }

    public int NeedMileage
    {
        get
        {
            return need_mileage;
        }
    }

    public int RewardItem
    {
        get
        {
            return reward_item;
        }
    }

    public int RewardItemCount
    {
        get
        {
            return reward_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        mileage_step = reader.ReadInt32();
        need_mileage = reader.ReadInt32();
        reward_item = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int mileage_step;

    private int need_mileage;

    private int reward_item;

    private int reward_item_count;
}