public class DBEventRoadHawkRow : ITableRowIndexer
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

    public string Run
    {
        get
        {
            return run;
        }
    }

    public string Item
    {
        get
        {
            return item;
        }
    }

    public string Info
    {
        get
        {
            return info;
        }
    }

    public string Reward
    {
        get
        {
            return reward;
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
        run = reader.ReadString();
        item = reader.ReadString();
        info = reader.ReadString();
        reward = reader.ReadString();
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

    private string run;

    private string item;

    private string info;

    private string reward;
}
