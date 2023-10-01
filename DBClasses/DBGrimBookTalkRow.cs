public class DBGrimBookTalkRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int CategoryId
    {
        get
        {
            return category_id;
        }
    }

    public int DefaultTalk
    {
        get
        {
            return default_talk;
        }
    }

    public string CategoryTalk
    {
        get
        {
            return category_talk.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        category_id = reader.ReadInt32();
        default_talk = reader.ReadInt32();
        category_talk = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int category_id;

    private int default_talk;

    private int category_talk;
}
