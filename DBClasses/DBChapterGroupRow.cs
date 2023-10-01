public class DBChapterGroupRow : ITableRowIndexer
{
    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public string GroupName
    {
        get
        {
            return group_name.Localize();
        }
    }

    public string RendererName
    {
        get
        {
            return renderer_name;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        group_id = reader.ReadInt32();
        group_name = reader.ReadInt32();
        renderer_name = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return GroupId;
    }

    private int group_id;

    private int group_name;

    private string renderer_name;
}
