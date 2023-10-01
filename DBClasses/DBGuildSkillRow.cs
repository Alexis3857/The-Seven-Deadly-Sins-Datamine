public class DBGuildSkillRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string PassiveType
    {
        get
        {
            return passive_type;
        }
    }

    public int GuildSkillPassive
    {
        get
        {
            return guild_skill_passive;
        }
    }

    public int GuildSkillOpenLv
    {
        get
        {
            return guild_skill_open_lv;
        }
    }

    public int GuildSkillLv
    {
        get
        {
            return guild_skill_lv;
        }
    }

    public int GuildSkillGroup
    {
        get
        {
            return guild_skill_group;
        }
    }

    public int GuildSkillLvPriceCount
    {
        get
        {
            return guild_skill_lv_price_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        passive_type = reader.ReadString();
        guild_skill_passive = reader.ReadInt32();
        guild_skill_open_lv = reader.ReadInt32();
        guild_skill_lv = reader.ReadInt32();
        guild_skill_group = reader.ReadInt32();
        guild_skill_lv_price_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string passive_type;

    private int guild_skill_passive;

    private int guild_skill_open_lv;

    private int guild_skill_lv;

    private int guild_skill_group;

    private int guild_skill_lv_price_count;
}
