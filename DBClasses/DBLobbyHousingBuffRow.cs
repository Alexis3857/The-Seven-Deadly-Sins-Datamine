public class DBLobbyHousingBuffRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string LobbyType
    {
        get
        {
            return lobby_type;
        }
    }

    public string PassiveType
    {
        get
        {
            return passive_type;
        }
    }

    public int PassiveId
    {
        get
        {
            return passive_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        lobby_type = reader.ReadString();
        passive_type = reader.ReadString();
        passive_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string lobby_type;

    private string passive_type;

    private int passive_id;
}
