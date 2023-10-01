public class DBEventRoadReactionRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string Locale
    {
        get
        {
            return locale.Localize();
        }
    }

    public string Animation
    {
        get
        {
            return animation;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        locale = reader.ReadInt32();
        animation = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int locale;

    private string animation;
}
