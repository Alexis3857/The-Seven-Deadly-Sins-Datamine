public class DBEventConfirmConfigRow
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string Contents
    {
        get
        {
            return contents;
        }
    }

    public int ValueInt1
    {
        get
        {
            return value_int_1;
        }
    }

    public int ValueInt2
    {
        get
        {
            return value_int_2;
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
    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        contents = reader.ReadString();
        value_int_1 = reader.ReadInt32();
        value_int_2 = reader.ReadInt32();
        return true;
    }
    private int id;

    private string contents;

    private int value_int_1;

    private int value_int_2;

    private List<int> list_value_int;
}