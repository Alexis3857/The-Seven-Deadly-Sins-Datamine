public class DBWeaponMagicRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 1184U;
        }
    }

    public int Id
    {
        get
        {
            return base.DecryptInt32(id);
        }
    }

    public int RandomOptionType
    {
        get
        {
            return base.DecryptInt32(random_option_type);
        }
    }

    public int RandomOptionGroup
    {
        get
        {
            return base.DecryptInt32(random_option_group);
        }
    }

    public string RandomOptionName
    {
        get
        {
            return random_option_name.Localize();
        }
    }

    public string RandomOptionDesc
    {
        get
        {
            return random_option_desc.Localize();
        }
    }

    public int OptionEffectId
    {
        get
        {
            return base.DecryptInt32(option_effect_id);
        }
    }

    public int OptionEffectMin
    {
        get
        {
            return base.DecryptInt32(option_effect_min);
        }
    }

    public int OptionEffectMax
    {
        get
        {
            return base.DecryptInt32(option_effect_max);
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadBytes(4);
        random_option_type = reader.ReadBytes(4);
        random_option_group = reader.ReadBytes(4);
        random_option_name = reader.ReadInt32();
        random_option_desc = reader.ReadInt32();
        option_effect_id = reader.ReadBytes(4);
        option_effect_min = reader.ReadBytes(4);
        option_effect_max = reader.ReadBytes(4);
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private byte[] id;

    private byte[] random_option_type;

    private byte[] random_option_group;

    private int random_option_name;

    private int random_option_desc;

    private byte[] option_effect_id;

    private byte[] option_effect_min;

    private byte[] option_effect_max;
}
