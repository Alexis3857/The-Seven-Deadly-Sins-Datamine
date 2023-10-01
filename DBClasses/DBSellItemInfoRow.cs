public class DBSellItemInfoRow : ITableRowIndexer
{
    public int ItemId
    {
        get
        {
            return item_id;
        }
    }

    public int SellType
    {
        get
        {
            return sell_type;
        }
    }

    public string ItemType
    {
        get
        {
            return item_type;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        item_id = reader.ReadInt32();
        sell_type = reader.ReadInt32();
        item_type = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return ItemId;
    }

    private int item_id;

    private int sell_type;

    private string item_type;
}
