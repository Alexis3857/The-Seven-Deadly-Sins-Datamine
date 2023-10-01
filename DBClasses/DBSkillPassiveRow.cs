public class DBSkillPassiveRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 588U;
        }
    }

    public int Id
    {
        get
        {
            return base.DecryptInt32(id);
        }
    }

    public string Name
    {
        get
        {
            return name.Localize();
        }
    }

    public string Explain
    {
        get
        {
            return explain.Localize();
        }
    }

    public string Icon
    {
        get
        {
            return icon;
        }
    }

    public int FirstStack
    {
        get
        {
            return base.DecryptInt32(first_stack);
        }
    }

    public int MaxStack
    {
        get
        {
            return base.DecryptInt32(max_stack);
        }
    }

    public byte UseStackSfx
    {
        get
        {
            return use_stack_sfx;
        }
    }

    public List<int> ListArrayUseStackSfxId
    {
        get
        {
            return list_array_use_stack_sfx_id;
        }
    }

    public string EffectKeyword
    {
        get
        {
            return effect_keyword;
        }
    }

    public float EffectValue
    {
        get
        {
            return base.DecryptFloat(effect_value);
        }
    }

    public float EffectValueAdd
    {
        get
        {
            return base.DecryptFloat(effect_value_add);
        }
    }

    public string SubValueType
    {
        get
        {
            return sub_value_type;
        }
    }

    public int SubValue
    {
        get
        {
            return base.DecryptInt32(sub_value);
        }
    }

    public string ThirdValueType
    {
        get
        {
            return third_value_type;
        }
    }

    public int ThirdValue
    {
        get
        {
            return base.DecryptInt32(third_value);
        }

    }
    public string Target
    {
        get
        {
            return target;
        }
    }

    public byte SubInvokePassive
    {
        get
        {
            return sub_invoke_passive;
        }
    }

    public List<int> ListArrayHeroTarget
    {
        get
        {
            return list_array_hero_target;
        }
    }

    public int KindTarget
    {
        get
        {
            return base.DecryptInt32(kind_target);
        }
    }

    public byte KindTargetSub
    {
        get
        {
            return kind_target_sub;
        }
    }

    public int AttributeTarget
    {
        get
        {
            return base.DecryptInt32(attribute_target);
        }
    }

    public List<int> ListArrayApplyContents
    {
        get
        {
            return list_array_apply_contents;
        }
    }

    public int ApplyArtifactPassiveCheck
    {
        get
        {
            return base.DecryptInt32(apply_artifact_passive_check);
        }
    }

    public List<string> ListArrayApplyHeroCategory
    {
        get
        {
            return list_array_apply_hero_category;
        }
    }

    public List<int> ListArrayApplyHeroJobGroup
    {
        get
        {
            return list_array_apply_hero_job_group;
        }
    }

    public List<int> ListArrayLimitContentsMatchPassiveGroup
    {
        get
        {
            return list_array_limit_contents_match_passive_group;
        }
    }

    public List<int> ListArrayExclusiveConditionIcon
    {
        get
        {
            return list_array_exclusive_condition_icon;
        }
    }

    public List<string> ListArrayUseBuffKeyword
    {
        get
        {
            return list_array_use_buff_keyword;
        }
    }

    public List<string> ListArrayUseOptionKeyword
    {
        get
        {
            return list_array_use_option_keyword;
        }
    }

    public byte SpecialLevelPassiveValueType
    {
        get
        {
            return special_level_passive_value_type;
        }
    }

    public List<float> ListArraySpecialPassiveValue
    {
        get
        {
            return list_array_special_level_passive_value;
        }
    }

    public List<int> ListArrayUseBuffId
    {
        get
        {
            return list_array_use_buff_id;
        }
    }

    public string ActiveText
    {
        get
        {
            return active_text.Localize();
        }
    }

    public int ActiveSfxId
    {
        get
        {
            return base.DecryptInt32(active_sfx_id);
        }
    }

    public string AddExclusiveHeroNick
    {
        get
        {
            return add_exclusive_hero_nick.Localize();
        }
    }

    public string ExclusiveType
    {
        get
        {
            return exclusive_type;
        }
    }

    public int ExclusiveAni
    {
        get
        {
            return base.DecryptInt32(exclusive_ani);
        }
    }

    public int PassiveSfxId
    {
        get
        {
            return base.DecryptInt32(passive_sfx_id);
        }
    }

    public byte ExclusiveInvisible
    {
        get
        {
            return exclusive_invisible;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadBytes(4);
        name = reader.ReadInt32();
        explain = reader.ReadInt32();
        icon = reader.ReadString();
        first_stack = reader.ReadBytes(4);
        max_stack = reader.ReadBytes(4);
        use_stack_sfx = reader.ReadByte();
        int num = reader.ReadInt32();
        list_array_use_stack_sfx_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_use_stack_sfx_id.Add(reader.ReadInt32());
        }
        effect_keyword = reader.ReadString();
        effect_value = reader.ReadBytes(4);
        effect_value_add = reader.ReadBytes(4);
        sub_value_type = reader.ReadString();
        sub_value = reader.ReadBytes(4);
        third_value_type = reader.ReadString();
        third_value = reader.ReadBytes(4);
        target = reader.ReadString();
        sub_invoke_passive = reader.ReadByte();
        int num99 = reader.ReadInt32();
        list_array_hero_target = new List<int>();
        for (int i = 0; i < num99; i++)
        {
            list_array_hero_target.Add(reader.ReadInt32());
        }
        kind_target = reader.ReadBytes(4);
        kind_target_sub = reader.ReadByte();
        attribute_target = reader.ReadBytes(4);
        int num2 = reader.ReadInt32();
        list_array_apply_contents = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_apply_contents.Add(reader.ReadInt32());
        }
        apply_artifact_passive_check = reader.ReadBytes(4);
        int num3 = reader.ReadInt32();
        list_array_apply_hero_category = new List<string>();
        for (int k = 0; k < num3; k++)
        {
            list_array_apply_hero_category.Add(reader.ReadString());
        }
        int num4 = reader.ReadInt32();
        list_array_apply_hero_job_group = new List<int>();
        for (int l = 0; l < num4; l++)
        {
            list_array_apply_hero_job_group.Add(reader.ReadInt32());
        }
        int num5 = reader.ReadInt32();
        list_array_limit_contents_match_passive_group = new List<int>();
        for (int m = 0; m < num5; m++)
        {
            list_array_limit_contents_match_passive_group.Add(reader.ReadInt32());
        }
        int num6 = reader.ReadInt32();
        list_array_exclusive_condition_icon = new List<int>();
        for (int n = 0; n < num6; n++)
        {
            list_array_exclusive_condition_icon.Add(reader.ReadInt32());
        }
        int num7 = reader.ReadInt32();
        list_array_use_buff_keyword = new List<string>();
        for (int num8 = 0; num8 < num7; num8++)
        {
            list_array_use_buff_keyword.Add(reader.ReadString());
        }
        int num9 = reader.ReadInt32();
        list_array_use_option_keyword = new List<string>();
        for (int num10 = 0; num10 < num9; num10++)
        {
            list_array_use_option_keyword.Add(reader.ReadString());
        }
        special_level_passive_value_type = reader.ReadByte();
        int num13 = reader.ReadInt32();
        list_array_special_level_passive_value = new List<float>();
        for (int num14 = 0; num14 < num13; num14++)
        {
            list_array_special_level_passive_value.Add(reader.ReadSingle());
        }
        int num11 = reader.ReadInt32();
        list_array_use_buff_id = new List<int>();
        for (int num12 = 0; num12 < num11; num12++)
        {
            list_array_use_buff_id.Add(reader.ReadInt32());
        }
        active_text = reader.ReadInt32();
        active_sfx_id = reader.ReadBytes(4);
        add_exclusive_hero_nick = reader.ReadInt32();
        exclusive_type = reader.ReadString();
        exclusive_ani = reader.ReadBytes(4);
        exclusive_invisible = reader.ReadByte();
        passive_sfx_id = reader.ReadBytes(4);
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private byte[] id;

    private int name;

    private int explain;

    private string icon;

    private byte[] first_stack;

    private byte[] max_stack;

    private byte use_stack_sfx;

    private List<int> list_array_use_stack_sfx_id;

    private string effect_keyword;

    private byte[] effect_value;

    private byte[] effect_value_add;

    private string sub_value_type;

    private byte[] sub_value;

    private string target;

    private string third_value_type;

    private byte[] third_value;

    private byte sub_invoke_passive;

    private List<int> list_array_hero_target;

    private byte[] kind_target;

    private byte kind_target_sub;

    private byte[] attribute_target;

    private List<int> list_array_apply_contents;

    private byte[] apply_artifact_passive_check;

    private List<string> list_array_apply_hero_category;

    private List<int> list_array_apply_hero_job_group;

    private List<int> list_array_limit_contents_match_passive_group;

    private List<int> list_array_exclusive_condition_icon;

    private List<string> list_array_use_buff_keyword;

    private List<string> list_array_use_option_keyword;

    private byte special_level_passive_value_type;

    private List<float> list_array_special_level_passive_value;

    private List<int> list_array_use_buff_id;

    private int active_text;

    private byte[] active_sfx_id;

    private int add_exclusive_hero_nick;

    private string exclusive_type;

    private byte[] exclusive_ani;

    private byte exclusive_invisible;

    private byte[] passive_sfx_id;
}
