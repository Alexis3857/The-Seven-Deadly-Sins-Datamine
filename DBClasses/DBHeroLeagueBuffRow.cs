public class DBHeroLeagueBuffRow
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int BuffTargetSeason
    {
        get
        {
            return buff_target_season;
        }
    }

    public int BuffPassiveId
    {
        get
        {
            return buff_passive_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        buff_target_season = reader.ReadInt32();
        buff_passive_id = reader.ReadInt32();
        return true;
    }

    private int id;

    private int buff_target_season;

    private int buff_passive_id;
}