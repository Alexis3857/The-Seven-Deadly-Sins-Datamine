public class DBEventSetupRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EventType
    {
        get
        {
            return event_type;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public int OpenTime1
    {
        get
        {
            return open_time_1;
        }
    }

    public int CloseTime1
    {
        get
        {
            return close_time_1;
        }
    }

    public int OpenTime2
    {
        get
        {
            return open_time_2;
        }
    }

    public int CloseTime2
    {
        get
        {
            return close_time_2;
        }
    }

    public int OpenTime3
    {
        get
        {
            return open_time_3;
        }
    }

    public int CloseTime3
    {
        get
        {
            return close_time_3;
        }
    }

    public int HeroCheck1
    {
        get
        {
            return hero_check_1;
        }
    }

    public int HeroCheck2
    {
        get
        {
            return hero_check_2;
        }
    }

    public int HeroCheck3
    {
        get
        {
            return hero_check_3;
        }
    }

    public int UserRank
    {
        get
        {
            return user_rank;
        }
    }

    public int HeroGrade
    {
        get
        {
            return hero_grade;
        }
    }

    public int HeroGradeValue
    {
        get
        {
            return hero_grade_value;
        }
    }

    public int OpenQuestId
    {
        get
        {
            return open_quest_id;
        }
    }

    public int NeedMainStageId
    {
        get
        {
            return need_main_stage_id;
        }
    }

    public string RankOpenAni
    {
        get
        {
            return rank_open_ani;
        }
    }

    public List<int> ListOpenTime
    {
        get
        {
            if (list_open_time == null)
            {
                list_open_time = new List<int>
                {
                    OpenTime1,
                    OpenTime2,
                    OpenTime3
                };
            }
            return list_open_time;
        }
    }

    public List<int> ListCloseTime
    {
        get
        {
            if (list_close_time == null)
            {
                list_close_time = new List<int>
                {
                    CloseTime1,
                    CloseTime2,
                    CloseTime3
                };
            }
            return list_close_time;
        }
    }

    public List<int> ListHeroCheck
    {
        get
        {
            if (list_hero_check == null)
            {
                list_hero_check = new List<int>
                {
                    HeroCheck1,
                    HeroCheck2,
                    HeroCheck3
                };
            }
            return list_hero_check;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_type = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        open_time_1 = reader.ReadInt32();
        close_time_1 = reader.ReadInt32();
        open_time_2 = reader.ReadInt32();
        close_time_2 = reader.ReadInt32();
        open_time_3 = reader.ReadInt32();
        close_time_3 = reader.ReadInt32();
        hero_check_1 = reader.ReadInt32();
        hero_check_2 = reader.ReadInt32();
        hero_check_3 = reader.ReadInt32();
        user_rank = reader.ReadInt32();
        hero_grade = reader.ReadInt32();
        hero_grade_value = reader.ReadInt32();
        open_quest_id = reader.ReadInt32();
        need_main_stage_id = reader.ReadInt32();
        rank_open_ani = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_type;

    private int event_sub_index;

    private int open_time_1;

    private int close_time_1;

    private int open_time_2;

    private int close_time_2;

    private int open_time_3;

    private int close_time_3;

    private int hero_check_1;

    private int hero_check_2;

    private int hero_check_3;

    private int user_rank;

    private int hero_grade;

    private int hero_grade_value;

    private int open_quest_id;

    private int need_main_stage_id;

    private string rank_open_ani;

    private List<int> list_open_time;

    private List<int> list_close_time;

    private List<int> list_hero_check;
}
