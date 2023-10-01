public class DBCheckHeroResourceRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int PortraitOn
    {
        get
        {
            return portrait_on;
        }
    }

    public int FacialOn
    {
        get
        {
            return facial_on;
        }
    }

    public int SkillPreviewOn
    {
        get
        {
            return skill_preview_on;
        }
    }

    public int MatchingHeroId
    {
        get
        {
            return matching_hero_id;
        }
    }

    public List<int> ListArrayMatchingSkin
    {
        get
        {
            return list_array_matching_skin;
        }
    }

    public string HeroNameLocalize
    {
        get
        {
            return hero_name_localize.Localize();
        }
    }

    public float HeroPortraitSize
    {
        get
        {
            return hero_portrait_size;
        }
    }

    public string HeroPotraitBase
    {
        get
        {
            return hero_potrait_base;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        portrait_on = reader.ReadInt32();
        facial_on = reader.ReadInt32();
        skill_preview_on = reader.ReadInt32();
        matching_hero_id = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_matching_skin = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_matching_skin.Add(reader.ReadInt32());
        }
        hero_name_localize = reader.ReadInt32();
        hero_portrait_size = reader.ReadSingle();
        hero_potrait_base = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int portrait_on;

    private int facial_on;

    private int skill_preview_on;

    private int matching_hero_id;

    private List<int> list_array_matching_skin;

    private int hero_name_localize;

    private float hero_portrait_size;

    private string hero_potrait_base;
}
