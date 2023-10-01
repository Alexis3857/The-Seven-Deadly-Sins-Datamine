public class DBEventConfirmConfigRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string Contents
    {
        get
        {
            return contents;
        }
    }

    public int ValueInt
    {
        get
        {
            return value_int;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        contents = reader.ReadString();
        value_int = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string contents;

    private int value_int;
}