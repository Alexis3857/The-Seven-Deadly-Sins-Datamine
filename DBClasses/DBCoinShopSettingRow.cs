public class DBCoinShopSettingRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string ItemType
    {
        get
        {
            return item_type;
        }
    }

    public int Rate
    {
        get
        {
            return rate;
        }
    }

    public int CoinShopMenu
    {
        get
        {
            return coin_shop_menu;
        }
    }

    public string ItemIcon
    {
        get
        {
            return item_icon;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        item_type = reader.ReadString();
        rate = reader.ReadInt32();
        coin_shop_menu = reader.ReadInt32();
        item_icon = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string item_type;

    private int rate;

    private int coin_shop_menu;

    private string item_icon;
}
