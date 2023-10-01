public class DBLoadingSceneRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public int LoadingType
    {
        get
        {
            return loading_type;
        }
    }

    public string LoadingScenePath
    {
        get
        {
            return loading_scene_path;
        }
    }

    public string ResourceLoadingScene
    {
        get
        {
            return resource_loading_scene;
        }
    }

    public string LoadingTitle
    {
        get
        {
            return loading_title.Localize();
        }
    }

    public string LoadingDesc
    {
        get
        {
            return loading_desc.Localize();
        }
    }

    public int LoadingHero
    {
        get
        {
            return loading_hero;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        group_id = reader.ReadInt32();
        loading_type = reader.ReadInt32();
        loading_scene_path = reader.ReadString();
        resource_loading_scene = reader.ReadString();
        loading_title = reader.ReadInt32();
        loading_desc = reader.ReadInt32();
        loading_hero = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int group_id;

    private int loading_type;

    private string loading_scene_path;

    private string resource_loading_scene;

    private int loading_title;

    private int loading_desc;

    private int loading_hero;
}
