public class DBMazeReplayBonusRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ClearBonusFloor
    {
        get
        {
            return clear_bonus_floor;
        }
    }

    public int BonusType
    {
        get
        {
            return bonus_type;
        }
    }

    public int LevelPoint
    {
        get
        {
            return level_point;
        }
    }

    public int SpecialPoint
    {
        get
        {
            return special_point;
        }
    }

    public int AwakenPoint
    {
        get
        {
            return awaken_point;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        clear_bonus_floor = reader.ReadInt32();
        bonus_type = reader.ReadInt32();
        level_point = reader.ReadInt32();
        special_point = reader.ReadInt32();
        awaken_point = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int clear_bonus_floor;

    private int bonus_type;

    private int level_point;

    private int special_point;

    private int awaken_point;
}