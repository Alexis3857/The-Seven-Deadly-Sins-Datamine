public class DBGuildBaseRow : ITableRowIndexer
{
    public int GuildLevel
    {
        get
        {
            return guild_level;
        }
    }

    public int GuildMember
    {
        get
        {
            return guild_member;
        }
    }

    public int SkillSlotCount
    {
        get
        {
            return skill_slot_count;
        }
    }

    public int NeedPointCount
    {
        get
        {
            return need_point_count;
        }
    }

    public int SavePointCount
    {
        get
        {
            return save_point_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        guild_level = reader.ReadInt32();
        guild_member = reader.ReadInt32();
        skill_slot_count = reader.ReadInt32();
        need_point_count = reader.ReadInt32();
        save_point_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return GuildLevel;
    }

    private int guild_level;

    private int guild_member;

    private int skill_slot_count;

    private int need_point_count;

    private int save_point_count;
}
