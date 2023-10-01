public class DBHeroLeagueInfoRow : ITableRowIndexer
{
    public int Index
    {
        get
        {
            return index;
        }
    }

    public int LeagueTypeGroup
    {
        get
        {
            return league_type_group;
        }
    }

    public int UserGroup
    {
        get
        {
            return user_group;
        }
    }

    public int UserNickname
    {
        get
        {
            return user_nickname;
        }
    }

    public string TeamSnapshot
    {
        get
        {
            return team_snapshot;
        }
    }

    public int TeamNumber
    {
        get
        {
            return team_number;
        }
    }

    public float Balance
    {
        get
        {
            return balance;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        index = reader.ReadInt32();
        league_type_group = reader.ReadInt32();
        user_group = reader.ReadInt32();
        user_nickname = reader.ReadInt32();
        team_snapshot = reader.ReadString();
        team_number = reader.ReadInt32();
        balance = reader.ReadSingle();
        return true;
    }

    public int GetRowIndex()
    {
        return Index;
    }

    private int index;

    private int league_type_group;

    private int user_group;

    private int user_nickname;

    private string team_snapshot;

    private int team_number;

    private float balance;
}