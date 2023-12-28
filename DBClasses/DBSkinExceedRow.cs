public class DBSkinExceedRow : ITableRowIndexer
{
    public int Id => id;
    public int HeroId => hero_id;
    public int ExceedCount => exceed_count;
    public int ExceedMaterialId1 => exceed_material_id_1;
    public int ExceedMaterialCount1 => exceed_material_count_1;
    public int ExceedMaterialId2 => exceed_material_id_2;
    public int ExceedMaterialCount2 => exceed_material_count_2;
    public int ExceedMaterialId3 => exceed_material_id_3;
    public int ExceedMaterialCount3 => exceed_material_count_3;
    public int ExceedMaterialId4 => exceed_material_id_4;
    public int ExceedMaterialCount4 => exceed_material_count_4;
    public int ExceedPriceId => exceed_price_id;
    public int ExceedPriceCount => exceed_price_count;
    public float AddAtk => add_atk;
    public float AddFixedAtkPer => add_fixed_atk_per;
    public float AddCritPer => add_crit_per;
    public float AddCritAtkPer => add_crit_atk_per;
    public float AddDef => add_def;
    public float AddFixedDefPer => add_fixed_def_per;
    public float AddCritResPer => add_crit_res_per;
    public float AddCritDefPer => add_crit_def_per;
    public float AddHp => add_hp;
    public float AddHpRegenPer => add_hp_regen_per;
    public float AddHpRecoveryPer => add_hp_recovery_per;
    public float AddHpStealPer => add_hp_steal_per;
    public float AddAttrEnhancePer => add_attr_enhance_per;

    public float AddDmgRes => add_dmg_res;
    public float AddFpower => add_fpower;
    public List<int> ListExceedMaterialId
    {
        get
        {
            if (list_exceed_material_id == null)
            {
                list_exceed_material_id = new List<int>
                {
                    ExceedMaterialId1,
                    ExceedMaterialId2,
                    ExceedMaterialId3,
                    ExceedMaterialId4
                };
            }
            return list_exceed_material_id;
        }
    }
    public List<int> ListExceedMaterialCount
    {
        get
        {
            if (list_exceed_material_count == null)
            {
                list_exceed_material_count = new List<int>
                {
                    ExceedMaterialCount1,
                    ExceedMaterialCount2,
                    ExceedMaterialCount3,
                    ExceedMaterialCount4
                };
            }
            return list_exceed_material_count;
        }
    }
    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        hero_id = reader.ReadInt32();
        exceed_count = reader.ReadInt32();
        exceed_material_id_1 = reader.ReadInt32();
        exceed_material_count_1 = reader.ReadInt32();
        exceed_material_id_2 = reader.ReadInt32();
        exceed_material_count_2 = reader.ReadInt32();
        exceed_material_id_3 = reader.ReadInt32();
        exceed_material_count_3 = reader.ReadInt32();
        exceed_material_id_4 = reader.ReadInt32();
        exceed_material_count_4 = reader.ReadInt32();
        exceed_price_id = reader.ReadInt32();
        exceed_price_count = reader.ReadInt32();
        add_atk = reader.ReadSingle();
        add_fixed_atk_per = reader.ReadSingle();
        add_crit_per = reader.ReadSingle();
        add_crit_atk_per = reader.ReadSingle();
        add_def = reader.ReadSingle();
        add_fixed_def_per = reader.ReadSingle();
        add_crit_res_per = reader.ReadSingle();
        add_crit_def_per = reader.ReadSingle();
        add_hp = reader.ReadSingle();
        add_hp_regen_per = reader.ReadSingle();
        add_hp_recovery_per = reader.ReadSingle();
        add_hp_steal_per = reader.ReadSingle();
        add_attr_enhance_per = reader.ReadSingle();
        add_dmg_res = reader.ReadSingle();
        add_fpower = reader.ReadSingle();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int hero_id;

    private int exceed_count;

    private int exceed_material_id_1;

    private int exceed_material_count_1;

    private int exceed_material_id_2;

    private int exceed_material_count_2;

    private int exceed_material_id_3;

    private int exceed_material_count_3;

    private int exceed_material_id_4;

    private int exceed_material_count_4;

    private int exceed_price_id;

    private int exceed_price_count;

    private float add_atk;

    private float add_fixed_atk_per;

    private float add_crit_per;

    private float add_crit_atk_per;

    private float add_def;

    private float add_fixed_def_per;

    private float add_crit_res_per;

    private float add_crit_def_per;

    private float add_hp;

    private float add_hp_regen_per;

    private float add_hp_recovery_per;

    private float add_hp_steal_per;

    private float add_attr_enhance_per;

    private float add_dmg_res;

    private float add_fpower;

    private List<int> list_exceed_material_id;

    private List<int> list_exceed_material_count;
}