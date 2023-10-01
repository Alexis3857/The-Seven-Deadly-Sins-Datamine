public class DBMonsterResourceRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 592U;
        }
    }

    public int Id
    {
        get
        {
            return base.DecryptInt32(id);
        }
    }

    public byte CheckSize
    {
        get
        {
            return check_size;
        }
    }

    public string HelmMixerName
    {
        get
        {
            return helm_mixer_name;
        }
    }

    public float AttackRange
    {
        get
        {
            return base.DecryptFloat(attack_range);
        }
    }

    public string CharacterBase
    {
        get
        {
            return character_base;
        }
    }

    public string ResourceHead
    {
        get
        {
            return resource_head;
        }
    }

    public string ResourceBody
    {
        get
        {
            return resource_body;
        }
    }

    public byte WeaponModelType
    {
        get
        {
            return weapon_model_type;
        }
    }

    public string ResourceWeapon
    {
        get
        {
            return resource_weapon;
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

    public float MoveSpeed
    {
        get
        {
            return base.DecryptFloat(move_speed);
        }
    }

    public float ModelScale
    {
        get
        {
            return base.DecryptFloat(model_scale);
        }
    }

    public float SfxScale
    {
        get
        {
            return base.DecryptFloat(sfx_scale);
        }
    }

    public int EnableSpecialSfx
    {
        get
        {
            return base.DecryptInt32(enable_special_sfx);
        }
    }

    public string PotraitBase
    {
        get
        {
            return potrait_base;
        }
    }

    public int LoopIdleSfx
    {
        get
        {
            return base.DecryptInt32(loop_idle_sfx);
        }
    }

    public int DynamicLoadSfx
    {
        get
        {
            return base.DecryptInt32(dynamic_load_sfx);
        }
    }

    public float MonsterInfoLocationZ
    {
        get
        {
            return base.DecryptFloat(monster_info_location_z);
        }
    }

    public float MonsterInfoLocationY
    {
        get
        {
            return base.DecryptFloat(monster_info_location_y);
        }
    }

    public float MonsterInfoLocationX
    {
        get
        {
            return base.DecryptFloat(monster_info_location_x);
        }
    }

    public int DieDynamicShaderColor
    {
        get
        {
            return base.DecryptInt32(die_dynamic_shader_color);
        }
    }

    public int TagSystemEffectId
    {
        get
        {
            return base.DecryptInt32(tag_system_effect_id);
        }
    }

    public int CharacterControllerOffsetX
    {
        get
        {
            return base.DecryptInt32(character_controller_offset_x);
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadBytes(4);
        check_size = reader.ReadByte();
        helm_mixer_name = reader.ReadString();
        attack_range = reader.ReadBytes(4);
        character_base = reader.ReadString();
        resource_head = reader.ReadString();
        resource_body = reader.ReadString();
        weapon_model_type = reader.ReadByte();
        resource_weapon = reader.ReadString();
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
        move_speed = reader.ReadBytes(4);
        model_scale = reader.ReadBytes(4);
        sfx_scale = reader.ReadBytes(4);
        enable_special_sfx = reader.ReadBytes(4);
        potrait_base = reader.ReadString();
        loop_idle_sfx = reader.ReadBytes(4);
        dynamic_load_sfx = reader.ReadBytes(4);
        monster_info_location_z = reader.ReadBytes(4);
        monster_info_location_y = reader.ReadBytes(4);
        monster_info_location_x = reader.ReadBytes(4);
        die_dynamic_shader_color = reader.ReadBytes(4);
        tag_system_effect_id = reader.ReadBytes(4);
        character_controller_offset_x = reader.ReadBytes(4);
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private byte[] id;

    private byte check_size;

    private string helm_mixer_name;

    private byte[] attack_range;

    private string character_base;

    private string resource_head;

    private string resource_body;

    private byte weapon_model_type;

    private string resource_weapon;

    private List<int> list_array_weapon_attach_dummy;

    private List<int> list_array_weapon_combi_attach_dummy;

    private string ani_directory_name;

    private byte[] move_speed;

    private byte[] model_scale;

    private byte[] sfx_scale;

    private byte[] enable_special_sfx;

    private string potrait_base;

    private byte[] loop_idle_sfx;

    private byte[] dynamic_load_sfx;

    private byte[] monster_info_location_z;

    private byte[] monster_info_location_y;

    private byte[] monster_info_location_x;

    private byte[] die_dynamic_shader_color;

    private byte[] tag_system_effect_id;

    private byte[] character_controller_offset_x;
}
