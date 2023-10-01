public class DBEventMonthlySettingRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string EventStartDate
    {
        get
        {
            return event_start_date;
        }
    }

    public string EventLimitedDate
    {
        get
        {
            return event_limited_date;
        }
    }

    public string EventTitle
    {
        get
        {
            return event_title.Localize();
        }
    }

    public string EventIconInfo
    {
        get
        {
            return event_icon_info;
        }
    }

    public int StorySet
    {
        get
        {
            return story_set;
        }
    }

    public int StoryId1
    {
        get
        {
            return story_id_1;
        }
    }

    public int StoryId2
    {
        get
        {
            return story_id_2;
        }
    }

    public int StoryId3
    {
        get
        {
            return story_id_3;
        }
    }

    public int StoryId4
    {
        get
        {
            return story_id_4;
        }
    }

    public int StoryId5
    {
        get
        {
            return story_id_5;
        }
    }

    public int CountRewardSet
    {
        get
        {
            return count_reward_set;
        }
    }

    public int CountRewardNeedPoint1
    {
        get
        {
            return count_reward_need_point_1;
        }
    }

    public int CountRewardId1
    {
        get
        {
            return count_reward_id_1;
        }
    }

    public int CountRewardValue1
    {
        get
        {
            return count_reward_value_1;
        }
    }

    public int CountRewardNeedPoint2
    {
        get
        {
            return count_reward_need_point_2;
        }
    }

    public int CountRewardId2
    {
        get
        {
            return count_reward_id_2;
        }
    }

    public int CountRewardValue2
    {
        get
        {
            return count_reward_value_2;
        }
    }

    public int CountRewardNeedPoint3
    {
        get
        {
            return count_reward_need_point_3;
        }
    }

    public int CountRewardId3
    {
        get
        {
            return count_reward_id_3;
        }
    }

    public int CountRewardValue3
    {
        get
        {
            return count_reward_value_3;
        }
    }

    public int CountRewardNeedPoint4
    {
        get
        {
            return count_reward_need_point_4;
        }
    }

    public int CountRewardId4
    {
        get
        {
            return count_reward_id_4;
        }
    }

    public int CountRewardValue4
    {
        get
        {
            return count_reward_value_4;
        }
    }

    public int CountRewardNeedPoint5
    {
        get
        {
            return count_reward_need_point_5;
        }
    }

    public int CountRewardId5
    {
        get
        {
            return count_reward_id_5;
        }
    }

    public int CountRewardValue5
    {
        get
        {
            return count_reward_value_5;
        }
    }

    public List<int> ListStoryId
    {
        get
        {
            if (list_story_id == null)
            {
                list_story_id = new List<int>
                {
                    StoryId1,
                    StoryId2,
                    StoryId3,
                    StoryId4,
                    StoryId5
                };
            }
            return list_story_id;
        }
    }

    public List<int> ListCountRewardNeedPoint
    {
        get
        {
            if (list_count_reward_need_point == null)
            {
                list_count_reward_need_point = new List<int>
                {
                    CountRewardNeedPoint1,
                    CountRewardNeedPoint2,
                    CountRewardNeedPoint3,
                    CountRewardNeedPoint4,
                    CountRewardNeedPoint5
                };
            }
            return list_count_reward_need_point;
        }
    }

    public List<int> ListCountRewardId
    {
        get
        {
            if (list_count_reward_id == null)
            {
                list_count_reward_id = new List<int>
                {
                    CountRewardId1,
                    CountRewardId2,
                    CountRewardId3,
                    CountRewardId4,
                    CountRewardId5
                };
            }
            return list_count_reward_id;
        }
    }

    public List<int> ListCountRewardValue
    {
        get
        {
            if (list_count_reward_value == null)
            {
                list_count_reward_value = new List<int>
                {
                    CountRewardValue1,
                    CountRewardValue2,
                    CountRewardValue3,
                    CountRewardValue4,
                    CountRewardValue5
                };
            }
            return list_count_reward_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_start_date = reader.ReadString();
        event_limited_date = reader.ReadString();
        event_title = reader.ReadInt32();
        event_icon_info = reader.ReadString();
        story_set = reader.ReadInt32();
        story_id_1 = reader.ReadInt32();
        story_id_2 = reader.ReadInt32();
        story_id_3 = reader.ReadInt32();
        story_id_4 = reader.ReadInt32();
        story_id_5 = reader.ReadInt32();
        count_reward_set = reader.ReadInt32();
        count_reward_need_point_1 = reader.ReadInt32();
        count_reward_id_1 = reader.ReadInt32();
        count_reward_value_1 = reader.ReadInt32();
        count_reward_need_point_2 = reader.ReadInt32();
        count_reward_id_2 = reader.ReadInt32();
        count_reward_value_2 = reader.ReadInt32();
        count_reward_need_point_3 = reader.ReadInt32();
        count_reward_id_3 = reader.ReadInt32();
        count_reward_value_3 = reader.ReadInt32();
        count_reward_need_point_4 = reader.ReadInt32();
        count_reward_id_4 = reader.ReadInt32();
        count_reward_value_4 = reader.ReadInt32();
        count_reward_need_point_5 = reader.ReadInt32();
        count_reward_id_5 = reader.ReadInt32();
        count_reward_value_5 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string event_start_date;

    private string event_limited_date;

    private int event_title;

    private string event_icon_info;

    private int story_set;

    private int story_id_1;

    private int story_id_2;

    private int story_id_3;

    private int story_id_4;

    private int story_id_5;

    private int count_reward_set;

    private int count_reward_need_point_1;

    private int count_reward_id_1;

    private int count_reward_value_1;

    private int count_reward_need_point_2;

    private int count_reward_id_2;

    private int count_reward_value_2;

    private int count_reward_need_point_3;

    private int count_reward_id_3;

    private int count_reward_value_3;

    private int count_reward_need_point_4;

    private int count_reward_id_4;

    private int count_reward_value_4;

    private int count_reward_need_point_5;

    private int count_reward_id_5;

    private int count_reward_value_5;

    private List<int> list_story_id;

    private List<int> list_count_reward_need_point;

    private List<int> list_count_reward_id;

    private List<int> list_count_reward_value;
}
