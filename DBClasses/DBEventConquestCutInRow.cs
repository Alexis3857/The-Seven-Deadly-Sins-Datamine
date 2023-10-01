public class DBEventConquestCutInRow : ITableRowIndexer
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

    public int CutInIndex
    {
        get
        {
            return cut_in_index;
        }
    }

    public string CutInLayoutType
    {
        get
        {
            return cut_in_layout_type;
        }
    }

    public int AppearOrder
    {
        get
        {
            return appear_order;
        }
    }

    public string AppearDirection
    {
        get
        {
            return appear_direction;
        }
    }

    public string CutInBg
    {
        get
        {
            return cut_in_bg;
        }
    }

    public int CutInResourceType
    {
        get
        {
            return cut_in_resource_type;
        }
    }

    public string CutInBase
    {
        get
        {
            return cut_in_base;
        }
    }

    public string CutInResource
    {
        get
        {
            return cut_in_resource;
        }
    }

    public int CutInDialogueBubbleType
    {
        get
        {
            return cut_in_dialogue_bubble_type;
        }
    }

    public string CutInDialogue
    {
        get
        {
            return cut_in_dialogue.Localize();
        }
    }
    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        cut_in_index = reader.ReadInt32();
        cut_in_layout_type = reader.ReadString();
        appear_order = reader.ReadInt32();
        appear_direction = reader.ReadString();
        cut_in_bg = reader.ReadString();
        cut_in_resource_type = reader.ReadInt32();
        cut_in_base = reader.ReadString();
        cut_in_resource = reader.ReadString();
        cut_in_dialogue_bubble_type = reader.ReadInt32();
        cut_in_dialogue = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int cut_in_index;

    private string cut_in_layout_type;

    private int appear_order;

    private string appear_direction;

    private string cut_in_bg;

    private int cut_in_resource_type;

    private string cut_in_base;

    private string cut_in_resource;

    private int cut_in_dialogue_bubble_type;

    private int cut_in_dialogue;
}