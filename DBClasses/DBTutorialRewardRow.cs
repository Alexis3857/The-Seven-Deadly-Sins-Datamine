public class DBTutorialRewardRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string TutorialName
    {
        get
        {
            return tutorial_name;
        }
    }

    public int TutorialGroup
    {
        get
        {
            return tutorial_group;
        }
    }

    public int StartPrefabId
    {
        get
        {
            return start_prefab_id;
        }
    }

    public int LinkQuest
    {
        get
        {
            return link_quest;
        }
    }

    public int SelectHeroId
    {
        get
        {
            return select_hero_id;
        }
    }

    public int ForceStartId
    {
        get
        {
            return force_start_id;
        }
    }

    public int TutorialResourceId1
    {
        get
        {
            return tutorial_resource_id_1;
        }
    }

    public int TutorialResourceCount1
    {
        get
        {
            return tutorial_resource_count_1;
        }
    }

    public int TutorialResourceId2
    {
        get
        {
            return tutorial_resource_id_2;
        }
    }

    public int TutorialResourceCount2
    {
        get
        {
            return tutorial_resource_count_2;
        }
    }

    public int TutorialResourceId3
    {
        get
        {
            return tutorial_resource_id_3;
        }
    }

    public int TutorialResourceCount3
    {
        get
        {
            return tutorial_resource_count_3;
        }
    }

    public int TutorialRewardId1
    {
        get
        {
            return tutorial_reward_id_1;
        }
    }

    public int TutorialRewardCount1
    {
        get
        {
            return tutorial_reward_count_1;
        }
    }

    public int TutorialRewardId2
    {
        get
        {
            return tutorial_reward_id_2;
        }
    }

    public int TutorialRewardCount2
    {
        get
        {
            return tutorial_reward_count_2;
        }
    }

    public int TutorialRewardId3
    {
        get
        {
            return tutorial_reward_id_3;
        }
    }

    public int TutorialRewardCount3
    {
        get
        {
            return tutorial_reward_count_3;
        }
    }

    public int TutorialRewardId4
    {
        get
        {
            return tutorial_reward_id_4;
        }
    }

    public int TutorialRewardCount4
    {
        get
        {
            return tutorial_reward_count_4;
        }
    }

    public List<int> ListTutorialResourceId
    {
        get
        {
            if (list_tutorial_resource_id == null)
            {
                list_tutorial_resource_id = new List<int>
                {
                    TutorialResourceId1,
                    TutorialResourceId2,
                    TutorialResourceId3
                };
            }
            return list_tutorial_resource_id;
        }
    }

    public List<int> ListTutorialResourceCount
    {
        get
        {
            if (list_tutorial_resource_count == null)
            {
                list_tutorial_resource_count = new List<int>
                {
                    TutorialResourceCount1,
                    TutorialResourceCount2,
                    TutorialResourceCount3
                };
            }
            return list_tutorial_resource_count;
        }
    }

    public List<int> ListTutorialRewardId
    {
        get
        {
            if (list_tutorial_reward_id == null)
            {
                list_tutorial_reward_id = new List<int>
                {
                    TutorialRewardId1,
                    TutorialRewardId2,
                    TutorialRewardId3,
                    TutorialRewardId4
                };
            }
            return list_tutorial_reward_id;
        }
    }

    public List<int> ListTutorialRewardCount
    {
        get
        {
            if (list_tutorial_reward_count == null)
            {
                list_tutorial_reward_count = new List<int>
                {
                    TutorialRewardCount1,
                    TutorialRewardCount2,
                    TutorialRewardCount3,
                    TutorialRewardCount4
                };
            }
            return list_tutorial_reward_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        tutorial_name = reader.ReadString();
        tutorial_group = reader.ReadInt32();
        start_prefab_id = reader.ReadInt32();
        link_quest = reader.ReadInt32();
        select_hero_id = reader.ReadInt32();
        force_start_id = reader.ReadInt32();
        tutorial_resource_id_1 = reader.ReadInt32();
        tutorial_resource_count_1 = reader.ReadInt32();
        tutorial_resource_id_2 = reader.ReadInt32();
        tutorial_resource_count_2 = reader.ReadInt32();
        tutorial_resource_id_3 = reader.ReadInt32();
        tutorial_resource_count_3 = reader.ReadInt32();
        tutorial_reward_id_1 = reader.ReadInt32();
        tutorial_reward_count_1 = reader.ReadInt32();
        tutorial_reward_id_2 = reader.ReadInt32();
        tutorial_reward_count_2 = reader.ReadInt32();
        tutorial_reward_id_3 = reader.ReadInt32();
        tutorial_reward_count_3 = reader.ReadInt32();
        tutorial_reward_id_4 = reader.ReadInt32();
        tutorial_reward_count_4 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string tutorial_name;

    private int tutorial_group;

    private int start_prefab_id;

    private int link_quest;

    private int select_hero_id;

    private int force_start_id;

    private int tutorial_resource_id_1;

    private int tutorial_resource_count_1;

    private int tutorial_resource_id_2;

    private int tutorial_resource_count_2;

    private int tutorial_resource_id_3;

    private int tutorial_resource_count_3;

    private int tutorial_reward_id_1;

    private int tutorial_reward_count_1;

    private int tutorial_reward_id_2;

    private int tutorial_reward_count_2;

    private int tutorial_reward_id_3;

    private int tutorial_reward_count_3;

    private int tutorial_reward_id_4;

    private int tutorial_reward_count_4;

    private List<int> list_tutorial_resource_id;

    private List<int> list_tutorial_resource_count;

    private List<int> list_tutorial_reward_id;

    private List<int> list_tutorial_reward_count;
}
