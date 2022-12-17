public class DBStageMazePassiveRow
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

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        passive_skill_id = reader.ReadInt32();
        random_passive_group = reader.ReadInt32();
        random_passive_grade = reader.ReadInt32();
        return true;
    }

    private int id;

    private int passive_skill_id;

    private int random_passive_group;

    private int random_passive_grade;
}
