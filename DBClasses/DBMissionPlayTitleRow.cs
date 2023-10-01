public class DBMissionPlayTitleRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int Category
    {
        get
        {
            return category;
        }
    }

    public string MissionType
    {
        get
        {
            return mission_type;
        }
    }

    public int MissionTypeValue
    {
        get
        {
            return mission_type_value;
        }
    }

    public int MissionTargetValue
    {
        get
        {
            return mission_target_value;
        }
    }

    public string RewardTitle
    {
        get
        {
            return reward_title.Localize();
        }
    }

    public int TitleDescDisplayType
    {
        get
        {
            return title_desc_display_type;
        }
    }

    public int TitleHintDisplayType
    {
        get
        {
            return title_hint_display_type;
        }
    }

    public string TitleDesc
    {
        get
        {
            return title_desc.Localize();
        }
    }

    public string TitleHint
    {
        get
        {
            return title_hint.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        category = reader.ReadInt32();
        mission_type = reader.ReadString();
        mission_type_value = reader.ReadInt32();
        mission_target_value = reader.ReadInt32();
        reward_title = reader.ReadInt32();
        title_desc_display_type = reader.ReadInt32();
        title_hint_display_type = reader.ReadInt32();
        title_desc = reader.ReadInt32();
        title_hint = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int category;

    private string mission_type;

    private int mission_type_value;

    private int mission_target_value;

    private int reward_title;

    private int title_desc_display_type;

    private int title_hint_display_type;

    private int title_desc;

    private int title_hint;
}
