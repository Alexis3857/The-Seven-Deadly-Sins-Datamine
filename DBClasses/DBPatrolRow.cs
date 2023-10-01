public class DBPatrolRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EventCheck
    {
        get
        {
            return event_check;
        }
    }

    public int PatrolGroupId
    {
        get
        {
            return patrol_group_id;
        }
    }

    public int PatrolGroupSubId
    {
        get
        {
            return patrol_group_sub_id;
        }
    }

    public string PatrolName
    {
        get
        {
            return patrol_name.Localize();
        }
    }

    public string PatrolOpenTime
    {
        get
        {
            return patrol_open_time;
        }
    }

    public int PatrolOpenQuestId
    {
        get
        {
            return patrol_open_quest_id;
        }
    }

    public int NeedHeroRating
    {
        get
        {
            return need_hero_rating;
        }
    }

    public int NeedHeroRatingCount
    {
        get
        {
            return need_hero_rating_count;
        }
    }

    public int NeedHeroTeampower
    {
        get
        {
            return need_hero_teampower;
        }
    }

    public int CompleteTime
    {
        get
        {
            return complete_time;
        }
    }

    public int RewardItemId1
    {
        get
        {
            return reward_item_id_1;
        }
    }

    public int RewardItemValue1
    {
        get
        {
            return reward_item_value_1;
        }
    }

    public int RewardItemValueEvent1
    {
        get
        {
            return reward_item_value_event_1;
        }
    }

    public int RewardItemId2
    {
        get
        {
            return reward_item_id_2;
        }
    }

    public int RewardItemValue2
    {
        get
        {
            return reward_item_value_2;
        }
    }

    public int RewardItemValueEvent2
    {
        get
        {
            return reward_item_value_event_2;
        }
    }

    public int RewardItemId3
    {
        get
        {
            return reward_item_id_3;
        }
    }

    public int RewardItemValue3
    {
        get
        {
            return reward_item_value_3;
        }
    }

    public int RewardItemValueEvent3
    {
        get
        {
            return reward_item_value_event_3;
        }
    }

    public int RewardItemId4
    {
        get
        {
            return reward_item_id_4;
        }
    }

    public int RewardItemValue4
    {
        get
        {
            return reward_item_value_4;
        }
    }

    public int RewardItemValueEvent4
    {
        get
        {
            return reward_item_value_event_4;
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

    public List<int> ListRewardItemValue
    {
        get
        {
            if (list_reward_item_value == null)
            {
                list_reward_item_value = new List<int>
                {
                    RewardItemValue1,
                    RewardItemValue2,
                    RewardItemValue3,
                    RewardItemValue4
                };
            }
            return list_reward_item_value;
        }
    }

    public List<int> LiistRewardItemValueEvent
    {
        get
        {
            if (list_reward_item_value_event == null)
            {
                list_reward_item_value_event = new List<int>
                {
                    RewardItemValueEvent1,
                    RewardItemValueEvent2,
                    RewardItemValueEvent3,
                    RewardItemValueEvent4
                };
            }
            return list_reward_item_value_event;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_check = reader.ReadInt32();
        patrol_group_id = reader.ReadInt32();
        patrol_group_sub_id = reader.ReadInt32();
        patrol_name = reader.ReadInt32();
        patrol_open_time = reader.ReadString();
        patrol_open_quest_id = reader.ReadInt32();
        need_hero_rating = reader.ReadInt32();
        need_hero_rating_count = reader.ReadInt32();
        need_hero_teampower = reader.ReadInt32();
        complete_time = reader.ReadInt32();
        reward_item_id_1 = reader.ReadInt32();
        reward_item_value_1 = reader.ReadInt32();
        reward_item_value_event_1 = reader.ReadInt32();
        reward_item_id_2 = reader.ReadInt32();
        reward_item_value_2 = reader.ReadInt32();
        reward_item_value_event_2 = reader.ReadInt32();
        reward_item_id_3 = reader.ReadInt32();
        reward_item_value_3 = reader.ReadInt32();
        reward_item_value_event_3 = reader.ReadInt32();
        reward_item_id_4 = reader.ReadInt32();
        reward_item_value_4 = reader.ReadInt32();
        reward_item_value_event_4 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_check;

    private int patrol_group_id;

    private int patrol_group_sub_id;

    private int patrol_name;

    private string patrol_open_time;

    private int patrol_open_quest_id;

    private int need_hero_rating;

    private int need_hero_rating_count;

    private int need_hero_teampower;

    private int complete_time;

    private int reward_item_id_1;

    private int reward_item_value_1;

    private int reward_item_value_event_1;

    private int reward_item_id_2;

    private int reward_item_value_2;

    private int reward_item_value_event_2;

    private int reward_item_id_3;

    private int reward_item_value_3;

    private int reward_item_value_event_3;

    private int reward_item_id_4;

    private int reward_item_value_4;

    private int reward_item_value_event_4;

    private List<int> list_reward_item_id;

    private List<int> list_reward_item_value;

    private List<int> list_reward_item_value_event;
}
