public class DBAiCustomizingConditionRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string SkillConditionEnum
    {
        get
        {
            return skill_condition_enum;
        }
    }

    public int SkillConditionName
    {
        get
        {
            return skill_condition_name;
        }
    }

    public List<int> ListArraySkillConditionType
    {
        get
        {
            return list_array_skill_condition_type;
        }
    }

    public List<int> ListArrayConditionOrder
    {
        get
        {
            return list_array_condition_order;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        skill_condition_enum = reader.ReadString();
        skill_condition_name = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_skill_condition_type = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_skill_condition_type.Add(reader.ReadInt32());
        }
        int num2 = reader.ReadInt32();
        list_array_condition_order = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_condition_order.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string skill_condition_enum;

    private int skill_condition_name;

    private List<int> list_array_skill_condition_type;

    private List<int> list_array_condition_order;
}
