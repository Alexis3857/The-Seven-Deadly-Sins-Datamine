public class DBWeaponGrindRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 600U;
        }
    }

    public int Id
    {
        get
        {
            return base.DecryptInt32(id);
        }
    }

    public int WeaponRating
    {
        get
        {
            return base.DecryptInt32(weapon_rating);
        }
    }

    public int WeaponEnchant
    {
        get
        {
            return base.DecryptInt32(weapon_enchant);
        }
    }

    public int FellowshipLevel
    {
        get
        {
            return base.DecryptInt32(fellowship_level);
        }
    }

    public int GrindItemId
    {
        get
        {
            return base.DecryptInt32(grind_item_id);
        }
    }

    public int BonusRate1
    {
        get
        {
            return base.DecryptInt32(bonus_rate_1);
        }
    }

    public int GrindItemCount1
    {
        get
        {
            return base.DecryptInt32(grind_item_count_1);
        }
    }

    public int EvolutionItemCount1
    {
        get
        {
            return base.DecryptInt32(evolution_item_count_1);
        }
    }

    public int BonusRate2
    {
        get
        {
            return base.DecryptInt32(bonus_rate_2);
        }
    }

    public int GrindItemCount2
    {
        get
        {
            return base.DecryptInt32(grind_item_count_2);
        }
    }

    public int EvolutionItemCount2
    {
        get
        {
            return base.DecryptInt32(evolution_item_count_2);
        }
    }

    public int BonusRate3
    {
        get
        {
            return base.DecryptInt32(bonus_rate_3);
        }
    }

    public int GrindItemCount3
    {
        get
        {
            return base.DecryptInt32(grind_item_count_3);
        }
    }

    public int EvolutionItemCount3
    {
        get
        {
            return base.DecryptInt32(evolution_item_count_3);
        }
    }

    public float EvolutionItemRate1
    {
        get
        {
            return base.DecryptFloat(evolution_item_rate_1);
        }
    }

    public float EvolutionItemRate2
    {
        get
        {
            return base.DecryptFloat(evolution_item_rate_2);
        }
    }

    public float EvolutionItemRate3
    {
        get
        {
            return base.DecryptFloat(evolution_item_rate_3);
        }
    }

    public float EvolutionItemRate4
    {
        get
        {
            return base.DecryptFloat(evolution_item_rate_4);
        }
    }

    public float EvolutionItemRate5
    {
        get
        {
            return base.DecryptFloat(evolution_item_rate_5);
        }
    }

    public float EvolutionItemRate6
    {
        get
        {
            return base.DecryptFloat(evolution_item_rate_6);
        }
    }

    public List<int> ListBonusRate
    {
        get
        {
            if (list_bonus_rate == null)
            {
                list_bonus_rate = new List<int>
                {
                    BonusRate1,
                    BonusRate2,
                    BonusRate3
                };
            }
            return list_bonus_rate;
        }
    }

    public List<int> ListGrindItemCount
    {
        get
        {
            if (list_grind_item_count == null)
            {
                list_grind_item_count = new List<int>
                {
                    GrindItemCount1,
                    GrindItemCount2,
                    GrindItemCount3
                };
            }
            return list_grind_item_count;
        }
    }

    public List<int> ListEvolutionItemCount
    {
        get
        {
            if (list_evolution_item_count == null)
            {
                list_evolution_item_count = new List<int>
                {
                    EvolutionItemCount1,
                    EvolutionItemCount2,
                    EvolutionItemCount3
                };
            }
            return list_evolution_item_count;
        }
    }

    public List<float> ListEvolutionItemRate
    {
        get
        {
            if (list_evolution_item_rate == null)
            {
                list_evolution_item_rate = new List<float>
                {
                    EvolutionItemRate1,
                    EvolutionItemRate2,
                    EvolutionItemRate3,
                    EvolutionItemRate4,
                    EvolutionItemRate5,
                    EvolutionItemRate6
                };
            }
            return list_evolution_item_rate;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadBytes(4);
        weapon_rating = reader.ReadBytes(4);
        weapon_enchant = reader.ReadBytes(4);
        fellowship_level = reader.ReadBytes(4);
        grind_item_id = reader.ReadBytes(4);
        bonus_rate_1 = reader.ReadBytes(4);
        grind_item_count_1 = reader.ReadBytes(4);
        evolution_item_count_1 = reader.ReadBytes(4);
        bonus_rate_2 = reader.ReadBytes(4);
        grind_item_count_2 = reader.ReadBytes(4);
        evolution_item_count_2 = reader.ReadBytes(4);
        bonus_rate_3 = reader.ReadBytes(4);
        grind_item_count_3 = reader.ReadBytes(4);
        evolution_item_count_3 = reader.ReadBytes(4);
        evolution_item_rate_1 = reader.ReadBytes(4);
        evolution_item_rate_2 = reader.ReadBytes(4);
        evolution_item_rate_3 = reader.ReadBytes(4);
        evolution_item_rate_4 = reader.ReadBytes(4);
        evolution_item_rate_5 = reader.ReadBytes(4);
        evolution_item_rate_6 = reader.ReadBytes(4);
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private byte[] id;

    private byte[] weapon_rating;

    private byte[] weapon_enchant;

    private byte[] fellowship_level;

    private byte[] grind_item_id;

    private byte[] bonus_rate_1;

    private byte[] grind_item_count_1;

    private byte[] evolution_item_count_1;

    private byte[] bonus_rate_2;

    private byte[] grind_item_count_2;

    private byte[] evolution_item_count_2;

    private byte[] bonus_rate_3;

    private byte[] grind_item_count_3;

    private byte[] evolution_item_count_3;

    private byte[] evolution_item_rate_1;

    private byte[] evolution_item_rate_2;

    private byte[] evolution_item_rate_3;

    private byte[] evolution_item_rate_4;

    private byte[] evolution_item_rate_5;

    private byte[] evolution_item_rate_6;

    private List<int> list_bonus_rate;

    private List<int> list_grind_item_count;

    private List<int> list_evolution_item_count;

    private List<float> list_evolution_item_rate;
}
