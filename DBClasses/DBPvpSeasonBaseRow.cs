public class DBPvpSeasonBaseRow
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string SeasonStartDate
    {
        get
        {
            return season_start_date;
        }
    }

    public string SeasonLimitedDate
    {
        get
        {
            return season_limited_date;
        }
    }

    public string SeasonPastLimitedDate
    {
        get
        {
            return season_past_limited_date;
        }
    }

    public string SeasonTitle
    {
        get
        {
            return season_title.Localize();
        }
    }

    public string SeasonBannerS
    {
        get
        {
            return season_banner_s;
        }
    }

    public string SeasonBannerSTitle
    {
        get
        {
            return season_banner_s_title.Localize();
        }
    }

    public string SeasonBannerSDesc
    {
        get
        {
            return season_banner_s_desc.Localize();
        }
    }

    public int SeasonRewardGroup
    {
        get
        {
            return season_reward_group;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        season_start_date = reader.ReadString();
        season_limited_date = reader.ReadString();
        season_past_limited_date = reader.ReadString();
        season_title = reader.ReadInt32();
        season_banner_s = reader.ReadString();
        season_banner_s_title = reader.ReadInt32();
        season_banner_s_desc = reader.ReadInt32();
        season_reward_group = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string season_start_date;

    private string season_limited_date;

    private string season_past_limited_date;

    private int season_title;

    private string season_banner_s;

    private int season_banner_s_title;

    private int season_banner_s_desc;

    private int season_reward_group;
}
