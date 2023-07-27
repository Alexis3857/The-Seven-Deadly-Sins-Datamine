public class DBEventBalloondartRewardRow
{
    public int Id => id;

    public int ItemId => item_id;

    public int ItemCount => item_count;

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        item_id = reader.ReadInt32();
        item_count = reader.ReadInt32();
        return true;
    }

    private int id;

    private int item_id;

    private int item_count;
}