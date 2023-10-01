public class DBSkinAwakenResourceRow : ITableRowIndexer
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

    public int SkinRating
    {
        get
        {
            return skin_rating;
        }
    }

    public int SkinAwakenCount
    {
        get
        {
            return skin_awaken_count;
        }
    }

    public int AwakenMaterialId1
    {
        get
        {
            return awaken_material_id_1;
        }
    }

    public int AwakenMaterialCount1
    {
        get
        {
            return awaken_material_count_1;
        }
    }

    public int AwakenMaterialId2
    {
        get
        {
            return awaken_material_id_2;
        }
    }

    public int AwakenMaterialCount2
    {
        get
        {
            return awaken_material_count_2;
        }
    }

    public int AwakenMaterialId3
    {
        get
        {
            return awaken_material_id_3;
        }
    }

    public int AwakenMaterialCount3
    {
        get
        {
            return awaken_material_count_3;
        }
    }

    public int AwakenMaterialId4
    {
        get
        {
            return awaken_material_id_4;
        }
    }

    public int AwakenMaterialCount4
    {
        get
        {
            return awaken_material_count_4;
        }
    }

    public int AwakenPriceId
    {
        get
        {
            return awaken_price_id;
        }
    }

    public int AwakenPriceCount
    {
        get
        {
            return awaken_price_count;
        }
    }

    public int WeaponCostumeId
    {
        get
        {
            return weapon_costume_id;
        }
    }

    public List<int> ListAwakenMaterialId
    {
        get
        {
            if (list_awaken_material_id == null)
            {
                list_awaken_material_id = new List<int>
                {
                    AwakenMaterialId1,
                    AwakenMaterialId2,
                    AwakenMaterialId3,
                    AwakenMaterialId4
                };
            }
            return list_awaken_material_id;
        }
    }

    public List<int> ListAwakenMaterialCount
    {
        get
        {
            if (list_awaken_material_count == null)
            {
                list_awaken_material_count = new List<int>
                {
                    AwakenMaterialCount1,
                    AwakenMaterialCount2,
                    AwakenMaterialCount3,
                    AwakenMaterialCount4
                };
            }
            return list_awaken_material_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        hero_id = reader.ReadInt32();
        skin_rating = reader.ReadInt32();
        skin_awaken_count = reader.ReadInt32();
        awaken_material_id_1 = reader.ReadInt32();
        awaken_material_count_1 = reader.ReadInt32();
        awaken_material_id_2 = reader.ReadInt32();
        awaken_material_count_2 = reader.ReadInt32();
        awaken_material_id_3 = reader.ReadInt32();
        awaken_material_count_3 = reader.ReadInt32();
        awaken_material_id_4 = reader.ReadInt32();
        awaken_material_count_4 = reader.ReadInt32();
        awaken_price_id = reader.ReadInt32();
        awaken_price_count = reader.ReadInt32();
        weapon_costume_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int hero_id;

    private int skin_rating;

    private int skin_awaken_count;

    private int awaken_material_id_1;

    private int awaken_material_count_1;

    private int awaken_material_id_2;

    private int awaken_material_count_2;

    private int awaken_material_id_3;

    private int awaken_material_count_3;

    private int awaken_material_id_4;

    private int awaken_material_count_4;

    private int awaken_price_id;

    private int awaken_price_count;

    private int weapon_costume_id;

    private List<int> list_awaken_material_id;

    private List<int> list_awaken_material_count;
}
