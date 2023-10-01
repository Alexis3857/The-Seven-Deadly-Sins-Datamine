public class DBFateMonsterRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string Type
    {
        get
        {
            return type;
        }
    }

    public int MonsterGroupId
    {
        get
        {
            return monster_group_id;
        }
    }

    public List<int> ListArrayHeroId
    {
        get
        {
            return list_array_hero_id;
        }
    }

    public List<int> ListArrayPassiveId
    {
        get
        {
            return list_array_passive_id;
        }
    }

    public string Potrait
    {
        get
        {
            return potrait;
        }
    }

    public string HeroName
    {
        get
        {
            return hero_name;
        }
    }

    public string Desc
    {
        get
        {
            return desc;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        type = reader.ReadString();
        monster_group_id = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_hero_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_hero_id.Add(reader.ReadInt32());
        }
        int num2 = reader.ReadInt32();
        list_array_passive_id = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_passive_id.Add(reader.ReadInt32());
        }
        potrait = reader.ReadString();
        hero_name = reader.ReadString();
        desc = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string type;

    private int monster_group_id;

    private List<int> list_array_hero_id;

    private List<int> list_array_passive_id;

    private string potrait;

    private string hero_name;

    private string desc;
}
