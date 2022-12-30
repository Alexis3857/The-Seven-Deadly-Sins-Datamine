public class DBEventRoadReactionRow
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string TileType
    {
        get
        {
            return tile_type;
        }
    }

    public string Locale
    {
        get
        {
            return locale.Localize();
        }
    }

    public string Animation
    {
        get
        {
            return animation;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        tile_type = reader.ReadString();
        locale = reader.ReadInt32();
        animation = reader.ReadString();
        return true;
    }

    private int id;

    private string tile_type;

    private int locale;

    private string animation;
}
