public class DBDailyAttendanceRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string AttendanceType
    {
        get
        {
            return attendance_type;
        }
    }

    public int Group
    {
        get
        {
            return group;
        }
    }

    public int Day
    {
        get
        {
            return day;
        }
    }

    public int ItemId
    {
        get
        {
            return item_id;
        }
    }

    public int ItemCount
    {
        get
        {
            return item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        attendance_type = reader.ReadString();
        group = reader.ReadInt32();
        day = reader.ReadInt32();
        item_id = reader.ReadInt32();
        item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string attendance_type;

    private int group;

    private int day;

    private int item_id;

    private int item_count;
}
