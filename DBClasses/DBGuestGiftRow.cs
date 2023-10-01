public class DBGuestGiftRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GuestId
    {
        get
        {
            return guest_id;
        }
    }

    public int GiftIndex
    {
        get
        {
            return gift_index;
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

    public int SalesBonus
    {
        get
        {
            return sales_bonus;
        }
    }

    public int ContentsPassiveId
    {
        get
        {
            return contents_passive_id;
        }
    }

    public int GiftFellowCount
    {
        get
        {
            return gift_fellow_count;
        }
    }

    public int RewardItemId
    {
        get
        {
            return reward_item_id;
        }
    }

    public int RewardItemCount
    {
        get
        {
            return reward_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        guest_id = reader.ReadInt32();
        gift_index = reader.ReadInt32();
        item_id = reader.ReadInt32();
        item_count = reader.ReadInt32();
        sales_bonus = reader.ReadInt32();
        contents_passive_id = reader.ReadInt32();
        gift_fellow_count = reader.ReadInt32();
        reward_item_id = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int guest_id;

    private int gift_index;

    private int item_id;

    private int item_count;

    private int sales_bonus;

    private int contents_passive_id;

    private int gift_fellow_count;

    private int reward_item_id;

    private int reward_item_count;
}
