public class DBQuestExtraRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int Region
    {
        get
        {
            return region;
        }
    }

    public int Area
    {
        get
        {
            return area;
        }
    }

    public string LargePopup
    {
        get
        {
            return large_popup;
        }
    }

    public string EventBanner
    {
        get
        {
            return event_banner;
        }
    }

    public int EndNpc
    {
        get
        {
            return end_npc;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        region = reader.ReadInt32();
        area = reader.ReadInt32();
        large_popup = reader.ReadString();
        event_banner = reader.ReadString();
        end_npc = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int region;

    private int area;

    private string large_popup;

    private string event_banner;

    private int end_npc;
}
