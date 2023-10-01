public class DBEventAutoBoxslotRow : ITableRowIndexer
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

    public int AddSlotCount
    {
        get
        {
            return add_slot_count;
        }
    }

    public int SlotCount
    {
        get
        {
            return slot_count;
        }
    }

    public int EnhanceCount
    {
        get
        {
            return enhance_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        add_slot_count = reader.ReadInt32();
        slot_count = reader.ReadInt32();
        enhance_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int add_slot_count;

    private int slot_count;

    private int enhance_count;
}
