public class DBContentLinkRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string QuicklinkName
    {
        get
        {
            return quicklink_name.Localize();
        }
    }

    public string QuicklinkIcon
    {
        get
        {
            return quicklink_icon;
        }
    }

    public string ContentType
    {
        get
        {
            return content_type;
        }
    }

    public int Region
    {
        get
        {
            return region;
        }
    }

    public int AreaId
    {
        get
        {
            return area_id;
        }
    }

    public string ContentMenu
    {
        get
        {
            return content_menu;
        }
    }

    public int MatchingAreaEndId
    {
        get
        {
            return matching_area_end_id;
        }
    }

    public int NpcId
    {
        get
        {
            return npc_id;
        }
    }

    public int WeaponItemId
    {
        get
        {
            return weapon_item_id;
        }
    }

    public int ContentLinkCheck
    {
        get
        {
            return content_link_check;
        }
    }

    public int MoveSkipCheck
    {
        get
        {
            return move_skip_check;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        quicklink_name = reader.ReadInt32();
        quicklink_icon = reader.ReadString();
        content_type = reader.ReadString();
        region = reader.ReadInt32();
        area_id = reader.ReadInt32();
        content_menu = reader.ReadString();
        matching_area_end_id = reader.ReadInt32();
        npc_id = reader.ReadInt32();
        weapon_item_id = reader.ReadInt32();
        content_link_check = reader.ReadInt32();
        move_skip_check = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int quicklink_name;

    private string quicklink_icon;

    private string content_type;

    private int region;

    private int area_id;

    private string content_menu;

    private int matching_area_end_id;

    private int npc_id;

    private int weapon_item_id;

    private int content_link_check;

    private int move_skip_check;
}
