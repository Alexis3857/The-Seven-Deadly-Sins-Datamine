public class DBEventLuckyboxRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int RewardTier
    {
        get
        {
            return reward_tier;
        }
    }

    public int RewardItem
    {
        get
        {
            return reward_item;
        }
    }

    public int RewardValue
    {
        get
        {
            return reward_value;
        }
    }

    public int RewardRestrictKR
    {
        get
        {
            return reward_restrict_KR;
        }
    }

    public int RewardRestrict
    {
        get
        {
            return reward_restrict;
        }
    }

    public string RewardIcon
    {
        get
        {
            return reward_icon;
        }
    }

    public string RewardName
    {
        get
        {
            return reward_name.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        reward_tier = reader.ReadInt32();
        reward_item = reader.ReadInt32();
        reward_value = reader.ReadInt32();
        reward_restrict_KR = reader.ReadInt32();
        reward_restrict = reader.ReadInt32();
        reward_icon = reader.ReadString();
        reward_name = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int reward_tier;

    private int reward_item;

    private int reward_value;

    private int reward_restrict_KR;

    private int reward_restrict;

    private string reward_icon;

    private int reward_name;
}