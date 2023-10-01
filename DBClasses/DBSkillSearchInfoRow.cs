public class DBSkillSearchInfoRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string SearchSkillName
    {
        get
        {
            return search_skill_name.Localize();
        }
    }

    public int SearchSkillTargetTag
    {
        get
        {
            return search_skill_target_tag;
        }
    }

    public byte SearchSkillGroup
    {
        get
        {
            return search_skill_group;
        }
    }

    public int SearchSkillSort
    {
        get
        {
            return search_skill_sort;
        }
    }

    public string SearchSkillDesc
    {
        get
        {
            return search_skill_desc.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        search_skill_name = reader.ReadInt32();
        search_skill_target_tag = reader.ReadInt32();
        search_skill_group = reader.ReadByte();
        search_skill_sort = reader.ReadInt32();
        search_skill_desc = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int search_skill_name;

    private int search_skill_target_tag;

    private byte search_skill_group;

    private int search_skill_sort;

    private int search_skill_desc;
}
