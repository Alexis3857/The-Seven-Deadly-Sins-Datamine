public class DBPvpRuleSettingRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string StartDate
    {
        get
        {
            return start_date;
        }
    }

    public int PvpPassiveId
    {
        get
        {
            return pvp_passive_id;
        }
    }

    public string PvpPassiveIcon
    {
        get
        {
            return pvp_passive_icon;
        }
    }

    public int PvpModeId
    {
        get
        {
            return pvp_mode_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        start_date = reader.ReadString();
        pvp_passive_id = reader.ReadInt32();
        pvp_passive_icon = reader.ReadString();
        pvp_mode_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string start_date;

    private int pvp_passive_id;

    private string pvp_passive_icon;

    private int pvp_mode_id;
}
