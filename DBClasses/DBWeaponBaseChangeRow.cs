public class DBWeaponBaseChangeRow : ITableRowIndexer
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

    public int NeedMaterialId1
    {
        get
        {
            return need_material_id_1;
        }
    }

    public int NeedMaterialCount1
    {
        get
        {
            return need_material_count_1;
        }
    }

    public int NeedMaterialId2
    {
        get
        {
            return need_material_id_2;
        }
    }

    public int NeedMaterialCount2
    {
        get
        {
            return need_material_count_2;
        }
    }

    public int NeedMaterialId3
    {
        get
        {
            return need_material_id_3;
        }
    }

    public int NeedMaterialCount3
    {
        get
        {
            return need_material_count_3;
        }
    }

    public List<int> ListNeedMaterialId
    {
        get
        {
            if (list_need_material_id == null)
            {
                list_need_material_id = new List<int>
                {
                    NeedMaterialId1,
                    NeedMaterialId2,
                    NeedMaterialId3
                };
            }
            return list_need_material_id;
        }
    }

    public List<int> ListNeedMaterialCount
    {
        get
        {
            if (list_need_material_count == null)
            {
                list_need_material_count = new List<int>
                {
                    NeedMaterialCount1,
                    NeedMaterialCount2,
                    NeedMaterialCount3
                };
            }
            return list_need_material_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        change_type = reader.ReadString();
        weapon_rating = reader.ReadInt32();
        need_material_id_1 = reader.ReadInt32();
        need_material_count_1 = reader.ReadInt32();
        need_material_id_2 = reader.ReadInt32();
        need_material_count_2 = reader.ReadInt32();
        need_material_id_3 = reader.ReadInt32();
        need_material_count_3 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string change_type;

    private int weapon_rating;

    private int need_material_id_1;

    private int need_material_count_1;

    private int need_material_id_2;

    private int need_material_count_2;

    private int need_material_id_3;

    private int need_material_count_3;

    private List<int> list_need_material_id;

    private List<int> list_need_material_count;
}
