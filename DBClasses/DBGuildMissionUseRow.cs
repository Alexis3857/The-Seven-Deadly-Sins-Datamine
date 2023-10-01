public class DBGuildMissionUseRow : ITableRowIndexer
{
    public int Index
    {
        get
        {
            return index;
        }
    }

    public int OpenGuildLevel
    {
        get
        {
            return open_guild_level;
        }
    }

    public int GuildMissionId
    {
        get
        {
            return guild_mission_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        index = reader.ReadInt32();
        open_guild_level = reader.ReadInt32();
        guild_mission_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Index;
    }

    private int index;

    private int open_guild_level;

    private int guild_mission_id;
}
