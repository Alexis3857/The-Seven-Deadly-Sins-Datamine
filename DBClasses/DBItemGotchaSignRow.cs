public class DBItemGotchaSignRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
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

    public List<float> ListSignRate
    {
        get
        {
            if (list_sign_rate == null)
            {
                list_sign_rate = new List<float>
                {
                    SignRate1,
                    SignRate2
                };
            }
            return list_sign_rate;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        sign = reader.ReadString();
        sign_rate_1 = reader.ReadSingle();
        sign_rate_2 = reader.ReadSingle();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string sign;

    private float sign_rate_1;

    private float sign_rate_2;

    private List<float> list_sign_rate;
}
