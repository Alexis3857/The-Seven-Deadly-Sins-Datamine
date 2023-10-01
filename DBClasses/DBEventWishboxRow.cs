public class DBEventWishboxRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int WishStep
    {
        get
        {
            return wish_step;
        }
    }

    public int WishType
    {
        get
        {
            return wish_type;
        }
    }

    public int ItemId
    {
        get
        {
            return item_id;
        }
    }

    public int ItemCount
    {
        get
        {
            return item_count;
        }
    }

    public int SkinLevel
    {
        get
        {
            return skin_level;
        }
    }

    public int SkinAwaken
    {
        get
        {
            return skin_awaken;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        wish_step = reader.ReadInt32();
        wish_type = reader.ReadInt32();
        item_id = reader.ReadInt32();
        item_count = reader.ReadInt32();
        skin_level = reader.ReadInt32();
        skin_awaken = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int wish_step;

    private int wish_type;

    private int item_id;

    private int item_count;

    private int skin_level;

    private int skin_awaken;
}
