public class DBContentAdRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string AdType
    {
        get
        {
            return ad_type;
        }
    }

    public int AdCount
    {
        get
        {
            return ad_count;
        }
    }

    public int ValueType1
    {
        get
        {
            return value_type_1;
        }
    }

    public int ValueType2
    {
        get
        {
            return value_type_2;
        }
    }

    public int GachaViewPriority
    {
        get
        {
            return gacha_view_priority;
        }
    }

    public List<int> ListArrayValueType
    {
        get
        {
            return list_array_value_type;
        }
    }

    public List<int> ListValueType
    {
        get
        {
            if (list_value_type == null)
            {
                list_value_type = new List<int>
                {
                    ValueType1,
                    ValueType2
                };
            }
            return list_value_type;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        ad_type = reader.ReadString();
        ad_count = reader.ReadInt32();
        value_type_1 = reader.ReadInt32();
        value_type_2 = reader.ReadInt32();
        gacha_view_priority = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_value_type = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_value_type.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string ad_type;

    private int ad_count;

    private int value_type_1;

    private int value_type_2;

    private int gacha_view_priority;

    private List<int> list_array_value_type;

    private List<int> list_value_type;
}
