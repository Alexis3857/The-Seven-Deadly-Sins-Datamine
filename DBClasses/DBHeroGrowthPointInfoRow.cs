public class DBHeroGrowthPointInfoRow : ITableRowIndexer
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

    public int HeroGetGp
    {
        get
        {
            return hero_get_gp;
        }
    }

    public int HeroEvolutionBreakGp
    {
        get
        {
            return hero_evolution_break_gp;
        }
    }

    public int HeroEvolutionLrGp
    {
        get
        {
            return hero_evolution_lr_gp;
        }
    }

    public int HeroAwakenGp
    {
        get
        {
            return hero_awaken_gp;
        }
    }

    public int HeroTranscendGp
    {
        get
        {
            return hero_transcend_gp;
        }
    }

    public int HeroExceedGp
    {
        get
        {
            return hero_exceed_gp;
        }
    }

    public int HeroSkilUpgradeGp
    {
        get
        {
            return hero_skil_upgrade_gp;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        start_rating = reader.ReadInt32();
        hero_get_gp = reader.ReadInt32();
        hero_evolution_break_gp = reader.ReadInt32();
        hero_evolution_lr_gp = reader.ReadInt32();
        hero_awaken_gp = reader.ReadInt32();
        hero_transcend_gp = reader.ReadInt32();
        hero_exceed_gp = reader.ReadInt32();
        hero_skil_upgrade_gp = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int start_rating;

    private int hero_get_gp;

    private int hero_evolution_break_gp;

    private int hero_evolution_lr_gp;

    private int hero_awaken_gp;

    private int hero_transcend_gp;

    private int hero_exceed_gp;

    private int hero_skil_upgrade_gp;
}
