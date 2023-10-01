public class DBEventFurnitureRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public string LobbyType
    {
        get
        {
            return lobby_type;
        }
    }

    public int FurnitureId
    {
        get
        {
            return furniture_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        lobby_type = reader.ReadString();
        furniture_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private string lobby_type;

    private int furniture_id;
}
