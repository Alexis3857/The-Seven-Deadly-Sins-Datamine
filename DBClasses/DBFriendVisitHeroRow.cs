public class DBFriendVisitHeroRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int SyncNpc
    {
        get
        {
            return sync_npc;
        }
    }

    public int GuestId
    {
        get
        {
            return guest_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        sync_npc = reader.ReadInt32();
        guest_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int sync_npc;

    private int guest_id;
}
