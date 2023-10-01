public class DBHeroLeagueBuffRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string StartDate
    {
        get
        {
            return start_date;
        }
    }

    public string LimitedDate
    {
        get
        {
            return limited_date;
        }
    }

    public int SpecialBuffPassiveId
    {
        get
        {
            return special_buff_passive_id;
        }
    }

    public int SeasonBuffPassiveId
    {
        get
        {
            return season_buff_passive_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        start_date = reader.ReadString();
        limited_date = reader.ReadString();
        special_buff_passive_id = reader.ReadInt32();
        season_buff_passive_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string start_date;

    private string limited_date;

    private int special_buff_passive_id;

    private int season_buff_passive_id;
}