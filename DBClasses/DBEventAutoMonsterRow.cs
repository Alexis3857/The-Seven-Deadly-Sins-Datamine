public class DBEventAutoMonsterRow : ITableRowIndexer
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

    public int MonsterBaseId
    {
        get
        {
            return monster_base_id;
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

    public string Die
    {
        get
        {
            return die;
        }
    }

    public int AttackRangeType
    {
        get
        {
            return attack_range_type;
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

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        monster_base_id = reader.ReadInt32();
        appear = reader.ReadString();
        idle = reader.ReadString();
        dmg = reader.ReadString();
        die = reader.ReadString();
        attack_range_type = reader.ReadInt32();
        dash = reader.ReadString();
        attack = reader.ReadString();
        back = reader.ReadString();
        end = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int monster_base_id;

    private string appear;

    private string idle;

    private string dmg;

    private string die;

    private int attack_range_type;

    private string dash;

    private string attack;

    private string back;

    private string end;
}
