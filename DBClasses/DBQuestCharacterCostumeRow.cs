public class DBQuestCharacterCostumeRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GuestId
    {
        get
        {
            return guest_id;
        }
    }

    public int UseSubCostume
    {
        get
        {
            return use_sub_costume;
        }
    }

    public int ItemId
    {
        get
        {
            return item_id;
        }
    }

    public int DefaultCheck
    {
        get
        {
            return default_check;
        }
    }

    public string StoryCostumeName
    {
        get
        {
            return story_costume_name.Localize();
        }
    }

    public string IconInfo
    {
        get
        {
            return icon_info;
        }
    }

    public string BlindOpenType
    {
        get
        {
            return blind_open_type;
        }
    }

    public int BlindOpenValue
    {
        get
        {
            return blind_open_value;
        }
    }

    public string OpenType
    {
        get
        {
            return open_type;
        }
    }

    public int OpenValue
    {
        get
        {
            return open_value;
        }
    }

    public int RewardCheck
    {
        get
        {
            return reward_check;
        }
    }

    public string Resource
    {
        get
        {
            return resource;
        }
    }

    public string HeadResource
    {
        get
        {
            return head_resource;
        }
    }

    public string BodyResource
    {
        get
        {
            return body_resource;
        }
    }

    public List<int> ListArrayProp
    {
        get
        {
            return list_array_prop;
        }
    }

    public string IdleAni
    {
        get
        {
            return idle_ani;
        }
    }

    public string WalkAni
    {
        get
        {
            return walk_ani;
        }
    }

    public int BlindOpenState
    {
        get
        {
            return blind_open_state;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        guest_id = reader.ReadInt32();
        use_sub_costume = reader.ReadInt32();
        item_id = reader.ReadInt32();
        default_check = reader.ReadInt32();
        story_costume_name = reader.ReadInt32();
        icon_info = reader.ReadString();
        blind_open_type = reader.ReadString();
        blind_open_value = reader.ReadInt32();
        open_type = reader.ReadString();
        open_value = reader.ReadInt32();
        reward_check = reader.ReadInt32();
        resource = reader.ReadString();
        head_resource = reader.ReadString();
        body_resource = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_prop = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_prop.Add(reader.ReadInt32());
        }
        idle_ani = reader.ReadString();
        walk_ani = reader.ReadString();
        blind_open_state = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int guest_id;

    private int use_sub_costume;

    private int item_id;

    private int default_check;

    private int story_costume_name;

    private string icon_info;

    private string blind_open_type;

    private int blind_open_value;

    private string open_type;

    private int open_value;

    private int reward_check;

    private string resource;

    private string head_resource;

    private string body_resource;

    private List<int> list_array_prop;

    private string idle_ani;

    private string walk_ani;

    private int blind_open_state;
}
