public class DBConstManastoneRandomRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int RandomGroupId
    {
        get
        {
            return random_group_id;
        }
    }

    public int RandomRate
    {
        get
        {
            return random_rate;
        }
    }

    public string StatusType
    {
        get
        {
            return status_type;
        }
    }

    public float StatusMin
    {
        get
        {
            return status_min;
        }
    }

    public float StatusMax
    {
        get
        {
            return status_max;
        }
    }

    public string StoneName
    {
        get
        {
            return stone_name.Localize();
        }
    }

    public string StoneImage
    {
        get
        {
            return stone_image;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        random_group_id = reader.ReadInt32();
        random_rate = reader.ReadInt32();
        status_type = reader.ReadString();
        status_min = reader.ReadSingle();
        status_max = reader.ReadSingle();
        stone_name = reader.ReadInt32();
        stone_image = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int random_group_id;

    private int random_rate;

    private string status_type;

    private float status_min;

    private float status_max;

    private int stone_name;

    private string stone_image;
}
