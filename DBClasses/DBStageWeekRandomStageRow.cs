public class DBStageWeekRandomStageRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string RandomStageString
    {
        get
        {
            return random_stage_string.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        random_stage_string = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int random_stage_string;
}
