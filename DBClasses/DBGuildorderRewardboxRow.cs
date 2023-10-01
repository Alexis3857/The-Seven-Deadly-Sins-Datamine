public class DBGuildorderRewardboxRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int NeedUap
    {
        get
        {
            return need_uap;
        }
    }

    public string BoxIconName
    {
        get
        {
            return box_icon_name;
        }
    }

    public int BonusrewardAmount
    {
        get
        {
            return bonusreward_amount;
        }
    }

    public int BonusrewardGroup
    {
        get
        {
            return bonusreward_group;
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

    public int RewardItemId2
    {
        get
        {
            return reward_item_id_2;
        }
    }

    public int RewardItemCount2
    {
        get
        {
            return reward_item_count_2;
        }
    }

    public int RewardItemId3
    {
        get
        {
            return reward_item_id_3;
        }
    }

    public int RewardItemCount3
    {
        get
        {
            return reward_item_count_3;
        }
    }

    public int RewardItemId4
    {
        get
        {
            return reward_item_id_4;
        }
    }

    public int RewardItemCount4
    {
        get
        {
            return reward_item_count_4;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        need_uap = reader.ReadInt32();
        box_icon_name = reader.ReadString();
        bonusreward_amount = reader.ReadInt32();
        bonusreward_group = reader.ReadInt32();
        reward_item_id_1 = reader.ReadInt32();
        reward_item_count_1 = reader.ReadInt32();
        reward_item_id_2 = reader.ReadInt32();
        reward_item_count_2 = reader.ReadInt32();
        reward_item_id_3 = reader.ReadInt32();
        reward_item_count_3 = reader.ReadInt32();
        reward_item_id_4 = reader.ReadInt32();
        reward_item_count_4 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int need_uap;

    private string box_icon_name;

    private int bonusreward_amount;

    private int bonusreward_group;

    private int reward_item_id_1;

    private int reward_item_count_1;

    private int reward_item_id_2;

    private int reward_item_count_2;

    private int reward_item_id_3;

    private int reward_item_count_3;

    private int reward_item_id_4;

    private int reward_item_count_4;
}