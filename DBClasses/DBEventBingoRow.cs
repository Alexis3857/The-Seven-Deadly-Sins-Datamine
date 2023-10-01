public class DBEventBingoRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int BingoRating
    {
        get
        {
            return bingo_rating;
        }
    }

    public int BingoType
    {
        get
        {
            return bingo_type;
        }
    }

    public int BingoEventType
    {
        get
        {
            return bingo_event_type;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        bingo_rating = reader.ReadInt32();
        bingo_type = reader.ReadInt32();
        bingo_event_type = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int bingo_rating;

    private int bingo_type;

    private int bingo_event_type;
}
