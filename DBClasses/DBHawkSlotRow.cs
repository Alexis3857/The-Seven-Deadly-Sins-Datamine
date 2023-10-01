public class DBHawkSlotRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int StageId
    {
        get
        {
            return stage_id;
        }
    }

    public int Slot
    {
        get
        {
            return slot;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        stage_id = reader.ReadInt32();
        slot = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int stage_id;

    private int slot;
}
