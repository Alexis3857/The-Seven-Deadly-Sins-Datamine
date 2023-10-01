public class DBBasepointNpcMoveRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string MoveName
    {
        get
        {
            return move_name;
        }
    }

    public int BasepointId
    {
        get
        {
            return basepoint_id;
        }
    }

    public int BasepointNpcId
    {
        get
        {
            return basepoint_npc_id;
        }
    }

    public string MoveCondition
    {
        get
        {
            return move_condition;
        }
    }

    public int ConditionId
    {
        get
        {
            return condition_id;
        }
    }

    public string MoveType
    {
        get
        {
            return move_type;
        }
    }

    public int WaitTimeMin
    {
        get
        {
            return wait_time_min;
        }
    }

    public int WaitTimeMax
    {
        get
        {
            return wait_time_max;
        }
    }

    public string WaitTimeAni
    {
        get
        {
            return wait_time_ani;
        }
    }

    public string MoveAni
    {
        get
        {
            return move_ani;
        }
    }

    public float WalkSpeed
    {
        get
        {
            return walk_speed;
        }
    }

    public float RunSpeed
    {
        get
        {
            return run_speed;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        move_name = reader.ReadString();
        basepoint_id = reader.ReadInt32();
        basepoint_npc_id = reader.ReadInt32();
        move_condition = reader.ReadString();
        condition_id = reader.ReadInt32();
        move_type = reader.ReadString();
        wait_time_min = reader.ReadInt32();
        wait_time_max = reader.ReadInt32();
        wait_time_ani = reader.ReadString();
        move_ani = reader.ReadString();
        walk_speed = reader.ReadSingle();
        run_speed = reader.ReadSingle();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string move_name;

    private int basepoint_id;

    private int basepoint_npc_id;

    private string move_condition;

    private int condition_id;

    private string move_type;

    private int wait_time_min;

    private int wait_time_max;

    private string wait_time_ani;

    private string move_ani;

    private float walk_speed;

    private float run_speed;
}
