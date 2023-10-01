public class DBSkinAwakenRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int SkinAwakenCount
    {
        get
        {
            return skin_awaken_count;
        }
    }

    public int SkinAwakenLevel
    {
        get
        {
            return skin_awaken_level;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        skin_awaken_count = reader.ReadInt32();
        skin_awaken_level = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int skin_awaken_count;

    private int skin_awaken_level;
}
