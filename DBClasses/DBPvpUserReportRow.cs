public class DBPvpUserReportRow
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

    private int id;

    private string user_report_explain;
}
