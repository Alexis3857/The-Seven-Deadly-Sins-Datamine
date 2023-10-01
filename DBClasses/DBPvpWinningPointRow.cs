public class DBPvpWinningPointRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string WinningType
    {
        get
        {
            return winning_type;
        }
    }

    public int BattlePointMin
    {
        get
        {
            return battle_point_min;
        }
    }

    public int BattlePointMax
    {
        get
        {
            return battle_point_max;
        }
    }

    public int AddBattlePoint
    {
        get
        {
            return add_battle_point;
        }
    }

    public int BronzeBattlePoint
    {
        get
        {
            return bronze_battle_point;
        }
    }

    public int SilverBattlePoint
    {
        get
        {
            return silver_battle_point;
        }
    }

    public int ChallengerBattlePoint
    {
        get
        {
            return challenger_battle_point;
        }
    }

    public int Top100AtkBattlePoint
    {
        get
        {
            return top100_atk_battle_point;
        }
    }

    public int Top100DefBattlePoint
    {
        get
        {
            return top100_def_battle_point;
        }
    }

    public int ChallengerWinSeasonPoint
    {
        get
        {
            return challenger_win_season_point;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        winning_type = reader.ReadString();
        battle_point_min = reader.ReadInt32();
        battle_point_max = reader.ReadInt32();
        add_battle_point = reader.ReadInt32();
        bronze_battle_point = reader.ReadInt32();
        silver_battle_point = reader.ReadInt32();
        challenger_battle_point = reader.ReadInt32();
        top100_atk_battle_point = reader.ReadInt32();
        top100_def_battle_point = reader.ReadInt32();
        challenger_win_season_point = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string winning_type;

    private int battle_point_min;

    private int battle_point_max;

    private int add_battle_point;

    private int bronze_battle_point;

    private int silver_battle_point;

    private int challenger_battle_point;

    private int top100_atk_battle_point;

    private int top100_def_battle_point;

    private int challenger_win_season_point;
}
