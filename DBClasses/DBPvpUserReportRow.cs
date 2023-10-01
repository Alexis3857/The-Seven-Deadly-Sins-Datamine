public class DBPvpUserReportRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string UserReportExplain
    {
        get
        {
            return user_report_explain;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        user_report_explain = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string user_report_explain;
}
