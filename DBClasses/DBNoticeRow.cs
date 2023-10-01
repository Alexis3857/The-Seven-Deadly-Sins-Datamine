public class DBNoticeRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string NoticeTitle
    {
        get
        {
            return notice_title.Localize();
        }
    }

    public string NoticeDesc1
    {
        get
        {
            return notice_desc1.Localize();
        }
    }

    public string NoticeDesc2
    {
        get
        {
            return notice_desc2.Localize();
        }
    }

    public int NoticeType
    {
        get
        {
            return notice_type;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        notice_title = reader.ReadInt32();
        notice_desc1 = reader.ReadInt32();
        notice_desc2 = reader.ReadInt32();
        notice_type = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int notice_title;

    private int notice_desc1;

    private int notice_desc2;

    private int notice_type;
}
