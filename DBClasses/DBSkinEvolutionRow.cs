public class DBSkinEvolutionRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int MatchingHeroId
    {
        get
        {
            return matching_hero_id;
        }
    }

    public int EvolutionBreakCheck
    {
        get
        {
            return evolution_break_check;
        }
    }

    public int EvolutionRating
    {
        get
        {
            return evolution_rating;
        }
    }

    public int CoinRate
    {
        get
        {
            return coin_rate;
        }
    }

    public int EvolutionKeyId
    {
        get
        {
            return evolution_key_id;
        }
    }

    public int EvolutionKeyCount
    {
        get
        {
            return evolution_key_count;
        }
    }

    public int EvolutionMaterialId1
    {
        get
        {
            return evolution_material_id_1;
        }
    }

    public int EvolutionMaterialCount1
    {
        get
        {
            return evolution_material_count_1;
        }
    }

    public int EvolutionMaterialId2
    {
        get
        {
            return evolution_material_id_2;
        }
    }

    public int EvolutionMaterialCount2
    {
        get
        {
            return evolution_material_count_2;
        }
    }

    public int EvolutionMaterialId3
    {
        get
        {
            return evolution_material_id_3;
        }
    }

    public int EvolutionMaterialCount3
    {
        get
        {
            return evolution_material_count_3;
        }
    }

    public int EvolutionPriceId
    {
        get
        {
            return evolution_price_id;
        }
    }

    public int EvolutionPriceCount
    {
        get
        {
            return evolution_price_count;
        }
    }

    public List<int> ListEvolutionMaterialId
    {
        get
        {
            if (list_evolution_material_id == null)
            {
                list_evolution_material_id = new List<int>
                {
                    EvolutionMaterialId1,
                    EvolutionMaterialId2,
                    EvolutionMaterialId3
                };
            }
            return list_evolution_material_id;
        }
    }

    public List<int> ListEvolutionMaterialCount
    {
        get
        {
            if (list_evolution_material_count == null)
            {
                list_evolution_material_count = new List<int>
                {
                    EvolutionMaterialCount1,
                    EvolutionMaterialCount2,
                    EvolutionMaterialCount3
                };
            }
            return list_evolution_material_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        matching_hero_id = reader.ReadInt32();
        evolution_break_check = reader.ReadInt32();
        evolution_rating = reader.ReadInt32();
        coin_rate = reader.ReadInt32();
        evolution_key_id = reader.ReadInt32();
        evolution_key_count = reader.ReadInt32();
        evolution_material_id_1 = reader.ReadInt32();
        evolution_material_count_1 = reader.ReadInt32();
        evolution_material_id_2 = reader.ReadInt32();
        evolution_material_count_2 = reader.ReadInt32();
        evolution_material_id_3 = reader.ReadInt32();
        evolution_material_count_3 = reader.ReadInt32();
        evolution_price_id = reader.ReadInt32();
        evolution_price_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int matching_hero_id;

    private int evolution_break_check;

    private int evolution_rating;

    private int coin_rate;

    private int evolution_key_id;

    private int evolution_key_count;

    private int evolution_material_id_1;

    private int evolution_material_count_1;

    private int evolution_material_id_2;

    private int evolution_material_count_2;

    private int evolution_material_id_3;

    private int evolution_material_count_3;

    private int evolution_price_id;

    private int evolution_price_count;

    private List<int> list_evolution_material_id;

    private List<int> list_evolution_material_count;
}
