public class DBPackageWeaponGrowthRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ProductId
    {
        get
        {
            return product_id;
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

    public int WeaponOptionMax
    {
        get
        {
            return weapon_option_max;
        }
    }

    public int EvolutionOption1
    {
        get
        {
            return evolution_option_1;
        }
    }

    public int EvolutionOption2
    {
        get
        {
            return evolution_option_2;
        }
    }

    public int EvolutionOption3
    {
        get
        {
            return evolution_option_3;
        }
    }

    public int EvolutionOption4
    {
        get
        {
            return evolution_option_4;
        }
    }

    public int EvolutionOption5
    {
        get
        {
            return evolution_option_5;
        }
    }

    public int WeaponUpgradeCount
    {
        get
        {
            return weapon_upgrade_count;
        }
    }

    public List<int> ListEvolutionOption
    {
        get
        {
            if (list_evolution_option == null)
            {
                list_evolution_option = new List<int>
                {
                    EvolutionOption1,
                    EvolutionOption2,
                    EvolutionOption3,
                    EvolutionOption4,
                    EvolutionOption5
                };
            }
            return list_evolution_option;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        product_id = reader.ReadInt32();
        item_id = reader.ReadInt32();
        weapon_evolution_count = reader.ReadInt32();
        weapon_option_max = reader.ReadInt32();
        evolution_option_1 = reader.ReadInt32();
        evolution_option_2 = reader.ReadInt32();
        evolution_option_3 = reader.ReadInt32();
        evolution_option_4 = reader.ReadInt32();
        evolution_option_5 = reader.ReadInt32();
        weapon_upgrade_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int product_id;

    private int item_id;

    private int weapon_evolution_count;

    private int weapon_option_max;

    private int evolution_option_1;

    private int evolution_option_2;

    private int evolution_option_3;

    private int evolution_option_4;

    private int evolution_option_5;

    private int weapon_upgrade_count;

    private List<int> list_evolution_option;
}
