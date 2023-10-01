public class DBEventBuffRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EventBuffIndex
    {
        get
        {
            return event_buff_index;
        }
    }

    public int RewardMark
    {
        get
        {
            return reward_mark;
        }
    }

    public string Icon
    {
        get
        {
            return icon;
        }
    }

    public string Title
    {
        get
        {
            return title.Localize();
        }
    }

    public string Explain
    {
        get
        {
            return explain.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_buff_index = reader.ReadInt32();
        reward_mark = reader.ReadInt32();
        icon = reader.ReadString();
        title = reader.ReadInt32();
        explain = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_buff_index;

    private int reward_mark;

    private string icon;

    private int title;

    private int explain;
}
