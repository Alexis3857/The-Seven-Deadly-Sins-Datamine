public class DBStageTrainingTaskRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string TaskGroup
    {
        get
        {
            return task_group;
        }
    }

    public int TaskGroupRate
    {
        get
        {
            return task_group_rate;
        }
    }

    public string TaskType
    {
        get
        {
            return task_type;
        }
    }

    public int TaskValue1
    {
        get
        {
            return task_value_1;
        }
    }

    public int TaskValue2
    {
        get
        {
            return task_value_2;
        }
    }

    public string TaskRewardType
    {
        get
        {
            return task_reward_type;
        }
    }

    public int TaskRewardValue1
    {
        get
        {
            return task_reward_value_1;
        }
    }

    public int TaskRewardValue2
    {
        get
        {
            return task_reward_value_2;
        }
    }

    public string TaskRewardIcon
    {
        get
        {
            return task_reward_icon;
        }
    }

    public string TaskName
    {
        get
        {
            return task_name.Localize();
        }
    }

    public string TaskDesc
    {
        get
        {
            return task_desc.Localize();
        }
    }

    public List<int> ListTaskValue
    {
        get
        {
            if (list_task_value == null)
            {
                list_task_value = new List<int>
                {
                    TaskValue1,
                    TaskValue2
                };
            }
            return list_task_value;
        }
    }

    public List<int> ListTaskRewardValue
    {
        get
        {
            if (list_task_reward_value == null)
            {
                list_task_reward_value = new List<int>
                {
                    TaskRewardValue1,
                    TaskRewardValue2
                };
            }
            return list_task_reward_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        task_group = reader.ReadString();
        task_group_rate = reader.ReadInt32();
        task_type = reader.ReadString();
        task_value_1 = reader.ReadInt32();
        task_value_2 = reader.ReadInt32();
        task_reward_type = reader.ReadString();
        task_reward_value_1 = reader.ReadInt32();
        task_reward_value_2 = reader.ReadInt32();
        task_reward_icon = reader.ReadString();
        task_name = reader.ReadInt32();
        task_desc = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string task_group;

    private int task_group_rate;

    private string task_type;

    private int task_value_1;

    private int task_value_2;

    private string task_reward_type;

    private int task_reward_value_1;

    private int task_reward_value_2;

    private string task_reward_icon;

    private int task_name;

    private int task_desc;

    private List<int> list_task_value;

    private List<int> list_task_reward_value;
}
