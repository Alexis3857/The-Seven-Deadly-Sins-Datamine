public class DBGuildMissionRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int OpenGuildLevel
    {
        get
        {
            return open_guild_level;
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

    public int AlarmType
    {
        get
        {
            return alarm_type;
        }
    }

    public int RewardItemId1
    {
        get
        {
            return reward_item_id_1;
        }
    }

    public int RewardItemCount1
    {
        get
        {
            return reward_item_count_1;
        }
    }

    public int RewardItemId2
    {
        get
        {
            return reward_item_id_2;
        }
    }

    public int RewardItemCount2
    {
        get
        {
            return reward_item_count_2;
        }
    }

    public int RewardGuildExp
    {
        get
        {
            return reward_guild_exp;
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

    public int MissionQuickLink
    {
        get
        {
            return mission_quick_link;
        }
    }

    public string GuildMissionIcon
    {
        get
        {
            return guild_mission_icon;
        }
    }

    public string GuildMissionIconPath
    {
        get
        {
            return guild_mission_icon_path;
        }
    }

    public List<int> ListRewardItemId
    {
        get
        {
            if (list_reward_item_id == null)
            {
                list_reward_item_id = new List<int>
                {
                    RewardItemId1,
                    RewardItemId2
                };
            }
            return list_reward_item_id;
        }
    }

    public List<int> ListRewardItemCount
    {
        get
        {
            if (list_reward_item_count == null)
            {
                list_reward_item_count = new List<int>
                {
                    RewardItemCount1,
                    RewardItemCount2
                };
            }
            return list_reward_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        open_guild_level = reader.ReadInt32();
        mission_type = reader.ReadString();
        mission_type_value = reader.ReadInt32();
        mission_target_value = reader.ReadInt32();
        alarm_type = reader.ReadInt32();
        reward_item_id_1 = reader.ReadInt32();
        reward_item_count_1 = reader.ReadInt32();
        reward_item_id_2 = reader.ReadInt32();
        reward_item_count_2 = reader.ReadInt32();
        reward_guild_exp = reader.ReadInt32();
        localize_display_type = reader.ReadInt32();
        mission_name = reader.ReadInt32();
        mission_quick_link = reader.ReadInt32();
        guild_mission_icon = reader.ReadString();
        guild_mission_icon_path = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int open_guild_level;

    private string mission_type;

    private int mission_type_value;

    private int mission_target_value;

    private int alarm_type;

    private int reward_item_id_1;

    private int reward_item_count_1;

    private int reward_item_id_2;

    private int reward_item_count_2;

    private int reward_guild_exp;

    private int localize_display_type;

    private int mission_name;

    private int mission_quick_link;

    private string guild_mission_icon;

    private string guild_mission_icon_path;

    private List<int> list_reward_item_id;

    private List<int> list_reward_item_count;
}
