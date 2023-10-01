public class DBPatrolScheduleRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int PatrolGroupId
    {
        get
        {
            return patrol_group_id;
        }
    }

    public int PatrolGroupSubId
    {
        get
        {
            return patrol_group_sub_id;
        }
    }

    public int SubGroupRotationTime
    {
        get
        {
            return sub_group_rotation_time;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        patrol_group_id = reader.ReadInt32();
        patrol_group_sub_id = reader.ReadInt32();
        sub_group_rotation_time = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int patrol_group_id;

    private int patrol_group_sub_id;

    private int sub_group_rotation_time;
}
