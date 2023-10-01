public class DBEventAutoHeroRow : ITableRowIndexer
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

    public int SumLevel
    {
        get
        {
            return sum_level;
        }
    }

    public int SpecialRewardOrder
    {
        get
        {
            return special_reward_order;
        }
    }

    public int SpecialRewardId
    {
        get
        {
            return special_reward_id;
        }
    }

    public int SpecialRewardCount
    {
        get
        {
            return special_reward_count;
        }
    }

    public int BaseMonsterId
    {
        get
        {
            return base_monster_id;
        }
    }

    public string Appear
    {
        get
        {
            return appear;
        }
    }

    public string Idle
    {
        get
        {
            return idle;
        }
    }

    public string Dmg
    {
        get
        {
            return dmg;
        }
    }

    public string Dash
    {
        get
        {
            return dash;
        }
    }

    public string Attack
    {
        get
        {
            return attack;
        }
    }

    public string Back
    {
        get
        {
            return back;
        }
    }

    public string End
    {
        get
        {
            return end;
        }
    }

    public string CriticalDash
    {
        get
        {
            return critical_dash;
        }
    }

    public string CriticalAttack
    {
        get
        {
            return critical_attack;
        }
    }

    public string CriticalBack
    {
        get
        {
            return critical_back;
        }
    }

    public string CriticalEnd
    {
        get
        {
            return critical_end;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        sum_level = reader.ReadInt32();
        special_reward_order = reader.ReadInt32();
        special_reward_id = reader.ReadInt32();
        special_reward_count = reader.ReadInt32();
        base_monster_id = reader.ReadInt32();
        appear = reader.ReadString();
        idle = reader.ReadString();
        dmg = reader.ReadString();
        dash = reader.ReadString();
        attack = reader.ReadString();
        back = reader.ReadString();
        end = reader.ReadString();
        critical_dash = reader.ReadString();
        critical_attack = reader.ReadString();
        critical_back = reader.ReadString();
        critical_end = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int sum_level;

    private int special_reward_order;

    private int special_reward_id;

    private int special_reward_count;

    private int base_monster_id;

    private string appear;

    private string idle;

    private string dmg;

    private string dash;

    private string attack;

    private string back;

    private string end;

    private string critical_dash;

    private string critical_attack;

    private string critical_back;

    private string critical_end;
}
