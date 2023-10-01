public class DBGuideRecommendListRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int DataCheck
    {
        get
        {
            return data_check;
        }
    }

    public string Type
    {
        get
        {
            return type;
        }
    }

    public int StageMode
    {
        get
        {
            return stage_mode;
        }
    }

    public int StageSubType
    {
        get
        {
            return stage_sub_type;
        }
    }

    public string StageTypeString
    {
        get
        {
            return stage_type_string.Localize();
        }
    }

    public string RecommendIcon
    {
        get
        {
            return recommend_icon;
        }
    }

    public string StageIcon
    {
        get
        {
            return stage_icon;
        }
    }

    public string StageIconPath
    {
        get
        {
            return stage_icon_path;
        }
    }

    public int RankingIcon
    {
        get
        {
            return ranking_icon;
        }
    }

    public int StageStringDisplayType
    {
        get
        {
            return stage_string_display_type;
        }
    }

    public string StageString
    {
        get
        {
            return stage_string.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        data_check = reader.ReadInt32();
        type = reader.ReadString();
        stage_mode = reader.ReadInt32();
        stage_sub_type = reader.ReadInt32();
        stage_type_string = reader.ReadInt32();
        recommend_icon = reader.ReadString();
        stage_icon = reader.ReadString();
        stage_icon_path = reader.ReadString();
        ranking_icon = reader.ReadInt32();
        stage_string_display_type = reader.ReadInt32();
        stage_string = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int data_check;

    private string type;

    private int stage_mode;

    private int stage_sub_type;

    private int stage_type_string;

    private string recommend_icon;

    private string stage_icon;

    private string stage_icon_path;

    private int ranking_icon;

    private int stage_string_display_type;

    private int stage_string;
}
