public class DBItemInfoRow : ITableRowIndexer
{
    public int ItemId
    {
        get
        {
            return item_id;
        }
    }

    public string ItemIcon
    {
        get
        {
            return item_icon;
        }
    }

    public string ItemNickname
    {
        get
        {
            return item_nickname.Localize();
        }
    }

    public string ItemName
    {
        get
        {
            return item_name.Localize();
        }
    }

    public string ItemDescription
    {
        get
        {
            return item_description.Localize();
        }
    }

    public byte ItemType
    {
        get
        {
            return item_type;
        }
    }

    public int ItemDisplayGroup
    {
        get
        {
            return item_display_group;
        }
    }

    public int ItemCategory
    {
        get
        {
            return item_category;
        }
    }

    public byte ItemRating
    {
        get
        {
            return item_rating;
        }
    }

    public int ItemParam1
    {
        get
        {
            return item_param_1;
        }
    }

    public int ItemParam2
    {
        get
        {
            return item_param_2;
        }
    }

    public int ItemParam3
    {
        get
        {
            return item_param_3;
        }
    }

    public int ItemParam4
    {
        get
        {
            return item_param_4;
        }
    }

    public byte StorageOn
    {
        get
        {
            return storage_on;
        }
    }

    public byte StorageGroup
    {
        get
        {
            return storage_group;
        }
    }

    public byte SellOn
    {
        get
        {
            return sell_on;
        }
    }

    public int SellId
    {
        get
        {
            return sell_id;
        }
    }

    public int SellCost
    {
        get
        {
            return sell_cost;
        }
    }

    public byte ItemCoinType
    {
        get
        {
            return item_coin_type;
        }
    }

    public List<int> ListItemParam
    {
        get
        {
            if (list_item_param == null)
            {
                list_item_param = new List<int>
                {
                    ItemParam1,
                    ItemParam2,
                    ItemParam3,
                    ItemParam4
                };
            }
            return list_item_param;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        item_id = reader.ReadInt32();
        item_icon = reader.ReadString();
        item_nickname = reader.ReadInt32();
        item_name = reader.ReadInt32();
        item_description = reader.ReadInt32();
        item_type = reader.ReadByte();
        item_display_group = reader.ReadInt32();
        item_category = reader.ReadInt32();
        item_rating = reader.ReadByte();
        item_param_1 = reader.ReadInt32();
        item_param_2 = reader.ReadInt32();
        item_param_3 = reader.ReadInt32();
        item_param_4 = reader.ReadInt32();
        storage_on = reader.ReadByte();
        storage_group = reader.ReadByte();
        sell_on = reader.ReadByte();
        sell_id = reader.ReadInt32();
        sell_cost = reader.ReadInt32();
        item_coin_type = reader.ReadByte();
        return true;
    }

    public int GetRowIndex()
    {
        return ItemId;
    }

    private int item_id;

    private string item_icon;

    private int item_nickname;

    private int item_name;

    private int item_description;

    private byte item_type;

    private int item_display_group;

    private int item_category;

    private byte item_rating;

    private int item_param_1;

    private int item_param_2;

    private int item_param_3;

    private int item_param_4;

    private byte storage_on;

    private byte storage_group;

    private byte sell_on;

    private int sell_id;

    private int sell_cost;

    private byte item_coin_type;

    private List<int> list_item_param;
}
