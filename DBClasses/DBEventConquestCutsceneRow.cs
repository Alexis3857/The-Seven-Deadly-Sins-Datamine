public class DBEventConquestCutsceneRow : ITableRowIndexer
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

    public int CutscenePlayType
    {
        get
        {
            return cutscene_play_type;
        }
    }

    public int EnemyId
    {
        get
        {
            return enemy_id;
        }
    }

    public string StoryOrder
    {
        get
        {
            return story_order.Localize();
        }
    }

    public string StoryTitle
    {
        get
        {
            return story_title.Localize();
        }
    }

    public string NoticeStoryOpenCondition
    {
        get
        {
            return notice_story_open_condition.Localize();
        }
    }

    public string ReplayImage
    {
        get
        {
            return replay_image;
        }
    }

    public int CutsceneId
    {
        get
        {
            return cutscene_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        cutscene_play_type = reader.ReadInt32();
        enemy_id = reader.ReadInt32();
        story_order = reader.ReadInt32();
        story_title = reader.ReadInt32();
        notice_story_open_condition = reader.ReadInt32();
        replay_image = reader.ReadString();
        cutscene_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int cutscene_play_type;

    private int enemy_id;

    private int story_order;

    private int story_title;

    private int notice_story_open_condition;

    private string replay_image;

    private int cutscene_id;
}