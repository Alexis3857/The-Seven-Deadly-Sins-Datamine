public class DBItemTypeDescRow : ITableRowIndexer
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

    public string ItemTypeDescription
    {
        get
        {
            return item_type_description.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        item_type = reader.ReadString();
        item_type_description = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string item_type;

    private int item_type_description;
}
