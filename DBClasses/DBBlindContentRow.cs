public class DBBlindContentRow : ITableRowIndexer
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

    public int ContentId
    {
        get
        {
            return content_id;
        }
    }

    public string TagetType
    {
        get
        {
            return taget_type;
        }
    }

    public int TargetId
    {
        get
        {
            return target_id;
        }
    }

    public string BlindOffType
    {
        get
        {
            return blind_off_type;
        }
    }

    public int BlindOffValue
    {
        get
        {
            return blind_off_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        content_type = reader.ReadString();
        content_id = reader.ReadInt32();
        taget_type = reader.ReadString();
        target_id = reader.ReadInt32();
        blind_off_type = reader.ReadString();
        blind_off_value = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string content_type;

    private int content_id;

    private string taget_type;

    private int target_id;

    private string blind_off_type;

    private int blind_off_value;
}
