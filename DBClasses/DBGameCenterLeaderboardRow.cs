public class DBGameCenterLeaderboardRow : ITableRowIndexer
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

    private string jp_platform_id;

    private string kr_platform_id;

    private string gb_platform_id;
}
