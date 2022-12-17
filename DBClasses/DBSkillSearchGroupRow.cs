public class DBSkillSearchGroupRow
{
    public int Id
    {
        get
        {
            return id;
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
        search_skill_group_name = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int search_skill_group_name;
}
