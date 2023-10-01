public class DBStageTrainingTaskOpenRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string TaskOpenCondition
    {
        get
        {
            return task_open_condition;
        }
    }

    public int TaskOpenConditionValue1
    {
        get
        {
            return task_open_condition_value_1;
        }
    }

    public int TaskOpenConditionValue2
    {
        get
        {
            return task_open_condition_value_2;
        }
    }

    public int OpenRate
    {
        get
        {
            return open_rate;
        }
    }

    public int OpenTaskGroupId
    {
        get
        {
            return open_task_group_id;
        }
    }

    public List<int> ListTaskOpenConditionValue
    {
        get
        {
            if (list_task_open_condition_value == null)
            {
                list_task_open_condition_value = new List<int>
                {
                    TaskOpenConditionValue1,
                    TaskOpenConditionValue2
                };
            }
            return list_task_open_condition_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        task_open_condition = reader.ReadString();
        task_open_condition_value_1 = reader.ReadInt32();
        task_open_condition_value_2 = reader.ReadInt32();
        open_rate = reader.ReadInt32();
        open_task_group_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string task_open_condition;

    private int task_open_condition_value_1;

    private int task_open_condition_value_2;

    private int open_rate;

    private int open_task_group_id;

    private List<int> list_task_open_condition_value;
}
