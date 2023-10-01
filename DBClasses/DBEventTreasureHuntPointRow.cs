public class DBEventTreasureHuntPointRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int SubIndex
    {
        get
        {
            return sub_index;
        }
    }

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public int PrevPointInd
    {
        get
        {
            return prev_point_ind;
        }
    }

    public int PointId
    {
        get
        {
            return point_id;
        }
    }

    public int NextPointId
    {
        get
        {
            return next_point_id;
        }
    }

    public string MissionType
    {
        get
        {
            return mission_type;
        }
    }

    public int MissionValue
    {
        get
        {
            return mission_value;
        }
    }

    public int StepholdType
    {
        get
        {
            return stephold_type;
        }
    }

    public string PointType
    {
        get
        {
            return point_type;
        }
    }

    public int PointTypeValue
    {
        get
        {
            return point_type_value;
        }
    }

    public int PointMoveType
    {
        get
        {
            return point_move_type;
        }
    }

    public List<int> ListArrayRewardItemId
    {
        get
        {
            return list_array_reward_item_id;
        }
    }

    public List<int> ListArrayRewardItemCount
    {
        get
        {
            return list_array_reward_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        sub_index = reader.ReadInt32();
        group_id = reader.ReadInt32();
        prev_point_ind = reader.ReadInt32();
        point_id = reader.ReadInt32();
        next_point_id = reader.ReadInt32();
        mission_type = reader.ReadString();
        mission_value = reader.ReadInt32();
        stephold_type = reader.ReadInt32();
        point_type = reader.ReadString();
        point_type_value = reader.ReadInt32();
        point_move_type = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_reward_item_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_reward_item_id.Add(reader.ReadInt32());
        }
        int num2 = reader.ReadInt32();
        list_array_reward_item_count = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_reward_item_count.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int sub_index;

    private int group_id;

    private int prev_point_ind;

    private int point_id;

    private int next_point_id;

    private string mission_type;

    private int mission_value;

    private int stephold_type;

    private string point_type;

    private int point_type_value;

    private int point_move_type;

    private List<int> list_array_reward_item_id;

    private List<int> list_array_reward_item_count;
}
