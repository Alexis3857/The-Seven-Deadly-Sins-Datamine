public class DBEventGambleboxGroupRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int Boxstep
    {
        get
        {
            return boxstep;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public int ItemId
    {
        get
        {
            return item_id;
        }
    }

    public int Amount
    {
        get
        {
            return amount;
        }
    }

    public int Stock
    {
        get
        {
            return stock;
        }
    }

    public int GambleRate
    {
        get
        {
            return gamble_rate;
        }
    }

    public int PickUpCheck
    {
        get
        {
            return pick_up_check;
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

    public int PickUpInfo
    {
        get
        {
            return pick_up_info;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        boxstep = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        item_id = reader.ReadInt32();
        amount = reader.ReadInt32();
        stock = reader.ReadInt32();
        gamble_rate = reader.ReadInt32();
        pick_up_check = reader.ReadInt32();
        skin_level = reader.ReadInt32();
        skin_awaken = reader.ReadInt32();
        pick_up_info = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int boxstep;

    private int event_sub_index;

    private int item_id;

    private int amount;

    private int stock;

    private int gamble_rate;

    private int pick_up_check;

    private int skin_level;

    private int skin_awaken;

    private int pick_up_info;
}