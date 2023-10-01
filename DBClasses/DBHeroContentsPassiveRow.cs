public class DBHeroContentsPassiveRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int PassiveId
    {
        get
        {
            return passive_id;
        }
    }

    public string ContentsType
    {
        get
        {
            return contents_type;
        }
    }

    public List<string> ListArrayStageType
    {
        get
        {
            return list_array_stage_type;
        }
    }

    public int DailyLimitedCount
    {
        get
        {
            return daily_limited_count;
        }
    }

    public byte RandomActive
    {
        get
        {
            return random_active;
        }
    }

    public string EffectKeyword
    {
        get
        {
            return effect_keyword;
        }
    }

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public int EventType
    {
        get
        {
            return event_type;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public int ApplyPer
    {
        get
        {
            return apply_per;
        }
    }

    public int Param1
    {
        get
        {
            return param_1;
        }
    }

    public int Param2
    {
        get
        {
            return param_2;
        }
    }

    public int Param3
    {
        get
        {
            return param_3;
        }
    }

    public int Param4
    {
        get
        {
            return param_4;
        }
    }

    public List<int> ListParam
    {
        get
        {
            if (list_param == null)
            {
                list_param = new List<int>
                {
                    Param1,
                    Param2,
                    Param3,
                    Param4
                };
            }
            return list_param;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        passive_id = reader.ReadInt32();
        contents_type = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_stage_type = new List<string>();
        for (int i = 0; i < num; i++)
        {
            list_array_stage_type.Add(reader.ReadString());
        }
        daily_limited_count = reader.ReadInt32();
        random_active = reader.ReadByte();
        effect_keyword = reader.ReadString();
        group_id = reader.ReadInt32();
        event_type = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        apply_per = reader.ReadInt32();
        param_1 = reader.ReadInt32();
        param_2 = reader.ReadInt32();
        param_3 = reader.ReadInt32();
        param_4 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int passive_id;

    private string contents_type;

    private List<string> list_array_stage_type;

    private int daily_limited_count;

    private byte random_active;

    private string effect_keyword;

    private int group_id;

    private int event_type;

    private int event_sub_index;

    private int apply_per;

    private int param_1;

    private int param_2;

    private int param_3;

    private int param_4;

    private List<int> list_param;
}
