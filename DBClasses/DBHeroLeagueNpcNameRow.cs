public class DBHeroLeagueNpcNameRow
{
    public int Index
    {
        get
        {
            return index;
        }
    }

    public string NameLocal
    {
        get
        {
            return name_local.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        index = reader.ReadInt32();
        name_local = reader.ReadInt32();
        return true;
    }

    private int index;

    private int name_local;
}