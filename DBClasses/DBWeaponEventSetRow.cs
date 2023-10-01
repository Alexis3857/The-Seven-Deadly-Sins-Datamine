public class DBWeaponEventSetRow : ITableRowIndexer
{
    public int EventSetId
    {
        get
        {
            return event_set_id;
        }
    }

    public int DisplayId
    {
        get
        {
            return display_id;
        }
    }

    public string EventSetIcon
    {
        get
        {
            return event_set_icon;
        }
    }

    public string EventSetName
    {
        get
        {
            return event_set_name.Localize();
        }
    }

    public string EventSetDesc
    {
        get
        {
            return event_set_desc.Localize();
        }
    }

    public int SetCount
    {
        get
        {
            return set_count;
        }
    }

    public int SetPassiveId
    {
        get
        {
            return set_passive_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        event_set_id = reader.ReadInt32();
        display_id = reader.ReadInt32();
        event_set_icon = reader.ReadString();
        event_set_name = reader.ReadInt32();
        event_set_desc = reader.ReadInt32();
        set_count = reader.ReadInt32();
        set_passive_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return EventSetId;
    }

    private int event_set_id;

    private int display_id;

    private string event_set_icon;

    private int event_set_name;

    private int event_set_desc;

    private int set_count;

    private int set_passive_id;
}
