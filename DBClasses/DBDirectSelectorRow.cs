public class DBDirectSelectorRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int RecGroup
    {
        get
        {
            return rec_group;
        }
    }

    public string Type
    {
        get
        {
            return type;
        }
    }

    public int FormatType
    {
        get
        {
            return format_type;
        }
    }

    public int TargetId
    {
        get
        {
            return target_id;
        }
    }

    public int BeforeLoadingSceneId
    {
        get
        {
            return before_loading_scene_id;
        }
    }

    public int AfterLoadingSceneId
    {
        get
        {
            return after_loading_scene_id;
        }
    }

    public int BattleScene
    {
        get
        {
            return battle_Scene;
        }
    }

    public int StoryChapter
    {
        get
        {
            return story_chapter;
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

    public string StoryChapterName
    {
        get
        {
            return story_chapter_name.Localize();
        }
    }

    public string StoryReplayName
    {
        get
        {
            return story_replay_name.Localize();
        }
    }

    public int StoryReplayStep
    {
        get
        {
            return story_replay_step;
        }
    }

    public int StoryReplayTitle
    {
        get
        {
            return story_replay_title;
        }
    }

    public string SkipSummary
    {
        get
        {
            return skip_summary.Localize();
        }
    }

    public int DlgNextEpisode
    {
        get
        {
            return dlg_next_episode;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        rec_group = reader.ReadInt32();
        type = reader.ReadString();
        format_type = reader.ReadInt32();
        target_id = reader.ReadInt32();
        before_loading_scene_id = reader.ReadInt32();
        after_loading_scene_id = reader.ReadInt32();
        battle_Scene = reader.ReadInt32();
        story_chapter = reader.ReadInt32();
        story_type = reader.ReadInt32();
        story_region = reader.ReadInt32();
        story_chapter_name = reader.ReadInt32();
        story_replay_name = reader.ReadInt32();
        story_replay_step = reader.ReadInt32();
        story_replay_title = reader.ReadInt32();
        skip_summary = reader.ReadInt32();
        dlg_next_episode = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int rec_group;

    private string type;

    private int format_type;

    private int target_id;

    private int before_loading_scene_id;

    private int after_loading_scene_id;

    private int battle_Scene;

    private int story_chapter;

    private int story_type;

    private int story_region;

    private int story_chapter_name;

    private int story_replay_name;

    private int story_replay_step;

    private int story_replay_title;

    private int skip_summary;

    private int dlg_next_episode;
}
