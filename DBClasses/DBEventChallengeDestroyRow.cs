public class DBEventChallengeDestroyRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public byte ExchangeIconCheck
    {
        get
        {
            return exchange_icon_check;
        }
    }

    public int LimitIndex
    {
        get
        {
            return limit_index;
        }
    }

    public int PointItem
    {
        get
        {
            return point_item;
        }
    }

    public int RewardpointNormal
    {
        get
        {
            return rewardpoint_normal;
        }
    }

    public int RewardpointHard
    {
        get
        {
            return rewardpoint_hard;
        }
    }

    public int RewardpointExtreme
    {
        get
        {
            return rewardpoint_extreme;
        }
    }

    public int RewardpointHell
    {
        get
        {
            return rewardpoint__hell;
        }
    }

    public int RewardNeedCount
    {
        get
        {
            return reward_need_count;
        }
    }

    public int RewardNeedCountKR
    {
        get
        {
            return reward_need_count_KR;
        }
    }

    public int RewardNeedCountJP
    {
        get
        {
            return reward_need_count_JP;
        }
    }

    public int RewardNeedCountASIA
    {
        get
        {
            return reward_need_count_ASIA;
        }
    }

    public int RewardNeedCountGLOBAL
    {
        get
        {
            return reward_need_count_GLOBAL;
        }
    }


    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        group_id = reader.ReadInt32();
        exchange_icon_check = reader.ReadByte();
        limit_index = reader.ReadInt32();
        point_item = reader.ReadInt32();
        rewardpoint_normal = reader.ReadInt32();
        rewardpoint_hard = reader.ReadInt32();
        rewardpoint_extreme = reader.ReadInt32();
        rewardpoint__hell = reader.ReadInt32();
        reward_need_count = reader.ReadInt32();
        reward_need_count_KR = reader.ReadInt32();
        reward_need_count_JP = reader.ReadInt32();
        reward_need_count_ASIA = reader.ReadInt32();
        reward_need_count_GLOBAL = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int group_id;

    private byte exchange_icon_check;

    private int limit_index;

    private int point_item;

    private int rewardpoint_normal;

    private int rewardpoint_hard;

    private int rewardpoint_extreme;

    private int rewardpoint__hell;

    private int reward_need_count;

    private int reward_need_count_KR;

    private int reward_need_count_JP;

    private int reward_need_count_ASIA;

    private int reward_need_count_GLOBAL;
}
