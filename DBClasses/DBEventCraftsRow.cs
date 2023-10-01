public class DBEventCraftsRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public int MaterialItemId1
    {
        get
        {
            return material_item_id_1;
        }
    }

    public int MaterialItemCount1
    {
        get
        {
            return material_item_count_1;
        }
    }

    public int MaterialItemId2
    {
        get
        {
            return material_item_id_2;
        }
    }

    public int MaterialItemCount2
    {
        get
        {
            return material_item_count_2;
        }
    }

    public int MaterialItemId3
    {
        get
        {
            return material_item_id_3;
        }
    }

    public int MaterialItemCount3
    {
        get
        {
            return material_item_count_3;
        }
    }

    public int OutputItemId
    {
        get
        {
            return output_item_id;
        }
    }

    public int OutputItemCount
    {
        get
        {
            return output_item_count;
        }
    }

    public List<int> ListMaterialItemId
    {
        get
        {
            if (list_material_item_id == null)
            {
                list_material_item_id = new List<int>
                {
                    MaterialItemId1,
                    MaterialItemId2,
                    MaterialItemId3
                };
            }
            return list_material_item_id;
        }
    }

    public List<int> ListMaterialItemCount
    {
        get
        {
            if (list_material_item_count == null)
            {
                list_material_item_count = new List<int>
                {
                    MaterialItemCount1,
                    MaterialItemCount2,
                    MaterialItemCount3
                };
            }
            return list_material_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        material_item_id_1 = reader.ReadInt32();
        material_item_count_1 = reader.ReadInt32();
        material_item_id_2 = reader.ReadInt32();
        material_item_count_2 = reader.ReadInt32();
        material_item_id_3 = reader.ReadInt32();
        material_item_count_3 = reader.ReadInt32();
        output_item_id = reader.ReadInt32();
        output_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int material_item_id_1;

    private int material_item_count_1;

    private int material_item_id_2;

    private int material_item_count_2;

    private int material_item_id_3;

    private int material_item_count_3;

    private int output_item_id;

    private int output_item_count;

    private List<int> list_material_item_id;

    private List<int> list_material_item_count;
}
