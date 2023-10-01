public class DBWeaponOptionChangeRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string ChangeType
    {
        get
        {
            return change_type;
        }
    }

    public int WeaponRating
    {
        get
        {
            return weapon_rating;
        }
    }

    public int EvolutionCount
    {
        get
        {
            return evolution_count;
        }
    }

    public int ChangeMaterialId
    {
        get
        {
            return change_material_id;
        }
    }

    public int ChangeMaterialCount
    {
        get
        {
            return change_material_count;
        }
    }

    public int ChangePriceId
    {
        get
        {
            return change_price_id;
        }
    }

    public int ChangePriceCount
    {
        get
        {
            return change_price_count;
        }
    }

    public int OptionChangeMin1
    {
        get
        {
            return option_change_min_1;
        }
    }

    public int OptionRate1
    {
        get
        {
            return option_rate_1;
        }
    }

    public int OptionChangeMin2
    {
        get
        {
            return option_change_min_2;
        }
    }

    public int OptionRate2
    {
        get
        {
            return option_rate_2;
        }
    }

    public int OptionChangeMin3
    {
        get
        {
            return option_change_min_3;
        }
    }

    public int OptionRate3
    {
        get
        {
            return option_rate_3;
        }
    }

    public List<int> ListOptionChangeMin
    {
        get
        {
            if (list_option_change_min == null)
            {
                list_option_change_min = new List<int>
                {
                    OptionChangeMin1,
                    OptionChangeMin2,
                    OptionChangeMin3
                };
            }
            return list_option_change_min;
        }
    }

    public List<int> ListOptionRate
    {
        get
        {
            if (list_option_rate == null)
            {
                list_option_rate = new List<int>
                {
                    OptionRate1,
                    OptionRate2,
                    OptionRate3
                };
            }
            return list_option_rate;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        change_type = reader.ReadString();
        weapon_rating = reader.ReadInt32();
        evolution_count = reader.ReadInt32();
        change_material_id = reader.ReadInt32();
        change_material_count = reader.ReadInt32();
        change_price_id = reader.ReadInt32();
        change_price_count = reader.ReadInt32();
        option_change_min_1 = reader.ReadInt32();
        option_rate_1 = reader.ReadInt32();
        option_change_min_2 = reader.ReadInt32();
        option_rate_2 = reader.ReadInt32();
        option_change_min_3 = reader.ReadInt32();
        option_rate_3 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string change_type;

    private int weapon_rating;

    private int evolution_count;

    private int change_material_id;

    private int change_material_count;

    private int change_price_id;

    private int change_price_count;

    private int option_change_min_1;

    private int option_rate_1;

    private int option_change_min_2;

    private int option_rate_2;

    private int option_change_min_3;

    private int option_rate_3;

    private List<int> list_option_change_min;

    private List<int> list_option_rate;
}
