public class DBStepupMileageRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int MileageGroup
    {
        get
        {
            return mileage_group;
        }
    }

    public int RewardOrder
    {
        get
        {
            return reward_order;
        }
    }

    public int StepupMileageValue
    {
        get
        {
            return stepup_mileage_value;
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

    public int BonusRewardGroupId
    {
        get
        {
            return bonus_reward_group_id;
        }
    }

    public int SkinLevel
    {
        get
        {
            return skin_level;
        }
    }

    public int SkinAwaken
    {
        get
        {
            return skin_awaken;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        mileage_group = reader.ReadInt32();
        reward_order = reader.ReadInt32();
        stepup_mileage_value = reader.ReadInt32();
        reward_item_id = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        bonus_reward_group_id = reader.ReadInt32();
        skin_level = reader.ReadInt32();
        skin_awaken = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int mileage_group;

    private int reward_order;

    private int stepup_mileage_value;

    private int reward_item_id;

    private int reward_item_count;

    private int bonus_reward_group_id;

    private int skin_level;

    private int skin_awaken;
}
