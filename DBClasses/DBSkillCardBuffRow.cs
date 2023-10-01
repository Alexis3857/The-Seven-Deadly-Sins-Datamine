public class DBSkillCardBuffRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 1147U;
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

    public string BuffType
    {
        get
        {
            return buff_type;
        }
    }

    public byte BuffAccureType
    {
        get
        {
            return buff_accure_type;
        }
    }

    public byte BuffTarget
    {
        get
        {
            return buff_target;
        }
    }

    public float BuffPer
    {
        get
        {
            return base.DecryptFloat(buff_per);
        }
    }

    public int BuffTurn
    {
        get
        {
            return base.DecryptInt32(buff_turn);
        }
    }

    public int BuffNumber
    {
        get
        {
            return base.DecryptInt32(buff_number);
        }
    }

    public byte OverlapType
    {
        get
        {
            return overlap_type;
        }
    }

    public int OverlapLimit
    {
        get
        {
            return base.DecryptInt32(overlap_limit);
        }
    }

    public string EffectKeyword
    {
        get
        {
            return effect_keyword;
        }
    }

    public string EffectName
    {
        get
        {
            return effect_name.Localize();
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

    public float SubValue
    {
        get
        {
            return base.DecryptFloat(sub_value);
        }
    }

    public float EffectValueTurnAdd
    {
        get
        {
            return base.DecryptFloat(effect_value_turn_add);
        }
    }

    public List<int> ListEffectGiveArrayId
    {
        get
        {
            return list_effect_give_array_id;
        }
    }

    public byte EffectGiveAttackType
    {
        get
        {
            return effect_give_attack_type;
        }
    }

    public List<string> ListArrayCompareBuffKeyword
    {
        get
        {
            return list_array_compare_buff_keyword;
        }
    }

    public List<int> ListArrayCompareBuffId
    {
        get
        {
            return list_array_compare_buff_id;
        }
    }

    public string BuffGroup
    {
        get
        {
            return buff_group;
        }
    }

    public byte EternalBuffGroupDeleteCheck
    {
        get
        {
            return eternal_buff_group_delete_check;
        }
    }

    public byte CarpetBuffCheck
    {
        get
        {
            return carpet_buff_check;
        }
    }

    public byte ForceSfxScale
    {
        get
        {
            return force_sfx_scale;
        }
    }

    public int CasterStartSfxId
    {
        get
        {
            return base.DecryptInt32(caster_start_sfx_id);
        }
    }

    public List<int> ListArrayTargetStartSfxId
    {
        get
        {
            return list_array_target_start_sfx_id;
        }
    }

    public int StartSoundId
    {
        get
        {
            return base.DecryptInt32(start_sound_id);
        }
    }

    public byte BuffLoopCut
    {
        get
        {
            return buff_loop_cut;
        }
    }

    public byte BuffLoopCutScout
    {
        get
        {
            return buff_loop_cut_scout;
        }
    }

    public int TargetKeepSfxId
    {
        get
        {
            return base.DecryptInt32(target_keep_sfx_id);
        }
    }

    public int TargetKeepSfxSecondId
    {
        get
        {
            return base.DecryptInt32(target_keep_sfx_second_id);

        }
    }

    public int TargetStopSfxId
    {
        get
        {
            return base.DecryptInt32(target_stop_sfx_id);
        }
    }

    public int StopSoundId
    {
        get
        {
            return base.DecryptInt32(stop_sound_id);
        }
    }

    public int TargetEndSfxId
    {
        get
        {
            return base.DecryptInt32(target_end_sfx_id);
        }
    }

    public int EndSoundId
    {
        get
        {
            return base.DecryptInt32(end_sound_id);
        }
    }

    public int TargetHitSfxId
    {
        get
        {
            return base.DecryptInt32(target_hit_sfx_id);
        }
    }

    public int HitSoundId
    {
        get
        {
            return base.DecryptInt32(hit_sound_id);
        }
    }

    public float SoundDelaySec
    {
        get
        {
            return base.DecryptFloat(sound_delay_sec);
        }
    }

    public List<int> ListArrayAccureValue
    {
        get
        {
            return list_array_accure_value;
        }
    }

    public int AccureValueMax
    {
        get
        {
            return base.DecryptInt32(accure_value_max);
        }
    }

    public List<int> ListArrayAccureTargetStartSfxId
    {
        get
        {
            return list_array_accure_target_start_sfx_id;
        }
    }

    public List<int> ListArrayAccureTargetKeepSfxId
    {
        get
        {
            return list_array_accure_target_keep_sfx_id;
        }
    }

    public List<int> ListArrayAccureTargetStopSfxId
    {
        get
        {
            return list_array_accure_target_stop_sfx_id;
        }
    }

    public List<int> ListArrayAccureTargetEndSfxId
    {
        get
        {
            return list_array_accure_target_end_sfx_id;
        }
    }

    public List<int> ListArrayAccureStartSoundId
    {
        get
        {
            return list_array_accure_start_sound_id;
        }
    }

    public List<int> ListArrayAccureStopSoundId
    {
        get
        {
            return list_array_accure_stop_sound_id;
        }
    }

    public List<int> ListArrayAccureEndSoundId
    {
        get
        {
            return list_array_accure_end_sound_id;
        }
    }

    public List<string> ListArrayEqualEffectKeyword
    {
        get
        {
            return list_array_equal_effect_keyword;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadBytes(4);
        name = reader.ReadInt32();
        explain = reader.ReadInt32();
        icon = reader.ReadString();
        buff_type = reader.ReadString();
        buff_accure_type = reader.ReadByte();
        buff_target = reader.ReadByte();
        buff_per = reader.ReadBytes(4);
        buff_turn = reader.ReadBytes(4);
        buff_number = reader.ReadBytes(4);
        overlap_type = reader.ReadByte();
        overlap_limit = reader.ReadBytes(4);
        effect_keyword = reader.ReadString();
        effect_name = reader.ReadInt32();
        effect_value = reader.ReadBytes(4);
        effect_value_add = reader.ReadBytes(4);
        sub_value_type = reader.ReadString();
        sub_value = reader.ReadBytes(4);
        effect_value_turn_add = reader.ReadBytes(4);
        int num = reader.ReadInt32();
        list_effect_give_array_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_effect_give_array_id.Add(reader.ReadInt32());
        }
        effect_give_attack_type = reader.ReadByte();
        int num2 = reader.ReadInt32();
        list_array_compare_buff_keyword = new List<string>();
        for (int j = 0; j < num2; j++)
        {
            list_array_compare_buff_keyword.Add(reader.ReadString());
        }
        int num3 = reader.ReadInt32();
        list_array_compare_buff_id = new List<int>();
        for (int k = 0; k < num3; k++)
        {
            list_array_compare_buff_id.Add(reader.ReadInt32());
        }
        buff_group = reader.ReadString();
        eternal_buff_group_delete_check = reader.ReadByte();
        carpet_buff_check = reader.ReadByte();
        force_sfx_scale = reader.ReadByte();
        caster_start_sfx_id = reader.ReadBytes(4);
        int num4 = reader.ReadInt32();
        list_array_target_start_sfx_id = new List<int>();
        for (int l = 0; l < num4; l++)
        {
            list_array_target_start_sfx_id.Add(reader.ReadInt32());
        }
        start_sound_id = reader.ReadBytes(4);
        buff_loop_cut = reader.ReadByte();
        buff_loop_cut_scout = reader.ReadByte();
        target_keep_sfx_id = reader.ReadBytes(4);
        target_keep_sfx_second_id = reader.ReadBytes(4);
        target_stop_sfx_id = reader.ReadBytes(4);
        stop_sound_id = reader.ReadBytes(4);
        target_end_sfx_id = reader.ReadBytes(4);
        end_sound_id = reader.ReadBytes(4);
        target_hit_sfx_id = reader.ReadBytes(4);
        hit_sound_id = reader.ReadBytes(4);
        sound_delay_sec = reader.ReadBytes(4);
        int num5 = reader.ReadInt32();
        list_array_accure_value = new List<int>();
        for (int m = 0; m < num5; m++)
        {
            list_array_accure_value.Add(reader.ReadInt32());
        }
        accure_value_max = reader.ReadBytes(4);
        int num6 = reader.ReadInt32();
        list_array_accure_target_start_sfx_id = new List<int>();
        for (int n = 0; n < num6; n++)
        {
            list_array_accure_target_start_sfx_id.Add(reader.ReadInt32());
        }
        int num7 = reader.ReadInt32();
        list_array_accure_target_keep_sfx_id = new List<int>();
        for (int num8 = 0; num8 < num7; num8++)
        {
            list_array_accure_target_keep_sfx_id.Add(reader.ReadInt32());
        }
        int num9 = reader.ReadInt32();
        list_array_accure_target_stop_sfx_id = new List<int>();
        for (int num10 = 0; num10 < num9; num10++)
        {
            list_array_accure_target_stop_sfx_id.Add(reader.ReadInt32());
        }
        int num11 = reader.ReadInt32();
        list_array_accure_target_end_sfx_id = new List<int>();
        for (int num12 = 0; num12 < num11; num12++)
        {
            list_array_accure_target_end_sfx_id.Add(reader.ReadInt32());
        }
        int num13 = reader.ReadInt32();
        list_array_accure_start_sound_id = new List<int>();
        for (int num14 = 0; num14 < num13; num14++)
        {
            list_array_accure_start_sound_id.Add(reader.ReadInt32());
        }
        int num15 = reader.ReadInt32();
        list_array_accure_stop_sound_id = new List<int>();
        for (int num16 = 0; num16 < num15; num16++)
        {
            list_array_accure_stop_sound_id.Add(reader.ReadInt32());
        }
        int num17 = reader.ReadInt32();
        list_array_accure_end_sound_id = new List<int>();
        for (int num18 = 0; num18 < num17; num18++)
        {
            list_array_accure_end_sound_id.Add(reader.ReadInt32());
        }
        int num19 = reader.ReadInt32();
        list_array_equal_effect_keyword = new List<string>();
        for (int num20 = 0; num20 < num19; num20++)
        {
            list_array_equal_effect_keyword.Add(reader.ReadString());
        }
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

    private string buff_type;

    private byte buff_accure_type;

    private byte buff_target;

    private byte[] buff_per;

    private byte[] buff_turn;

    private byte[] buff_number;

    private byte overlap_type;

    private byte[] overlap_limit;

    private string effect_keyword;

    private int effect_name;

    private byte[] effect_value;

    private byte[] effect_value_add;

    private string sub_value_type;

    private byte[] sub_value;

    private byte[] effect_value_turn_add;

    private List<int> list_effect_give_array_id;

    private byte effect_give_attack_type;

    private List<string> list_array_compare_buff_keyword;

    private List<int> list_array_compare_buff_id;

    private string buff_group;

    private byte eternal_buff_group_delete_check;

    private byte carpet_buff_check;

    private byte force_sfx_scale;

    private byte[] caster_start_sfx_id;

    private List<int> list_array_target_start_sfx_id;

    private byte[] start_sound_id;

    private byte buff_loop_cut;

    private byte buff_loop_cut_scout;

    private byte[] target_keep_sfx_id;

    private byte[] target_keep_sfx_second_id;

    private byte[] target_stop_sfx_id;

    private byte[] stop_sound_id;

    private byte[] target_end_sfx_id;

    private byte[] end_sound_id;

    private byte[] target_hit_sfx_id;

    private byte[] hit_sound_id;

    private byte[] sound_delay_sec;

    private List<int> list_array_accure_value;

    private byte[] accure_value_max;

    private List<int> list_array_accure_target_start_sfx_id;

    private List<int> list_array_accure_target_keep_sfx_id;

    private List<int> list_array_accure_target_stop_sfx_id;

    private List<int> list_array_accure_target_end_sfx_id;

    private List<int> list_array_accure_start_sound_id;

    private List<int> list_array_accure_stop_sound_id;

    private List<int> list_array_accure_end_sound_id;

    private List<string> list_array_equal_effect_keyword;
}
