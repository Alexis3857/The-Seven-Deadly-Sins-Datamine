public class DBEventConfirmScoreRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ScoreOrder
    {
        get
        {
            return score_order;
        }
    }

    public int ScoreRequire
    {
        get
        {
            return score_require;
        }
    }

    public int ScoreItemId
    {
        get
        {
            return score_item_id;
        }
    }

    public int ScoreItemCount
    {
        get
        {
            return score_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        score_order = reader.ReadInt32();
        score_require = reader.ReadInt32();
        score_item_id = reader.ReadInt32();
        score_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int score_order;

    private int score_require;

    private int score_item_id;

    private int score_item_count;
}