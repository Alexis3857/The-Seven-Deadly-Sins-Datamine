public class DBRandomShopRatingPerRow : ITableRowIndexer
{
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
        rating = reader.ReadInt32();
        normal_slot = reader.ReadInt32();
        special_slot = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Rating;
    }

    private int rating;

    private int normal_slot;

    private int special_slot;
}
