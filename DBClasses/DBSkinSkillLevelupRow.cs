public class DBSkinSkillLevelupRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int HeroId
    {
        get
        {
            return hero_id;
        }
    }

    public int SpecialMaterialCount1
    {
        get
        {
            return special_material_count_1;
        }
    }

    public int SpecialPriceId1
    {
        get
        {
            return special_price_id_1;
        }
    }

    public int SpecialPriceCount1
    {
        get
        {
            return special_price_count_1;
        }
    }

    public int SpecialMaterialCount2
    {
        get
        {
            return special_material_count_2;
        }
    }

    public int SpecialPriceId2
    {
        get
        {
            return special_price_id_2;
        }
    }

    public int SpecialPriceCount2
    {
        get
        {
            return special_price_count_2;
        }
    }

    public int SpecialMaterialCount3
    {
        get
        {
            return special_material_count_3;
        }
    }

    public int SpecialPriceId3
    {
        get
        {
            return special_price_id_3;
        }
    }

    public int SpecialPriceCount3
    {
        get
        {
            return special_price_count_3;
        }
    }

    public int SpecialMaterialCount4
    {
        get
        {
            return special_material_count_4;
        }
    }

    public int SpecialPriceId4
    {
        get
        {
            return special_price_id_4;
        }
    }

    public int SpecialPriceCount4
    {
        get
        {
            return special_price_count_4;
        }
    }

    public int SpecialMaterialCount5
    {
        get
        {
            return special_material_count_5;
        }
    }

    public int SpecialPriceId5
    {
        get
        {
            return special_price_id_5;
        }
    }

    public int SpecialPriceCount5
    {
        get
        {
            return special_price_count_5;
        }
    }

    public int SpecialMaterialCount6
    {
        get
        {
            return special_material_count_6;
        }
    }

    public int SpecialPriceId6
    {
        get
        {
            return special_price_id_6;
        }
    }

    public int SpecialPriceCount6
    {
        get
        {
            return special_price_count_6;
        }
    }

    public List<int> ListSpecialMaterialCount
    {
        get
        {
            if (list_special_material_count == null)
            {
                list_special_material_count = new List<int>
                {
                    SpecialMaterialCount1,
                    SpecialMaterialCount2,
                    SpecialMaterialCount3,
                    SpecialMaterialCount4,
                    SpecialMaterialCount5,
                    SpecialMaterialCount6
                };
            }
            return list_special_material_count;
        }
    }

    public List<int> ListSpecialPriceId
    {
        get
        {
            if (list_special_price_id == null)
            {
                list_special_price_id = new List<int>
                {
                    SpecialPriceId1,
                    SpecialPriceId2,
                    SpecialPriceId3,
                    SpecialPriceId4,
                    SpecialPriceId5,
                    SpecialPriceId6
                };
            }
            return list_special_price_id;
        }
    }

    public List<int> ListSpecialPriceCount
    {
        get
        {
            if (list_special_price_count == null)
            {
                list_special_price_count = new List<int>
                {
                    SpecialPriceCount1,
                    SpecialPriceCount2,
                    SpecialPriceCount3,
                    SpecialPriceCount4,
                    SpecialPriceCount5,
                    SpecialPriceCount6
                };
            }
            return list_special_price_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        hero_id = reader.ReadInt32();
        special_material_count_1 = reader.ReadInt32();
        special_price_id_1 = reader.ReadInt32();
        special_price_count_1 = reader.ReadInt32();
        special_material_count_2 = reader.ReadInt32();
        special_price_id_2 = reader.ReadInt32();
        special_price_count_2 = reader.ReadInt32();
        special_material_count_3 = reader.ReadInt32();
        special_price_id_3 = reader.ReadInt32();
        special_price_count_3 = reader.ReadInt32();
        special_material_count_4 = reader.ReadInt32();
        special_price_id_4 = reader.ReadInt32();
        special_price_count_4 = reader.ReadInt32();
        special_material_count_5 = reader.ReadInt32();
        special_price_id_5 = reader.ReadInt32();
        special_price_count_5 = reader.ReadInt32();
        special_material_count_6 = reader.ReadInt32();
        special_price_id_6 = reader.ReadInt32();
        special_price_count_6 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int hero_id;

    private int special_material_count_1;

    private int special_price_id_1;

    private int special_price_count_1;

    private int special_material_count_2;

    private int special_price_id_2;

    private int special_price_count_2;

    private int special_material_count_3;

    private int special_price_id_3;

    private int special_price_count_3;

    private int special_material_count_4;

    private int special_price_id_4;

    private int special_price_count_4;

    private int special_material_count_5;

    private int special_price_id_5;

    private int special_price_count_5;

    private int special_material_count_6;

    private int special_price_id_6;

    private int special_price_count_6;

    private List<int> list_special_material_count;

    private List<int> list_special_price_id;

    private List<int> list_special_price_count;
}
