public class DBStoryreviewRootRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ShowList
    {
        get
        {
            return show_list;
        }
    }

    public int StoryType
    {
        get
        {
            return story_type;
        }
    }

    public int StoryRegion
    {
        get
        {
            return story_region;
        }
    }

    public int StoryRegionEp
    {
        get
        {
            return story_region_ep;
        }
    }

    public int StoryGroup
    {
        get
        {
            return story_group;
        }
    }

    public string StoryChapterName
    {
        get
        {
            return story_chapter_name.Localize();
        }
    }

    public string StoryGroupName
    {
        get
        {
            return story_group_name.Localize();
        }
    }

    public string ReplayImage
    {
        get
        {
            return replay_Image;
        }
    }

    public string ReplayListSummary
    {
        get
        {
            return replay_list_summary.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        show_list = reader.ReadInt32();
        story_type = reader.ReadInt32();
        story_region = reader.ReadInt32();
        story_region_ep = reader.ReadInt32();
        story_group = reader.ReadInt32();
        story_chapter_name = reader.ReadInt32();
        story_group_name = reader.ReadInt32();
        replay_Image = reader.ReadString();
        replay_list_summary = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int show_list;

    private int story_type;

    private int story_region;

    private int story_region_ep;

    private int story_group;

    private int story_chapter_name;

    private int story_group_name;

    private string replay_Image;

    private int replay_list_summary;
}
