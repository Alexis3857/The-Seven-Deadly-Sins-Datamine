public class DBEventExchangeCardGroupRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public int ItemGroup
    {
        get
        {
            return item_group;
        }
    }

    public int SpecialRewardCount
    {
        get
        {
            return special_reward_count;
        }
    }

    public List<int> ListArrayResetItem
    {
        get
        {
            return list_array_reset_item;
        }
    }

    public int RewardType
    {
        get
        {
            return reward_type;
        }
    }

    public int BonusChanceLimitCount
    {
        get
        {
            return bonus_chance_limit_count;
        }
    }

    public int BonusSpecialRewardCount
    {
        get
        {
            return bonus_special_reward_count;
        }
    }

    public int BonusCountValue
    {
        get
        {
            return bonus_count_value;
        }
    }

    public int BonusRewardCheck
    {
        get
        {
            return bonus_reward_check;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        item_group = reader.ReadInt32();
        special_reward_count = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_reset_item = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_reset_item.Add(reader.ReadInt32());
        }
        reward_type = reader.ReadInt32();
        bonus_chance_limit_count = reader.ReadInt32();
        bonus_special_reward_count = reader.ReadInt32();
        bonus_count_value = reader.ReadInt32();
        bonus_reward_check = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int item_group;

    private int special_reward_count;

    private List<int> list_array_reset_item;

    private int reward_type;

    private int bonus_chance_limit_count;

    private int bonus_special_reward_count;

    private int bonus_count_value;

    private int bonus_reward_check;
}
