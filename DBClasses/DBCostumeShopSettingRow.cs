public class DBCostumeShopSettingRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int CostumeBannerGroup
    {
        get
        {
            return costume_banner_group;
        }
    }

    public int StoryId
    {
        get
        {
            return story_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        costume_banner_group = reader.ReadInt32();
        story_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int costume_banner_group;

    private int story_id;
}
