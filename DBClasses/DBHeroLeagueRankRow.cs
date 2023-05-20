public class DBHeroLeagueRankRow
{
    public int Index
    {
        get
        {
            return index;
        }
    }

    public string HeroLeagueName
    {
        get
        {
            return hero_league_name.Localize();
        }
    }

    public string HeroLeagueIcon
    {
        get
        {
            return hero_league_icon;
        }
    }

    public int HeroLeagueRecommend
    {
        get
        {
            return hero_league_recommend;
        }
    }

    public int FateUse
    {
        get
        {
            return fate_use;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        index = reader.ReadInt32();
        hero_league_name = reader.ReadInt32();
        hero_league_icon = reader.ReadString();
        hero_league_recommend = reader.ReadInt32();
        fate_use = reader.ReadInt32();
        return true;
    }

    private int index;

    private int hero_league_name;

    private string hero_league_icon;

    private int hero_league_recommend;

    private int fate_use;
}