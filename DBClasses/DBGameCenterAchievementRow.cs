public class DBGameCenterAchievementRow : ITableRowIndexer
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

    public int TargetValue
    {
        get
        {
            return target_value;
        }
    }

    public string JpPlatformId
    {
        get
        {
            return jp_platform_id;
        }
    }

    public string KrPlatformId
    {
        get
        {
            return kr_platform_id;
        }
    }

    public string GbPlatformId
    {
        get
        {
            return gb_platform_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        mission_type = reader.ReadString();
        target_value = reader.ReadInt32();
        jp_platform_id = reader.ReadString();
        kr_platform_id = reader.ReadString();
        gb_platform_id = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string mission_type;

    private int target_value;

    private string jp_platform_id;

    private string kr_platform_id;

    private string gb_platform_id;
}
