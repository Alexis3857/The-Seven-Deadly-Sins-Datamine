public class DBEventMatchHawkRow : ITableRowIndexer
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

    public string Resource
    {
        get
        {
            return resource;
        }
    }

    public string HeadPrefabs
    {
        get
        {
            return head_prefabs;
        }
    }

    public string BodyPrefabs
    {
        get
        {
            return body_prefabs;
        }
    }

    public string Idle
    {
        get
        {
            return idle;
        }
    }

    public string Good
    {
        get
        {
            return good;
        }
    }

    public string Awesome
    {
        get
        {
            return awesome;
        }
    }

    public string Bad
    {
        get
        {
            return bad;
        }
    }

    public string End
    {
        get
        {
            return end;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        resource = reader.ReadString();
        head_prefabs = reader.ReadString();
        body_prefabs = reader.ReadString();
        idle = reader.ReadString();
        good = reader.ReadString();
        awesome = reader.ReadString();
        bad = reader.ReadString();
        end = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private string resource;

    private string head_prefabs;

    private string body_prefabs;

    private string idle;

    private string good;

    private string awesome;

    private string bad;

    private string end;
}
