public class DBSkinCostumeResourceRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public float AttackRange
    {
        get
        {
            return attack_range;
        }
    }

    public float MoveSpeed
    {
        get
        {
            return move_speed;
        }
    }

    public float HeroPortrait
    {
        get
        {
            return hero_portrait;
        }
    }

    public float HeroCameraOffsetY
    {
        get
        {
            return hero_camera_offset_y;
        }
    }

    public string CharacterBase
    {
        get
        {
            return character_base;
        }
    }

    public int HeadErrorCheck
    {
        get
        {
            return head_error_check;
        }
    }

    public string ResourceBody
    {
        get
        {
            return resource_body;
        }
    }

    public string ReplaceResourceBody
    {
        get
        {
            return replace_resource_body;
        }
    }

    public int ChangeHead
    {
        get
        {
            return change_head;
        }
    }

    public string ResourceBaseHead
    {
        get
        {
            return resource_base_head;
        }
    }

    public string BaseHeadHelmMixerName
    {
        get
        {
            return base_head_helm_mixer_name;
        }
    }

    public List<int> ListArrayWeaponAttachDummy
    {
        get
        {
            return list_array_weapon_attach_dummy;
        }
    }

    public List<int> ListArrayWeaponCombiAttachDummy
    {
        get
        {
            return list_array_weapon_combi_attach_dummy;
        }
    }

    public string AniDirectoryName
    {
        get
        {
            return ani_directory_name;
        }
    }

    public int EnableSpecialSfx
    {
        get
        {
            return enable_special_sfx;
        }
    }

    public float SfxScale
    {
        get
        {
            return sfx_scale;
        }
    }

    public float ModelScale
    {
        get
        {
            return model_scale;
        }
    }

    public float GachaModelScale
    {
        get
        {
            return gacha_model_scale;
        }
    }

    public string PortraitBase
    {
        get
        {
            return portrait_base;
        }
    }

    public string CheckSize
    {
        get
        {
            return check_size;
        }
    }

    public string VictoryProp
    {
        get
        {
            return victory_prop;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        attack_range = reader.ReadSingle();
        move_speed = reader.ReadSingle();
        hero_portrait = reader.ReadSingle();
        hero_camera_offset_y = reader.ReadSingle();
        character_base = reader.ReadString();
        head_error_check = reader.ReadInt32();
        resource_body = reader.ReadString();
        replace_resource_body = reader.ReadString();
        change_head = reader.ReadInt32();
        resource_base_head = reader.ReadString();
        base_head_helm_mixer_name = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_weapon_attach_dummy = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_weapon_attach_dummy.Add(reader.ReadInt32());
        }
        int num2 = reader.ReadInt32();
        list_array_weapon_combi_attach_dummy = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_weapon_combi_attach_dummy.Add(reader.ReadInt32());
        }
        ani_directory_name = reader.ReadString();
        enable_special_sfx = reader.ReadInt32();
        sfx_scale = reader.ReadSingle();
        model_scale = reader.ReadSingle();
        gacha_model_scale = reader.ReadSingle();
        portrait_base = reader.ReadString();
        check_size = reader.ReadString();
        victory_prop = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private float attack_range;

    private float move_speed;

    private float hero_portrait;

    private float hero_camera_offset_y;

    private string character_base;

    private int head_error_check;

    private string resource_body;

    private string replace_resource_body;

    private int change_head;

    private string resource_base_head;

    private string base_head_helm_mixer_name;

    private List<int> list_array_weapon_attach_dummy;

    private List<int> list_array_weapon_combi_attach_dummy;

    private string ani_directory_name;

    private int enable_special_sfx;

    private float sfx_scale;

    private float model_scale;

    private float gacha_model_scale;

    private string portrait_base;

    private string check_size;

    private string victory_prop;
}
