public class DBEventBossMissionRow : ITableRowIndexer
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

    public int StageId
    {
        get
        {
            return stage_id;
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

    public int EventPointId
    {
        get
        {
            return event_point_id;
        }
    }

    public int EventPointCount
    {
        get
        {
            return event_point_count;
        }
    }

    public int LocalizeDisplayType
    {
        get
        {
            return localize_display_type;
        }
    }

    public string MissionName
    {
        get
        {
            return mission_name.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        group_id = reader.ReadInt32();
        stage_id = reader.ReadInt32();
        mission_type = reader.ReadString();
        mission_type_value = reader.ReadInt32();
        mission_target_value = reader.ReadInt32();
        event_point_id = reader.ReadInt32();
        event_point_count = reader.ReadInt32();
        localize_display_type = reader.ReadInt32();
        mission_name = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int group_id;

    private int stage_id;

    private string mission_type;

    private int mission_type_value;

    private int mission_target_value;

    private int event_point_id;

    private int event_point_count;

    private int localize_display_type;

    private int mission_name;
}
