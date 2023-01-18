public class DBEventRoadReactionRow
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string Locale
    {
        get
        {
            return locale.Localize();
        }
    }

    public string Animation
    {
        get
        {
            return animation;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        locale = reader.ReadInt32();
        animation = reader.ReadString();
        return true;
    }

    private int id;

    private int locale;

    private string animation;
}
