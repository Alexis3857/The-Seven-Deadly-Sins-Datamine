public class DBCoinDemonpointRow : ITableRowIndexer
{
    public int Id => id;

    public int Demonpoint => demonpoint;

    public byte ItemType => item_type;

    public byte ItemRating => item_rating;

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        demonpoint = reader.ReadInt32();
        item_type = reader.ReadByte();
        item_rating = reader.ReadByte();
        return true;
    }

    public int GetRowIndex()
    {
        return id;
    }

    private int id;

    private int demonpoint;

    private byte item_type;

    private byte item_rating;
}