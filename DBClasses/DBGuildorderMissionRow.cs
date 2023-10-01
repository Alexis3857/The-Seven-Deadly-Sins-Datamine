public class DBGuildorderMissionRow : ITableRowIndexer
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

    public string MissionName
    {
        get
        {
            return mission_name.Localize();
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

    public int RewardIap
    {
        get
        {
            return reward_iap;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        mission_type = reader.ReadString();
        mission_name = reader.ReadInt32();
        mission_type_value = reader.ReadInt32();
        mission_target_value = reader.ReadInt32();
        reward_iap = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string mission_type;

    private int mission_name;

    private int mission_type_value;

    private int mission_target_value;

    private int reward_iap;
}