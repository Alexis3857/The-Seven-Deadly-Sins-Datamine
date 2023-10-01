public class DBWeaponUpgradeRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 1131U;
        }
    }

    public int Id
    {
        get
        {
            return base.DecryptInt32(id);
        }
    }

    public int UpgradeLevel
    {
        get
        {
            return base.DecryptInt32(upgrade_level);
        }
    }

    public int WeaponRating
    {
        get
        {
            return base.DecryptInt32(weapon_rating);
        }
    }

    public int UpgradePer
    {
        get
        {
            return base.DecryptInt32(upgrade_per);
        }
    }

    public int UpgradeMaterialId
    {
        get
        {
            return base.DecryptInt32(upgrade_material_id);
        }
    }

    public int UpgradeMaterialCount
    {
        get
        {
            return base.DecryptInt32(upgrade_material_count);
        }
    }

    public int UpgradePriceId
    {
        get
        {
            return base.DecryptInt32(upgrade_price_id);
        }
    }

    public int UpgradePriceCount
    {
        get
        {
            return base.DecryptInt32(upgrade_price_count);
        }
    }

    public int UpgradeFailGauge
    {
        get
        {
            return base.DecryptInt32(upgrade_fail_gauge);
        }
    }

    public int DiscountEventMode
    {
        get
        {
            return base.DecryptInt32(discount_event_mode);
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadBytes(4);
        upgrade_level = reader.ReadBytes(4);
        weapon_rating = reader.ReadBytes(4);
        upgrade_per = reader.ReadBytes(4);
        upgrade_material_id = reader.ReadBytes(4);
        upgrade_material_count = reader.ReadBytes(4);
        upgrade_price_id = reader.ReadBytes(4);
        upgrade_price_count = reader.ReadBytes(4);
        upgrade_fail_gauge = reader.ReadBytes(4);
        discount_event_mode = reader.ReadBytes(4);
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private byte[] id;

    private byte[] upgrade_level;

    private byte[] weapon_rating;

    private byte[] upgrade_per;

    private byte[] upgrade_material_id;

    private byte[] upgrade_material_count;

    private byte[] upgrade_price_id;

    private byte[] upgrade_price_count;

    private byte[] upgrade_fail_gauge;

    private byte[] discount_event_mode;
}
