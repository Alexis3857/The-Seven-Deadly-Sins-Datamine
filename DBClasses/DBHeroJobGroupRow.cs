public class DBHeroJobGroupRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string HeroJobGroupName
    {
        get
        {
            return hero_job_group_name.Localize();
        }
    }

    public List<int> ListArrayHeroId
    {
        get
        {
            return list_array_hero_id;
        }
    }

    public List<int> ListArrayUnionId
    {
        get
        {
            return list_array_union_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        hero_job_group_name = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_hero_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_hero_id.Add(reader.ReadInt32());
        }
        int num2 = reader.ReadInt32();
        list_array_union_id = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_union_id.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int hero_job_group_name;

    private List<int> list_array_hero_id;

    private List<int> list_array_union_id;
}
