public class DBStageTypeRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string ControlType
    {
        get
        {
            return control_type;
        }
    }

    public int FriendControl
    {
        get
        {
            return friend_control;
        }
    }

    public int AutoReplay
    {
        get
        {
            return auto_replay;
        }
    }

    public int AutoControl
    {
        get
        {
            return auto_control;
        }
    }

    public int RestartControl
    {
        get
        {
            return restart_control;
        }
    }

    public int ContinueControl
    {
        get
        {
            return continue_control;
        }
    }

    public int ContinueFreeCount
    {
        get
        {
            return continue_free_count;
        }
    }

    public int ContinueFreeCountEvent
    {
        get
        {
            return continue_free_count_event;
        }
    }

    public int ChangeMonsterAi
    {
        get
        {
            return change_monster_ai;
        }
    }

    public int ContinueNumberLimited
    {
        get
        {
            return continue_number_limited;
        }
    }

    public int ContinueCostId
    {
        get
        {
            return continue_cost_id;
        }
    }

    public int ContinueCostCount
    {
        get
        {
            return continue_cost_count;
        }
    }

    public int ClearTicket
    {
        get
        {
            return clear_ticket;
        }
    }

    public int ClearTicketLimit
    {
        get
        {
            return clear_ticket_limit;
        }
    }

    public int RejoinControl
    {
        get
        {
            return rejoin_control;
        }
    }

    public int GiveupRestartControl
    {
        get
        {
            return giveup_restart_control;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        control_type = reader.ReadString();
        friend_control = reader.ReadInt32();
        auto_replay = reader.ReadInt32();
        auto_control = reader.ReadInt32();
        restart_control = reader.ReadInt32();
        continue_control = reader.ReadInt32();
        continue_free_count = reader.ReadInt32();
        continue_free_count_event = reader.ReadInt32();
        change_monster_ai = reader.ReadInt32();
        continue_number_limited = reader.ReadInt32();
        continue_cost_id = reader.ReadInt32();
        continue_cost_count = reader.ReadInt32();
        clear_ticket = reader.ReadInt32();
        clear_ticket_limit = reader.ReadInt32();
        rejoin_control = reader.ReadInt32();
        giveup_restart_control = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string control_type;

    private int friend_control;

    private int auto_replay;

    private int auto_control;

    private int restart_control;

    private int continue_control;

    private int continue_free_count;

    private int continue_free_count_event;

    private int change_monster_ai;

    private int continue_number_limited;

    private int continue_cost_id;

    private int continue_cost_count;

    private int clear_ticket;

    private int clear_ticket_limit;

    private int rejoin_control;

    private int giveup_restart_control;
}
