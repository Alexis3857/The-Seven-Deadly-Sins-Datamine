public class DBRegionRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int TimeSlot
    {
        get
        {
            return time_slot;
        }
    }

    public string RegionType
    {
        get
        {
            return region_type;
        }
    }

    public int GrimOpenState
    {
        get
        {
            return grim_open_state;
        }
    }

    public int BoarhatType
    {
        get
        {
            return boarhat_type;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        time_slot = reader.ReadInt32();
        region_type = reader.ReadString();
        grim_open_state = reader.ReadInt32();
        boarhat_type = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int time_slot;

    private string region_type;

    private int grim_open_state;

    private int boarhat_type;
}
