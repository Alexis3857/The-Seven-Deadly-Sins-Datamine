public class DBAiCustomizingCostRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string SkillCostEnum
    {
        get
        {
            return skill_cost_enum;
        }
    }

    public int SkillCostName
    {
        get
        {
            return skill_cost_name;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        skill_cost_enum = reader.ReadString();
        skill_cost_name = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string skill_cost_enum;

    private int skill_cost_name;
}
