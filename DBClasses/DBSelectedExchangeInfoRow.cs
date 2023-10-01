public class DBSelectedExchangeInfoRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public byte SelectGroup
    {
        get
        {
            return select_group;
        }
    }

    public byte SelectType1
    {
        get
        {
            return select_type_1;
        }
    }

    public byte SelectType2
    {
        get
        {
            return select_type_2;
        }
    }

    public int ItemId
    {
        get
        {
            return item_id;
        }
    }

    public int WeaponStatusAmount
    {
        get
        {
            return weapon_status_amount;

        }
    }

    public byte WeaponEvolutionCount
    {
        get
        {
            return weapon_evolution_count;
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

    public int EvolutionOptionAmount
    {
        get
        {
            return evolution_option_amount;
        }
    }

    public float EvolutionOptionAmountSet
    {
        get
        {
            return evolution_option_amount_set;
        }
    }

    public byte WeaponUpgradeCount
    {
        get
        {
            return Weapon_upgrade_count;
        }
    }

    public List<byte> ListSelectType
    {
        get
        {
            if (list_select_type == null)
            {
                list_select_type = new List<byte>
                {
                    SelectType1,
                    SelectType2
                };
            }
            return list_select_type;
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
        select_group = reader.ReadByte();
        select_type_1 = reader.ReadByte();
        select_type_2 = reader.ReadByte();
        item_id = reader.ReadInt32();
        weapon_status_amount = reader.ReadInt32();
        weapon_evolution_count = reader.ReadByte();
        evolution_option_1 = reader.ReadInt32();
        evolution_option_2 = reader.ReadInt32();
        evolution_option_3 = reader.ReadInt32();
        evolution_option_4 = reader.ReadInt32();
        evolution_option_5 = reader.ReadInt32();
        evolution_option_amount = reader.ReadInt32();
        evolution_option_amount_set = reader.ReadSingle();
        Weapon_upgrade_count = reader.ReadByte();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private byte select_group;

    private byte select_type_1;

    private byte select_type_2;

    private int item_id;

    private int weapon_status_amount;

    private byte weapon_evolution_count;

    private int evolution_option_1;

    private int evolution_option_2;

    private int evolution_option_3;

    private int evolution_option_4;

    private int evolution_option_5;

    private int evolution_option_amount;

    private float evolution_option_amount_set;

    private byte Weapon_upgrade_count;

    private List<byte> list_select_type;

    private List<int> list_evolution_option;
}
