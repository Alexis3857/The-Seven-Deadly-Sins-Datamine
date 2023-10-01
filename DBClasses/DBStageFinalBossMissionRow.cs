public class DBStageFinalBossMissionRow : ITableRowIndexer
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

    public int MissionTypeValue
    {
        get
        {
            return mission_type_value;
        }
    }

    public int LocalizeDisplayType
    {
        get
        {
            return localize_display_type;
        }
    }

    public float MissionRewardValue
    {
        get
        {
            return mission_reward_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        mission_group_id = reader.ReadInt32();
        mission_name = reader.ReadInt32();
        mission_type = reader.ReadString();
        mission_type_value = reader.ReadInt32();
        localize_display_type = reader.ReadInt32();
        mission_reward_value = reader.ReadSingle();
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

    private int mission_type_value;

    private int localize_display_type;

    private float mission_reward_value;
}
