public class DBStageGlobalTypeRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string StageType
    {
        get
        {
            return stage_type;
        }
    }

    public string StageName
    {
        get
        {
            return stage_name.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        stage_type = reader.ReadString();
        stage_name = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string stage_type;

    private int stage_name;
}
