public class DBGuildWarLeagueSignRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GuildwarType
    {
        get
        {
            return guildwar_type;
        }
    }

    public int Season
    {
        get
        {
            return season;
        }
    }

    public int LeagueType
    {
        get
        {
            return league_type;
        }
    }

    public int LeagueTypeGroup
    {
        get
        {
            return league_type_group;
        }
    }

    public int ApplyItem
    {
        get
        {
            return apply_item;
        }
    }

    public string LeagueName
    {
        get
        {
            return league_name.Localize();
        }
    }

    public string LeagueIcon
    {
        get
        {
            return league_icon;
        }
    }

    public string LeagueColor
    {
        get
        {
            return league_color;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        guildwar_type = reader.ReadInt32();
        season = reader.ReadInt32();
        league_type = reader.ReadInt32();
        league_type_group = reader.ReadInt32();
        apply_item = reader.ReadInt32();
        league_name = reader.ReadInt32();
        league_icon = reader.ReadString();
        league_color = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int guildwar_type;

    private int season;

    private int league_type;

    private int league_type_group;

    private int apply_item;

    private int league_name;

    private string league_icon;

    private string league_color;
}
