public class DBWeaponEvolutionRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
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

    public int EvolutionMaterialId
    {
        get
        {
            return evolution_material_id;
        }
    }

    public int EvolutionMaterialCount
    {
        get
        {
            return evolution_material_count;
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

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        weapon_rating = reader.ReadInt32();
        evolution_count = reader.ReadInt32();
        evolution_material_id = reader.ReadInt32();
        evolution_material_count = reader.ReadInt32();
        evolution_price_id = reader.ReadInt32();
        evolution_price_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int weapon_rating;

    private int evolution_count;

    private int evolution_material_id;

    private int evolution_material_count;

    private int evolution_price_id;

    private int evolution_price_count;
}
