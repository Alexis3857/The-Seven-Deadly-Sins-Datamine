public class DBSkillSearchGroupRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int SkillGroupId
    {
        get
        {
            return skill_group_id;
        }
    }

    public string SearchSkillGroupName
    {
        get
        {
            return search_skill_group_name.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        skill_group_id = reader.ReadInt32();
        search_skill_group_name = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int skill_group_id;

    private int search_skill_group_name;
}
