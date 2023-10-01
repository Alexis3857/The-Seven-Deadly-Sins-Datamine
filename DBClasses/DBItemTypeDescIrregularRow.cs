public class DBItemTypeDescIrregularRow : ITableRowIndexer
{
    public int ItemID
    {
        get
        {
            return item_ID;
        }
    }

    public string ItemTypeDescription
    {
        get
        {
            return item_type_description.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        item_ID = reader.ReadInt32();
        item_type_description = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return ItemID;
    }

    private int item_ID;

    private int item_type_description;
}
