public class DBForumControlRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public byte Url1
    {
        get
        {
            return url_1;
        }
    }

    public byte Url2
    {
        get
        {
            return url_2;
        }
    }

    public byte Url3
    {
        get
        {
            return url_3;
        }
    }

    public byte Url4
    {
        get
        {
            return url_4;
        }
    }

    public byte Url5
    {
        get
        {
            return url_5;
        }
    }

    public byte Url6
    {
        get
        {
            return url_6;
        }
    }

    public byte Url7
    {
        get
        {
            return url_7;
        }
    }

    public List<byte> ListUrl
    {
        get
        {
            if (list_url == null)
            {
                list_url = new List<byte>
                {
                    Url1,
                    Url2,
                    Url3,
                    Url4,
                    Url5,
                    Url6,
                    Url7
                };
            }
            return list_url;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        url_1 = reader.ReadByte();
        url_2 = reader.ReadByte();
        url_3 = reader.ReadByte();
        url_4 = reader.ReadByte();
        url_5 = reader.ReadByte();
        url_6 = reader.ReadByte();
        url_7 = reader.ReadByte();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private byte url_1;

    private byte url_2;

    private byte url_3;

    private byte url_4;

    private byte url_5;

    private byte url_6;

    private byte url_7;

    private List<byte> list_url;
}
