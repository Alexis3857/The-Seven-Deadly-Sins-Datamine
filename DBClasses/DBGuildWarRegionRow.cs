public class DBGuildWarRegionRow : ITableRowIndexer
{
    public int GuildWarRegionId
    {
        get
        {
            return guild_war_region_id;
        }
    }

    public string GuildWarRegionType
    {
        get
        {
            return guild_war_region_type;
        }
    }

    public string GuildWarRegionName
    {
        get
        {
            return guild_war_region_name.Localize();
        }
    }

    public string GuildWarRegionIcon
    {
        get
        {
            return guild_war_region_icon;
        }
    }

    public int GuildWarRegionScore
    {
        get
        {
            return guild_war_region_score;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        guild_war_region_id = reader.ReadInt32();
        guild_war_region_type = reader.ReadString();
        guild_war_region_name = reader.ReadInt32();
        guild_war_region_icon = reader.ReadString();
        guild_war_region_score = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return GuildWarRegionId;
    }

    private int guild_war_region_id;

    private string guild_war_region_type;

    private int guild_war_region_name;

    private string guild_war_region_icon;

    private int guild_war_region_score;
}
