public class DBItemGotchaGroupRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GotchaGroup
    {
        get
        {
            return gotcha_group;
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

    public int ItemRate
    {
        get
        {
            return item_rate;
        }
    }

    public int Rate
    {
        get
        {
            return rate;
        }
    }

    public int PickUpCheck
    {
        get
        {
            return pick_up_check;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        gotcha_group = reader.ReadInt32();
        item_id = reader.ReadInt32();
        item_count = reader.ReadInt32();
        item_rate = reader.ReadInt32();
        rate = reader.ReadInt32();
        pick_up_check = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int gotcha_group;

    private int item_id;

    private int item_count;

    private int item_rate;

    private int rate;

    private int pick_up_check;
}
