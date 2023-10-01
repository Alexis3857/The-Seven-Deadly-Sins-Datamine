public class DBCostumeBaseRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int FinalBossCostumeCheck
    {
        get
        {
            return final_boss_costume_check;
        }
    }

    public string CostumeName
    {
        get
        {
            return costume_name.Localize();
        }
    }

    public List<int> ListArrayCostumeHideHeroId
    {
        get
        {
            return list_array_costume_hide_hero_id;
        }
    }

    public List<int> ListArrayMatchingHeroId
    {
        get
        {
            return list_array_matching_hero_id;
        }
    }

    public int HeroGroup
    {
        get
        {
            return hero_group;
        }
    }

    public int CostumeGroup
    {
        get
        {
            return costume_group;
        }
    }

    public int CostumeType
    {
        get
        {
            return costume_type;
        }
    }

    public int CostumeCombination
    {
        get
        {
            return costume_combination;
        }
    }

    public int CostumeSorting
    {
        get
        {
            return costume_sorting;
        }
    }

    public int StoryId
    {
        get
        {
            return story_id;
        }
    }

    public int CostumeTier
    {
        get
        {
            return costume_tier;
        }
    }

    public int CostumeStatType
    {
        get
        {
            return costume_stat_type;
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

    public int AutoSellItemId
    {
        get
        {
            return auto_sell_item_id;
        }
    }

    public int AutoSellItemCount
    {
        get
        {
            return auto_sell_item_count;
        }
    }

    public int EventRewardIndex
    {
        get
        {
            return event_reward_index;
        }
    }

    public int SetCostumeId
    {
        get
        {
            return set_costume_id;
        }
    }

    public int MaintenancePeriodDate
    {
        get
        {
            return maintenance_period_date;
        }
    }

    public int ShareCostumeCheck
    {
        get
        {
            return share_costume_check;
        }
    }

    public int CraftCostumeCheck
    {
        get
        {
            return craft_costume_check;
        }
    }

    public int PassiveId
    {
        get
        {
            return passive_id;
        }
    }

    public int LoopIdleSfx
    {
        get
        {
            return loop_idle_sfx;
        }
    }

    public int GrowthPoint
    {
        get
        {
            return growth_point;
        }
    }

    public List<int> ListArrayAddPassiveId
    {
        get
        {
            return list_array_add_passive_id;
        }
    }

    public int CraftCostumeGroup
    {
        get
        {
            return craft_costume_group;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        final_boss_costume_check = reader.ReadInt32();
        costume_name = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_costume_hide_hero_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_costume_hide_hero_id.Add(reader.ReadInt32());
        }
        int num2 = reader.ReadInt32();
        list_array_matching_hero_id = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_matching_hero_id.Add(reader.ReadInt32());
        }
        hero_group = reader.ReadInt32();
        costume_group = reader.ReadInt32();
        costume_type = reader.ReadInt32();
        costume_combination = reader.ReadInt32();
        costume_sorting = reader.ReadInt32();
        story_id = reader.ReadInt32();
        costume_tier = reader.ReadInt32();
        costume_stat_type = reader.ReadInt32();
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
        auto_sell_item_id = reader.ReadInt32();
        auto_sell_item_count = reader.ReadInt32();
        event_reward_index = reader.ReadInt32();
        set_costume_id = reader.ReadInt32();
        maintenance_period_date = reader.ReadInt32();
        share_costume_check = reader.ReadInt32();
        craft_costume_check = reader.ReadInt32();
        passive_id = reader.ReadInt32();
        loop_idle_sfx = reader.ReadInt32();
        growth_point = reader.ReadInt32();
        int num3 = reader.ReadInt32();
        list_array_add_passive_id = new List<int>();
        for (int i = 0; i < num3; i++)
        {
            list_array_add_passive_id.Add(reader.ReadInt32());
        }
        craft_costume_group = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int final_boss_costume_check;

    private int costume_name;

    private List<int> list_array_costume_hide_hero_id;

    private List<int> list_array_matching_hero_id;

    private int hero_group;

    private int costume_group;

    private int costume_type;

    private int costume_combination;

    private int costume_sorting;

    private int story_id;

    private int costume_tier;

    private int costume_stat_type;

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

    private int auto_sell_item_id;

    private int auto_sell_item_count;

    private int event_reward_index;

    private int set_costume_id;

    private int maintenance_period_date;

    private int share_costume_check;

    private int craft_costume_check;

    private int passive_id;

    private int loop_idle_sfx;

    private int growth_point;

    private List<int> list_array_add_passive_id;

    private int craft_costume_group;
}
