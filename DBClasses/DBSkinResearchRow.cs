public class DBSkinResearchRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int RoleType1
    {
        get
        {
            return role_type_1;
        }
    }

    public int ResearchRank
    {
        get
        {
            return research_rank;
        }
    }

    public int PassiveSkillId1
    {
        get
        {
            return passive_skill_id_1;
        }
    }

    public int Value1
    {
        get
        {
            return value_1;
        }
    }

    public int PassiveSkillId2
    {
        get
        {
            return passive_skill_id_2;
        }
    }

    public int Value2
    {
        get
        {
            return value_2;
        }
    }

    public int ResourceType
    {
        get
        {
            return resource_type;
        }
    }

    public int HeroCoinCount
    {
        get
        {
            return hero_coin_count;
        }
    }

    public int ResearchResourceType1
    {
        get
        {
            return research_resource_type_1;
        }
    }

    public int ResearchResourceCount1
    {
        get
        {
            return research_resource_count_1;
        }
    }

    public int ResearchResourceType2
    {
        get
        {
            return research_resource_type_2;
        }
    }

    public int ResearchResourceCount2
    {
        get
        {
            return research_resource_count_2;
        }
    }

    public int ResearchResourceType3
    {
        get
        {
            return research_resource_type_3;
        }
    }

    public int ResearchResourceCount3
    {
        get
        {
            return research_resource_count_3;
        }
    }

    public int ResearchResourceType4
    {
        get
        {
            return research_resource_type_4;
        }
    }

    public int ResearchResourceCount4
    {
        get
        {
            return research_resource_count_4;
        }
    }

    public int ResearchResourceType5
    {
        get
        {
            return research_resource_type_5;
        }
    }

    public int ResearchResourceCount5
    {
        get
        {
            return research_resource_count_5;
        }
    }

    public int ResearchResourceType6
    {
        get
        {
            return research_resource_type_6;
        }
    }

    public int ResearchResourceCount6
    {
        get
        {
            return research_resource_count_6;
        }
    }

    public int ResearchNeedGold
    {
        get
        {
            return research_need_gold;
        }
    }

    public List<int> ListRoleType
    {
        get
        {
            if (list_role_type == null)
            {
                list_role_type = new List<int>
                {
                    RoleType1
                };
            }
            return list_role_type;
        }
    }

    public List<int> ListPassiveSkillId
    {
        get
        {
            if (list_passive_skill_id == null)
            {
                list_passive_skill_id = new List<int>
                {
                    PassiveSkillId1,
                    PassiveSkillId2
                };
            }
            return list_passive_skill_id;
        }
    }

    public List<int> ListValue
    {
        get
        {
            if (list_value == null)
            {
                list_value = new List<int>
                {
                    Value1,
                    Value2
                };
            }
            return list_value;
        }
    }

    public List<int> ListResearchResourceType
    {
        get
        {
            if (list_research_resource_type == null)
            {
                list_research_resource_type = new List<int>
                {
                    ResearchResourceType1,
                    ResearchResourceType2,
                    ResearchResourceType3,
                    ResearchResourceType4,
                    ResearchResourceType5,
                    ResearchResourceType6
                };
            }
            return list_research_resource_type;
        }
    }

    public List<int> ListResearchResourceCount
    {
        get
        {
            if (list_research_resource_count == null)
            {
                list_research_resource_count = new List<int>
                {
                    ResearchResourceCount1,
                    ResearchResourceCount2,
                    ResearchResourceCount3,
                    ResearchResourceCount4,
                    ResearchResourceCount5,
                    ResearchResourceCount6
                };
            }
            return list_research_resource_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        role_type_1 = reader.ReadInt32();
        research_rank = reader.ReadInt32();
        passive_skill_id_1 = reader.ReadInt32();
        value_1 = reader.ReadInt32();
        passive_skill_id_2 = reader.ReadInt32();
        value_2 = reader.ReadInt32();
        resource_type = reader.ReadInt32();
        hero_coin_count = reader.ReadInt32();
        research_resource_type_1 = reader.ReadInt32();
        research_resource_count_1 = reader.ReadInt32();
        research_resource_type_2 = reader.ReadInt32();
        research_resource_count_2 = reader.ReadInt32();
        research_resource_type_3 = reader.ReadInt32();
        research_resource_count_3 = reader.ReadInt32();
        research_resource_type_4 = reader.ReadInt32();
        research_resource_count_4 = reader.ReadInt32();
        research_resource_type_5 = reader.ReadInt32();
        research_resource_count_5 = reader.ReadInt32();
        research_resource_type_6 = reader.ReadInt32();
        research_resource_count_6 = reader.ReadInt32();
        research_need_gold = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int role_type_1;

    private int research_rank;

    private int passive_skill_id_1;

    private int value_1;

    private int passive_skill_id_2;

    private int value_2;

    private int resource_type;

    private int hero_coin_count;

    private int research_resource_type_1;

    private int research_resource_count_1;

    private int research_resource_type_2;

    private int research_resource_count_2;

    private int research_resource_type_3;

    private int research_resource_count_3;

    private int research_resource_type_4;

    private int research_resource_count_4;

    private int research_resource_type_5;

    private int research_resource_count_5;

    private int research_resource_type_6;

    private int research_resource_count_6;

    private int research_need_gold;

    private List<int> list_role_type;

    private List<int> list_passive_skill_id;

    private List<int> list_value;

    private List<int> list_research_resource_type;

    private List<int> list_research_resource_count;
}
