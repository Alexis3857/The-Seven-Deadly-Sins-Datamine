public class DBEventPvpWincountWeekRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public int Week
    {
        get
        {
            return week;
        }
    }

    public string StartTime
    {
        get
        {
            return start_time;
        }
    }

    public string EndTime
    {
        get
        {
            return end_time;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        group_id = reader.ReadInt32();
        week = reader.ReadInt32();
        start_time = reader.ReadString();
        end_time = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int group_id;

    private int week;

    private string start_time;

    private string end_time;
}
