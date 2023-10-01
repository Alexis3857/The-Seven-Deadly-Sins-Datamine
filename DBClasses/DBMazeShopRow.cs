public class DBMazeShopRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ShopGroupId
    {
        get
        {
            return shop_group_id;
        }
    }

    public string SpotType
    {
        get
        {
            return spot_type;
        }
    }

    public int PriceId
    {
        get
        {
            return price_id;
        }
    }

    public int PriceCount
    {
        get
        {
            return price_count;
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

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        shop_group_id = reader.ReadInt32();
        spot_type = reader.ReadString();
        price_id = reader.ReadInt32();
        price_count = reader.ReadInt32();
        need_hero_group = reader.ReadInt32();
        hero_count = reader.ReadInt32();
        random_hero_count = reader.ReadInt32();
        heal_per = reader.ReadInt32();
        level_point = reader.ReadInt32();
        special_point = reader.ReadInt32();
        awaken_point = reader.ReadInt32();
        random_passive_group = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int shop_group_id;

    private string spot_type;

    private int price_id;

    private int price_count;

    private int need_hero_group;

    private int hero_count;

    private int random_hero_count;

    private int heal_per;

    private int level_point;

    private int special_point;

    private int awaken_point;

    private int random_passive_group;
}
