public class DBStageWeekBuffRow : ITableRowIndexer
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

    public string StageString
    {
        get
        {
            return stage_string.Localize();
        }
    }

    public int ContetsPassiveId
    {
        get
        {
            return contets_passive_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        stage_type = reader.ReadString();
        stage_string = reader.ReadInt32();
        contets_passive_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string stage_type;

    private int stage_string;

    private int contets_passive_id;
}
