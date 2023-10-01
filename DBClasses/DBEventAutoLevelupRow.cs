public class DBEventAutoLevelupRow : ITableRowIndexer
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

    public int Level
    {
        get
        {
            return level;
        }
    }

    public int AttackValue
    {
        get
        {
            return attack_value;
        }
    }

    public int EnhanceCount1
    {
        get
        {
            return enhance_count_1;
        }
    }

    public int CriticalValue
    {
        get
        {
            return critical_value;
        }
    }

    public int EnhanceCount2
    {
        get
        {
            return enhance_count_2;
        }
    }

    public int CriticalRate
    {
        get
        {
            return critical_rate;
        }
    }

    public int EnhanceCount3
    {
        get
        {
            return enhance_count_3;
        }
    }

    public List<int> ListEnhanceCount
    {
        get
        {
            if (list_enhance_count == null)
            {
                list_enhance_count = new List<int>
                {
                    EnhanceCount1,
                    EnhanceCount2,
                    EnhanceCount3
                };
            }
            return list_enhance_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        level = reader.ReadInt32();
        attack_value = reader.ReadInt32();
        enhance_count_1 = reader.ReadInt32();
        critical_value = reader.ReadInt32();
        enhance_count_2 = reader.ReadInt32();
        critical_rate = reader.ReadInt32();
        enhance_count_3 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int level;

    private int attack_value;

    private int enhance_count_1;

    private int critical_value;

    private int enhance_count_2;

    private int critical_rate;

    private int enhance_count_3;

    private List<int> list_enhance_count;
}
