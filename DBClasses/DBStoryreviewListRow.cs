public class DBStoryreviewListRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int RootId
    {
        get
        {
            return root_id;
        }
    }

    public int StoryLowslot
    {
        get
        {
            return story_lowslot;
        }
    }

    public string StoryLowslotName
    {
        get
        {
            return story_lowslot_name.Localize();
        }
    }

    public int StoryConnecting
    {
        get
        {
            return story_connecting;
        }
    }

    public int Formattype
    {
        get
        {
            return formattype;
        }
    }

    public string Opentype
    {
        get
        {
            return opentype;
        }
    }

    public int Openvalue
    {
        get
        {
            return openvalue;
        }
    }

    public int TargetId
    {
        get
        {
            return target_id;
        }
    }

    public string ReplaySummary
    {
        get
        {
            return replay_summary.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        root_id = reader.ReadInt32();
        story_lowslot = reader.ReadInt32();
        story_lowslot_name = reader.ReadInt32();
        story_connecting = reader.ReadInt32();
        formattype = reader.ReadInt32();
        opentype = reader.ReadString();
        openvalue = reader.ReadInt32();
        target_id = reader.ReadInt32();
        replay_summary = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int root_id;

    private int story_lowslot;

    private int story_lowslot_name;

    private int story_connecting;

    private int formattype;

    private string opentype;

    private int openvalue;

    private int target_id;

    private int replay_summary;
}
