public class DBConstellationIgnoreTeamRow
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int IgnoreTeamIndex
    {
        get
        {
            return ignore_team_index;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        ignore_team_index = reader.ReadInt32();
        return true;
    }

    private int id;

    private int ignore_team_index;
}
