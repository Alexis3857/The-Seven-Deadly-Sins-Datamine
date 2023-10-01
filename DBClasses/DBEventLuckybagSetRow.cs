public class DBEventLuckybagSetRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int LuckybagGroup
    {
        get
        {
            return luckybag_group;
        }
    }

    public int LuckybagCount
    {
        get
        {
            return luckybag_count;
        }
    }

    public int OpenKeyItem
    {
        get
        {
            return open_key_item;
        }
    }

    public int LuckybagOpenProductId
    {
        get
        {
            return luckybag_open_product_id;
        }
    }

    public string LuckybagTitle
    {
        get
        {
            return luckybag_title.Localize();
        }
    }

    public string LuckybagSubTitle
    {
        get
        {
            return luckybag_sub_title.Localize();
        }
    }

    public string LuckybagImage
    {
        get
        {
            return luckybag_image;
        }
    }

    public int LuckybagAllclearRewardItemId
    {
        get
        {
            return luckybag_allclear_reward_item_id;
        }
    }

    public int LuckybagAllclearRewardItemCount
    {
        get
        {
            return luckybag_allclear_reward_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        luckybag_group = reader.ReadInt32();
        luckybag_count = reader.ReadInt32();
        open_key_item = reader.ReadInt32();
        luckybag_open_product_id = reader.ReadInt32();
        luckybag_title = reader.ReadInt32();
        luckybag_sub_title = reader.ReadInt32();
        luckybag_image = reader.ReadString();
        luckybag_allclear_reward_item_id = reader.ReadInt32();
        luckybag_allclear_reward_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int luckybag_group;

    private int luckybag_count;

    private int open_key_item;

    private int luckybag_open_product_id;

    private int luckybag_title;

    private int luckybag_sub_title;

    private string luckybag_image;

    private int luckybag_allclear_reward_item_id;

    private int luckybag_allclear_reward_item_count;
}
