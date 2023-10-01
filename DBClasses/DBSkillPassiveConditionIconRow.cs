public class DBSkillPassiveConditionIconRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string PassiveConditionIcon
    {
        get
        {
            return passive_condition_icon;
        }
    }

    public string PassiveConditionDesc
    {
        get
        {
            return passive_condition_desc.Localize();
        }
    }

    public string PassiveConditionFilterName
    {
        get
        {
            return passive_condition_filter_name.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        passive_condition_icon = reader.ReadString();
        passive_condition_desc = reader.ReadInt32();
        passive_condition_filter_name = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string passive_condition_icon;

    private int passive_condition_desc;

    private int passive_condition_filter_name;
}
