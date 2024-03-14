public class DBRandomShopRatingPerRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int Rating
    {
        get
        {
            return rating;
        }
    }

    public int NormalSlot
    {
        get
        {
            return normal_slot;
        }
    }

    public int SpecialSlot
    {
        get
        {
            return special_slot;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        rating = reader.ReadInt32();
        normal_slot = reader.ReadInt32();
        special_slot = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Rating;
    }

    private int id;

    private int rating;

    private int normal_slot;

    private int special_slot;
}
