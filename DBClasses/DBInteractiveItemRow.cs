public class DBInteractiveItemRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string Name
    {
        get
        {
            return name.Localize();
        }
    }

    public int GuestId
    {
        get
        {
            return guest_id;
        }
    }

    public int NpcType
    {
        get
        {
            return npc_type;
        }
    }

    public int Index
    {
        get
        {
            return index;
        }
    }

    public int Condition
    {
        get
        {
            return condition;
        }
    }

    public int CostumeTabType
    {
        get
        {
            return costume_tab_type;
        }
    }

    public string IconId
    {
        get
        {
            return icon_id;
        }
    }

    public string Resource
    {
        get
        {
            return resource;
        }
    }

    public string HeadResource
    {
        get
        {
            return head_resource;
        }
    }

    public string BodyResource
    {
        get
        {
            return body_resource;
        }
    }

    public float Scale
    {
        get
        {
            return scale;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        name = reader.ReadInt32();
        guest_id = reader.ReadInt32();
        npc_type = reader.ReadInt32();
        index = reader.ReadInt32();
        condition = reader.ReadInt32();
        costume_tab_type = reader.ReadInt32();
        icon_id = reader.ReadString();
        resource = reader.ReadString();
        head_resource = reader.ReadString();
        body_resource = reader.ReadString();
        scale = reader.ReadSingle();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int name;

    private int guest_id;

    private int npc_type;

    private int index;

    private int condition;

    private int costume_tab_type;

    private string icon_id;

    private string resource;

    private string head_resource;

    private string body_resource;

    private float scale;
}
