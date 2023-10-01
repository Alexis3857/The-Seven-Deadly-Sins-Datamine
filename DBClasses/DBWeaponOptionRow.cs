public class DBWeaponOptionRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 952U;
        }
    }

    public int Id
    {
        get
        {
            return base.DecryptInt32(id);
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

    public int OptionEffectId
    {
        get
        {
            return base.DecryptInt32(option_effect_id);
        }
    }

    public float OptionEffectMin
    {
        get
        {
            return base.DecryptFloat(option_effect_min);
        }
    }

    public float OptionEffectMax
    {
        get
        {
            return base.DecryptFloat(option_effect_max);
        }
    }

    public float OptionUpgradeValue
    {
        get
        {
            return base.DecryptFloat(option_upgrade_value);
        }
    }

    public string OptionName
    {
        get
        {
            return option_name.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadBytes(4);
        random_option_group = reader.ReadBytes(4);
        random_option_name = reader.ReadInt32();
        option_effect_id = reader.ReadBytes(4);
        option_effect_min = reader.ReadBytes(4);
        option_effect_max = reader.ReadBytes(4);
        option_upgrade_value = reader.ReadBytes(4);
        option_name = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private byte[] id;

    private byte[] random_option_group;

    private int random_option_name;

    private byte[] option_effect_id;

    private byte[] option_effect_min;

    private byte[] option_effect_max;

    private byte[] option_upgrade_value;

    private int option_name;
}
