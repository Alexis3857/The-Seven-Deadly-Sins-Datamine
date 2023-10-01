public class DBJukeboxListRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string BgmName
    {
        get
        {
            return bgm_name.Localize();
        }
    }

    public string BgmIcon
    {
        get
        {
            return bgm_icon;
        }
    }

    public string BgmDesc
    {
        get
        {
            return bgm_desc.Localize();
        }
    }

    public string BgmDescSub
    {
        get
        {
            return bgm_desc_sub.Localize();
        }
    }

    public string BgmCollectRequire
    {
        get
        {
            return bgm_collect_require.Localize();
        }
    }

    public int BgmResourceId
    {
        get
        {
            return bgm_resource_id;
        }
    }

    public int BgmType
    {
        get
        {
            return bgm_type;
        }
    }

    public int MatchingHeroId
    {
        get
        {
            return matching_hero_id;
        }
    }

    public int CollectionType
    {
        get
        {
            return collection_type;
        }
    }

    public int CollectionValue
    {
        get
        {
            return collection_value;
        }
    }

    public string Bgm7MlCode
    {
        get
        {
            return bgm_7ml_code;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        bgm_name = reader.ReadInt32();
        bgm_icon = reader.ReadString();
        bgm_desc = reader.ReadInt32();
        bgm_desc_sub = reader.ReadInt32();
        bgm_collect_require = reader.ReadInt32();
        bgm_resource_id = reader.ReadInt32();
        bgm_type = reader.ReadInt32();
        matching_hero_id = reader.ReadInt32();
        collection_type = reader.ReadInt32();
        collection_value = reader.ReadInt32();
        bgm_7ml_code = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int bgm_name;

    private string bgm_icon;

    private int bgm_desc;

    private int bgm_desc_sub;

    private int bgm_collect_require;

    private int bgm_resource_id;

    private int bgm_type;

    private int matching_hero_id;

    private int collection_type;

    private int collection_value;

    private string bgm_7ml_code;
}
