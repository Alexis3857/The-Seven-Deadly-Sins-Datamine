public class DBEventMissionChapterRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public int Region
    {
        get
        {
            return region;
        }
    }

    public int ChapterStartQuest
    {
        get
        {
            return chapter_start_quest;
        }
    }

    public List<int> ListArrayProgressGroup
    {
        get
        {
            return list_array_progress_group;
        }
    }

    public string ChapterIcon
    {
        get
        {
            return chapter_icon;
        }
    }

    public string MissionDesc
    {
        get
        {
            return mission_desc;
        }
    }

    public int RewardId1
    {
        get
        {
            return reward_id_1;
        }
    }

    public int RewardCount1
    {
        get
        {
            return reward_count_1;
        }
    }

    public int RewardId2
    {
        get
        {
            return reward_id_2;
        }
    }

    public int RewardCount2
    {
        get
        {
            return reward_count_2;
        }
    }

    public int RewardId3
    {
        get
        {
            return reward_id_3;
        }
    }

    public int RewardCount3
    {
        get
        {
            return reward_count_3;
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
                    RewardId1,
                    RewardId2,
                    RewardId3
                };
            }
            return list_reward_id;
        }
    }

    public List<int> ListRewardCount
    {
        get
        {
            if (list_reward_count == null)
            {
                list_reward_count = new List<int>
                {
                    RewardCount1,
                    RewardCount2,
                    RewardCount3
                };
            }
            return list_reward_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        region = reader.ReadInt32();
        chapter_start_quest = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_progress_group = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_progress_group.Add(reader.ReadInt32());
        }
        chapter_icon = reader.ReadString();
        mission_desc = reader.ReadString();
        reward_id_1 = reader.ReadInt32();
        reward_count_1 = reader.ReadInt32();
        reward_id_2 = reader.ReadInt32();
        reward_count_2 = reader.ReadInt32();
        reward_id_3 = reader.ReadInt32();
        reward_count_3 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int region;

    private int chapter_start_quest;

    private List<int> list_array_progress_group;

    private string chapter_icon;

    private string mission_desc;

    private int reward_id_1;

    private int reward_count_1;

    private int reward_id_2;

    private int reward_count_2;

    private int reward_id_3;

    private int reward_count_3;

    private List<int> list_reward_id;

    private List<int> list_reward_count;
}
