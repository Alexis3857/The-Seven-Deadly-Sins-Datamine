public class DBEventDiceQuestionRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int Type
    {
        get
        {
            return type;
        }
    }

    public int TextGroup
    {
        get
        {
            return text_group;
        }
    }

    public string Resource
    {
        get
        {
            return resource;
        }
    }

    public string HeadResource
    {
        get
        {
            return head_resource;
        }
    }

    public string BodyResource
    {
        get
        {
            return body_resource;
        }
    }

    public string QLocalId
    {
        get
        {
            return q_local_id.Localize();
        }
    }

    public string QAni
    {
        get
        {
            return q_ani;
        }
    }

    public string ALocalId1
    {
        get
        {
            return a_local_id_1.Localize();
        }
    }

    public string RLocalId11
    {
        get
        {
            return r_local_id_1_1.Localize();
        }
    }

    public string RnLocalId11
    {
        get
        {
            return rn_local_id_1_1.Localize();
        }
    }

    public string Ani11
    {
        get
        {
            return ani_1_1;
        }
    }

    public string RewardType11
    {
        get
        {
            return reward_type_1_1;
        }
    }

    public int Reward11
    {
        get
        {
            return reward_1_1;
        }
    }

    public int RewardCount11
    {
        get
        {
            return reward_count_1_1;
        }
    }

    public string RLocalId12
    {
        get
        {
            return r_local_id_1_2.Localize();
        }
    }

    public string RnLocalId12
    {
        get
        {
            return rn_local_id_1_2.Localize();
        }
    }

    public string Ani12
    {
        get
        {
            return ani_1_2;
        }
    }

    public string RewardType12
    {
        get
        {
            return reward_type_1_2;
        }
    }

    public int Reward12
    {
        get
        {
            return reward_1_2;
        }
    }

    public int RewardCount12
    {
        get
        {
            return reward_count_1_2;
        }
    }

    public string ALocalId2
    {
        get
        {
            return a_local_id_2.Localize();
        }
    }

    public string RLocalId21
    {
        get
        {
            return r_local_id_2_1.Localize();
        }
    }

    public string RnLocalId21
    {
        get
        {
            return rn_local_id_2_1.Localize();
        }
    }

    public string Ani21
    {
        get
        {
            return ani_2_1;
        }
    }

    public string RewardType21
    {
        get
        {
            return reward_type_2_1;
        }
    }

    public int Reward21
    {
        get
        {
            return reward_2_1;
        }
    }

    public int RewardCount21
    {
        get
        {
            return reward_count_2_1;
        }
    }

    public string RLocalId22
    {
        get
        {
            return r_local_id_2_2.Localize();
        }
    }

    public string RnLocalId22
    {
        get
        {
            return rn_local_id_2_2.Localize();
        }
    }

    public string Ani22
    {
        get
        {
            return ani_2_2;
        }
    }

    public string RewardType22
    {
        get
        {
            return reward_type_2_2;
        }
    }

    public int Reward22
    {
        get
        {
            return reward_2_2;
        }
    }

    public int RewardCount22
    {
        get
        {
            return reward_count_2_2;
        }
    }

    public string ALocalId3
    {
        get
        {
            return a_local_id_3.Localize();
        }
    }

    public string RLocalId31
    {
        get
        {
            return r_local_id_3_1.Localize();
        }
    }

    public string RnLocalId31
    {
        get
        {
            return rn_local_id_3_1.Localize();
        }
    }

    public string Ani31
    {
        get
        {
            return ani_3_1;
        }
    }

    public string RewardType31
    {
        get
        {
            return reward_type_3_1;
        }
    }

    public int Reward31
    {
        get
        {
            return reward_3_1;
        }
    }

    public int RewardCount31
    {
        get
        {
            return reward_count_3_1;
        }
    }

    public string RLocalId32
    {
        get
        {
            return r_local_id_3_2.Localize();
        }
    }

    public string RnLocalId32
    {
        get
        {
            return rn_local_id_3_2.Localize();
        }
    }

    public string Ani32
    {
        get
        {
            return ani_3_2;
        }
    }

    public string RewardType32
    {
        get
        {
            return reward_type_3_2;
        }
    }

    public int Reward32
    {
        get
        {
            return reward_3_2;
        }
    }

    public int RewardCount32
    {
        get
        {
            return reward_count_3_2;
        }
    }

    public List<string> ListALocalId
    {
        get
        {
            if (list_a_local_id == null)
            {
                list_a_local_id = new List<string>
                {
                    ALocalId1,
                    ALocalId2,
                    ALocalId3
                };
            }
            return list_a_local_id;
        }
    }

    public List<string> ListRLocalId1
    {
        get
        {
            if (list_r_local_id_1 == null)
            {
                list_r_local_id_1 = new List<string>
                {
                    RLocalId11,
                    RLocalId12
                };
            }
            return list_r_local_id_1;
        }
    }

    public List<string> ListRnLocalId1
    {
        get
        {
            if (list_rn_local_id_1 == null)
            {
                list_rn_local_id_1 = new List<string>
                {
                    RnLocalId11,
                    RnLocalId12
                };
            }
            return list_rn_local_id_1;
        }
    }

    public List<string> ListAni1
    {
        get
        {
            if (list_ani_1 == null)
            {
                list_ani_1 = new List<string>
                {
                    Ani11,
                    Ani12
                };
            }
            return list_ani_1;
        }
    }

    public List<string> ListRewardType1
    {
        get
        {
            if (list_reward_type_1 == null)
            {
                list_reward_type_1 = new List<string>
                {
                    RewardType11,
                    RewardType12
                };
            }
            return list_reward_type_1;
        }
    }

    public List<int> ListReward1
    {
        get
        {
            if (list_reward_1 == null)
            {
                list_reward_1 = new List<int>
                {
                    Reward11,
                    Reward12
                };
            }
            return list_reward_1;
        }
    }

    public List<int> ListRewardCount1
    {
        get
        {
            if (list_reward_count_1 == null)
            {
                list_reward_count_1 = new List<int>
                {
                    RewardCount11,
                    RewardCount12
                };
            }
            return list_reward_count_1;
        }
    }

    public List<string> ListRLocalId2
    {
        get
        {
            if (list_r_local_id_2 == null)
            {
                list_r_local_id_2 = new List<string>
                {
                    RLocalId21,
                    RLocalId22
                };
            }
            return list_r_local_id_2;
        }
    }

    public List<string> ListRnLocalId2
    {
        get
        {
            if (list_rn_local_id_2 == null)
            {
                list_rn_local_id_2 = new List<string>
                {
                    RnLocalId21,
                    RnLocalId22
                };
            }
            return list_rn_local_id_2;
        }
    }

    public List<string> ListAni2
    {
        get
        {
            if (list_ani_2 == null)
            {
                list_ani_2 = new List<string>
                {
                    Ani21,
                    Ani22
                };
            }
            return list_ani_2;
        }
    }

    public List<string> ListRewardType2
    {
        get
        {
            if (list_reward_type_2 == null)
            {
                list_reward_type_2 = new List<string>
                {
                    RewardType21,
                    RewardType22
                };
            }
            return list_reward_type_2;
        }
    }

    public List<int> ListReward2
    {
        get
        {
            if (list_reward_2 == null)
            {
                list_reward_2 = new List<int>
                {
                    Reward21,
                    Reward22
                };
            }
            return list_reward_2;
        }
    }

    public List<int> ListRewardCount2
    {
        get
        {
            if (list_reward_count_2 == null)
            {
                list_reward_count_2 = new List<int>
                {
                    RewardCount21,
                    RewardCount22
                };
            }
            return list_reward_count_2;
        }
    }

    public List<string> ListRLocalId3
    {
        get
        {
            if (list_r_local_id_3 == null)
            {
                list_r_local_id_3 = new List<string>
                {
                    RLocalId31,
                    RLocalId32
                };
            }
            return list_r_local_id_3;
        }
    }

    public List<string> ListRnLocalId3
    {
        get
        {
            if (list_rn_local_id_3 == null)
            {
                list_rn_local_id_3 = new List<string>
                {
                    RnLocalId31,
                    RnLocalId32
                };
            }
            return list_rn_local_id_3;
        }
    }

    public List<string> ListAni3
    {
        get
        {
            if (list_ani_3 == null)
            {
                list_ani_3 = new List<string>
                {
                    Ani31,
                    Ani32
                };
            }
            return list_ani_3;
        }
    }

    public List<string> ListRewardType3
    {
        get
        {
            if (list_reward_type_3 == null)
            {
                list_reward_type_3 = new List<string>
                {
                    RewardType31,
                    RewardType32
                };
            }
            return list_reward_type_3;
        }
    }

    public List<int> ListReward3
    {
        get
        {
            if (list_reward_3 == null)
            {
                list_reward_3 = new List<int>
                {
                    Reward31,
                    Reward32
                };
            }
            return list_reward_3;
        }
    }

    public List<int> ListRewardCount3
    {
        get
        {
            if (list_reward_count_3 == null)
            {
                list_reward_count_3 = new List<int>
                {
                    RewardCount31,
                    RewardCount32
                };
            }
            return list_reward_count_3;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        type = reader.ReadInt32();
        text_group = reader.ReadInt32();
        resource = reader.ReadString();
        head_resource = reader.ReadString();
        body_resource = reader.ReadString();
        q_local_id = reader.ReadInt32();
        q_ani = reader.ReadString();
        a_local_id_1 = reader.ReadInt32();
        r_local_id_1_1 = reader.ReadInt32();
        rn_local_id_1_1 = reader.ReadInt32();
        ani_1_1 = reader.ReadString();
        reward_type_1_1 = reader.ReadString();
        reward_1_1 = reader.ReadInt32();
        reward_count_1_1 = reader.ReadInt32();
        r_local_id_1_2 = reader.ReadInt32();
        rn_local_id_1_2 = reader.ReadInt32();
        ani_1_2 = reader.ReadString();
        reward_type_1_2 = reader.ReadString();
        reward_1_2 = reader.ReadInt32();
        reward_count_1_2 = reader.ReadInt32();
        a_local_id_2 = reader.ReadInt32();
        r_local_id_2_1 = reader.ReadInt32();
        rn_local_id_2_1 = reader.ReadInt32();
        ani_2_1 = reader.ReadString();
        reward_type_2_1 = reader.ReadString();
        reward_2_1 = reader.ReadInt32();
        reward_count_2_1 = reader.ReadInt32();
        r_local_id_2_2 = reader.ReadInt32();
        rn_local_id_2_2 = reader.ReadInt32();
        ani_2_2 = reader.ReadString();
        reward_type_2_2 = reader.ReadString();
        reward_2_2 = reader.ReadInt32();
        reward_count_2_2 = reader.ReadInt32();
        a_local_id_3 = reader.ReadInt32();
        r_local_id_3_1 = reader.ReadInt32();
        rn_local_id_3_1 = reader.ReadInt32();
        ani_3_1 = reader.ReadString();
        reward_type_3_1 = reader.ReadString();
        reward_3_1 = reader.ReadInt32();
        reward_count_3_1 = reader.ReadInt32();
        r_local_id_3_2 = reader.ReadInt32();
        rn_local_id_3_2 = reader.ReadInt32();
        ani_3_2 = reader.ReadString();
        reward_type_3_2 = reader.ReadString();
        reward_3_2 = reader.ReadInt32();
        reward_count_3_2 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int type;

    private int text_group;

    private string resource;

    private string head_resource;

    private string body_resource;

    private int q_local_id;

    private string q_ani;

    private int a_local_id_1;

    private int r_local_id_1_1;

    private int rn_local_id_1_1;

    private string ani_1_1;

    private string reward_type_1_1;

    private int reward_1_1;

    private int reward_count_1_1;

    private int r_local_id_1_2;

    private int rn_local_id_1_2;

    private string ani_1_2;

    private string reward_type_1_2;

    private int reward_1_2;

    private int reward_count_1_2;

    private int a_local_id_2;

    private int r_local_id_2_1;

    private int rn_local_id_2_1;

    private string ani_2_1;

    private string reward_type_2_1;

    private int reward_2_1;

    private int reward_count_2_1;

    private int r_local_id_2_2;

    private int rn_local_id_2_2;

    private string ani_2_2;

    private string reward_type_2_2;

    private int reward_2_2;

    private int reward_count_2_2;

    private int a_local_id_3;

    private int r_local_id_3_1;

    private int rn_local_id_3_1;

    private string ani_3_1;

    private string reward_type_3_1;

    private int reward_3_1;

    private int reward_count_3_1;

    private int r_local_id_3_2;

    private int rn_local_id_3_2;

    private string ani_3_2;

    private string reward_type_3_2;

    private int reward_3_2;

    private int reward_count_3_2;

    private List<string> list_a_local_id;

    private List<string> list_r_local_id_1;

    private List<string> list_rn_local_id_1;

    private List<string> list_ani_1;

    private List<string> list_reward_type_1;

    private List<int> list_reward_1;

    private List<int> list_reward_count_1;

    private List<string> list_r_local_id_2;

    private List<string> list_rn_local_id_2;

    private List<string> list_ani_2;

    private List<string> list_reward_type_2;

    private List<int> list_reward_2;

    private List<int> list_reward_count_2;

    private List<string> list_r_local_id_3;

    private List<string> list_rn_local_id_3;

    private List<string> list_ani_3;

    private List<string> list_reward_type_3;

    private List<int> list_reward_3;

    private List<int> list_reward_count_3;
}
