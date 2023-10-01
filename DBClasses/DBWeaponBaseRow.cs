public class DBWeaponBaseRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 788U;
        }
    }

    public int Id
    {
        get
        {
            return base.DecryptInt32(id);
        }
    }

    public int SetId
    {
        get
        {
            return base.DecryptInt32(set_id);
        }
    }

    public int WeaponRating
    {
        get
        {
            return base.DecryptInt32(weapon_rating);
        }
    }

    public int WeaponType
    {
        get
        {
            return base.DecryptInt32(weapon_type);
        }
    }

    public int WeaponParts
    {
        get
        {
            return base.DecryptInt32(weapon_parts);
        }
    }

    public int StatusValueMin
    {
        get
        {
            return base.DecryptInt32(status_value_min);
        }
    }

    public int StatusValueMax
    {
        get
        {
            return base.DecryptInt32(status_value_max);
        }
    }

    public int UpgradeStatusValue
    {
        get
        {
            return base.DecryptInt32(upgrade_status_value);
        }
    }

    public int RandomOptionId
    {
        get
        {
            return base.DecryptInt32(random_option_id);
        }
    }

    public int RandomOptionCount
    {
        get
        {
            return base.DecryptInt32(random_option_count);
        }
    }

    public int EvolutionAddValue
    {
        get
        {
            return base.DecryptInt32(evolution_add_value);
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadBytes(4);
        set_id = reader.ReadBytes(4);
        weapon_rating = reader.ReadBytes(4);
        weapon_type = reader.ReadBytes(4);
        weapon_parts = reader.ReadBytes(4);
        status_value_min = reader.ReadBytes(4);
        status_value_max = reader.ReadBytes(4);
        upgrade_status_value = reader.ReadBytes(4);
        random_option_id = reader.ReadBytes(4);
        random_option_count = reader.ReadBytes(4);
        evolution_add_value = reader.ReadBytes(4);
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private byte[] id;

    private byte[] set_id;

    private byte[] weapon_rating;

    private byte[] weapon_type;

    private byte[] weapon_parts;

    private byte[] status_value_min;

    private byte[] status_value_max;

    private byte[] upgrade_status_value;

    private byte[] random_option_id;

    private byte[] random_option_count;

    private byte[] evolution_add_value;
}
