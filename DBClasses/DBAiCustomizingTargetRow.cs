public class DBAiCustomizingTargetRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string SkillTargetEnum
    {
        get
        {
            return skill_target_enum;
        }
    }

    public int SkillTargetName
    {
        get
        {
            return skill_target_name;
        }
    }

    public List<int> ListArraySkillTargetType
    {
        get
        {
            return list_array_skill_target_type;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        skill_target_enum = reader.ReadString();
        skill_target_name = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_skill_target_type = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_skill_target_type.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string skill_target_enum;

    private int skill_target_name;

    private List<int> list_array_skill_target_type;
}
