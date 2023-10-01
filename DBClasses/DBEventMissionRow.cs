public class DBEventMissionRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int MissionGroup
    {
        get
        {
            return mission_group;
        }
    }

    public int SeasonPassWeeks
    {
        get
        {
            return season_pass_weeks;
        }
    }

    public int Category
    {
        get
        {
            return category;
        }
    }

    public string SeasonPassMissionCategory
    {
        get
        {
            return season_pass_mission_category;
        }
    }

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public int GroupIndex
    {
        get
        {
            return group_index;
        }
    }

    public int ChainId
    {
        get
        {
            return chain_id;
        }
    }

    public int ChainIndex
    {
        get
        {
            return chain_index;
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

    public int MissionStage
    {
        get
        {
            return mission_stage;
        }
    }

    public int MissionHero
    {
        get
        {
            return mission_hero;
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

    public int SkinLevel1
    {
        get
        {
            return skin_level_1;
        }
    }

    public int SkinAwaken1
    {
        get
        {
            return skin_awaken_1;
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

    public int SkinLevel2
    {
        get
        {
            return skin_level_2;
        }
    }

    public int SkinAwaken2
    {
        get
        {
            return skin_awaken_2;
        }
    }

    public int RewardItemId3
    {
        get
        {
            return reward_item_id_3;
        }
    }

    public int RewardItemCount3
    {
        get
        {
            return reward_item_count_3;
        }
    }

    public int SkinLevel3
    {
        get
        {
            return skin_level_3;
        }
    }

    public int SkinAwaken3
    {
        get
        {
            return skin_awaken_3;
        }
    }

    public int RewardItemId4
    {
        get
        {
            return reward_item_id_4;
        }
    }

    public int RewardItemCount4
    {
        get
        {
            return reward_item_count_4;
        }
    }

    public int SkinLevel4
    {
        get
        {
            return skin_level_4;
        }
    }

    public int SkinAwaken4
    {
        get
        {
            return skin_awaken_4;
        }
    }

    public int RewardAchievepointValue
    {
        get
        {
            return reward_achievepoint_value;
        }
    }

    public int RewardPeriodDay
    {
        get
        {
            return reward_period_day;
        }
    }

    public int LocalizeDisplayType
    {
        get
        {
            return localize_display_type;
        }
    }

    public int DisplayTitle
    {
        get
        {
            return display_title;
        }
    }

    public string IconInfo
    {
        get
        {
            return icon_info;
        }
    }

    public string MissionTitle
    {
        get
        {
            return mission_title.Localize();
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

    public List<int> ListRewardItemId
    {
        get
        {
            if (list_reward_item_id == null)
            {
                list_reward_item_id = new List<int>
                {
                    RewardItemId1,
                    RewardItemId2,
                    RewardItemId3,
                    RewardItemId4
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
                    RewardItemCount2,
                    RewardItemCount3,
                    RewardItemCount4
                };
            }
            return list_reward_item_count;
        }
    }

    public List<int> ListSkinLevel
    {
        get
        {
            if (list_skin_level == null)
            {
                list_skin_level = new List<int>
                {
                    SkinLevel1,
                    SkinLevel2,
                    SkinLevel3,
                    SkinLevel4
                };
            }
            return list_skin_level;
        }
    }

    public List<int> ListSkinAwaken
    {
        get
        {
            if (list_skin_awaken == null)
            {
                list_skin_awaken = new List<int>
                {
                    SkinAwaken1,
                    SkinAwaken2,
                    SkinAwaken3,
                    SkinAwaken4
                };
            }
            return list_skin_awaken;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        mission_group = reader.ReadInt32();
        season_pass_weeks = reader.ReadInt32();
        category = reader.ReadInt32();
        season_pass_mission_category = reader.ReadString();
        group_id = reader.ReadInt32();
        group_index = reader.ReadInt32();
        chain_id = reader.ReadInt32();
        chain_index = reader.ReadInt32();
        mission_type = reader.ReadString();
        mission_type_value = reader.ReadInt32();
        mission_target_value = reader.ReadInt32();
        mission_stage = reader.ReadInt32();
        mission_hero = reader.ReadInt32();
        alarm_type = reader.ReadInt32();
        reward_item_id_1 = reader.ReadInt32();
        reward_item_count_1 = reader.ReadInt32();
        skin_level_1 = reader.ReadInt32();
        skin_awaken_1 = reader.ReadInt32();
        reward_item_id_2 = reader.ReadInt32();
        reward_item_count_2 = reader.ReadInt32();
        skin_level_2 = reader.ReadInt32();
        skin_awaken_2 = reader.ReadInt32();
        reward_item_id_3 = reader.ReadInt32();
        reward_item_count_3 = reader.ReadInt32();
        skin_level_3 = reader.ReadInt32();
        skin_awaken_3 = reader.ReadInt32();
        reward_item_id_4 = reader.ReadInt32();
        reward_item_count_4 = reader.ReadInt32();
        skin_level_4 = reader.ReadInt32();
        skin_awaken_4 = reader.ReadInt32();
        reward_achievepoint_value = reader.ReadInt32();
        reward_period_day = reader.ReadInt32();
        localize_display_type = reader.ReadInt32();
        display_title = reader.ReadInt32();
        icon_info = reader.ReadString();
        mission_title = reader.ReadInt32();
        mission_name = reader.ReadInt32();
        mission_quick_link = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int mission_group;

    private int season_pass_weeks;

    private int category;

    private string season_pass_mission_category;

    private int group_id;

    private int group_index;

    private int chain_id;

    private int chain_index;

    private string mission_type;

    private int mission_type_value;

    private int mission_target_value;

    private int mission_stage;

    private int mission_hero;

    private int alarm_type;

    private int reward_item_id_1;

    private int reward_item_count_1;

    private int skin_level_1;

    private int skin_awaken_1;

    private int reward_item_id_2;

    private int reward_item_count_2;

    private int skin_level_2;

    private int skin_awaken_2;

    private int reward_item_id_3;

    private int reward_item_count_3;

    private int skin_level_3;

    private int skin_awaken_3;

    private int reward_item_id_4;

    private int reward_item_count_4;

    private int skin_level_4;

    private int skin_awaken_4;

    private int reward_achievepoint_value;

    private int reward_period_day;

    private int localize_display_type;

    private int display_title;

    private string icon_info;

    private int mission_title;

    private int mission_name;

    private int mission_quick_link;

    private List<int> list_reward_item_id;

    private List<int> list_reward_item_count;

    private List<int> list_skin_level;

    private List<int> list_skin_awaken;
}
