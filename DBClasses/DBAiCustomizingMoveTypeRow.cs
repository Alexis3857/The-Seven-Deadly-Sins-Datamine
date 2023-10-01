public class DBAiCustomizingMoveTypeRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string SkillMoveTypeEnum
    {
        get
        {
            return skill_move_type_enum;
        }
    }

    public int MoveTypeName
    {
        get
        {
            return move_type_name;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        skill_move_type_enum = reader.ReadString();
        move_type_name = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string skill_move_type_enum;

    private int move_type_name;
}
