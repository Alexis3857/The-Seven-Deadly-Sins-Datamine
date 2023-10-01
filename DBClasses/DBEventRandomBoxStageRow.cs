public class DBEventRandomBoxStageRow : ITableRowIndexer
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

    public string EventTitle
    {
        get
        {
            return event_title.Localize();
        }
    }

    public string EventDesc
    {
        get
        {
            return event_desc.Localize();
        }
    }

    public int TicketItemId
    {
        get
        {
            return ticket_item_id;
        }
    }

    public int TicketItemCountPerPlay
    {
        get
        {
            return ticket_item_count_per_play;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        event_title = reader.ReadInt32();
        event_desc = reader.ReadInt32();
        ticket_item_id = reader.ReadInt32();
        ticket_item_count_per_play = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int event_title;

    private int event_desc;

    private int ticket_item_id;

    private int ticket_item_count_per_play;
}
