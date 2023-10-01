public class DBRecommendTeamRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string Type
    {
        get
        {
            return type;
        }
    }

    public int StageId
    {
        get
        {
            return stage_id;
        }
    }

    public int StageMode
    {
        get
        {
            return stage_mode;
        }
    }

    public int RecommendType
    {
        get
        {
            return recommend_type;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        type = reader.ReadString();
        stage_id = reader.ReadInt32();
        stage_mode = reader.ReadInt32();
        recommend_type = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string type;

    private int stage_id;

    private int stage_mode;

    private int recommend_type;
}
