public class DBConstellationStoneRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ConstellationGroupId
    {
        get
        {
            return constellation_group_id;
        }
    }

    public int StoneType
    {
        get
        {
            return stone_type;
        }
    }

    public int MotherLinkId
    {
        get
        {
            return mother_link_id;
        }
    }

    public List<int> ListArrayChildLinkId
    {
        get
        {
            return list_array_child_link_id;
        }
    }

    public int GrowthPoint
    {
        get
        {
            return growth_point;
        }
    }

    public string StatusType
    {
        get
        {
            return status_type;
        }
    }

    public float StatusValue
    {
        get
        {
            return status_value;
        }
    }

    public int RandomGroupId
    {
        get
        {
            return random_group_id;
        }
    }

    public string StoneName
    {
        get
        {
            return stone_name.Localize();
        }
    }

    public string StoneDesc
    {
        get
        {
            return stone_desc.Localize();
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
        constellation_group_id = reader.ReadInt32();
        stone_type = reader.ReadInt32();
        mother_link_id = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_child_link_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_child_link_id.Add(reader.ReadInt32());
        }
        growth_point = reader.ReadInt32();
        status_type = reader.ReadString();
        status_value = reader.ReadSingle();
        random_group_id = reader.ReadInt32();
        stone_name = reader.ReadInt32();
        stone_desc = reader.ReadInt32();
        stone_image = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int constellation_group_id;

    private int stone_type;

    private int mother_link_id;

    private List<int> list_array_child_link_id;

    private int growth_point;

    private string status_type;

    private float status_value;

    private int random_group_id;

    private int stone_name;

    private int stone_desc;

    private string stone_image;
}
