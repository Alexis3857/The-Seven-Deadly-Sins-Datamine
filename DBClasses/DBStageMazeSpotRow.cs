public class DBStageMazeSpotRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int SeasonGroupId
    {
        get
        {
            return season_group_id;
        }
    }

    public int FloorGroupId
    {
        get
        {
            return floor_group_id;
        }
    }

    public int SpotGroupId
    {
        get
        {
            return spot_group_id;
        }
    }

    public int SpotId
    {
        get
        {
            return spot_id;
        }
    }

    public int RandomSpotCheck
    {
        get
        {
            return random_spot_check;
        }
    }

    public string SpotType
    {
        get
        {
            return spot_type;
        }
    }

    public int NeedHeroGroup
    {
        get
        {
            return need_hero_group;
        }
    }

    public int HeroCount
    {
        get
        {
            return hero_count;
        }
    }

    public int RandomHeroCount
    {
        get
        {
            return random_hero_count;
        }
    }

    public List<int> ListArrayHealPer
    {
        get
        {
            return list_array_heal_per;
        }
    }

    public List<int> ListArrayLevelPoint
    {
        get
        {
            return list_array_level_point;
        }
    }

    public List<int> ListArraySpecialPoint
    {
        get
        {
            return list_array_special_point;
        }
    }

    public List<int> ListArrayAwakenPoint
    {
        get
        {
            return list_array_awaken_point;
        }
    }

    public int RandomStagePer
    {
        get
        {
            return random_stage_per;
        }
    }

    public int RandomPassiveGroup
    {
        get
        {
            return random_passive_group;
        }
    }

    public int ShopGroupId
    {
        get
        {
            return shop_group_id;
        }
    }

    public int RandomCount
    {
        get
        {
            return random_count;
        }
    }

    public int BuffRate
    {
        get
        {
            return buff_rate;
        }
    }

    public int BadgeEtc
    {
        get
        {
            return badge_etc;
        }
    }

    public int RandomStageGroup
    {
        get
        {
            return random_stage_group;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        season_group_id = reader.ReadInt32();
        floor_group_id = reader.ReadInt32();
        spot_group_id = reader.ReadInt32();
        spot_id = reader.ReadInt32();
        random_spot_check = reader.ReadInt32();
        spot_type = reader.ReadString();
        need_hero_group = reader.ReadInt32();
        hero_count = reader.ReadInt32();
        random_hero_count = reader.ReadInt32();
        int num1 = reader.ReadInt32();
        list_array_heal_per = new List<int>();
        for (int i = 0; i < num1; i++)
        {
            list_array_heal_per.Add(reader.ReadInt32());
        }
        int num2 = reader.ReadInt32();
        list_array_level_point = new List<int>();
        for (int i = 0; i < num2; i++)
        {
            list_array_level_point.Add(reader.ReadInt32());
        }
        int num3 = reader.ReadInt32();
        list_array_special_point = new List<int>();
        for (int i = 0; i < num3; i++)
        {
            list_array_special_point.Add(reader.ReadInt32());
        }
        int num4 = reader.ReadInt32();
        list_array_awaken_point = new List<int>();
        for (int i = 0; i < num4; i++)
        {
            list_array_awaken_point.Add(reader.ReadInt32());
        }
        random_stage_per = reader.ReadInt32();
        random_passive_group = reader.ReadInt32();
        shop_group_id = reader.ReadInt32();
        random_count = reader.ReadInt32();
        buff_rate = reader.ReadInt32();
        badge_etc = reader.ReadInt32();
        random_stage_group = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int season_group_id;

    private int floor_group_id;

    private int spot_group_id;

    private int spot_id;

    private int random_spot_check;

    private string spot_type;

    private int need_hero_group;

    private int hero_count;

    private int random_hero_count;

    private List<int> list_array_heal_per;

    private List<int> list_array_level_point;

    private List<int> list_array_special_point;

    private List<int> list_array_awaken_point;

    private int random_stage_per;

    private int random_passive_group;

    private int shop_group_id;

    private int random_count;

    private int buff_rate;

    private int badge_etc;

    private int random_stage_group;
}