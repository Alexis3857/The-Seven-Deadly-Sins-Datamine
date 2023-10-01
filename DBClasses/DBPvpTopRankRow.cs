public class DBPvpTopRankRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int RankMin
    {
        get
        {
            return rank_min;
        }
    }

    public int RankMax
    {
        get
        {
            return rank_max;
        }
    }

    public string RankerTitle
    {
        get
        {
            return ranker_title.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        rank_min = reader.ReadInt32();
        rank_max = reader.ReadInt32();
        ranker_title = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int rank_min;

    private int rank_max;

    private int ranker_title;
}
