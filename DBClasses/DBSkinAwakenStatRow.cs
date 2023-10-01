public class DBSkinAwakenStatRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int HeroId
    {
        get
        {
            return hero_id;
        }
    }

    public int SkinRating
    {
        get
        {
            return skin_rating;
        }
    }

    public int SkinAwakenCount
    {
        get
        {
            return skin_awaken_count;
        }
    }

    public float AwakenAddAtk
    {
        get
        {
            return awaken_add_atk;
        }
    }

    public float AwakenAddFixedAtkPer
    {
        get
        {
            return awaken_add_fixed_atk_per;
        }
    }

    public float AwakenAddCritPer
    {
        get
        {
            return awaken_add_crit_per;
        }
    }

    public float AwakenAddCritAtkPer
    {
        get
        {
            return awaken_add_crit_atk_per;
        }
    }

    public float AwakenAddDef
    {
        get
        {
            return awaken_add_def;
        }
    }

    public float AwakenAddFixedDefPer
    {
        get
        {
            return awaken_add_fixed_def_per;
        }
    }

    public float AwakenAddCritResPer
    {
        get
        {
            return awaken_add_crit_res_per;
        }
    }

    public float AwakenAddCritDefPer
    {
        get
        {
            return awaken_add_crit_def_per;
        }
    }

    public float AwakenAddHp
    {
        get
        {
            return awaken_add_hp;
        }
    }

    public float AwakenAddHpRegenPer
    {
        get
        {
            return awaken_add_hp_regen_per;
        }
    }

    public float AwakenAddHpRecoveryPer
    {
        get
        {
            return awaken_add_hp_recovery_per;
        }
    }

    public float AwakenAddHpStealPer
    {
        get
        {
            return awaken_add_hp_steal_per;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        hero_id = reader.ReadInt32();
        skin_rating = reader.ReadInt32();
        skin_awaken_count = reader.ReadInt32();
        awaken_add_atk = reader.ReadSingle();
        awaken_add_fixed_atk_per = reader.ReadSingle();
        awaken_add_crit_per = reader.ReadSingle();
        awaken_add_crit_atk_per = reader.ReadSingle();
        awaken_add_def = reader.ReadSingle();
        awaken_add_fixed_def_per = reader.ReadSingle();
        awaken_add_crit_res_per = reader.ReadSingle();
        awaken_add_crit_def_per = reader.ReadSingle();
        awaken_add_hp = reader.ReadSingle();
        awaken_add_hp_regen_per = reader.ReadSingle();
        awaken_add_hp_recovery_per = reader.ReadSingle();
        awaken_add_hp_steal_per = reader.ReadSingle();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int hero_id;

    private int skin_rating;

    private int skin_awaken_count;

    private float awaken_add_atk;

    private float awaken_add_fixed_atk_per;

    private float awaken_add_crit_per;

    private float awaken_add_crit_atk_per;

    private float awaken_add_def;

    private float awaken_add_fixed_def_per;

    private float awaken_add_crit_res_per;

    private float awaken_add_crit_def_per;

    private float awaken_add_hp;

    private float awaken_add_hp_regen_per;

    private float awaken_add_hp_recovery_per;

    private float awaken_add_hp_steal_per;
}
