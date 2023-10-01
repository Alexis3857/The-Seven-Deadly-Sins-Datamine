public class DBBasepointCollisionNpcRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int BasepointId
    {
        get
        {
            return basepoint_id;
        }
    }

    public int CollisionIndex
    {
        get
        {
            return collision_index;
        }
    }

    public int CollisionCount
    {
        get
        {
            return collision_count;
        }
    }

    public string CollisionResource
    {
        get
        {
            return collision_resource;
        }
    }

    public string OpenType
    {
        get
        {
            return open_type;
        }
    }

    public int OpenValue
    {
        get
        {
            return open_value;
        }
    }

    public string CloseType
    {
        get
        {
            return close_type;
        }
    }

    public int CloseValue
    {
        get
        {
            return close_value;
        }
    }

    public string NpcRole
    {
        get
        {
            return npc_role;
        }
    }

    public int NpcContentId
    {
        get
        {
            return npc_content_id;
        }
    }

    public int FindEnterAreaId
    {
        get
        {
            return find_enter_area_id;
        }
    }

    public int NpcCinemaId
    {
        get
        {
            return npc_cinema_id;
        }
    }

    public string GuideLocal
    {
        get
        {
            return guide_local.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        basepoint_id = reader.ReadInt32();
        collision_index = reader.ReadInt32();
        collision_count = reader.ReadInt32();
        collision_resource = reader.ReadString();
        open_type = reader.ReadString();
        open_value = reader.ReadInt32();
        close_type = reader.ReadString();
        close_value = reader.ReadInt32();
        npc_role = reader.ReadString();
        npc_content_id = reader.ReadInt32();
        find_enter_area_id = reader.ReadInt32();
        npc_cinema_id = reader.ReadInt32();
        guide_local = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int basepoint_id;

    private int collision_index;

    private int collision_count;

    private string collision_resource;

    private string open_type;

    private int open_value;

    private string close_type;

    private int close_value;

    private string npc_role;

    private int npc_content_id;

    private int find_enter_area_id;

    private int npc_cinema_id;

    private int guide_local;
}
