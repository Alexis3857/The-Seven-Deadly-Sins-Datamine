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

    public string ReactionImage
    {
        get
        {
            return reaction_image;
        }
    }

    public string Locale
    {
        get
        {
            return locale.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        tile_type = reader.ReadString();
        reaction_image = reader.ReadString();
        locale = reader.ReadInt32();
        return true;
    }

    private int id;

    private string tile_type;

    private string reaction_image;

    private int locale;
}
