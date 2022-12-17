public class DBStageMazeSpotRow
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

    public int HealPer
    {
        get
        {
            return heal_per;
        }
    }

    public int LevelPoint
    {
        get
        {
            return level_point;
        }
    }

    public int SpecialPoint
    {
        get
        {
            return special_point;
        }
    }

    public int AwakenPoint
    {
        get
        {
            return awaken_point;
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
        heal_per = reader.ReadInt32();
        level_point = reader.ReadInt32();
        special_point = reader.ReadInt32();
        awaken_point = reader.ReadInt32();
        random_passive_group = reader.ReadInt32();
        shop_group_id = reader.ReadInt32();
        random_count = reader.ReadInt32();
        badge_etc = reader.ReadInt32();
        random_stage_group = reader.ReadInt32();
        return true;
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

    private int heal_per;

    private int level_point;

    private int special_point;

    private int awaken_point;

    private int random_passive_group;

    private int shop_group_id;

    private int random_count;

    private int badge_etc;

    private int random_stage_group;
}