public class DBStepupMileageBonusRewardRow : ITableRowIndexer
{
    public int Index
    {
        get
        {
            return index;
        }
    }

    public int BonusRewardGroupId
    {
        get
        {
            return bonus_reward_group_id;
        }
    }

    public int BonusRewardType
    {
        get
        {
            return bonus_reward_type;
        }
    }

    public int BonusRewardItemId
    {
        get
        {
            return bonus_reward_item_id;
        }
    }

    public int BonusRewardItemCount
    {
        get
        {
            return bonus_reward_item_count;
        }
    }

    public int BonusRewardRate
    {
        get
        {
            return bonus_reward_rate;
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
        index = reader.ReadInt32();
        bonus_reward_group_id = reader.ReadInt32();
        bonus_reward_type = reader.ReadInt32();
        bonus_reward_item_id = reader.ReadInt32();
        bonus_reward_item_count = reader.ReadInt32();
        bonus_reward_rate = reader.ReadInt32();
        skin_level = reader.ReadInt32();
        skin_awaken = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Index;
    }

    private int index;

    private int bonus_reward_group_id;

    private int bonus_reward_type;

    private int bonus_reward_item_id;

    private int bonus_reward_item_count;

    private int bonus_reward_rate;

    private int skin_level;

    private int skin_awaken;
}
