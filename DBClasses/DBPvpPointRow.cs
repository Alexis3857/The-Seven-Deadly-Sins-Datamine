public class DBPvpPointRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int LeagueType
    {
        get
        {
            return league_type;
        }
    }

    public int RankType
    {
        get
        {
            return rank_type;
        }
    }

    public int RankNum
    {
        get
        {
            return rank_num;
        }
    }

    public int Rating
    {
        get
        {
            return rating;
        }
    }

    public int RealtimeRate
    {
        get
        {
            return realtime_rate;
        }
    }

    public string RatingIcon
    {
        get
        {
            return rating_icon;
        }
    }

    public string RatingName
    {
        get
        {
            return rating_name.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        league_type = reader.ReadInt32();
        rank_type = reader.ReadInt32();
        rank_num = reader.ReadInt32();
        rating = reader.ReadInt32();
        realtime_rate = reader.ReadInt32();
        rating_icon = reader.ReadString();
        rating_name = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int league_type;

    private int rank_type;

    private int rank_num;

    private int rating;

    private int realtime_rate;

    private string rating_icon;

    private int rating_name;
}
