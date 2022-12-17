public class DBEventRoadTileRow
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int TileScore
    {
        get
        {
            return tile_score;
        }
    }

    private string TileIcon
    {
        get
        {
            return tile_icon;
        }
    }

    public int TileTitle
    {
        get
        {
            return tile_title;
        }
    }

    public string TileDesc
    {
        get
        {
            return tile_desc.Localize();
        }
    }
    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        tile_score = reader.ReadInt32();
        tile_icon = reader.ReadString();
        tile_title = reader.ReadInt32();
        tile_desc = reader.ReadInt32();
        return true;
    }

    private int id;

    private int tile_score;

    private string tile_icon;

    private int tile_title;

    private int tile_desc;
}
