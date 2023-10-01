public class DBSkillCardOptionRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 1213U;
        }
    }

    public int Id
    {
        get
        {
            return base.DecryptInt32(id);
        }
    }

    public float OptionPer
    {
        get
        {
            return base.DecryptFloat(option_per);
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

    public int TargetStartSfxId
    {
        get
        {
            return base.DecryptInt32(target_start_sfx_id);
        }
    }

    public int UseBuffId1
    {
        get
        {
            return base.DecryptInt32(use_buff_id_1);
        }
    }

    public int UseBuffId2
    {
        get
        {
            return base.DecryptInt32(use_buff_id_2);
        }
    }

    public int UseBuffId3
    {
        get
        {
            return base.DecryptInt32(use_buff_id_3);
        }
    }

    public int UseBuffId4
    {
        get
        {
            return base.DecryptInt32(use_buff_id_5);
        }
    }

    public int UseBuffId5
    {
        get
        {
            return base.DecryptInt32(use_buff_id_4);
        }
    }

    public List<string> ListArrayUseBuffKeyword
    {
        get
        {
            return list_array_use_buff_keyword;
        }
    }

    public List<int> ListUseBuffId
    {
        get
        {
            if (list_use_buff_id == null)
            {
                list_use_buff_id = new List<int>
                {
                    UseBuffId1,
                    UseBuffId2,
                    UseBuffId3
                };
            }
            return list_use_buff_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadBytes(4);
        option_per = reader.ReadBytes(4);
        effect_keyword = reader.ReadString();
        effect_name = reader.ReadInt32();
        effect_value = reader.ReadBytes(4);
        effect_value_add = reader.ReadBytes(4);
        sub_value_type = reader.ReadString();
        sub_value = reader.ReadBytes(4);
        third_value_type = reader.ReadString();
        third_value = reader.ReadBytes(4);
        target_start_sfx_id = reader.ReadBytes(4);
        use_buff_id_1 = reader.ReadBytes(4);
        use_buff_id_2 = reader.ReadBytes(4);
        use_buff_id_3 = reader.ReadBytes(4);
        use_buff_id_4 = reader.ReadBytes(4);
        use_buff_id_5 = reader.ReadBytes(4);
        int num = reader.ReadInt32();
        list_array_use_buff_keyword = new List<string>();
        for (int i = 0; i < num; i++)
        {
            list_array_use_buff_keyword.Add(reader.ReadString());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private byte[] id;

    private byte[] option_per;

    private string effect_keyword;

    private int effect_name;

    private byte[] effect_value;

    private byte[] effect_value_add;

    private string sub_value_type;

    private byte[] sub_value;

    private string third_value_type;

    private byte[] third_value;

    private byte[] target_start_sfx_id;

    private byte[] use_buff_id_1;

    private byte[] use_buff_id_2;

    private byte[] use_buff_id_3;

    private byte[] use_buff_id_4;

    private byte[] use_buff_id_5;

    private List<string> list_array_use_buff_keyword;

    private List<int> list_use_buff_id;
}
