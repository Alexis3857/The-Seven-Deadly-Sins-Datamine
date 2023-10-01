public class DBEventAutoStageRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public int StageGroup
    {
        get
        {
            return stage_group;
        }
    }

    public int StageOrder
    {
        get
        {
            return stage_order;
        }
    }

    public int Grade
    {
        get
        {
            return grade;
        }
    }

    public int MonsterId
    {
        get
        {
            return monster_id;
        }
    }

    public int MonsterHP
    {
        get
        {
            return monster_HP;
        }
    }

    public int EnhanceRewardCount
    {
        get
        {
            return enhance_reward_count;
        }
    }

    public int BoxRewardGrade
    {
        get
        {
            return box_reward_grade;
        }
    }

    public int BoxRewardCount
    {
        get
        {
            return box_reward_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        stage_group = reader.ReadInt32();
        stage_order = reader.ReadInt32();
        grade = reader.ReadInt32();
        monster_id = reader.ReadInt32();
        monster_HP = reader.ReadInt32();
        enhance_reward_count = reader.ReadInt32();
        box_reward_grade = reader.ReadInt32();
        box_reward_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int stage_group;

    private int stage_order;

    private int grade;

    private int monster_id;

    private int monster_HP;

    private int enhance_reward_count;

    private int box_reward_grade;

    private int box_reward_count;
}
