public class DBPvpWinStreakPointRow : ITableRowIndexer
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

    public int WinStreakMin
    {
        get
        {
            return win_streak_min;
        }
    }

    public int WinStreakMax
    {
        get
        {
            return win_streak_max;
        }
    }

    public int BonusValue
    {
        get
        {
            return bonus_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        league_type = reader.ReadInt32();
        win_streak_min = reader.ReadInt32();
        win_streak_max = reader.ReadInt32();
        bonus_value = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int league_type;

    private int win_streak_min;

    private int win_streak_max;

    private int bonus_value;
}
