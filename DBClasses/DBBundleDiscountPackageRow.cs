public class DBBundleDiscountPackageRow : ITableRowIndexer

{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ProductId
    {
        get
        {
            return product_id;
        }
    }

    public int LinkProductId
    {
        get
        {
            return link_product_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        product_id = reader.ReadInt32();
        link_product_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int product_id;

    private int link_product_id;
}
