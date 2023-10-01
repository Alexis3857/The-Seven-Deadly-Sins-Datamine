public class DBStageNpcBaseRow : ITableRowIndexer
{
    public int NpcId
    {
        get
        {
            return npc_id;
        }
    }

    public int SkinId
    {
        get
        {
            return skin_id;
        }
    }

    public int ExclusiveCondition
    {
        get
        {
            return exclusive_condition;
        }
    }

    public int Level
    {
        get
        {
            return level;
        }
    }

    public int MaxLevel
    {
        get
        {
            return max_level;
        }
    }

    public byte SpecialSkillLevel
    {
        get
        {
            return special_skill_level;
        }
    }

    public int WeaponCostumeId
    {
        get
        {
            return weapon_costume_id;
        }
    }

    public int SkinCostumeId
    {
        get
        {
            return skin_costume_id;
        }
    }

    public int HeadCostumeId
    {
        get
        {
            return head_costume_id;
        }
    }

    public string NpcIcon
    {
        get
        {
            return npc_icon;
        }
    }

    public string NpcNickname
    {
        get
        {
            return npc_nickname.Localize();
        }
    }

    public string ItemName
    {
        get
        {
            return item_name.Localize();
        }
    }

    public int CostumeRating
    {
        get
        {
            return costume_rating;
        }
    }

    public int Role
    {
        get
        {
            return role;
        }
    }

    public int Attribute
    {
        get
        {
            return attribute;
        }
    }

    public float AtkIncPer
    {
        get
        {
            return atk_inc_per;
        }
    }

    public float DefIncPer
    {
        get
        {
            return def_inc_per;
        }
    }

    public float HpIncPer
    {
        get
        {
            return hp_inc_per;
        }
    }

    public float Atk
    {
        get
        {
            return atk;
        }
    }

    public float FixedAtkPer
    {
        get
        {
            return fixed_atk_per;
        }
    }

    public float CritPer
    {
        get
        {
            return crit_per;
        }
    }

    public float CritAtkPer
    {
        get
        {
            return crit_atk_per;
        }
    }

    public float Def
    {
        get
        {
            return def;
        }
    }

    public float FixedDefPer
    {
        get
        {
            return fixed_def_per;
        }
    }

    public float CritResPer
    {
        get
        {
            return crit_res_per;
        }
    }

    public float CritDefPer
    {
        get
        {
            return crit_def_per;
        }
    }

    public float Hp
    {
        get
        {
            return hp;
        }
    }

    public float HpRegenPer
    {
        get
        {
            return hp_regen_per;
        }
    }

    public float HpRecoveryPer
    {
        get
        {
            return hp_recovery_per;
        }
    }

    public float HpStealPer
    {
        get
        {
            return hp_steal_per;
        }
    }

    public float AtkAdd
    {
        get
        {
            return atk_add;
        }
    }

    public float DefAdd
    {
        get
        {
            return def_add;
        }
    }

    public float HpAdd
    {
        get
        {
            return hp_add;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        npc_id = reader.ReadInt32();
        skin_id = reader.ReadInt32();
        exclusive_condition = reader.ReadInt32();
        level = reader.ReadInt32();
        max_level = reader.ReadInt32();
        special_skill_level = reader.ReadByte();
        weapon_costume_id = reader.ReadInt32();
        skin_costume_id = reader.ReadInt32();
        head_costume_id = reader.ReadInt32();
        npc_icon = reader.ReadString();
        npc_nickname = reader.ReadInt32();
        item_name = reader.ReadInt32();
        costume_rating = reader.ReadInt32();
        role = reader.ReadInt32();
        attribute = reader.ReadInt32();
        atk_inc_per = reader.ReadSingle();
        def_inc_per = reader.ReadSingle();
        hp_inc_per = reader.ReadSingle();
        atk = reader.ReadSingle();
        fixed_atk_per = reader.ReadSingle();
        crit_per = reader.ReadSingle();
        crit_atk_per = reader.ReadSingle();
        def = reader.ReadSingle();
        fixed_def_per = reader.ReadSingle();
        crit_res_per = reader.ReadSingle();
        crit_def_per = reader.ReadSingle();
        hp = reader.ReadSingle();
        hp_regen_per = reader.ReadSingle();
        hp_recovery_per = reader.ReadSingle();
        hp_steal_per = reader.ReadSingle();
        atk_add = reader.ReadSingle();
        def_add = reader.ReadSingle();
        hp_add = reader.ReadSingle();
        return true;
    }

    public int GetRowIndex()
    {
        return NpcId;
    }

    private int npc_id;

    private int skin_id;

    private int exclusive_condition;

    private int level;

    private int max_level;

    private byte special_skill_level;

    private int weapon_costume_id;

    private int skin_costume_id;

    private int head_costume_id;

    private string npc_icon;

    private int npc_nickname;

    private int item_name;

    private int costume_rating;

    private int role;

    private int attribute;

    private float atk_inc_per;

    private float def_inc_per;

    private float hp_inc_per;

    private float atk;

    private float fixed_atk_per;

    private float crit_per;

    private float crit_atk_per;

    private float def;

    private float fixed_def_per;

    private float crit_res_per;

    private float crit_def_per;

    private float hp;

    private float hp_regen_per;

    private float hp_recovery_per;

    private float hp_steal_per;

    private float atk_add;

    private float def_add;

    private float hp_add;
}
