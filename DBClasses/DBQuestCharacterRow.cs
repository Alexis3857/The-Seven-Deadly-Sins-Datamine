public class DBQuestCharacterRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int DefaultCharacter
    {
        get
        {
            return default_character;
        }
    }

    public int GuestId
    {
        get
        {
            return guest_id;
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

    public string CloseType
    {
        get
        {
            return close_type;
        }
    }

    public int CloseValue
    {
        get
        {
            return close_value;
        }
    }

    public string Contents
    {
        get
        {
            return contents;
        }
    }

    public int ChangeContentsId
    {
        get
        {
            return change_contents_id;
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

    public string RandomIdleAni
    {
        get
        {
            return random_idle_ani;
        }
    }

    public string WalkAni
    {
        get
        {
            return walk_ani;
        }
    }

    public string RunAni
    {
        get
        {
            return run_ani;
        }
    }

    public string DestroyAni
    {
        get
        {
            return destroy_ani;
        }
    }

    public string SpecialAni
    {
        get
        {
            return special_ani;
        }
    }

    public string SpecialEndAni
    {
        get
        {
            return special_end_ani;
        }
    }

    public float RunRadius
    {
        get
        {
            return run_radius;
        }
    }

    public float WalkSpeed
    {
        get
        {
            return walk_speed;
        }
    }

    public float RunSpeed
    {
        get
        {
            return run_speed;
        }
    }

    public string Attach
    {
        get
        {
            return attach;
        }
    }

    public int ShadowState
    {
        get
        {
            return shadow_state;
        }
    }

    public int GlowState
    {
        get
        {
            return glow_state;
        }
    }

    public float TransScale
    {
        get
        {
            return trans_scale;
        }
    }

    public int LookAtState
    {
        get
        {
            return look_at_state;
        }
    }

    public List<float> ListArrayControllerVal
    {
        get
        {
            return list_array_controller_val;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        default_character = reader.ReadInt32();
        guest_id = reader.ReadInt32();
        open_type = reader.ReadString();
        open_value = reader.ReadInt32();
        close_type = reader.ReadString();
        close_value = reader.ReadInt32();
        contents = reader.ReadString();
        change_contents_id = reader.ReadInt32();
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
        random_idle_ani = reader.ReadString();
        walk_ani = reader.ReadString();
        run_ani = reader.ReadString();
        destroy_ani = reader.ReadString();
        special_ani = reader.ReadString();
        special_end_ani = reader.ReadString();
        run_radius = reader.ReadSingle();
        walk_speed = reader.ReadSingle();
        run_speed = reader.ReadSingle();
        attach = reader.ReadString();
        shadow_state = reader.ReadInt32();
        glow_state = reader.ReadInt32();
        trans_scale = reader.ReadSingle();
        look_at_state = reader.ReadInt32();
        int num2 = reader.ReadInt32();
        list_array_controller_val = new List<float>();
        for (int j = 0; j < num2; j++)
        {
            list_array_controller_val.Add(reader.ReadSingle());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int default_character;

    private int guest_id;

    private string open_type;

    private int open_value;

    private string close_type;

    private int close_value;

    private string contents;

    private int change_contents_id;

    private string resource;

    private string head_resource;

    private string body_resource;

    private List<int> list_array_prop;

    private string idle_ani;

    private string random_idle_ani;

    private string walk_ani;

    private string run_ani;

    private string destroy_ani;

    private string special_ani;

    private string special_end_ani;

    private float run_radius;

    private float walk_speed;

    private float run_speed;

    private string attach;

    private int shadow_state;

    private int glow_state;

    private float trans_scale;

    private int look_at_state;

    private List<float> list_array_controller_val;
}
