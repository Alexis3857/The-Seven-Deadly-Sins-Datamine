public class DBAiCustomizingGroupRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GroupName
    {
        get
        {
            return group_name;
        }
    }

    public int GroupContainAction
    {
        get
        {
            return group_contain_action;
        }
    }

    public int ActionCheck
    {
        get
        {
            return action_check;
        }
    }

    public string GroupTypeIcon
    {
        get
        {
            return group_type_icon;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        group_name = reader.ReadInt32();
        group_contain_action = reader.ReadInt32();
        action_check = reader.ReadInt32();
        group_type_icon = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int group_name;

    private int group_contain_action;

    private int action_check;

    private string group_type_icon;
}
