public class DBGambleSignRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GambleResult
    {
        get
        {
            return gamble_result;
        }
    }

    public string Sign
    {
        get
        {
            return sign;
        }
    }

    public float SignRate1
    {
        get
        {
            return sign_rate_1;
        }
    }

    public float SignRate2
    {
        get
        {
            return sign_rate_2;
        }
    }

    public float SignRate3
    {
        get
        {
            return sign_rate_3;
        }
    }

    public float SignRate4
    {
        get
        {
            return sign_rate_4;
        }
    }

    public float SignRate5
    {
        get
        {
            return sign_rate_5;
        }
    }

    public float SignRate6
    {
        get
        {
            return sign_rate_6;
        }
    }

    public float SignRate7
    {
        get
        {
            return sign_rate_7;
        }
    }

    public float SignRate8
    {
        get
        {
            return sign_rate_8;
        }
    }

    public List<float> ListSignRate
    {
        get
        {
            if (list_sign_rate == null)
            {
                list_sign_rate = new List<float>
                {
                    SignRate1,
                    SignRate2,
                    SignRate3,
                    SignRate4,
                    SignRate5,
                    SignRate6,
                    SignRate7,
                    SignRate8
                };
            }
            return list_sign_rate;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        gamble_result = reader.ReadInt32();
        sign = reader.ReadString();
        sign_rate_1 = reader.ReadSingle();
        sign_rate_2 = reader.ReadSingle();
        sign_rate_3 = reader.ReadSingle();
        sign_rate_4 = reader.ReadSingle();
        sign_rate_5 = reader.ReadSingle();
        sign_rate_6 = reader.ReadSingle();
        sign_rate_7 = reader.ReadSingle();
        sign_rate_8 = reader.ReadSingle();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int gamble_result;

    private string sign;

    private float sign_rate_1;

    private float sign_rate_2;

    private float sign_rate_3;

    private float sign_rate_4;

    private float sign_rate_5;

    private float sign_rate_6;

    private float sign_rate_7;

    private float sign_rate_8;

    private List<float> list_sign_rate;
}
