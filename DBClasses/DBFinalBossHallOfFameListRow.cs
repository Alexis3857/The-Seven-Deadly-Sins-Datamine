public class DBFinalBossHallOfFameListRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int SeasonId
    {
        get
        {
            return season_id;
        }
    }

    public int ItemId
    {
        get
        {
            return item_id;
        }
    }

    public string BossName
    {
        get
        {
            return boss_name.Localize();
        }
    }

    public int UseCheck
    {
        get
        {
            return use_check;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        season_id = reader.ReadInt32();
        item_id = reader.ReadInt32();
        boss_name = reader.ReadInt32();
        use_check = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int season_id;

    private int item_id;

    private int boss_name;

    private int use_check;
}
