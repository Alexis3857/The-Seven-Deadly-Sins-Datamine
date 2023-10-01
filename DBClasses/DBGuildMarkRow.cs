public class DBGuildMarkRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string GuildMarkType
    {
        get
        {
            return guild_mark_type;
        }
    }

    public int GuildMarkId
    {
        get
        {
            return guild_mark_id;
        }
    }

    public int UnlockMissionId
    {
        get
        {
            return unlock_mission_id;
        }
    }

    public string GuildMarkTypeName
    {
        get
        {
            return guild_mark_type_name.Localize();
        }
    }

    public string GuildMarkFileName
    {
        get
        {
            return guild_mark_file_name;
        }
    }

    public string AuraUiFileName
    {
        get
        {
            return aura_ui_file_name;
        }
    }

    public string AuraSfxFileName
    {
        get
        {
            return aura_sfx_file_name;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        guild_mark_type = reader.ReadString();
        guild_mark_id = reader.ReadInt32();
        unlock_mission_id = reader.ReadInt32();
        guild_mark_type_name = reader.ReadInt32();
        guild_mark_file_name = reader.ReadString();
        aura_ui_file_name = reader.ReadString();
        aura_sfx_file_name = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string guild_mark_type;

    private int guild_mark_id;

    private int unlock_mission_id;

    private int guild_mark_type_name;

    private string guild_mark_file_name;

    private string aura_ui_file_name;

    private string aura_sfx_file_name;
}
