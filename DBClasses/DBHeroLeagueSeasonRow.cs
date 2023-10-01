public class DBHeroLeagueSeasonRow : ITableRowIndexer
{
    public int Index
    {
        get
        {
            return index;
        }
    }

    public int Season
    {
        get
        {
            return season;
        }
    }

    public int Week
    {
        get
        {
            return week;
        }
    }

    public string WeekStartDate
    {
        get
        {
            return week_start_date;
        }
    }

    public string WeekLimitedDate
    {
        get
        {
            return week_limited_date;
        }
    }

    public string SeasonTitle
    {
        get
        {
            return season_title.Localize();
        }
    }

    public int SeasonPriceId
    {
        get
        {
            return season_price_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        index = reader.ReadInt32();
        season = reader.ReadInt32();
        week = reader.ReadInt32();
        week_start_date = reader.ReadString();
        week_limited_date = reader.ReadString();
        season_title = reader.ReadInt32();
        season_price_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Index;
    }

    private int index;

    private int season;

    private int week;

    private string week_start_date;

    private string week_limited_date;

    private int season_title;

    private int season_price_id;
}