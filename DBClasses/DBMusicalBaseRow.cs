public class DBMusicalBaseRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string MusicalBaseTypeName
    {
        get
        {
            return musical_base_type_name.Localize();
        }
    }

    public string MusicalBaseIcon
    {
        get
        {
            return musical_base_icon;
        }
    }

    public int MusicalComposeUse
    {
        get
        {
            return musical_compose_use;
        }
    }

    public int MusicalComposeOpen
    {
        get
        {
            return musical_compose_open;
        }
    }

    public int MusicalGmId
    {
        get
        {
            return musical_gm_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        musical_base_type_name = reader.ReadInt32();
        musical_base_icon = reader.ReadString();
        musical_compose_use = reader.ReadInt32();
        musical_compose_open = reader.ReadInt32();
        musical_gm_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int musical_base_type_name;

    private string musical_base_icon;

    private int musical_compose_use;

    private int musical_compose_open;

    private int musical_gm_id;
}
