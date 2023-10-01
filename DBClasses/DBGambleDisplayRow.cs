public class DBGambleDisplayRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GambleType
    {
        get
        {
            return gamble_type;
        }
    }

    public int GambleLabel
    {
        get
        {
            return gamble_label;
        }
    }

    public int GamblePickup
    {
        get
        {
            return gamble_pickup;
        }
    }

    public int ProbabilityCheck
    {
        get
        {
            return probability_check;
        }
    }

    public float Probability
    {
        get
        {
            return probability;
        }
    }

    public int GambleControl
    {
        get
        {
            return gamble_control;
        }
    }

    public int GambleGroup
    {
        get
        {
            return gamble_group;
        }
    }

    public int GachaBonusRewardGroup
    {
        get
        {
            return gacha_bonus_reward_group;
        }
    }

    public int GambleBackground
    {
        get
        {
            return gamble_background;
        }
    }

    public List<int> ListArrayPickupSkinId
    {
        get
        {
            return list_array_pickup_skin_id;
        }
    }

    public int GambleLimitCount
    {
        get
        {
            return gamble_limit_count;
        }
    }

    public int FailBonusCheck
    {
        get
        {
            return fail_bonus_check;
        }
    }

    public int HeroGachaFailCount
    {
        get
        {
            return hero_gacha_fail_count;
        }
    }

    public int GachaBonusCountReset
    {
        get
        {
            return gacha_bonus_count_reset;
        }
    }

    public int HeroGachaFailGroup
    {
        get
        {
            return hero_gacha_fail_group;
        }
    }

    public int GambleCount1
    {
        get
        {
            return gamble_count_1;
        }
    }

    public int GambleMoneyId1
    {
        get
        {
            return gamble_money_id_1;
        }
    }

    public int GambleMoneyCount1
    {
        get
        {
            return gamble_money_count_1;
        }
    }

    public int GambleRewardId1
    {
        get
        {
            return gamble_reward_id_1;
        }
    }

    public int GambleRewardIdCount1
    {
        get
        {
            return gamble_reward_id_count_1;
        }
    }

    public int GambleMileage1
    {
        get
        {
            return gamble_mileage_1;
        }
    }

    public int GambleCount2
    {
        get
        {
            return gamble_count_2;
        }
    }

    public int GambleMoneyId2
    {
        get
        {
            return gamble_money_id_2;
        }
    }

    public int GambleMoneyCount2
    {
        get
        {
            return gamble_money_count_2;
        }
    }

    public int GambleRewardId2
    {
        get
        {
            return gamble_reward_id_2;
        }
    }

    public int GambleRewardIdCount2
    {
        get
        {
            return gamble_reward_id_count_2;
        }
    }

    public int GambleMileage2
    {
        get
        {
            return gamble_mileage_2;
        }
    }

    public int GambleCount3
    {
        get
        {
            return gamble_count_3;
        }
    }

    public int GambleMoneyId3
    {
        get
        {
            return gamble_money_id_3;
        }
    }

    public int GambleMoneyCount3
    {
        get
        {
            return gamble_money_count_3;
        }
    }

    public int GambleRewardId3
    {
        get
        {
            return gamble_reward_id_3;
        }
    }

    public int GambleRewardIdCount3
    {
        get
        {
            return gamble_reward_id_count_3;
        }
    }

    public int GambleMileage3
    {
        get
        {
            return gamble_mileage_3;
        }
    }

    public int GambleCount4
    {
        get
        {
            return gamble_count_4;
        }
    }

    public int GambleMoneyId4
    {
        get
        {
            return gamble_money_id_4;
        }
    }

    public int GambleMoneyCount4
    {
        get
        {
            return gamble_money_count_4;
        }
    }

    public int GambleRewardId4
    {
        get
        {
            return gamble_reward_id_4;
        }
    }

    public int GambleRewardIdCount4
    {
        get
        {
            return gamble_reward_id_count_4;
        }
    }

    public int GambleMileage4
    {
        get
        {
            return gamble_mileage_4;
        }
    }

    public string GambleBGName
    {
        get
        {
            return gamble_BG_name;
        }
    }

    public string GambleMBannerName
    {
        get
        {
            return gamble_m_banner_name;
        }
    }

    public string GambleDesc
    {
        get
        {
            return gamble_desc.Localize();
        }
    }

    public string GambleProbabilityUrlDev
    {
        get
        {
            return gamble_probability_url_dev;
        }
    }

    public string GambleProbabilityUrlReal
    {
        get
        {
            return gamble_probability_url_real;
        }
    }

    public string GambleInformationDetail
    {
        get
        {
            return gamble_information_detail.Localize();
        }
    }

    public byte GambleInformationDetailOnoff
    {
        get
        {
            return gamble_information_detail_onoff;
        }
    }

    public int DailyFreeChance
    {
        get
        {
            return daily_free_chance;
        }
    }

    public int FreeChance
    {
        get
        {
            return free_chance;
        }
    }

    public int AccountRunningTime
    {
        get
        {
            return account_running_time;
        }
    }

    public string LobbyDisplayIcon
    {
        get
        {
            return lobby_display_icon;
        }
    }

    public List<int> ListGambleCount
    {
        get
        {
            if (list_gamble_count == null)
            {
                list_gamble_count = new List<int>
                {
                    GambleCount1,
                    GambleCount2,
                    GambleCount3,
                    GambleCount4
                };
            }
            return list_gamble_count;
        }
    }

    public List<int> ListGambleMoneyId
    {
        get
        {
            if (list_gamble_money_id == null)
            {
                list_gamble_money_id = new List<int>
                {
                    GambleMoneyId1,
                    GambleMoneyId2,
                    GambleMoneyId3,
                    GambleMoneyId4
                };
            }
            return list_gamble_money_id;
        }
    }

    public List<int> ListGambleMoneyCount
    {
        get
        {
            if (list_gamble_money_count == null)
            {
                list_gamble_money_count = new List<int>
                {
                    GambleMoneyCount1,
                    GambleMoneyCount2,
                    GambleMoneyCount3,
                    GambleMoneyCount4
                };
            }
            return list_gamble_money_count;
        }
    }

    public List<int> ListGambleRewardId
    {
        get
        {
            if (list_gamble_reward_id == null)
            {
                list_gamble_reward_id = new List<int>
                {
                    GambleRewardId1,
                    GambleRewardId2,
                    GambleRewardId3,
                    GambleRewardId4
                };
            }
            return list_gamble_reward_id;

        }
    }

    public List<int> ListGambleRewardIdCount
    {
        get
        {
            if (list_gamble_reward_id_count == null)
            {
                list_gamble_reward_id_count = new List<int>
                {
                    GambleRewardIdCount1,
                    GambleRewardIdCount2,
                    GambleRewardIdCount3,
                    GambleRewardIdCount4
                };
            }
            return list_gamble_reward_id_count;

        }
    }

    public List<int> ListGambleMileage
    {
        get
        {
            if (list_gamble_mileage == null)
            {
                list_gamble_mileage = new List<int>
                {
                    GambleMileage1,
                    GambleMileage2,
                    GambleMileage3,
                    GambleMileage4
                };
            }
            return list_gamble_mileage;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        gamble_type = reader.ReadInt32();
        gamble_label = reader.ReadInt32();
        gamble_pickup = reader.ReadInt32();
        probability_check = reader.ReadInt32();
        probability = reader.ReadSingle();
        gamble_control = reader.ReadInt32();
        gamble_group = reader.ReadInt32();
        gacha_bonus_reward_group = reader.ReadInt32();
        gamble_background = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_pickup_skin_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_pickup_skin_id.Add(reader.ReadInt32());
        }
        gamble_limit_count = reader.ReadInt32();
        fail_bonus_check = reader.ReadInt32();
        hero_gacha_fail_count = reader.ReadInt32();
        gacha_bonus_count_reset = reader.ReadInt32();
        hero_gacha_fail_group = reader.ReadInt32();
        gamble_count_1 = reader.ReadInt32();
        gamble_money_id_1 = reader.ReadInt32();
        gamble_money_count_1 = reader.ReadInt32();
        gamble_reward_id_1 = reader.ReadInt32();
        gamble_reward_id_count_1 = reader.ReadInt32();
        gamble_mileage_1 = reader.ReadInt32();
        gamble_count_2 = reader.ReadInt32();
        gamble_money_id_2 = reader.ReadInt32();
        gamble_money_count_2 = reader.ReadInt32();
        gamble_reward_id_2 = reader.ReadInt32();
        gamble_reward_id_count_2 = reader.ReadInt32();
        gamble_mileage_2 = reader.ReadInt32();
        gamble_count_3 = reader.ReadInt32();
        gamble_money_id_3 = reader.ReadInt32();
        gamble_money_count_3 = reader.ReadInt32();
        gamble_reward_id_3 = reader.ReadInt32();
        gamble_reward_id_count_3 = reader.ReadInt32();
        gamble_mileage_3 = reader.ReadInt32();
        gamble_count_4 = reader.ReadInt32();
        gamble_money_id_4 = reader.ReadInt32();
        gamble_money_count_4 = reader.ReadInt32();
        gamble_reward_id_4 = reader.ReadInt32();
        gamble_reward_id_count_4 = reader.ReadInt32();
        gamble_mileage_4 = reader.ReadInt32();
        gamble_BG_name = reader.ReadString();
        gamble_m_banner_name = reader.ReadString();
        gamble_desc = reader.ReadInt32();
        gamble_probability_url_dev = reader.ReadString();
        gamble_probability_url_real = reader.ReadString();
        gamble_information_detail = reader.ReadInt32();
        gamble_information_detail_onoff = reader.ReadByte();
        daily_free_chance = reader.ReadInt32();
        free_chance = reader.ReadInt32();
        account_running_time = reader.ReadInt32();
        lobby_display_icon = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int gamble_type;

    private int gamble_label;

    private int gamble_pickup;

    private int probability_check;

    private float probability;

    private int gamble_control;

    private int gamble_group;

    private int gacha_bonus_reward_group;

    private int gamble_background;

    private List<int> list_array_pickup_skin_id;

    private int gamble_limit_count;

    private int fail_bonus_check;

    private int hero_gacha_fail_count;

    private int gacha_bonus_count_reset;

    private int hero_gacha_fail_group;

    private int gamble_count_1;

    private int gamble_money_id_1;

    private int gamble_money_count_1;

    private int gamble_reward_id_1;

    private int gamble_reward_id_count_1;

    private int gamble_mileage_1;

    private int gamble_count_2;

    private int gamble_money_id_2;

    private int gamble_money_count_2;

    private int gamble_reward_id_2;

    private int gamble_reward_id_count_2;

    private int gamble_mileage_2;

    private int gamble_count_3;

    private int gamble_money_id_3;

    private int gamble_money_count_3;

    private int gamble_reward_id_3;

    private int gamble_reward_id_count_3;

    private int gamble_mileage_3;

    private int gamble_count_4;

    private int gamble_money_id_4;

    private int gamble_money_count_4;

    private int gamble_reward_id_4;

    private int gamble_reward_id_count_4;

    private int gamble_mileage_4;

    private string gamble_BG_name;

    private string gamble_m_banner_name;

    private int gamble_desc;

    private string gamble_probability_url_dev;

    private string gamble_probability_url_real;

    private int gamble_information_detail;

    private byte gamble_information_detail_onoff;

    private int daily_free_chance;

    private int free_chance;

    private int account_running_time;

    private string lobby_display_icon;

    private List<int> list_gamble_count;

    private List<int> list_gamble_money_id;

    private List<int> list_gamble_money_count;

    private List<int> list_gamble_reward_id;

    private List<int> list_gamble_reward_id_count;

    private List<int> list_gamble_mileage;
}
