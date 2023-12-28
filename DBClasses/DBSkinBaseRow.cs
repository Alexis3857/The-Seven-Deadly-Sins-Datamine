public class DBSkinBaseRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string SkinGachaDescription
    {
        get
        {
            return skin_gacha_description.Localize();
        }
    }

    public string CostumeName
    {
        get
        {
            return costume_name.Localize();
        }
    }

    public int BaseSkinCostumeId
    {
        get
        {
            return base_skin_costume_id;
        }
    }

    public int BaseHeadCostumeId
    {
        get
        {
            return base_head_costume_id;
        }
    }

    public int BaseWeaponCostumeId
    {
        get
        {
            return base_weapon_costume_id;
        }
    }

    public string SkinPortraitBase
    {
        get
        {
            return skin_portrait_base;
        }
    }

    public int CostumeCombination
    {
        get
        {
            return costume_combination;
        }
    }

    public int SkinCategory
    {
        get
        {
            return skin_category;
        }
    }

    public int SkinDisplay
    {
        get
        {
            return skin_display;
        }
    }

    public int SkinCombat
    {
        get
        {
            return skin_combat;
        }
    }

    public int Sort
    {
        get
        {
            return sort;
        }
    }

    public int StartRating
    {
        get
        {
            return start_rating;
        }
    }

    public int Rating
    {
        get
        {
            return rating;
        }
    }

    public int Attribute
    {
        get
        {
            return attribute;
        }
    }

    public int AttributeSub
    {
        get
        {
            return attribute_sub;
        }
    }

    public string SelectRankExp
    {
        get
        {
            return select_rank_exp;
        }
    }

    public int LevelInitializtion
    {
        get
        {
            return level_initializtion;
        }
    }

    public int MaxLevel
    {
        get
        {
            return max_level;
        }
    }

    public int EvolutionLevel
    {
        get
        {
            return evolution_level;
        }
    }

    public int CreateSpecialScore
    {
        get
        {
            return create_special_score;
        }
    }

    public int CategoryGroup
    {
        get
        {
            return category_group;
        }
    }

    public int MatchingHeroId
    {
        get
        {
            return matching_hero_id;
        }
    }

    public int HeroCoin
    {
        get
        {
            return hero_coin;
        }
    }

    public int HeroCoinCount
    {
        get
        {
            return hero_coin_count;
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

    public float AttrEnhancePer
    {
        get
        {
            return attr_enhance_per;
        }
    }

    public float DmgRes
    {
        get
        {
            return dmg_res;
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

    public string CostumeSetCount
    {
        get
        {
            return costume_set_count;
        }
    }

    public int ChangeHeroSkinId
    {
        get
        {
            return change_hero_skin_id;
        }
    }

    public int BeforeChangeHeroSkinId
    {
        get
        {
            return before_change_hero_skin_id;
        }
    }

    public int ChangeEffectId
    {
        get
        {
            return change_effect_id;
        }
    }

    public int AfterChangeHeroModel
    {
        get
        {
            return after_change_hero_model;
        }
    }

    public int WeaponHideDisplay
    {
        get
        {
            return weapon_hide_display;
        }
    }

    public int RandomStateActive
    {
        get
        {
            return random_state_active;
        }
    }

    public int RandomStateStartEffectId
    {
        get
        {
            return random_state_start_effect_id;
        }
    }

    public int RandomStateLoopEffectId
    {
        get
        {
            return random_state_loop_effect_id;
        }
    }

    public int RandomStateMinTime
    {
        get
        {
            return random_state_min_time;
        }
    }

    public int RandomStateMaxTime
    {
        get
        {
            return random_state_max_time;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        skin_gacha_description = reader.ReadInt32();
        costume_name = reader.ReadInt32();
        base_skin_costume_id = reader.ReadInt32();
        base_head_costume_id = reader.ReadInt32();
        base_weapon_costume_id = reader.ReadInt32();
        skin_portrait_base = reader.ReadString();
        costume_combination = reader.ReadInt32();
        skin_category = reader.ReadInt32();
        skin_display = reader.ReadInt32();
        skin_combat = reader.ReadInt32();
        sort = reader.ReadInt32();
        start_rating = reader.ReadInt32();
        rating = reader.ReadInt32();
        attribute = reader.ReadInt32();
        attribute_sub = reader.ReadInt32();
        select_rank_exp = reader.ReadString();
        level_initializtion = reader.ReadInt32();
        max_level = reader.ReadInt32();
        evolution_level = reader.ReadInt32();
        create_special_score = reader.ReadInt32();
        category_group = reader.ReadInt32();
        matching_hero_id = reader.ReadInt32();
        hero_coin = reader.ReadInt32();
        hero_coin_count = reader.ReadInt32();
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
        attr_enhance_per = reader.ReadSingle();
        dmg_res = reader.ReadSingle();
        atk_add = reader.ReadSingle();
        def_add = reader.ReadSingle();
        hp_add = reader.ReadSingle();
        costume_set_count = reader.ReadString();
        change_hero_skin_id = reader.ReadInt32();
        before_change_hero_skin_id = reader.ReadInt32();
        change_effect_id = reader.ReadInt32();
        after_change_hero_model = reader.ReadInt32();
        weapon_hide_display = reader.ReadInt32();
        random_state_active = reader.ReadInt32();
        random_state_start_effect_id = reader.ReadInt32();
        random_state_loop_effect_id = reader.ReadInt32();
        random_state_min_time = reader.ReadInt32();
        random_state_max_time = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int skin_gacha_description;

    private int costume_name;

    private int base_skin_costume_id;

    private int base_head_costume_id;

    private int base_weapon_costume_id;

    private string skin_portrait_base;

    private int costume_combination;

    private int skin_category;

    private int skin_display;

    private int skin_combat;

    private int sort;

    private int start_rating;

    private int rating;

    private int attribute;

    private int attribute_sub;

    private string select_rank_exp;

    private int level_initializtion;

    private int max_level;

    private int evolution_level;

    private int create_special_score;

    private int category_group;

    private int matching_hero_id;

    private int hero_coin;

    private int hero_coin_count;

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

    private float attr_enhance_per;

    private float dmg_res;

    private float atk_add;

    private float def_add;

    private float hp_add;

    private string costume_set_count;

    private int change_hero_skin_id;

    private int before_change_hero_skin_id;

    private int change_effect_id;

    private int after_change_hero_model;

    private int weapon_hide_display;

    private int random_state_active;

    private int random_state_start_effect_id;

    private int random_state_loop_effect_id;

    private int random_state_min_time;

    private int random_state_max_time;
}
