public class DBNpcPropRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string Path
    {
        get
        {
            return path;
        }
    }

    public string Resource
    {
        get
        {
            return resource;
        }
    }

    public int Type
    {
        get
        {
            return type;
        }
    }

    public string AttachName
    {
        get
        {
            return attach_name;
        }
    }

    public string Attach
    {
        get
        {
            return attach;
        }
    }

    public string AniKeyname
    {
        get
        {
            return ani_keyname;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        path = reader.ReadString();
        resource = reader.ReadString();
        type = reader.ReadInt32();
        attach_name = reader.ReadString();
        attach = reader.ReadString();
        ani_keyname = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string path;

    private string resource;

    private int type;

    private string attach_name;

    private string attach;

    private string ani_keyname;
}
