public class DBGuildBossHellMissionRow : ITableRowIndexer
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

    public int MissionGroup
    {
        get
        {
            return mission_group;
        }
    }

    public int MissionIndex
    {
        get
        {
            return mission_index;
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
        season_id = reader.ReadInt32();
        group_id = reader.ReadInt32();
        stage_id = reader.ReadInt32();
        mission_group = reader.ReadInt32();
        mission_index = reader.ReadInt32();
        mission_type = reader.ReadString();
        mission_type_value = reader.ReadInt32();
        mission_target_value = reader.ReadInt32();
        localize_display_type = reader.ReadInt32();
        mission_name = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int season_id;

    private int group_id;

    private int stage_id;

    private int mission_group;

    private int mission_index;

    private string mission_type;

    private int mission_type_value;

    private int mission_target_value;

    private int localize_display_type;

    private int mission_name;
}
