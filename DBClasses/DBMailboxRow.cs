public class DBMailboxRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string MailRouteLocalize
    {
        get
        {
            return mail_route_localize.Localize();
        }
    }

    public string MailRouteDescLocalize
    {
        get
        {
            return mail_route_desc_localize.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        mail_route_localize = reader.ReadInt32();
        mail_route_desc_localize = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int mail_route_localize;

    private int mail_route_desc_localize;
}
