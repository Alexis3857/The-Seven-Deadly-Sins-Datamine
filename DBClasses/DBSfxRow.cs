public class DBSfxRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int AttachType
    {
        get
        {
            return attach_type;
        }
    }

    public int ForceSfxScale
    {
        get
        {
            return force_sfx_scale;
        }
    }

    public string CreateSocket
    {
        get
        {
            return create_socket;
        }
    }

    public List<int> ListArrayWeaponAttachDummy
    {
        get
        {
            return list_array_weapon_attach_dummy;
        }
    }

    public int SpecialAfterHitType
    {
        get
        {
            return special_after_hit_type;
        }
    }

    public int AttachAniEvent
    {
        get
        {
            return attach_ani_event;
        }
    }

    public string Path
    {
        get
        {
            return path;
        }
    }

    public string Filename
    {
        get
        {
            return filename;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        attach_type = reader.ReadInt32();
        force_sfx_scale = reader.ReadInt32();
        create_socket = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_weapon_attach_dummy = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_weapon_attach_dummy.Add(reader.ReadInt32());
        }
        special_after_hit_type = reader.ReadInt32();
        attach_ani_event = reader.ReadInt32();
        path = reader.ReadString();
        filename = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int attach_type;

    private int force_sfx_scale;

    private string create_socket;

    private List<int> list_array_weapon_attach_dummy;

    private int special_after_hit_type;

    private int attach_ani_event;

    private string path;

    private string filename;
}
