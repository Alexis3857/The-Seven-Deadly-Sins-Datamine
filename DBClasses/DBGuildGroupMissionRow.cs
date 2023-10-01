public class DBGuildGroupMissionRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string MissionType
    {
        get
        {
            return mission_type;
        }
    }

    public int MissionTypeValue
    {
        get
        {
            return mission_type_value;
        }
    }

    public int MissionTargetValue
    {
        get
        {
            return mission_target_value;
        }
    }

    public int AlarmType
    {
        get
        {
            return alarm_type;
        }
    }

    public string MissionDesc
    {
        get
        {
            return mission_desc.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        mission_type = reader.ReadString();
        mission_type_value = reader.ReadInt32();
        mission_target_value = reader.ReadInt32();
        alarm_type = reader.ReadInt32();
        mission_desc = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string mission_type;

    private int mission_type_value;

    private int mission_target_value;

    private int alarm_type;

    private int mission_desc;
}
