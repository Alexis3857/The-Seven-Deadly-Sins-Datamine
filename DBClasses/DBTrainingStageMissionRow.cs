public class DBTrainingStageMissionRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int MissionGroupId
    {
        get
        {
            return mission_group_id;
        }
    }

    public string MissionName
    {
        get
        {
            return mission_name.Localize();
        }
    }

    public string MissionType
    {
        get
        {
            return mission_type;
        }
    }

    public int MissionValue
    {
        get
        {
            return mission_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        mission_group_id = reader.ReadInt32();
        mission_name = reader.ReadInt32();
        mission_type = reader.ReadString();
        mission_value = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int mission_group_id;

    private int mission_name;

    private string mission_type;

    private int mission_value;
}
