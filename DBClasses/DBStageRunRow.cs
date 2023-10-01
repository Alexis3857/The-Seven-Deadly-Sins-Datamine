public class DBStageRunRow : ITableRowIndexer
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

    public int Region
    {
        get
        {
            return region;
        }
    }

    public int Area
    {
        get
        {
            return area;
        }
    }

    public string StageString
    {
        get
        {
            return stage_string.Localize();
        }
    }

    public string ControlType
    {
        get
        {
            return control_type;
        }
    }

    public int RunIndex
    {
        get
        {
            return run_index;
        }
    }

    public int NeedBaseFellowId
    {
        get
        {
            return need_base_fellow_id;
        }
    }

    public int NeedBaseFellowLevel
    {
        get
        {
            return need_base_fellow_level;
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

    public int FirstRewardId
    {
        get
        {
            return first_reward_id;
        }
    }

    public int FirstRewardValue
    {
        get
        {
            return first_reward_value;
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

    public int RewardMaxValue
    {
        get
        {
            return reward_max_value;
        }
    }

    public string HawkRunBg
    {
        get
        {
            return hawk_run_bg;
        }
    }

    public string HawkRunBalance
    {
        get
        {
            return hawk_run_balance;
        }
    }

    public int BgmSoundId
    {
        get
        {
            return bgm_sound_id;
        }
    }

    public int SpeedSoundId
    {
        get
        {
            return speed_sound_id;
        }
    }

    public float MagnetEffectTime
    {
        get
        {
            return magnet_effect_time;
        }
    }

    public int BrokenTowerCoin
    {
        get
        {
            return broken_tower_coin;
        }
    }

    public float SpeedupTime
    {
        get
        {
            return speedup_time;
        }
    }

    public float VelocityDefault
    {
        get
        {
            return velocity_default;
        }
    }

    public float VelocitySpeedup
    {
        get
        {
            return velocity_speedup;
        }
    }

    public int InitHp
    {
        get
        {
            return init_hp;
        }
    }

    public int CoinBoxValue
    {
        get
        {
            return coin_box_value;
        }
    }

    public int RewardHpCoin
    {
        get
        {
            return reward_hp_coin;
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

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        type = reader.ReadString();
        region = reader.ReadInt32();
        area = reader.ReadInt32();
        stage_string = reader.ReadInt32();
        control_type = reader.ReadString();
        run_index = reader.ReadInt32();
        need_base_fellow_id = reader.ReadInt32();
        need_base_fellow_level = reader.ReadInt32();
        need_stamina_item_id = reader.ReadInt32();
        need_stamina_count = reader.ReadInt32();
        first_reward_id = reader.ReadInt32();
        first_reward_value = reader.ReadInt32();
        reward_id_1 = reader.ReadInt32();
        reward_value_1 = reader.ReadInt32();
        reward_max_value = reader.ReadInt32();
        hawk_run_bg = reader.ReadString();
        hawk_run_balance = reader.ReadString();
        bgm_sound_id = reader.ReadInt32();
        speed_sound_id = reader.ReadInt32();
        magnet_effect_time = reader.ReadSingle();
        broken_tower_coin = reader.ReadInt32();
        speedup_time = reader.ReadSingle();
        velocity_default = reader.ReadSingle();
        velocity_speedup = reader.ReadSingle();
        init_hp = reader.ReadInt32();
        coin_box_value = reader.ReadInt32();
        reward_hp_coin = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string type;

    private int region;

    private int area;

    private int stage_string;

    private string control_type;

    private int run_index;

    private int need_base_fellow_id;

    private int need_base_fellow_level;

    private int need_stamina_item_id;

    private int need_stamina_count;

    private int first_reward_id;

    private int first_reward_value;

    private int reward_id_1;

    private int reward_value_1;

    private int reward_max_value;

    private string hawk_run_bg;

    private string hawk_run_balance;

    private int bgm_sound_id;

    private int speed_sound_id;

    private float magnet_effect_time;

    private int broken_tower_coin;

    private float speedup_time;

    private float velocity_default;

    private float velocity_speedup;

    private int init_hp;

    private int coin_box_value;

    private int reward_hp_coin;

    private List<int> list_reward_id;

    private List<int> list_reward_value;
}
