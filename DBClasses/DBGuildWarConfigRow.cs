public class DBGuildWarConfigRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string Type
    {
        get
        {
            return type;
        }
    }

    public string ValueString
    {
        get
        {
            return value_string;
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
        type = reader.ReadString();
        value_string = reader.ReadString();
        value_int = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string type;

    private string value_string;

    private int value_int;
}
