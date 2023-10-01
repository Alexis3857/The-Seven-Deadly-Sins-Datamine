public class DBEventRoadStageRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int Group
    {
        get
        {
            return group;
        }
    }

    public int Index
    {
        get
        {
            return index;
        }
    }

    public int TileType
    {
        get
        {
            return tile_type;
        }
    }

    public int TileValue1
    {
        get
        {
            return tile_value1;
        }
    }

    public int TileValue2
    {
        get
        {
            return tile_value2;
        }
    }

    public int TileReaction
    {
        get
        {
            return tile_reaction;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        group = reader.ReadInt32();
        index = reader.ReadInt32();
        tile_type = reader.ReadInt32();
        tile_value1 = reader.ReadInt32();
        tile_value2 = reader.ReadInt32();
        tile_reaction = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int group;

    private int index;

    private int tile_type;

    private int tile_value1;

    private int tile_value2;

    private int tile_reaction;
}
