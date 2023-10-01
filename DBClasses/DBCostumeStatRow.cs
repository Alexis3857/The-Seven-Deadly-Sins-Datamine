public class DBCostumeStatRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int CostumeType
    {
        get
        {
            return costume_type;
        }
    }

    public int UpgradeLevel
    {
        get
        {
            return upgrade_level;
        }
    }

    public int CostumeRating
    {
        get
        {
            return costume_rating;
        }
    }

    public int CostumeStatType
    {
        get
        {
            return costume_stat_type;
        }
    }

    public int UpgradeStatTier1
    {
        get
        {
            return upgrade_stat_tier_1;
        }
    }

    public int UpgradeMaterialIdTier1
    {
        get
        {
            return upgrade_material_id_tier_1;
        }
    }

    public int UpgradeMaterialCountTier1
    {
        get
        {
            return upgrade_material_count_tier_1;
        }
    }

    public int UpgradePriceIdTier1
    {
        get
        {
            return upgrade_price_id_tier_1;
        }
    }

    public int UpgradePriceCountTier1
    {
        get
        {
            return upgrade_price_count_tier_1;
        }
    }

    public int UpgradeStatTier2
    {
        get
        {
            return upgrade_stat_tier_2;
        }
    }

    public int UpgradeMaterialIdTier2
    {
        get
        {
            return upgrade_material_id_tier_2;
        }
    }

    public int UpgradeMaterialCountTier2
    {
        get
        {
            return upgrade_material_count_tier_2;
        }
    }

    public int UpgradePriceIdTier2
    {
        get
        {
            return upgrade_price_id_tier_2;
        }
    }

    public int UpgradePriceCountTier2
    {
        get
        {
            return upgrade_price_count_tier_2;
        }
    }

    public int UpgradeStatTier3
    {
        get
        {
            return upgrade_stat_tier_3;
        }
    }

    public int UpgradeMaterialIdTier3
    {
        get
        {
            return upgrade_material_id_tier_3;
        }
    }

    public int UpgradeMaterialCountTier3
    {
        get
        {
            return upgrade_material_count_tier_3;
        }
    }

    public int UpgradePriceIdTier3
    {
        get
        {
            return upgrade_price_id_tier_3;
        }
    }

    public int UpgradePriceCountTier3
    {
        get
        {
            return upgrade_price_count_tier_3;
        }
    }

    public int UpgradeStatTier4
    {
        get
        {
            return upgrade_stat_tier_4;
        }
    }

    public int UpgradeMaterialIdTier4
    {
        get
        {
            return upgrade_material_id_tier_4;
        }
    }

    public int UpgradeMaterialCountTier4
    {
        get
        {
            return upgrade_material_count_tier_4;
        }
    }

    public int UpgradePriceIdTier4
    {
        get
        {
            return upgrade_price_id_tier_4;
        }
    }

    public int UpgradePriceCountTier4
    {
        get
        {
            return upgrade_price_count_tier_4;
        }
    }

    public List<int> ListUpgradeStatTier
    {
        get
        {
            if (list_upgrade_stat_tier == null)
            {
                list_upgrade_stat_tier = new List<int>
                {
                    UpgradeStatTier1,
                    UpgradeStatTier2,
                    UpgradeStatTier3,
                    UpgradeStatTier4
                };
            }
            return list_upgrade_stat_tier;
        }
    }

    public List<int> ListUpgradeMaterialIdTier
    {
        get
        {
            if (list_upgrade_material_id_tier == null)
            {
                list_upgrade_material_id_tier = new List<int>
                {
                    UpgradeMaterialIdTier1,
                    UpgradeMaterialIdTier2,
                    UpgradeMaterialIdTier3,
                    UpgradeMaterialIdTier4
                };
            }
            return list_upgrade_material_id_tier;
        }
    }

    public List<int> ListUpgradeMaterialCountTier
    {
        get
        {
            if (list_upgrade_material_count_tier == null)
            {
                list_upgrade_material_count_tier = new List<int>
                {
                    UpgradeMaterialCountTier1,
                    UpgradeMaterialCountTier2,
                    UpgradeMaterialCountTier3,
                    UpgradeMaterialCountTier4
                };
            }
            return list_upgrade_material_count_tier;
        }
    }

    public List<int> ListUpgradePriceIdTier
    {
        get
        {
            if (list_upgrade_price_id_tier == null)
            {
                list_upgrade_price_id_tier = new List<int>
                {
                    UpgradePriceIdTier1,
                    UpgradePriceIdTier2,
                    UpgradePriceIdTier3,
                    UpgradePriceIdTier4
                };
            }
            return list_upgrade_price_id_tier;
        }
    }

    public List<int> ListUpgradePriceCountTier
    {
        get
        {
            if (list_upgrade_price_count_tier == null)
            {
                list_upgrade_price_count_tier = new List<int>
                {
                    UpgradePriceCountTier1,
                    UpgradePriceCountTier2,
                    UpgradePriceCountTier3,
                    UpgradePriceCountTier4
                };
            }
            return list_upgrade_price_count_tier;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        costume_type = reader.ReadInt32();
        upgrade_level = reader.ReadInt32();
        costume_rating = reader.ReadInt32();
        costume_stat_type = reader.ReadInt32();
        upgrade_stat_tier_1 = reader.ReadInt32();
        upgrade_material_id_tier_1 = reader.ReadInt32();
        upgrade_material_count_tier_1 = reader.ReadInt32();
        upgrade_price_id_tier_1 = reader.ReadInt32();
        upgrade_price_count_tier_1 = reader.ReadInt32();
        upgrade_stat_tier_2 = reader.ReadInt32();
        upgrade_material_id_tier_2 = reader.ReadInt32();
        upgrade_material_count_tier_2 = reader.ReadInt32();
        upgrade_price_id_tier_2 = reader.ReadInt32();
        upgrade_price_count_tier_2 = reader.ReadInt32();
        upgrade_stat_tier_3 = reader.ReadInt32();
        upgrade_material_id_tier_3 = reader.ReadInt32();
        upgrade_material_count_tier_3 = reader.ReadInt32();
        upgrade_price_id_tier_3 = reader.ReadInt32();
        upgrade_price_count_tier_3 = reader.ReadInt32();
        upgrade_stat_tier_4 = reader.ReadInt32();
        upgrade_material_id_tier_4 = reader.ReadInt32();
        upgrade_material_count_tier_4 = reader.ReadInt32();
        upgrade_price_id_tier_4 = reader.ReadInt32();
        upgrade_price_count_tier_4 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int costume_type;

    private int upgrade_level;

    private int costume_rating;

    private int costume_stat_type;

    private int upgrade_stat_tier_1;

    private int upgrade_material_id_tier_1;

    private int upgrade_material_count_tier_1;

    private int upgrade_price_id_tier_1;

    private int upgrade_price_count_tier_1;

    private int upgrade_stat_tier_2;

    private int upgrade_material_id_tier_2;

    private int upgrade_material_count_tier_2;

    private int upgrade_price_id_tier_2;

    private int upgrade_price_count_tier_2;

    private int upgrade_stat_tier_3;

    private int upgrade_material_id_tier_3;

    private int upgrade_material_count_tier_3;

    private int upgrade_price_id_tier_3;

    private int upgrade_price_count_tier_3;

    private int upgrade_stat_tier_4;

    private int upgrade_material_id_tier_4;

    private int upgrade_material_count_tier_4;

    private int upgrade_price_id_tier_4;

    private int upgrade_price_count_tier_4;

    private List<int> list_upgrade_stat_tier;

    private List<int> list_upgrade_material_id_tier;

    private List<int> list_upgrade_material_count_tier;

    private List<int> list_upgrade_price_id_tier;

    private List<int> list_upgrade_price_count_tier;
}
