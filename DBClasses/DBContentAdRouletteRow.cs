public class DBContentAdRouletteRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string AdType
    {
        get
        {
            return ad_type;
        }
    }

    public int ItemId
    {
        get
        {
            return item_id;
        }
    }

    public int ItemCount
    {
        get
        {
            return item_count;
        }
    }

    public int Rate
    {
        get
        {
            return rate;
        }
    }

    public int Grade
    {
        get
        {
            return grade;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        ad_type = reader.ReadString();
        item_id = reader.ReadInt32();
        item_count = reader.ReadInt32();
        rate = reader.ReadInt32();
        grade = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string ad_type;

    private int item_id;

    private int item_count;

    private int rate;

    private int grade;
}
