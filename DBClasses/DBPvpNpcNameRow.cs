public class DBPvpNpcNameRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string NameLocal
    {
        get
        {
            return name_local.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        name_local = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int name_local;
}
