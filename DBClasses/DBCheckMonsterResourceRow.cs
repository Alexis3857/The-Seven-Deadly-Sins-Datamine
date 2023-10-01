public class DBCheckMonsterResourceRow : ITableRowIndexer
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

    public string CharacterBase
    {
        get
        {
            return character_base;
        }
    }

    public List<int> ListArrayMatchingBody
    {
        get
        {
            return list_array_matching_body;
        }
    }

    public List<int> ListArraySkillBody
    {
        get
        {
            return list_array_skill_body;
        }
    }

    public string MonsterNameLocalize
    {
        get
        {
            return monster_name_localize.Localize();
        }
    }

    public float MonsterPortraitSize
    {
        get
        {
            return monster_portrait_size;
        }
    }

    public string MonsterPortraitBase
    {
        get
        {
            return monster_portrait_base;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        portrait_on = reader.ReadInt32();
        facial_on = reader.ReadInt32();
        skill_preview_on = reader.ReadInt32();
        character_base = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_matching_body = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_matching_body.Add(reader.ReadInt32());
        }
        int num2 = reader.ReadInt32();
        list_array_skill_body = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_skill_body.Add(reader.ReadInt32());
        }
        monster_name_localize = reader.ReadInt32();
        monster_portrait_size = reader.ReadSingle();
        monster_portrait_base = reader.ReadString();
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

    private string character_base;

    private List<int> list_array_matching_body;

    private List<int> list_array_skill_body;

    private int monster_name_localize;

    private float monster_portrait_size;

    private string monster_portrait_base;
}
