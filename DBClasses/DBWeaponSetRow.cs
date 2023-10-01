public class DBWeaponSetRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 842U;
        }
    }

    public int SetId
    {
        get
        {
            return base.DecryptInt32(set_id);
        }
    }

    public int TabOn
    {
        get
        {
            return base.DecryptInt32(tab_on);
        }
    }

    public int DisplayId
    {
        get
        {
            return base.DecryptInt32(display_id);
        }
    }

    public int SetPriority
    {
        get
        {
            return base.DecryptInt32(set_priority);
        }
    }

    public string SetIcon
    {
        get
        {
            return set_icon;
        }
    }

    public string SetName
    {
        get
        {
            return set_name.Localize();
        }
    }

    public string SetDesc
    {
        get
        {
            return set_desc.Localize();
        }
    }

    public int SetCount
    {
        get
        {
            return base.DecryptInt32(set_count);
        }
    }

    public int SetPassiveId
    {
        get
        {
            return base.DecryptInt32(set_passive_id);
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        set_id = reader.ReadBytes(4);
        tab_on = reader.ReadBytes(4);
        display_id = reader.ReadBytes(4);
        set_priority = reader.ReadBytes(4);
        set_icon = reader.ReadString();
        set_name = reader.ReadInt32();
        set_desc = reader.ReadInt32();
        set_count = reader.ReadBytes(4);
        set_passive_id = reader.ReadBytes(4);
        return true;
    }

    public int GetRowIndex()
    {
        return SetId;
    }

    private byte[] set_id;

    private byte[] tab_on;

    private byte[] display_id;

    private byte[] set_priority;

    private string set_icon;

    private int set_name;

    private int set_desc;

    private byte[] set_count;

    private byte[] set_passive_id;
}
