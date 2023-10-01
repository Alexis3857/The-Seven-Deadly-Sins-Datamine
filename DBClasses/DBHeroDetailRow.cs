public class DBHeroDetailRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int Type
    {
        get
        {
            return type;
        }
    }

    public string AniClip
    {
        get
        {
            return ani_clip;
        }
    }

    public string AniClipName
    {
        get
        {
            return ani_clip_name.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        type = reader.ReadInt32();
        ani_clip = reader.ReadString();
        ani_clip_name = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int type;

    private string ani_clip;

    private int ani_clip_name;
}
