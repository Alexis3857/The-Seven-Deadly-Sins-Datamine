public class DBCheckStoryRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int StoryId
    {
        get
        {
            return story_id;
        }
    }

    public int StoryType
    {
        get
        {
            return story_type;
        }
    }

    public int Order
    {
        get
        {
            return order;
        }
    }

    public int DirectorType
    {
        get
        {
            return director_type;
        }
    }

    public int StoryOn
    {
        get
        {
            return story_on;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        story_id = reader.ReadInt32();
        story_type = reader.ReadInt32();
        order = reader.ReadInt32();
        director_type = reader.ReadInt32();
        story_on = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int story_id;

    private int story_type;

    private int order;

    private int director_type;

    private int story_on;
}
