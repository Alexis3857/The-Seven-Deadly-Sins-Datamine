public class DBSkillCardResourceRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 1297U;
        }
    }

    public int Id
    {
        get
        {
            return base.DecryptInt32(id);
        }
    }

    public string SkillFolder
    {
        get
        {
            return skill_folder;
        }
    }

    public string Icon
    {
        get
        {
            return icon;
        }
    }

    public int HitSoundId
    {
        get
        {
            return base.DecryptInt32(hit_sound_id);
        }
    }

    public int HitSfxId
    {
        get
        {
            return base.DecryptInt32(hit_sfx_id);
        }
    }

    public int LastHitSfxId
    {
        get
        {
            return base.DecryptInt32(last_hit_sfx_id);
        }
    }

    public string CutInSpecial
    {
        get
        {
            return cut_in_special;
        }
    }

    public List<int> ListArraySpecialEndSfxId
    {
        get
        {
            return list_array_special_end_sfx_id;
        }
    }

    public int SkillFinalEndSfxId
    {
        get
        {
            return base.DecryptInt32(skill_final_end_sfx_id);
        }
    }

    public string SpecialEndUiSfx
    {
        get
        {
            return special_end_ui_sfx;
        }
    }

    public byte SpecialEndAni
    {
        get
        {
            return special_end_ani;
        }
    }

    public int SkillFinalEndSoundId
    {
        get
        {
            return base.DecryptInt32(skill_final_end_sound_id);
        }
    }

    public int SpecialEndSoundId
    {
        get
        {
            return base.DecryptInt32(special_end_sound_id);
        }
    }

    public List<int> ListArrayCounterPortraitSound
    {
        get
        {
            return list_array_counter_portrait_sound;
        }
    }

    public string CounterPortraitAni
    {
        get
        {
            return counter_portrait_ani;
        }
    }

    public string CounterPortraitLocal
    {
        get
        {
            return counter_portrait_local;
        }
    }

    public float CounterPortraitDelayTime
    {
        get
        {
            return DecryptFloat(counter_portrait_delay_time);
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadBytes(4);
        skill_folder = reader.ReadString();
        icon = reader.ReadString();
        hit_sound_id = reader.ReadBytes(4);
        hit_sfx_id = reader.ReadBytes(4);
        last_hit_sfx_id = reader.ReadBytes(4);
        cut_in_special = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_special_end_sfx_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_special_end_sfx_id.Add(reader.ReadInt32());
        }
        skill_final_end_sfx_id = reader.ReadBytes(4);
        special_end_ui_sfx = reader.ReadString();
        special_end_ani = reader.ReadByte();
        skill_final_end_sound_id = reader.ReadBytes(4);
        special_end_sound_id = reader.ReadBytes(4);
        int num2 = reader.ReadInt32();
        list_array_counter_portrait_sound = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_counter_portrait_sound.Add(reader.ReadInt32());
        }
        counter_portrait_ani = reader.ReadString();
        counter_portrait_local = reader.ReadString();
        counter_portrait_delay_time = reader.ReadBytes(4);
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private byte[] id;

    private string skill_folder;

    private string icon;

    private byte[] hit_sound_id;

    private byte[] hit_sfx_id;

    private byte[] last_hit_sfx_id;

    private string cut_in_special;

    private List<int> list_array_special_end_sfx_id;

    private byte[] skill_final_end_sfx_id;

    private string special_end_ui_sfx;

    private byte special_end_ani;

    private byte[] skill_final_end_sound_id;

    private byte[] special_end_sound_id;

    private List<int> list_array_counter_portrait_sound;

    private string counter_portrait_ani;

    private string counter_portrait_local;

    private byte[] counter_portrait_delay_time;
}
