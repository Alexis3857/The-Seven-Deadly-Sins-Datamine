public class DBConfigGameRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 827U;
        }
    }

    public int Id
    {
        get
        {
            return base.DecryptInt32(id);
        }
    }

    public string Contents
    {
        get
        {
            return contents;
        }
    }

    public string ValueString1
    {
        get
        {
            return value_string_1;
        }
    }

    public string ValueString2
    {
        get
        {
            return value_string_2;
        }
    }

    public int ValueInt1
    {
        get
        {
            return base.DecryptInt32(value_int_1);
        }
    }

    public int ValueInt2
    {
        get
        {
            return base.DecryptInt32(value_int_2);
        }
    }

    public float ValueFloat1
    {
        get
        {
            return base.DecryptFloat(value_float_1);
        }
    }

    public float ValueFloat2
    {
        get
        {
            return base.DecryptFloat(value_float_2);
        }
    }

    public List<string> ListValueString
    {
        get
        {
            if (list_value_string == null)
            {
                list_value_string = new List<string>
                {
                    ValueString1,
                    ValueString2
                };
            }
            return list_value_string;
        }
    }

    public List<int> ListValueInt
    {
        get
        {
            if (list_value_int == null)
            {
                list_value_int = new List<int>
                {
                    ValueInt1,
                    ValueInt2
                };
            }
            return list_value_int;
        }
    }

    public List<float> ListValueFloat
    {
        get
        {
            if (list_value_float == null)
            {
                list_value_float = new List<float>
                {
                    ValueFloat1,
                    ValueFloat2
                };
            }
            return list_value_float;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadBytes(4);
        contents = reader.ReadString();
        value_string_1 = reader.ReadString();
        value_string_2 = reader.ReadString();
        value_int_1 = reader.ReadBytes(4);
        value_int_2 = reader.ReadBytes(4);
        value_float_1 = reader.ReadBytes(4);
        value_float_2 = reader.ReadBytes(4);
        return true;
    }

    public int GetRowIndex()
    {
        return Id;

    }
    private byte[] id;

    private string contents;

    private string value_string_1;

    private string value_string_2;

    private byte[] value_int_1;

    private byte[] value_int_2;

    private byte[] value_float_1;

    private byte[] value_float_2;

    private List<string> list_value_string;

    private List<int> list_value_int;

    private List<float> list_value_float;
}
