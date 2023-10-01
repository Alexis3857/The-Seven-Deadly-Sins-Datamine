public class DBAiCustomizingTypeRow : ITableRowIndexer
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

    public string SkillTypeName
    {
        get
        {
            return skill_type_name.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        skill_type_enum = reader.ReadString();
        skill_type_icon = reader.ReadString();
        skill_type_name = reader.ReadInt32();
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
}
