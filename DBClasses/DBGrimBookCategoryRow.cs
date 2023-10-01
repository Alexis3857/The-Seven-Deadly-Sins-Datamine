public class DBGrimBookCategoryRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string CategoryName
    {
        get
        {
            return category_name.Localize();
        }
    }

    public int CategoryShow
    {
        get
        {
            return category_show;
        }
    }

    public int CategoryMain
    {
        get
        {
            return category_main;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        category_name = reader.ReadInt32();
        category_show = reader.ReadInt32();
        category_main = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int category_name;

    private int category_show;

    private int category_main;
}
