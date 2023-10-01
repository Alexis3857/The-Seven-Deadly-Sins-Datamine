public class DBEventLabelInfoRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string EventHighlightName
    {
        get
        {
            return event_highlight_name.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_highlight_name = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_highlight_name;
}
