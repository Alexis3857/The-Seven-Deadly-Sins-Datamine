public class DBEventDisasterTripleRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int Region
    {
        get
        {
            return region;
        }
    }

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public string SeasonTitle
    {
        get
        {
            return season_title.Localize();
        }
    }

    public int LimitIndex
    {
        get
        {
            return limit_index;
        }
    }

    public int EventSubGroup
    {
        get
        {
            return event_sub_group;
        }
    }

    public string ControlType
    {
        get
        {
            return control_type;
        }
    }

    public int DBContentLinkId
    {
        get
        {
            return DB_content_link_id;
        }
    }

    public int FirstRewardIdNormal
    {
        get
        {
            return first_reward_id_normal;
        }
    }

    public int FirstRewardValueNormal
    {
        get
        {
            return first_reward_value_normal;
        }
    }

    public int FirstRewardIdHard
    {
        get
        {
            return first_reward_id_hard;
        }
    }

    public int FirstRewardValueHard
    {
        get
        {
            return first_reward_value_hard;
        }
    }

    public int FirstRewardIdExtreme
    {
        get
        {
            return first_reward_id_extreme;
        }
    }

    public int FirstRewardValueExtreme
    {
        get
        {
            return first_reward_value_extreme;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        region = reader.ReadInt32();
        group_id = reader.ReadInt32();
        season_title = reader.ReadInt32();
        limit_index = reader.ReadInt32();
        event_sub_group = reader.ReadInt32();
        control_type = reader.ReadString();
        DB_content_link_id = reader.ReadInt32();
        first_reward_id_normal = reader.ReadInt32();
        first_reward_value_normal = reader.ReadInt32();
        first_reward_id_hard = reader.ReadInt32();
        first_reward_value_hard = reader.ReadInt32();
        first_reward_id_extreme = reader.ReadInt32();
        first_reward_value_extreme = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int region;

    private int group_id;

    private int season_title;

    private int limit_index;

    private int event_sub_group;

    private string control_type;

    private int DB_content_link_id;

    private int first_reward_id_normal;

    private int first_reward_value_normal;

    private int first_reward_id_hard;

    private int first_reward_value_hard;

    private int first_reward_id_extreme;

    private int first_reward_value_extreme;
}
