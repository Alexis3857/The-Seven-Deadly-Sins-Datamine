public class DBGambleBonusRewardRow : ITableRowIndexer
{
    public int Index
    {
        get
        {
            return index;
        }
    }

    public int GachaBonusRewardGroupId
    {
        get
        {
            return gacha_bonus_reward_group_id;
        }
    }

    public int GachaBonusRewardType
    {
        get
        {
            return gacha_bonus_reward_type;
        }
    }

    public int MileageStep
    {
        get
        {
            return mileage_step;
        }
    }

    public int MileageValue
    {
        get
        {
            return mileage_value;
        }
    }

    public int GambleGroup
    {
        get
        {
            return gamble_group;
        }
    }

    public int GachaBonusReward
    {
        get
        {
            return gacha_bonus_reward;
        }
    }

    public int GachaBonusCount
    {
        get
        {
            return gacha_bonus_count;
        }
    }

    public int GachaBonusRewardRate
    {
        get
        {
            return gacha_bonus_reward_rate;
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

    public int GachaSsrBonusCount
    {
        get
        {
            return gacha_ssr_bonus_count;
        }
    }

    public int GachaUr
    {
        get
        {
            return gacha_ur;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        index = reader.ReadInt32();
        gacha_bonus_reward_group_id = reader.ReadInt32();
        gacha_bonus_reward_type = reader.ReadInt32();
        mileage_step = reader.ReadInt32();
        mileage_value = reader.ReadInt32();
        gamble_group = reader.ReadInt32();
        gacha_bonus_reward = reader.ReadInt32();
        gacha_bonus_count = reader.ReadInt32();
        gacha_bonus_reward_rate = reader.ReadInt32();
        skin_level = reader.ReadInt32();
        skin_awaken = reader.ReadInt32();
        gacha_ssr_bonus_count = reader.ReadInt32();
        gacha_ur = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Index;
    }

    private int index;

    private int gacha_bonus_reward_group_id;

    private int gacha_bonus_reward_type;

    private int mileage_step;

    private int mileage_value;

    private int gamble_group;

    private int gacha_bonus_reward;

    private int gacha_bonus_count;

    private int gacha_bonus_reward_rate;

    private int skin_level;

    private int skin_awaken;

    private int gacha_ssr_bonus_count;

    private int gacha_ur;
}
