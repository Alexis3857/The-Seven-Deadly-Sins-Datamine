public class DBEventTreasureHuntSettingRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int SubIndex
    {
        get
        {
            return sub_index;
        }
    }

    public int GroupCount
    {
        get
        {
            return group_count;
        }
    }

    public int RewardGetType
    {
        get
        {
            return reward_get_type;
        }
    }

    public int DiceDailyLimit
    {
        get
        {
            return dice_daily_limit;
        }
    }

    public int DiceItemId
    {
        get
        {
            return dice_item_id;
        }
    }

    public int DiceItemCount
    {
        get
        {
            return dice_item_count;
        }
    }

    public int DiceSlowItemCount
    {
        get
        {
            return dice_slow_item_count;
        }
    }

    public int DiceSlowValue
    {
        get
        {
            return dice_slow_value;
        }
    }

    public int DiceSlowMax
    {
        get
        {
            return dice_slow_max;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        sub_index = reader.ReadInt32();
        group_count = reader.ReadInt32();
        reward_get_type = reader.ReadInt32();
        dice_daily_limit = reader.ReadInt32();
        dice_item_id = reader.ReadInt32();
        dice_item_count = reader.ReadInt32();
        dice_slow_item_count = reader.ReadInt32();
        dice_slow_value = reader.ReadInt32();
        dice_slow_max = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int sub_index;

    private int group_count;

    private int reward_get_type;

    private int dice_daily_limit;

    private int dice_item_id;

    private int dice_item_count;

    private int dice_slow_item_count;

    private int dice_slow_value;

    private int dice_slow_max;
}
