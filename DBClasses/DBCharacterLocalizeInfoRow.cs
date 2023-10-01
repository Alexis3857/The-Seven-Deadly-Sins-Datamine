public class DBCharacterLocalizeInfoRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string BaseId
    {
        get
        {
            return base_id;
        }
    }

    public string Localize
    {
        get
        {
            return localize;
        }
    }

    public string Icon
    {
        get
        {
            return icon;
        }
    }

    public string IconType
    {
        get
        {
            return icon_type;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        base_id = reader.ReadString();
        localize = reader.ReadString();
        icon = reader.ReadString();
        icon_type = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string base_id;

    private string localize;

    private string icon;

    private string icon_type;
}
