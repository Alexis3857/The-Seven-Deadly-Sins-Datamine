public class DBEventCraftsMaterialRow : ITableRowIndexer
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

    public int MaterialItemId
    {
        get
        {
            return material_item_id;
        }
    }

    public string RendererIcon
    {
        get
        {
            return renderer_icon;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        material_item_id = reader.ReadInt32();
        renderer_icon = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int material_item_id;

    private string renderer_icon;
}
