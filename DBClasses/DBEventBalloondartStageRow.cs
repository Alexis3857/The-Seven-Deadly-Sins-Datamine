public class DBEventBalloondartStageRow : ITableRowIndexer
{
    public int Id => id;

    public string StageTitle => stage_title.Localize();

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        stage_title = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int stage_title;
}