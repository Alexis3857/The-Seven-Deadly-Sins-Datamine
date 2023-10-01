public class DBVoiceRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int HeroId
    {
        get
        {
            return hero_id;
        }
    }

    public int FellowshipLevel
    {
        get
        {
            return fellowship_level;
        }
    }

    public int SoundId
    {
        get
        {
            return sound_id;
        }
    }

    public string SoundName
    {
        get
        {
            return sound_name.Localize();
        }
    }

    public string SoundDescription
    {
        get
        {
            return sound_description.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        hero_id = reader.ReadInt32();
        fellowship_level = reader.ReadInt32();
        sound_id = reader.ReadInt32();
        sound_name = reader.ReadInt32();
        sound_description = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int hero_id;

    private int fellowship_level;

    private int sound_id;

    private int sound_name;

    private int sound_description;
}
