public class DBEventCraftsLocalizationRow : ITableRowIndexer
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

    public string NoticeNotSelectedItem
    {
        get
        {
            return notice_not_selected_item.Localize();
        }
    }

    public string NoticeNotEnoughItem
    {
        get
        {
            return notice_not_enough_item.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        notice_not_selected_item = reader.ReadInt32();
        notice_not_enough_item = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int notice_not_selected_item;

    private int notice_not_enough_item;
}
