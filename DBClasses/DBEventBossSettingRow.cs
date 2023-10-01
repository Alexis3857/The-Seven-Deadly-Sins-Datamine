public class DBEventBossSettingRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string EventStart
    {
        get
        {
            return event_start;
        }
    }

    public int EventUseHeroReset
    {
        get
        {
            return event_use_hero_reset;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_start = reader.ReadString();
        event_use_hero_reset = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string event_start;

    private int event_use_hero_reset;
}
