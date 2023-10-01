public class DBBasepointFellowRewardRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int BasepointId
    {
        get
        {
            return basepoint_id;
        }
    }

    public List<string> ListArrayContentsCheck
    {
        get
        {
            return list_array_contents_check;
        }
    }

    public int FellowLevel
    {
        get
        {
            return fellow_level;
        }
    }

    public int FellowExp
    {
        get
        {
            return fellow_exp;
        }
    }

    public string FellowString
    {
        get
        {
            return fellow_string.Localize();
        }
    }

    public int NpcId
    {
        get
        {
            return npc_id;
        }
    }

    public string TalkString
    {
        get
        {
            return talk_string.Localize();
        }
    }

    public string DonationTalkingString
    {
        get
        {
            return donation_talking_string.Localize();
        }
    }

    public string DonationTalking2String
    {
        get
        {
            return donation_talking2_string.Localize();
        }
    }

    public string DonationTalking3String
    {
        get
        {
            return donation_talking3_string.Localize();
        }
    }

    public int ExchangeAddRate
    {
        get
        {
            return exchange_add_rate;
        }
    }

    public int WorldFellowReward1
    {
        get
        {
            return world_fellow_reward_1;
        }
    }

    public int WorldFellowRewardCount1
    {
        get
        {
            return world_fellow_reward_count_1;
        }
    }

    public int WorldFellowReward2
    {
        get
        {
            return world_fellow_reward_2;
        }
    }

    public int WorldFellowRewardCount2
    {
        get
        {
            return world_fellow_reward_count_2;
        }
    }

    public int WorldFellowReward3
    {
        get
        {
            return world_fellow_reward_3;
        }
    }

    public int WorldFellowRewardCount3
    {
        get
        {
            return world_fellow_reward_count_3;
        }
    }

    public int WorldFellowReward4
    {
        get
        {
            return world_fellow_reward_4;
        }
    }

    public int WorldFellowRewardCount4
    {
        get
        {
            return world_fellow_reward_count_4;
        }
    }

    public int FellowReward1
    {
        get
        {
            return fellow_reward_1;
        }
    }

    public int FellowRewardCount1
    {
        get
        {
            return fellow_reward_count_1;
        }
    }

    public int FellowReward2
    {
        get
        {
            return fellow_reward_2;
        }
    }

    public int FellowRewardCount2
    {
        get
        {
            return fellow_reward_count_2;
        }
    }

    public int OverDonationCondition
    {
        get
        {
            return over_donation_condition;
        }
    }

    public int OverDonationPassiveId
    {
        get
        {
            return over_donation_passive_id;
        }
    }

    public List<int> ListWorldFellowReward
    {
        get
        {
            if (list_world_fellow_reward == null)
            {
                list_world_fellow_reward = new List<int>
                {
                    WorldFellowReward1,
                    WorldFellowReward2,
                    WorldFellowReward3,
                    WorldFellowReward4
                };
            }
            return list_world_fellow_reward;
        }
    }

    public List<int> ListWorldFellowRewardCount
    {
        get
        {
            if (list_world_fellow_reward_count == null)
            {
                list_world_fellow_reward_count = new List<int>
                {
                    WorldFellowRewardCount1,
                    WorldFellowRewardCount2,
                    WorldFellowRewardCount3,
                    WorldFellowRewardCount4
                };
            }
            return list_world_fellow_reward_count;
        }
    }

    public List<int> ListFellowReward
    {
        get
        {
            if (list_fellow_reward == null)
            {
                list_fellow_reward = new List<int>
                {
                    FellowReward1,
                    FellowReward2
                };
            }
            return list_fellow_reward;
        }
    }

    public List<int> ListFellowRewardCount
    {
        get
        {
            if (list_fellow_reward_count == null)
            {
                list_fellow_reward_count = new List<int>
                {
                    FellowRewardCount1,
                    FellowRewardCount2
                };
            }
            return list_fellow_reward_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        basepoint_id = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_contents_check = new List<string>();
        for (int i = 0; i < num; i++)
        {
            list_array_contents_check.Add(reader.ReadString());
        }
        fellow_level = reader.ReadInt32();
        fellow_exp = reader.ReadInt32();
        fellow_string = reader.ReadInt32();
        npc_id = reader.ReadInt32();
        talk_string = reader.ReadInt32();
        donation_talking_string = reader.ReadInt32();
        donation_talking2_string = reader.ReadInt32();
        donation_talking3_string = reader.ReadInt32();
        exchange_add_rate = reader.ReadInt32();
        world_fellow_reward_1 = reader.ReadInt32();
        world_fellow_reward_count_1 = reader.ReadInt32();
        world_fellow_reward_2 = reader.ReadInt32();
        world_fellow_reward_count_2 = reader.ReadInt32();
        world_fellow_reward_3 = reader.ReadInt32();
        world_fellow_reward_count_3 = reader.ReadInt32();
        world_fellow_reward_4 = reader.ReadInt32();
        world_fellow_reward_count_4 = reader.ReadInt32();
        fellow_reward_1 = reader.ReadInt32();
        fellow_reward_count_1 = reader.ReadInt32();
        fellow_reward_2 = reader.ReadInt32();
        fellow_reward_count_2 = reader.ReadInt32();
        over_donation_condition = reader.ReadInt32();
        over_donation_passive_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int basepoint_id;

    private List<string> list_array_contents_check;

    private int fellow_level;

    private int fellow_exp;

    private int fellow_string;

    private int npc_id;

    private int talk_string;

    private int donation_talking_string;

    private int donation_talking2_string;

    private int donation_talking3_string;

    private int exchange_add_rate;

    private int world_fellow_reward_1;

    private int world_fellow_reward_count_1;

    private int world_fellow_reward_2;

    private int world_fellow_reward_count_2;

    private int world_fellow_reward_3;

    private int world_fellow_reward_count_3;

    private int world_fellow_reward_4;

    private int world_fellow_reward_count_4;

    private int fellow_reward_1;

    private int fellow_reward_count_1;

    private int fellow_reward_2;

    private int fellow_reward_count_2;

    private int over_donation_condition;

    private int over_donation_passive_id;

    private List<int> list_world_fellow_reward;

    private List<int> list_world_fellow_reward_count;

    private List<int> list_fellow_reward;

    private List<int> list_fellow_reward_count;
}
