public class DBAiCustomizingSkillTypeRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string SkillTypeEnum
    {
        get
        {
            return skill_type_enum;
        }
    }

    public string SkillTypeIcon
    {
        get
        {
            return skill_type_icon;
        }
    }

    public int SkillTypeName
    {
        get
        {
            return skill_type_name;
        }
    }

    public List<int> ListArrayGroupId
    {
        get
        {
            return list_array_group_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        skill_type_enum = reader.ReadString();
        skill_type_icon = reader.ReadString();
        skill_type_name = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_group_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_group_id.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string skill_type_enum;

    private string skill_type_icon;

    private int skill_type_name;

    private List<int> list_array_group_id;
}
