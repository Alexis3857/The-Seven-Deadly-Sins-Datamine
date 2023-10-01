public class DBCheckNpcResourceRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int NpcId
    {
        get
        {
            return npc_id;
        }
    }

    public int PortraitOn
    {
        get
        {
            return portrait_on;
        }
    }

    public int FacialOn
    {
        get
        {
            return facial_on;
        }
    }

    public string NpcNameLocalize
    {
        get
        {
            return npc_name_localize.Localize();
        }
    }

    public float NpcPortraitSize
    {
        get
        {
            return npc_portrait_size;
        }
    }

    public string NpcPortraitBase
    {
        get
        {
            return npc_portrait_base;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        npc_id = reader.ReadInt32();
        portrait_on = reader.ReadInt32();
        facial_on = reader.ReadInt32();
        npc_name_localize = reader.ReadInt32();
        npc_portrait_size = reader.ReadSingle();
        npc_portrait_base = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int npc_id;

    private int portrait_on;

    private int facial_on;

    private int npc_name_localize;

    private float npc_portrait_size;

    private string npc_portrait_base;
}
