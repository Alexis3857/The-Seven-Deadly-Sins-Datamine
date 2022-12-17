public class DBAiCustomizingMoveRow
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

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        skill_condition_enum = reader.ReadString();
        skill_condition_name = reader.ReadInt32();
        return true;
    }

    private int id;

    private string skill_condition_enum;

    private int skill_condition_name;
}
