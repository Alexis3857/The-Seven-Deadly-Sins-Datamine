public class DBMonsterBaseRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 705U;
        }
    }

    public int Id
    {
        get
        {
            return base.DecryptInt32(id);
        }
    }

    public byte Kind
    {
        get
        {
            return kind;
        }
    }

    public byte Attribute
    {
        get
        {
            return attribute;
        }
    }

    public byte MonsterClass
    {
        get
        {
            return monster_class;
        }
    }

    public byte MonsterTranscendHp
    {
        get
        {
            return monster_transcend_hp;
        }
    }

    public byte HpVisibleType
    {
        get
        {
            return hp_visible_type;
        }
    }

    public float Atk
    {
        get
        {
            return base.DecryptFloat(atk);
        }
    }

    public float FixedAtkPer
    {
        get
        {
            return base.DecryptFloat(fixed_atk_per);
        }
    }

    public float CritPer
    {
        get
        {
            return base.DecryptFloat(crit_per);
        }
    }

    public float CritAtkPer
    {
        get
        {
            return base.DecryptFloat(crit_atk_per);
        }
    }

    public float Def
    {
        get
        {
            return base.DecryptFloat(def);
        }
    }

    public float FixedDefPer
    {
        get
        {
            return base.DecryptFloat(fixed_def_per);
        }
    }

    public float CritResPer
    {
        get
        {
            return base.DecryptFloat(crit_res_per);
        }
    }

    public float CritDefPer
    {
        get
        {
            return base.DecryptFloat(crit_def_per);
        }
    }

    public float Hp
    {
        get
        {
            return base.DecryptFloat(hp);
        }
    }

    public float HpRegenPer
    {
        get
        {
            return base.DecryptFloat(hp_regen_per);
        }
    }

    public float HpRecoveryPer
    {
        get
        {
            return base.DecryptFloat(hp_recovery_per);
        }
    }

    public float HpStealPer
    {
        get
        {
            return base.DecryptFloat(hp_steal_per);
        }
    }

    public float AtkAdd
    {
        get
        {
            return base.DecryptFloat(atk_add);
        }
    }

    public float DefAdd
    {
        get
        {
            return base.DecryptFloat(def_add);
        }
    }

    public float HpAdd
    {
        get
        {
            return base.DecryptFloat(hp_add);
        }
    }

    public byte CreateSpecialScore
    {
        get
        {
            return create_special_score;
        }
    }

    public List<int> ListArrayPassiveSkillId
    {
        get
        {
            return list_array_passive_skill_id;
        }
    }

    public int MonsterDropId
    {
        get
        {
            return base.DecryptInt32(monster_drop_id);
        }
    }

    public int MonsterGroupId
    {
        get
        {
            return base.DecryptInt32(monster_group_id);
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadBytes(4);
        kind = reader.ReadByte();
        attribute = reader.ReadByte();
        monster_class = reader.ReadByte();
        monster_transcend_hp = reader.ReadByte();
        hp_visible_type = reader.ReadByte();
        atk = reader.ReadBytes(4);
        fixed_atk_per = reader.ReadBytes(4);
        crit_per = reader.ReadBytes(4);
        crit_atk_per = reader.ReadBytes(4);
        def = reader.ReadBytes(4);
        fixed_def_per = reader.ReadBytes(4);
        crit_res_per = reader.ReadBytes(4);
        crit_def_per = reader.ReadBytes(4);
        hp = reader.ReadBytes(4);
        hp_regen_per = reader.ReadBytes(4);
        hp_recovery_per = reader.ReadBytes(4);
        hp_steal_per = reader.ReadBytes(4);
        atk_add = reader.ReadBytes(4);
        def_add = reader.ReadBytes(4);
        hp_add = reader.ReadBytes(4);
        create_special_score = reader.ReadByte();
        int num = reader.ReadInt32();
        list_array_passive_skill_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_passive_skill_id.Add(reader.ReadInt32());
        }
        monster_drop_id = reader.ReadBytes(4);
        monster_group_id = reader.ReadBytes(4);
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private byte[] id;

    private byte kind;

    private byte attribute;

    private byte monster_class;

    private byte monster_transcend_hp;

    private byte hp_visible_type;

    private byte[] atk;

    private byte[] fixed_atk_per;

    private byte[] crit_per;

    private byte[] crit_atk_per;

    private byte[] def;

    private byte[] fixed_def_per;

    private byte[] crit_res_per;

    private byte[] crit_def_per;

    private byte[] hp;

    private byte[] hp_regen_per;

    private byte[] hp_recovery_per;

    private byte[] hp_steal_per;

    private byte[] atk_add;

    private byte[] def_add;

    private byte[] hp_add;

    private byte create_special_score;

    private List<int> list_array_passive_skill_id;

    private byte[] monster_drop_id;

    private byte[] monster_group_id;
}
