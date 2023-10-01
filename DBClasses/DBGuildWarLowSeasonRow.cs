public class DBGuildWarLowSeasonRow : ITableRowIndexer
{
    public int Season
    {
        get
        {
            return season;
        }
    }

    public string StartDate
    {
        get
        {
            return start_date;
        }
    }

    public int ApplicationSec
    {
        get
        {
            return application_sec;
        }
    }

    public int MatchingSec
    {
        get
        {
            return matching_sec;
        }
    }

    public int InBattleSec
    {
        get
        {
            return in_battle_sec;
        }
    }

    public int CalculateSec
    {
        get
        {
            return calculate_sec;
        }
    }

    public string BannerImageName
    {
        get
        {
            return banner_image_name;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        season = reader.ReadInt32();
        start_date = reader.ReadString();
        application_sec = reader.ReadInt32();
        matching_sec = reader.ReadInt32();
        in_battle_sec = reader.ReadInt32();
        calculate_sec = reader.ReadInt32();
        banner_image_name = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Season;
    }

    private int season;

    private string start_date;

    private int application_sec;

    private int matching_sec;

    private int in_battle_sec;

    private int calculate_sec;

    private string banner_image_name;
}
