public class DBVideoRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string SubPath
    {
        get
        {
            return sub_path;
        }
    }

    public string Name
    {
        get
        {
            return name;
        }
    }

    public string Screen
    {
        get
        {
            return screen;
        }
    }

    public string EndPrefab
    {
        get
        {
            return end_Prefab;
        }
    }

    public string StartTitle
    {
        get
        {
            return start_title.Localize();
        }
    }

    public string StartContent
    {
        get
        {
            return start_content.Localize();
        }
    }

    public string EndTitle
    {
        get
        {
            return end_title.Localize();
        }
    }

    public string EndContent
    {
        get
        {
            return end_content.Localize();
        }
    }
    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        sub_path = reader.ReadString();
        name = reader.ReadString();
        screen = reader.ReadString();
        end_Prefab = reader.ReadString();
        start_title = reader.ReadInt32();
        start_content = reader.ReadInt32();
        end_title = reader.ReadInt32();
        end_content = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string sub_path;

    private string name;

    private string screen;

    private string end_Prefab;

    private int start_title;

    private int start_content;

    private int end_title;

    private int end_content;
}
