public class DBAiCustomizingSkillSelectRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string SkillSelectEnum
    {
        get
        {
            return skill_select_enum;
        }
    }

    public List<string> ListArraySkillSelectContainSkillType
    {
        get
        {
            return list_array_skill_select_contain_skill_type;
        }
    }

    public string SkillSelectName
    {
        get
        {
            return skill_select_name.Localize();
        }
    }

    public int CheckActiveSkillTarget
    {
        get
        {
            return check_active_skill_target;
        }
    }


    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        skill_select_enum = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_skill_select_contain_skill_type = new List<string>();
        for (int i = 0; i < num; i++)
        {
            list_array_skill_select_contain_skill_type.Add(reader.ReadString());
        }
        skill_select_name = reader.ReadInt32();
        check_active_skill_target = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string skill_select_enum;

    private List<string> list_array_skill_select_contain_skill_type;

    private int skill_select_name;

    private int check_active_skill_target;
}
