public class DBGuildBossMissionRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int SeasonId
    {
        get
        {
            return season_id;
        }
    }

    public int SeasonGroup
    {
        get
        {
            return season_group;
        }
    }

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public int StageId
    {
        get
        {
            return stage_id;
        }
    }

    public string MissionType
    {
        get
        {
            return mission_type;
        }
    }

    public int MissionTypeValue
    {
        get
        {
            return mission_type_value;
        }
    }

    public int MissionTargetValue
    {
        get
        {
            return mission_target_value;
        }
    }

    public int GuildContributionReward
    {
        get
        {
            return guild_contribution_reward;
        }
    }

    public int MissionMultiplyValue
    {
        get
        {
            return mission_multiply_value;
        }
    }

    public int LocalizeDisplayType
    {
        get
        {
            return localize_display_type;
        }
    }

    public string MissionName
    {
        get
        {
            return mission_name.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        season_id = reader.ReadInt32();
        season_group = reader.ReadInt32();
        group_id = reader.ReadInt32();
        stage_id = reader.ReadInt32();
        mission_type = reader.ReadString();
        mission_type_value = reader.ReadInt32();
        mission_target_value = reader.ReadInt32();
        guild_contribution_reward = reader.ReadInt32();
        mission_multiply_value = reader.ReadInt32();
        localize_display_type = reader.ReadInt32();
        mission_name = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int season_id;

    private int season_group;

    private int group_id;

    private int stage_id;

    private string mission_type;

    private int mission_type_value;

    private int mission_target_value;

    private int guild_contribution_reward;

    private int mission_multiply_value;

    private int localize_display_type;

    private int mission_name;
}
