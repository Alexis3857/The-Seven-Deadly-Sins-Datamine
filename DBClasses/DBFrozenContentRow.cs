public class DBFrozenContentRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string ContentType
    {
        get
        {
            return content_type;
        }
    }

    public int PIDLMin1
    {
        get
        {
            return PIDL_Min_1;
        }
    }

    public int PIDLMax1
    {
        get
        {
            return PIDL_Max_1;
        }
    }

    public int PIDLMin2
    {
        get
        {
            return PIDL_Min_2;
        }
    }

    public int PIDLMax2
    {
        get
        {
            return PIDL_Max_2;
        }
    }

    public int PIDLMin3
    {
        get
        {
            return PIDL_Min_3;
        }
    }

    public int PIDLMax3
    {
        get
        {
            return PIDL_Max_3;
        }
    }

    public int PIDLMin4
    {
        get
        {
            return PIDL_Min_4;
        }
    }

    public int PIDLMax4
    {
        get
        {
            return PIDL_Max_4;
        }
    }

    public int PIDLMin5
    {
        get
        {
            return PIDL_Min_5;
        }
    }

    public int PIDLMax5
    {
        get
        {
            return PIDL_Max_5;
        }
    }

    public string PopupDesc
    {
        get
        {
            return popup_desc.Localize();
        }
    }

    public List<int> ListPIDLMin
    {
        get
        {
            if (list_PIDL_Min == null)
            {
                list_PIDL_Min = new List<int>
                {
                    PIDLMin1,
                    PIDLMin2,
                    PIDLMin3,
                    PIDLMin4,
                    PIDLMin5
                };
            }
            return list_PIDL_Min;
        }
    }

    public List<int> ListPIDLMax
    {
        get
        {
            if (list_PIDL_Max == null)
            {
                list_PIDL_Max = new List<int>
                {
                    PIDLMax1,
                    PIDLMax2,
                    PIDLMax3,
                    PIDLMax4,
                    PIDLMax5
                };
            }
            return list_PIDL_Max;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        content_type = reader.ReadString();
        PIDL_Min_1 = reader.ReadInt32();
        PIDL_Max_1 = reader.ReadInt32();
        PIDL_Min_2 = reader.ReadInt32();
        PIDL_Max_2 = reader.ReadInt32();
        PIDL_Min_3 = reader.ReadInt32();
        PIDL_Max_3 = reader.ReadInt32();
        PIDL_Min_4 = reader.ReadInt32();
        PIDL_Max_4 = reader.ReadInt32();
        PIDL_Min_5 = reader.ReadInt32();
        PIDL_Max_5 = reader.ReadInt32();
        popup_desc = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string content_type;

    private int PIDL_Min_1;

    private int PIDL_Max_1;

    private int PIDL_Min_2;

    private int PIDL_Max_2;

    private int PIDL_Min_3;

    private int PIDL_Max_3;

    private int PIDL_Min_4;

    private int PIDL_Max_4;

    private int PIDL_Min_5;

    private int PIDL_Max_5;

    private int popup_desc;

    private List<int> list_PIDL_Min;

    private List<int> list_PIDL_Max;
}
