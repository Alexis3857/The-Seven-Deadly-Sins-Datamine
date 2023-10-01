public class DBBirthdayRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GuestId
    {
        get
        {
            return guest_id;
        }
    }

    public int BirthdayMonth
    {
        get
        {
            return birthday_month;
        }
    }

    public int BirthdayDay
    {
        get
        {
            return birthday_day;
        }
    }

    public int FellowshipMultipleValue
    {
        get
        {
            return fellowship_multiple_value;
        }
    }

    public string BirthdayComment
    {
        get
        {
            return birthday_comment.Localize();
        }
    }

    public string IllustId
    {
        get
        {
            return illust_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        guest_id = reader.ReadInt32();
        birthday_month = reader.ReadInt32();
        birthday_day = reader.ReadInt32();
        fellowship_multiple_value = reader.ReadInt32();
        birthday_comment = reader.ReadInt32();
        illust_id = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int guest_id;

    private int birthday_month;

    private int birthday_day;

    private int fellowship_multiple_value;

    private int birthday_comment;

    private string illust_id;
}
