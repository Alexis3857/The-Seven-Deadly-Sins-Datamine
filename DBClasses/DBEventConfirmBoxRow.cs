public class DBEventConfirmBoxRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string BoxId
    {
        get
        {
            return box_id;
        }
    }

    public int BoxScore
    {
        get
        {
            return box_score;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        box_id = reader.ReadString();
        box_score = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string box_id;

    private int box_score;
}