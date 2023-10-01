public class DBStagePlayCountRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int LimitIndex
    {
        get
        {
            return limit_index;
        }
    }

    public int PlayCount
    {
        get
        {
            return play_count;
        }
    }

    public int ResetdailyCheck
    {
        get
        {
            return resetdaily_check;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        limit_index = reader.ReadInt32();
        play_count = reader.ReadInt32();
        resetdaily_check = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int limit_index;

    private int play_count;

    private int resetdaily_check;
}
