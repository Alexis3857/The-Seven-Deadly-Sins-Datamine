public class DBGuildWarSeasonRow : ITableRowIndexer
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

    public int NonseasonSec
    {
        get
        {
            return nonseason_sec;
        }
    }

    public int SelectionSec
    {
        get
        {
            return selection_sec;
        }
    }

    public int MatchingSec
    {
        get
        {
            return matching_sec;
        }
    }

    public int BattleSettingSec
    {
        get
        {
            return battle_setting_sec;
        }
    }

    public int InBattleSec
    {
        get
        {
            return in_battle_sec;
        }
    }

    public int RankCalculateSec
    {
        get
        {
            return rank_calculate_Sec;
        }
    }

    public string BannerImageName
    {
        get
        {
            return banner_image_name;
        }
    }

    public int BannerOpenSec
    {
        get
        {
            return banner_open_sec;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        season = reader.ReadInt32();
        start_date = reader.ReadString();
        nonseason_sec = reader.ReadInt32();
        selection_sec = reader.ReadInt32();
        matching_sec = reader.ReadInt32();
        battle_setting_sec = reader.ReadInt32();
        in_battle_sec = reader.ReadInt32();
        rank_calculate_Sec = reader.ReadInt32();
        banner_image_name = reader.ReadString();
        banner_open_sec = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Season;
    }

    private int season;

    private string start_date;

    private int nonseason_sec;

    private int selection_sec;

    private int matching_sec;

    private int battle_setting_sec;

    private int in_battle_sec;

    private int rank_calculate_Sec;

    private string banner_image_name;

    private int banner_open_sec;
}
