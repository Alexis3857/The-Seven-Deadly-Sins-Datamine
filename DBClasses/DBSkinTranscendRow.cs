public class DBSkinTranscendRow : ITableRowIndexer
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

    public int TranscendLevel
    {
        get
        {
            return transcend_level;
        }
    }

    public int TranscendGauge
    {
        get
        {
            return transcend_gauge;
        }
    }

    public int AddTranscendGauge
    {
        get
        {
            return add_transcend_gauge;
        }
    }

    public List<string> ListArrayItemType
    {
        get
        {
            return list_array_item_type;
        }
    }

    public int ResetReturnItemId
    {
        get
        {
            return reset_return_item_id;
        }
    }

    public int ResetReturnItemCount
    {
        get
        {
            return reset_return_item_count;
        }
    }

    public int TranscendPriceId
    {
        get
        {
            return transcend_price_id;
        }
    }

    public int TranscendPriceCount
    {
        get
        {
            return transcend_price_count;
        }
    }

    public float TranscendAddAtk
    {
        get
        {
            return transcend_add_atk;
        }
    }

    public float TranscendAddFixedAtkPer
    {
        get
        {
            return transcend_add_fixed_atk_per;
        }
    }

    public float TranscendAddCritPer
    {
        get
        {
            return transcend_add_crit_per;
        }
    }

    public float TranscendAddCritAtkPer
    {
        get
        {
            return transcend_add_crit_atk_per;
        }
    }

    public float TranscendAddDef
    {
        get
        {
            return transcend_add_def;
        }
    }

    public float TranscendAddFixedDefPer
    {
        get
        {
            return transcend_add_fixed_def_per;
        }
    }

    public float TranscendAddCritResPer
    {
        get
        {
            return transcend_add_crit_res_per;
        }
    }

    public float TranscendAddCritDefPer
    {
        get
        {
            return transcend_add_crit_def_per;
        }
    }

    public float TranscendAddHp
    {
        get
        {
            return transcend_add_hp;
        }
    }

    public float TranscendAddHpRegenPer
    {
        get
        {
            return transcend_add_hp_regen_per;
        }
    }

    public float TranscendAddHpRecoveryPer
    {
        get
        {
            return transcend_add_hp_recovery_per;
        }
    }

    public float TranscendAddHpStealPer
    {
        get
        {
            return transcend_add_hp_steal_per;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        hero_id = reader.ReadInt32();
        transcend_level = reader.ReadInt32();
        transcend_gauge = reader.ReadInt32();
        add_transcend_gauge = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_item_type = new List<string>();
        for (int i = 0; i < num; i++)
        {
            list_array_item_type.Add(reader.ReadString());
        }
        reset_return_item_id = reader.ReadInt32();
        reset_return_item_count = reader.ReadInt32();
        transcend_price_id = reader.ReadInt32();
        transcend_price_count = reader.ReadInt32();
        transcend_add_atk = reader.ReadSingle();
        transcend_add_fixed_atk_per = reader.ReadSingle();
        transcend_add_crit_per = reader.ReadSingle();
        transcend_add_crit_atk_per = reader.ReadSingle();
        transcend_add_def = reader.ReadSingle();
        transcend_add_fixed_def_per = reader.ReadSingle();
        transcend_add_crit_res_per = reader.ReadSingle();
        transcend_add_crit_def_per = reader.ReadSingle();
        transcend_add_hp = reader.ReadSingle();
        transcend_add_hp_regen_per = reader.ReadSingle();
        transcend_add_hp_recovery_per = reader.ReadSingle();
        transcend_add_hp_steal_per = reader.ReadSingle();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int hero_id;

    private int transcend_level;

    private int transcend_gauge;

    private int add_transcend_gauge;

    private List<string> list_array_item_type;

    private int reset_return_item_id;

    private int reset_return_item_count;

    private int transcend_price_id;

    private int transcend_price_count;

    private float transcend_add_atk;

    private float transcend_add_fixed_atk_per;

    private float transcend_add_crit_per;

    private float transcend_add_crit_atk_per;

    private float transcend_add_def;

    private float transcend_add_fixed_def_per;

    private float transcend_add_crit_res_per;

    private float transcend_add_crit_def_per;

    private float transcend_add_hp;

    private float transcend_add_hp_regen_per;

    private float transcend_add_hp_recovery_per;

    private float transcend_add_hp_steal_per;
}
