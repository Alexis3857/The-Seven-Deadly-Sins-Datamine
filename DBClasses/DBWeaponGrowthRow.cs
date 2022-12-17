public class DBWeaponGrowthRow
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ItemId
    {
        get
        {
            return item_id;
        }
    }

    public int WeaponEvolutionCount
    {
        get
        {
            return weapon_evolution_count;
        }
    }

    public int WeaponUpgradeCount
    {
        get
        {
            return weapon_upgrade_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        item_id = reader.ReadInt32();
        weapon_evolution_count = reader.ReadInt32();
        weapon_upgrade_count = reader.ReadInt32();
        return true;
    }

    private int id;

    private int item_id;

    private int weapon_evolution_count;

    private int weapon_upgrade_count;
}
