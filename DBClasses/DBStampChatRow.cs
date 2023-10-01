public class DBStampChatRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string StampItem
    {
        get
        {
            return stamp_item;
        }
    }

    public int StampGroupItemId
    {
        get
        {
            return stamp_group_item_id;
        }
    }

    public string StampTypeName
    {
        get
        {
            return stamp_type_name.Localize();
        }
    }

    public int StampType
    {
        get
        {
            return stamp_type;
        }
    }

    public int StampGroup
    {
        get
        {
            return stamp_group;
        }
    }

    public string StampName
    {
        get
        {
            return stamp_name.Localize();
        }
    }

    public string StampDesc
    {
        get
        {
            return stamp_desc.Localize();
        }
    }

    public string StampKeyword
    {
        get
        {
            return stamp_keyword.Localize();
        }
    }

    public int StampCategory
    {
        get
        {
            return stamp_category;
        }
    }

    public int StampSound
    {
        get
        {
            return stamp_sound;
        }
    }

    public string StampMindType
    {
        get
        {
            return stamp_mind_type;
        }
    }

    public string GetStampDesc
    {
        get
        {
            return get_stamp_desc.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        stamp_item = reader.ReadString();
        stamp_group_item_id = reader.ReadInt32();
        stamp_type_name = reader.ReadInt32();
        stamp_type = reader.ReadInt32();
        stamp_group = reader.ReadInt32();
        stamp_name = reader.ReadInt32();
        stamp_desc = reader.ReadInt32();
        stamp_keyword = reader.ReadInt32();
        stamp_category = reader.ReadInt32();
        stamp_sound = reader.ReadInt32();
        stamp_mind_type = reader.ReadString();
        get_stamp_desc = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string stamp_item;

    private int stamp_group_item_id;

    private int stamp_type_name;

    private int stamp_type;

    private int stamp_group;

    private int stamp_name;

    private int stamp_desc;

    private int stamp_keyword;

    private int stamp_category;

    private int stamp_sound;

    private string stamp_mind_type;

    private int get_stamp_desc;
}
