public class DBEvolutionBreakBaseRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int StartRating
    {
        get
        {
            return start_rating;
        }
    }

    public int EvolutionBreakAttribute
    {
        get
        {
            return evolution_break_attribute;
        }
    }

    public int EvolutionBreakStep
    {
        get
        {
            return evolution_break_step;
        }
    }

    public int EvolutionBreakLevelUp
    {
        get
        {
            return evolution_break_level_up;
        }
    }

    public int EvolutionBreakKeyId
    {
        get
        {
            return evolution_break_key_id;
        }
    }

    public int EvolutionBreakKeyCount
    {
        get
        {
            return evolution_break_key_count;
        }
    }

    public int EvolutionBreakMaterialId1
    {
        get
        {
            return evolution_break_material_id_1;
        }
    }

    public int EvolutionBreakMaterialCount1
    {
        get
        {
            return evolution_break_material_count_1;
        }
    }

    public int EvolutionBreakMaterialId2
    {
        get
        {
            return evolution_break_material_id_2;
        }
    }

    public int EvolutionBreakMaterialCount2
    {
        get
        {
            return evolution_break_material_count_2;
        }
    }

    public int EvolutionBreakMaterialId3
    {
        get
        {
            return evolution_break_material_id_3;
        }
    }

    public int EvolutionBreakMaterialCount3
    {
        get
        {
            return evolution_break_material_count_3;
        }
    }

    public int EvolutionBreakPriceId
    {
        get
        {
            return evolution_break_price_id;
        }
    }

    public int EvolutionBreakPriceCount
    {
        get
        {
            return evolution_break_price_count;
        }
    }

    public List<int> ListEvolutionBreakMaterialId
    {
        get
        {
            if (list_evolution_break_material_id == null)
            {
                list_evolution_break_material_id = new List<int>
                {
                    EvolutionBreakMaterialId1,
                    EvolutionBreakMaterialId2,
                    EvolutionBreakMaterialId3
                };
            }
            return list_evolution_break_material_id;
        }
    }

    public List<int> ListEvolutionBreakMaterialCount
    {
        get
        {
            if (list_evolution_break_material_count == null)
            {
                list_evolution_break_material_count = new List<int>
                {
                    EvolutionBreakMaterialCount1,
                    EvolutionBreakMaterialCount2,
                    EvolutionBreakMaterialCount3
                };
            }
            return list_evolution_break_material_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        start_rating = reader.ReadInt32();
        evolution_break_attribute = reader.ReadInt32();
        evolution_break_step = reader.ReadInt32();
        evolution_break_level_up = reader.ReadInt32();
        evolution_break_key_id = reader.ReadInt32();
        evolution_break_key_count = reader.ReadInt32();
        evolution_break_material_id_1 = reader.ReadInt32();
        evolution_break_material_count_1 = reader.ReadInt32();
        evolution_break_material_id_2 = reader.ReadInt32();
        evolution_break_material_count_2 = reader.ReadInt32();
        evolution_break_material_id_3 = reader.ReadInt32();
        evolution_break_material_count_3 = reader.ReadInt32();
        evolution_break_price_id = reader.ReadInt32();
        evolution_break_price_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int start_rating;

    private int evolution_break_attribute;

    private int evolution_break_step;

    private int evolution_break_level_up;

    private int evolution_break_key_id;

    private int evolution_break_key_count;

    private int evolution_break_material_id_1;

    private int evolution_break_material_count_1;

    private int evolution_break_material_id_2;

    private int evolution_break_material_count_2;

    private int evolution_break_material_id_3;

    private int evolution_break_material_count_3;

    private int evolution_break_price_id;

    private int evolution_break_price_count;

    private List<int> list_evolution_break_material_id;

    private List<int> list_evolution_break_material_count;
}
