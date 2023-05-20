public class DBHeroLeagueBuffRow
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int BuffTargetSeason
    {
        get
        {
            return buff_target_season;
        }
    }

    public int BuffPassiveId
    {
        get
        {
            return buff_passive_id;
        }
    }

    public int BuffIconSlot
    {
        get
        {
            return buff_icon_slot;
        }
    }

    public string BuffPassiveIcon
    {
        get
        {
            return buff_passive_icon;
        }
    }

    public int HeroMatchingIcon1
    {
        get
        {
            return hero_matching_icon_1;
        }
    }

    public int HeroMatchingIcon2
    {
        get
        {
            return hero_matching_icon_2;
        }
    }

    public int HeroMatchingIcon3
    {
        get
        {
            return hero_matching_icon_3;
        }
    }

    public List<int> ListHeroMatchingIcon
    {
        get
        {
            if (list_hero_matching_icon == null)
            {
                list_hero_matching_icon = new List<int>()
                {
                    HeroMatchingIcon1,
                    HeroMatchingIcon2,
                    HeroMatchingIcon3
                };
            }
            return list_hero_matching_icon;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        buff_target_season = reader.ReadInt32();
        buff_passive_id = reader.ReadInt32();
        buff_icon_slot = reader.ReadInt32();
        buff_passive_icon = reader.ReadString();
        hero_matching_icon_1 = reader.ReadInt32();
        hero_matching_icon_2 = reader.ReadInt32();
        hero_matching_icon_3 = reader.ReadInt32();
        return true;
    }

    private int id;

    private int buff_target_season;

    private int buff_passive_id;

    private int buff_icon_slot;

    private string buff_passive_icon;

    private int hero_matching_icon_1;

    private int hero_matching_icon_2;

    private int hero_matching_icon_3;

    private List<int> list_hero_matching_icon;
}