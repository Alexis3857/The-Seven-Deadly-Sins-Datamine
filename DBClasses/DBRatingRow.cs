public class DBRatingRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 1171U;
        }
    }

    public int Id
    {
        get
        {
            return base.DecryptInt32(id);
        }
    }

    public string Type
    {
        get
        {
            return type;
        }
    }

    public int Rating
    {
        get
        {
            return base.DecryptInt32(rating);
        }
    }

    public int RatingMaxLevel
    {
        get
        {
            return base.DecryptInt32(rating_max_level);
        }
    }

    public int CapacityMaxLevel
    {
        get
        {
            return base.DecryptInt32(capacity_max_level);
        }
    }

    public int GetExp
    {
        get
        {
            return base.DecryptInt32(get_exp);
        }
    }

    public int LevelupExpPer
    {
        get
        {
            return base.DecryptInt32(levelup_exp_per);
        }
    }

    public int BonusMaterialValue
    {
        get
        {
            return base.DecryptInt32(bonus_material_value);
        }
    }

    public int LevelupPriceId
    {
        get
        {
            return base.DecryptInt32(levelup_price_id);
        }
    }

    public int LevelupPriceCount
    {
        get
        {
            return base.DecryptInt32(levelup_price_count);
        }
    }

    public float LevelupBonusPer1
    {
        get
        {
            return base.DecryptFloat(levelup_bonus_per_1);
        }
    }

    public int LevelupBonusValue1
    {
        get
        {
            return base.DecryptInt32(levelup_bonus_value_1);
        }
    }

    public float LevelupBonusPer2
    {
        get
        {
            return base.DecryptFloat(levelup_bonus_per_2);
        }
    }

    public int LevelupBonusValue2
    {
        get
        {
            return base.DecryptInt32(levelup_bonus_value_2);
        }
    }

    public float LevelupBonusPer3
    {
        get
        {
            return base.DecryptFloat(levelup_bonus_per_3);
        }
    }

    public int LevelupBonusValue3
    {
        get
        {
            return base.DecryptInt32(levelup_bonus_value_3);
        }
    }

    public int CapacityPriceId
    {
        get
        {
            return base.DecryptInt32(capacity_price_id);
        }
    }

    public int CapacityPriceCount
    {
        get
        {
            return base.DecryptInt32(capacity_price_count);
        }
    }

    public float CapacityBonusPer1
    {
        get
        {
            return base.DecryptFloat(capacity_bonus_per_1);
        }
    }

    public int CapacityBonusValue1
    {
        get
        {
            return base.DecryptInt32(capacity_bonus_value_1);
        }
    }

    public float CapacityBonusPer2
    {
        get
        {
            return base.DecryptFloat(capacity_bonus_per_2);
        }
    }

    public int CapacityBonusValue2
    {
        get
        {
            return base.DecryptInt32(capacity_bonus_value_2);
        }
    }

    public float CapacityBonusPer3
    {
        get
        {
            return base.DecryptFloat(capacity_bonus_per_3);
        }
    }

    public int CapacityBonusValue3
    {
        get
        {
            return base.DecryptInt32(capacity_bonus_value_3);
        }
    }

    public int SkilllevelupPriceId
    {
        get
        {
            return base.DecryptInt32(skilllevelup_price_id);
        }
    }

    public int SkilllevelupPriceCount
    {
        get
        {
            return base.DecryptInt32(skilllevelup_price_count);
        }
    }

    public int SkilllevelupItemId
    {
        get
        {
            return base.DecryptInt32(skilllevelup_item_id);
        }
    }

    public int SkilllevelupItemCount
    {
        get
        {
            return base.DecryptInt32(skilllevelup_item_count);
        }
    }

    public float SkilllevelupBonusPer1
    {
        get
        {
            return base.DecryptFloat(skilllevelup_bonus_per_1);
        }
    }

    public int SkilllevelupBonusValue1
    {
        get
        {
            return base.DecryptInt32(skilllevelup_bonus_value_1);
        }
    }

    public float SkilllevelupBonusPer2
    {
        get
        {
            return base.DecryptFloat(skilllevelup_bonus_per_2);
        }
    }

    public int SkilllevelupBonusValue2
    {
        get
        {
            return base.DecryptInt32(skilllevelup_bonus_value_2);
        }
    }

    public float SkilllevelupBonusPer3
    {
        get
        {
            return base.DecryptFloat(skilllevelup_bonus_per_3);
        }
    }

    public int SkilllevelupBonusValue3
    {
        get
        {
            return base.DecryptInt32(skilllevelup_bonus_value_3);
        }
    }

    public int GrindId
    {
        get
        {
            return base.DecryptInt32(grind_id);
        }
    }

    public int GrindCount
    {
        get
        {
            return base.DecryptInt32(grind_count);
        }
    }

    public float GrindBonusPer1
    {
        get
        {
            return base.DecryptFloat(grind_bonus_per_1);
        }
    }

    public int GrindBonusValue1
    {
        get
        {
            return base.DecryptInt32(grind_bonus_value_1);
        }
    }

    public float GrindBonusPer2
    {
        get
        {
            return base.DecryptFloat(grind_bonus_per_2);
        }
    }

    public int GrindBonusValue2
    {
        get
        {
            return base.DecryptInt32(grind_bonus_value_2);
        }
    }

    public float GrindBonusPer3
    {
        get
        {
            return base.DecryptFloat(grind_bonus_per_3);
        }
    }

    public int GrindBonusValue3
    {
        get
        {
            return base.DecryptInt32(grind_bonus_value_3);
        }
    }

    public List<float> ListLevelupBonusPer
    {
        get
        {
            if (list_levelup_bonus_per == null)
            {
                list_levelup_bonus_per = new List<float>
                {
                    LevelupBonusPer1,
                    LevelupBonusPer2,
                    LevelupBonusPer3
                };
            }
            return list_levelup_bonus_per;
        }
    }

    public List<int> ListLevelupBonusValue
    {
        get
        {
            if (list_levelup_bonus_value == null)
            {
                list_levelup_bonus_value = new List<int>
                {
                    LevelupBonusValue1,
                    LevelupBonusValue2,
                    LevelupBonusValue3
                };
            }
            return list_levelup_bonus_value;
        }
    }

    public List<float> ListCapacityBonusPer
    {
        get
        {
            if (list_capacity_bonus_per == null)
            {
                list_capacity_bonus_per = new List<float>
                {
                    CapacityBonusPer1,
                    CapacityBonusPer2,
                    CapacityBonusPer3
                };
            }
            return list_capacity_bonus_per;
        }
    }

    public List<int> ListCapacityBonusValue
    {
        get
        {
            if (list_capacity_bonus_value == null)
            {
                list_capacity_bonus_value = new List<int>
                {
                    CapacityBonusValue1,
                    CapacityBonusValue2,
                    CapacityBonusValue3
                };
            }
            return list_capacity_bonus_value;
        }
    }

    public List<float> ListSkilllevelupBonusPer
    {
        get
        {
            if (list_skilllevelup_bonus_per == null)
            {
                list_skilllevelup_bonus_per = new List<float>
                {
                    SkilllevelupBonusPer1,
                    SkilllevelupBonusPer2,
                    SkilllevelupBonusPer3
                };
            }
            return list_skilllevelup_bonus_per;
        }
    }

    public List<int> ListSkilllevelupBonusValue
    {
        get
        {
            if (list_skilllevelup_bonus_value == null)
            {
                list_skilllevelup_bonus_value = new List<int>
                {
                    SkilllevelupBonusValue1,
                    SkilllevelupBonusValue2,
                    SkilllevelupBonusValue3
                };
            }
            return list_skilllevelup_bonus_value;
        }
    }

    public List<float> ListGrindBonusPer
    {
        get
        {
            if (list_grind_bonus_per == null)
            {
                list_grind_bonus_per = new List<float>
                {
                    GrindBonusPer1,
                    GrindBonusPer2,
                    GrindBonusPer3
                };
            }
            return list_grind_bonus_per;
        }
    }

    public List<int> ListGrindBonusValue
    {
        get
        {
            if (list_grind_bonus_value == null)
            {
                list_grind_bonus_value = new List<int>
                {
                    GrindBonusValue1,
                    GrindBonusValue2,
                    GrindBonusValue3
                };
            }
            return list_grind_bonus_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadBytes(4);
        type = reader.ReadString();
        rating = reader.ReadBytes(4);
        rating_max_level = reader.ReadBytes(4);
        capacity_max_level = reader.ReadBytes(4);
        get_exp = reader.ReadBytes(4);
        levelup_exp_per = reader.ReadBytes(4);
        bonus_material_value = reader.ReadBytes(4);
        levelup_price_id = reader.ReadBytes(4);
        levelup_price_count = reader.ReadBytes(4);
        levelup_bonus_per_1 = reader.ReadBytes(4);
        levelup_bonus_value_1 = reader.ReadBytes(4);
        levelup_bonus_per_2 = reader.ReadBytes(4);
        levelup_bonus_value_2 = reader.ReadBytes(4);
        levelup_bonus_per_3 = reader.ReadBytes(4);
        levelup_bonus_value_3 = reader.ReadBytes(4);
        capacity_price_id = reader.ReadBytes(4);
        capacity_price_count = reader.ReadBytes(4);
        capacity_bonus_per_1 = reader.ReadBytes(4);
        capacity_bonus_value_1 = reader.ReadBytes(4);
        capacity_bonus_per_2 = reader.ReadBytes(4);
        capacity_bonus_value_2 = reader.ReadBytes(4);
        capacity_bonus_per_3 = reader.ReadBytes(4);
        capacity_bonus_value_3 = reader.ReadBytes(4);
        skilllevelup_price_id = reader.ReadBytes(4);
        skilllevelup_price_count = reader.ReadBytes(4);
        skilllevelup_item_id = reader.ReadBytes(4);
        skilllevelup_item_count = reader.ReadBytes(4);
        skilllevelup_bonus_per_1 = reader.ReadBytes(4);
        skilllevelup_bonus_value_1 = reader.ReadBytes(4);
        skilllevelup_bonus_per_2 = reader.ReadBytes(4);
        skilllevelup_bonus_value_2 = reader.ReadBytes(4);
        skilllevelup_bonus_per_3 = reader.ReadBytes(4);
        skilllevelup_bonus_value_3 = reader.ReadBytes(4);
        grind_id = reader.ReadBytes(4);
        grind_count = reader.ReadBytes(4);
        grind_bonus_per_1 = reader.ReadBytes(4);
        grind_bonus_value_1 = reader.ReadBytes(4);
        grind_bonus_per_2 = reader.ReadBytes(4);
        grind_bonus_value_2 = reader.ReadBytes(4);
        grind_bonus_per_3 = reader.ReadBytes(4);
        grind_bonus_value_3 = reader.ReadBytes(4);
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private byte[] id;

    private string type;

    private byte[] rating;

    private byte[] rating_max_level;

    private byte[] capacity_max_level;

    private byte[] get_exp;

    private byte[] levelup_exp_per;

    private byte[] bonus_material_value;

    private byte[] levelup_price_id;

    private byte[] levelup_price_count;

    private byte[] levelup_bonus_per_1;

    private byte[] levelup_bonus_value_1;

    private byte[] levelup_bonus_per_2;

    private byte[] levelup_bonus_value_2;

    private byte[] levelup_bonus_per_3;

    private byte[] levelup_bonus_value_3;

    private byte[] capacity_price_id;

    private byte[] capacity_price_count;

    private byte[] capacity_bonus_per_1;

    private byte[] capacity_bonus_value_1;

    private byte[] capacity_bonus_per_2;

    private byte[] capacity_bonus_value_2;

    private byte[] capacity_bonus_per_3;

    private byte[] capacity_bonus_value_3;

    private byte[] skilllevelup_price_id;

    private byte[] skilllevelup_price_count;

    private byte[] skilllevelup_item_id;

    private byte[] skilllevelup_item_count;

    private byte[] skilllevelup_bonus_per_1;

    private byte[] skilllevelup_bonus_value_1;

    private byte[] skilllevelup_bonus_per_2;

    private byte[] skilllevelup_bonus_value_2;

    private byte[] skilllevelup_bonus_per_3;

    private byte[] skilllevelup_bonus_value_3;

    private byte[] grind_id;

    private byte[] grind_count;

    private byte[] grind_bonus_per_1;

    private byte[] grind_bonus_value_1;

    private byte[] grind_bonus_per_2;

    private byte[] grind_bonus_value_2;

    private byte[] grind_bonus_per_3;

    private byte[] grind_bonus_value_3;

    private List<float> list_levelup_bonus_per;

    private List<int> list_levelup_bonus_value;

    private List<float> list_capacity_bonus_per;

    private List<int> list_capacity_bonus_value;

    private List<float> list_skilllevelup_bonus_per;

    private List<int> list_skilllevelup_bonus_value;

    private List<float> list_grind_bonus_per;

    private List<int> list_grind_bonus_value;
}
