public class DBEventAutoSettingRow : ITableRowIndexer
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

    public string EventName
    {
        get
        {
            return event_name.Localize();
        }
    }

    public string EventDesc
    {
        get
        {
            return event_desc.Localize();
        }
    }

    public int AttackDelay
    {
        get
        {
            return attack_delay;
        }
    }

    public int MiddleDelay
    {
        get
        {
            return middle_delay;
        }
    }

    public int AutoAttackTime
    {
        get
        {
            return auto_attack_time;
        }
    }

    public int LastBossStage
    {
        get
        {
            return last_boss_stage;
        }
    }

    public int LastStage
    {
        get
        {
            return last_stage;
        }
    }

    public int BuffActiveRate
    {
        get
        {
            return buff_active_rate;
        }
    }

    public int BuffActiveTime
    {
        get
        {
            return buff_active_time;
        }
    }

    public int BuffActiveMax
    {
        get
        {
            return buff_active_max;
        }
    }

    public int EnhanceItemId
    {
        get
        {
            return enhance_item_id;
        }
    }

    public int GetEnhanceMax
    {
        get
        {
            return get_enhance_max;
        }
    }

    public int SlotAddMax
    {
        get
        {
            return slot_add_max;
        }
    }

    public int EnhanceLevelMax
    {
        get
        {
            return enhance_level_max;
        }
    }

    public int ExtraStageBoxMax
    {
        get
        {
            return extra_stage_box_max;
        }
    }

    public int ExchangeOpenStageId
    {
        get
        {
            return exchange_open_stage_id;
        }
    }

    public int ExchangeGroup
    {
        get
        {
            return exchange_group;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        event_name = reader.ReadInt32();
        event_desc = reader.ReadInt32();
        attack_delay = reader.ReadInt32();
        middle_delay = reader.ReadInt32();
        auto_attack_time = reader.ReadInt32();
        last_boss_stage = reader.ReadInt32();
        last_stage = reader.ReadInt32();
        buff_active_rate = reader.ReadInt32();
        buff_active_time = reader.ReadInt32();
        buff_active_max = reader.ReadInt32();
        enhance_item_id = reader.ReadInt32();
        get_enhance_max = reader.ReadInt32();
        slot_add_max = reader.ReadInt32();
        enhance_level_max = reader.ReadInt32();
        extra_stage_box_max = reader.ReadInt32();
        exchange_open_stage_id = reader.ReadInt32();
        exchange_group = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int event_name;

    private int event_desc;

    private int attack_delay;

    private int middle_delay;

    private int auto_attack_time;

    private int last_boss_stage;

    private int last_stage;

    private int buff_active_rate;

    private int buff_active_time;

    private int buff_active_max;

    private int enhance_item_id;

    private int get_enhance_max;

    private int slot_add_max;

    private int enhance_level_max;

    private int extra_stage_box_max;

    private int exchange_open_stage_id;

    private int exchange_group;
}
