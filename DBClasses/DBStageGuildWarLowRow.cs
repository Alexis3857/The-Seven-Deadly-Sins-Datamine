public class DBStageGuildWarLowRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string Type
    {
        get
        {
            return type;
        }
    }

    public string ControlType
    {
        get
        {
            return control_type;
        }
    }

    public int GuildWarLowAreaId
    {
        get
        {
            return guild_war_low_area_id;
        }
    }

    public int Index
    {
        get
        {
            return index;
        }
    }

    public int NeedStaminaItemId
    {
        get
        {
            return need_stamina_item_id;
        }
    }

    public int NeedStaminaCount
    {
        get
        {
            return need_stamina_count;
        }
    }

    public int RewardId1
    {
        get
        {
            return reward_id_1;
        }
    }

    public int RewardValue1
    {
        get
        {
            return reward_value_1;
        }
    }

    public int RewardValueBox1
    {
        get
        {
            return reward_value_box_1;
        }
    }

    public int IsTurnPivot
    {
        get
        {
            return is_turn_pivot;
        }
    }

    public int PlayBossSpawn
    {
        get
        {
            return play_boss_spawn;
        }
    }

    public string BossEntryType
    {
        get
        {
            return boss_entry_type;
        }
    }

    public List<int> ListArrayAllyPassiveId
    {
        get
        {
            return list_array_ally_passive_id;
        }
    }

    public string MapFilename
    {
        get
        {
            return map_filename;
        }
    }

    public string SpawnPropFilename
    {
        get
        {
            return spawn_prop_filename;
        }
    }

    public string ChangeMapFilename
    {
        get
        {
            return change_map_filename;
        }
    }

    public int BgmSoundId
    {
        get
        {
            return bgm_sound_id;
        }
    }

    public int BossSoundId
    {
        get
        {
            return boss_sound_id;
        }
    }

    public int HrunRewardMaxValue
    {
        get
        {
            return Hrun_reward_max_value;
        }
    }

    public string HrunMap
    {
        get
        {
            return Hrun_map;
        }
    }

    public string HrunBg
    {
        get
        {
            return Hrun_bg;
        }
    }

    public int NpcTeamId
    {
        get
        {
            return npc_team_id;
        }
    }

    public List<int> ListRewardId
    {
        get
        {
            if (list_reward_id == null)
            {
                list_reward_id = new List<int>
                {
                    RewardId1
                };
            }
            return list_reward_id;
        }
    }

    public List<int> ListRewardValue
    {
        get
        {
            if (list_reward_value == null)
            {
                list_reward_value = new List<int>
                {
                    RewardValue1
                };
            }
            return list_reward_value;
        }
    }

    public List<int> ListRewardValueBox
    {
        get
        {
            if (list_reward_value_box == null)
            {
                list_reward_value_box = new List<int>
                {
                    RewardValueBox1
                };
            }
            return list_reward_value_box;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        type = reader.ReadString();
        control_type = reader.ReadString();
        guild_war_low_area_id = reader.ReadInt32();
        index = reader.ReadInt32();
        need_stamina_item_id = reader.ReadInt32();
        need_stamina_count = reader.ReadInt32();
        reward_id_1 = reader.ReadInt32();
        reward_value_1 = reader.ReadInt32();
        reward_value_box_1 = reader.ReadInt32();
        is_turn_pivot = reader.ReadInt32();
        play_boss_spawn = reader.ReadInt32();
        boss_entry_type = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_ally_passive_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_ally_passive_id.Add(reader.ReadInt32());
        }
        map_filename = reader.ReadString();
        spawn_prop_filename = reader.ReadString();
        change_map_filename = reader.ReadString();
        bgm_sound_id = reader.ReadInt32();
        boss_sound_id = reader.ReadInt32();
        Hrun_reward_max_value = reader.ReadInt32();
        Hrun_map = reader.ReadString();
        Hrun_bg = reader.ReadString();
        npc_team_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string type;

    private string control_type;

    private int guild_war_low_area_id;

    private int index;

    private int need_stamina_item_id;

    private int need_stamina_count;

    private int reward_id_1;

    private int reward_value_1;

    private int reward_value_box_1;

    private int is_turn_pivot;

    private int play_boss_spawn;

    private string boss_entry_type;

    private List<int> list_array_ally_passive_id;

    private string map_filename;

    private string spawn_prop_filename;

    private string change_map_filename;

    private int bgm_sound_id;

    private int boss_sound_id;

    private int Hrun_reward_max_value;

    private string Hrun_map;

    private string Hrun_bg;

    private int npc_team_id;

    private List<int> list_reward_id;

    private List<int> list_reward_value;

    private List<int> list_reward_value_box;
}
