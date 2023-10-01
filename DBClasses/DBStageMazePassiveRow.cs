public class DBStageMazePassiveRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int PassiveSkillId
    {
        get
        {
            return passive_skill_id;
        }
    }

    public int RandomPassiveGroup
    {
        get
        {
            return random_passive_group;
        }
    }

    public int RandomPassiveGrade
    {
        get
        {
            return random_passive_grade;
        }
    }

    public int BasicPassive
    {
        get
        {
            return basic_passive;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        passive_skill_id = reader.ReadInt32();
        random_passive_group = reader.ReadInt32();
        random_passive_grade = reader.ReadInt32();
        basic_passive = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int passive_skill_id;

    private int random_passive_group;

    private int random_passive_grade;

    private int basic_passive;
}
