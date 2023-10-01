public class DBNpcInfoRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string NpcIconInfo
    {
        get
        {
            return npc_icon_info;
        }
    }

    public string DressupSilhouette
    {
        get
        {
            return dressup_silhouette;
        }
    }

    public List<int> ListArrayProp
    {
        get
        {
            return list_array_prop;
        }
    }

    public List<int> ListArrayAttachNpcId
    {
        get
        {
            return list_array_attach_npc_id;
        }
    }

    public List<string> ListArrayAttach
    {
        get
        {
            return list_array_attach;
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

    public string SpecialResource
    {
        get
        {
            return special_resource;
        }
    }

    public string AnimResource
    {
        get
        {
            return anim_resource;
        }
    }

    public string NormalAni
    {
        get
        {
            return normal_ani;
        }
    }

    public string RandomAni
    {
        get
        {
            return random_ani;
        }
    }

    public string WaitAni
    {
        get
        {
            return wait_ani;
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

    public string SequenceStartAni
    {
        get
        {
            return sequence_start_ani;
        }
    }

    public string SequenceStartAddAni1
    {
        get
        {
            return sequence_start_add_ani_1;
        }
    }

    public string SequenceStartAddAni2
    {
        get
        {
            return sequence_start_add_ani_2;
        }
    }

    public string SequenceStartAddAni3
    {
        get
        {
            return sequence_start_add_ani_3;
        }
    }

    public string SequenceEndAni
    {
        get
        {
            return sequence_end_ani;
        }
    }

    public float NpcHeight
    {
        get
        {
            return npc_height;
        }
    }

    public float TransScale
    {
        get
        {
            return trans_scale;
        }
    }

    public string SizeInfo
    {
        get
        {
            return size_info;
        }
    }

    public float ContentRadius
    {
        get
        {
            return content_radius;
        }
    }

    public int PositionId
    {
        get
        {
            return position_id;
        }
    }

    public int LookAt
    {
        get
        {
            return look_at;
        }
    }

    public int ObjectCheck
    {
        get
        {
            return object_check;
        }
    }

    public List<string> ListSequenceStartAddAni
    {
        get
        {
            if (list_sequence_start_add_ani == null)
            {
                list_sequence_start_add_ani = new List<string>
                {
                    SequenceStartAddAni1,
                    SequenceStartAddAni2,
                    SequenceStartAddAni3
                };
            }
            return list_sequence_start_add_ani;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        npc_icon_info = reader.ReadString();
        dressup_silhouette = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_prop = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_prop.Add(reader.ReadInt32());
        }
        int num2 = reader.ReadInt32();
        list_array_attach_npc_id = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_attach_npc_id.Add(reader.ReadInt32());
        }
        int num3 = reader.ReadInt32();
        list_array_attach = new List<string>();
        for (int k = 0; k < num3; k++)
        {
            list_array_attach.Add(reader.ReadString());
        }
        resource = reader.ReadString();
        head_resource = reader.ReadString();
        body_resource = reader.ReadString();
        special_resource = reader.ReadString();
        anim_resource = reader.ReadString();
        normal_ani = reader.ReadString();
        random_ani = reader.ReadString();
        wait_ani = reader.ReadString();
        walk_ani = reader.ReadString();
        run_ani = reader.ReadString();
        sequence_start_ani = reader.ReadString();
        sequence_start_add_ani_1 = reader.ReadString();
        sequence_start_add_ani_2 = reader.ReadString();
        sequence_start_add_ani_3 = reader.ReadString();
        sequence_end_ani = reader.ReadString();
        npc_height = reader.ReadSingle();
        trans_scale = reader.ReadSingle();
        size_info = reader.ReadString();
        content_radius = reader.ReadSingle();
        position_id = reader.ReadInt32();
        look_at = reader.ReadInt32();
        object_check = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string npc_icon_info;

    private string dressup_silhouette;

    private List<int> list_array_prop;

    private List<int> list_array_attach_npc_id;

    private List<string> list_array_attach;

    private string resource;

    private string head_resource;

    private string body_resource;

    private string special_resource;

    private string anim_resource;

    private string normal_ani;

    private string random_ani;

    private string wait_ani;

    private string walk_ani;

    private string run_ani;

    private string sequence_start_ani;

    private string sequence_start_add_ani_1;

    private string sequence_start_add_ani_2;

    private string sequence_start_add_ani_3;

    private string sequence_end_ani;

    private float npc_height;

    private float trans_scale;

    private string size_info;

    private float content_radius;

    private int position_id;

    private int look_at;

    private int object_check;

    private List<string> list_sequence_start_add_ani;
}
