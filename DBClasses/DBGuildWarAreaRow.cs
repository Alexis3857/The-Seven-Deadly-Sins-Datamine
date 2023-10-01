public class DBGuildWarAreaRow : ITableRowIndexer
{
    public int GuildWarAreaId
    {
        get
        {
            return guild_war_area_id;
        }
    }

    public int GuildWarRegionId
    {
        get
        {
            return guild_war_region_id;
        }
    }

    public string GuildWarAreaName
    {
        get
        {
            return guild_war_area_name.Localize();
        }
    }

    public string GuildWarAreaIcon
    {
        get
        {
            return guild_war_area_icon;
        }
    }

    public string GuildWarAreaDestroyIcon
    {
        get
        {
            return guild_war_area_destroy_icon;
        }
    }

    public string GuildWarAreaBgPath
    {
        get
        {
            return guild_war_area_bg_path;
        }
    }

    public string GuildWarAreaBg
    {
        get
        {
            return guild_war_area_bg;
        }
    }

    public int GuildWarAreaScore
    {
        get
        {
            return guild_war_area_score;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        guild_war_area_id = reader.ReadInt32();
        guild_war_region_id = reader.ReadInt32();
        guild_war_area_name = reader.ReadInt32();
        guild_war_area_icon = reader.ReadString();
        guild_war_area_destroy_icon = reader.ReadString();
        guild_war_area_bg_path = reader.ReadString();
        guild_war_area_bg = reader.ReadString();
        guild_war_area_score = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return GuildWarAreaId;
    }

    private int guild_war_area_id;

    private int guild_war_region_id;

    private int guild_war_area_name;

    private string guild_war_area_icon;

    private string guild_war_area_destroy_icon;

    private string guild_war_area_bg_path;

    private string guild_war_area_bg;

    private int guild_war_area_score;
}
