public class DBHeroCapacityMentRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string HeroCapacityMent1
    {
        get
        {
            return hero_capacity_ment_1.Localize();
        }
    }

    public string HeroCapacityMent2
    {
        get
        {
            return hero_capacity_ment_2.Localize();
        }
    }

    public string HeroCapacityMent3
    {
        get
        {
            return hero_capacity_ment_3.Localize();
        }
    }

    public string HeroCapacityMent4
    {
        get
        {
            return hero_capacity_ment_4.Localize();
        }
    }

    public string HeroCapacityMent5
    {
        get
        {
            return hero_capacity_ment_5.Localize();
        }
    }

    public string HeroCapacityMent6
    {
        get
        {
            return hero_capacity_ment_6.Localize();
        }
    }

    public string HeroCapacityMent7
    {
        get
        {
            return hero_capacity_ment_7.Localize();
        }
    }

    public string HeroLrCapacityMent1
    {
        get
        {
            return hero_lr_capacity_ment_1.Localize();
        }
    }

    public string HeroLrCapacityMent2
    {
        get
        {
            return hero_lr_capacity_ment_2.Localize();
        }
    }

    public string HeroLrCapacityMent3
    {
        get
        {
            return hero_lr_capacity_ment_3.Localize();
        }
    }

    public string HeroLrCapacityMent4
    {
        get
        {
            return hero_lr_capacity_ment_4.Localize();
        }
    }

    public string HeroLrCapacityMent5
    {
        get
        {
            return hero_lr_capacity_ment_5.Localize();
        }
    }

    public string HeroLrCapacityMent6
    {
        get
        {
            return hero_lr_capacity_ment_6.Localize();
        }
    }

    public string HeroLrCapacityMent7
    {
        get
        {
            return hero_lr_capacity_ment_7.Localize();
        }
    }

    public List<string> ListHeroCapacityMent
    {
        get
        {
            if (list_hero_capacity_ment == null)
            {
                list_hero_capacity_ment = new List<string>
                {
                    HeroCapacityMent1,
                    HeroCapacityMent2,
                    HeroCapacityMent3,
                    HeroCapacityMent4,
                    HeroCapacityMent5,
                    HeroCapacityMent6,
                    HeroCapacityMent7
                };
            }
            return list_hero_capacity_ment;
        }
    }

    public List<string> ListHeroLrCapacityMent
    {
        get
        {
            if (list_hero_lr_capacity_ment == null)
            {
                list_hero_lr_capacity_ment = new List<string>
                {
                    HeroLrCapacityMent1,
                    HeroLrCapacityMent2,
                    HeroLrCapacityMent3,
                    HeroLrCapacityMent4,
                    HeroLrCapacityMent5,
                    HeroLrCapacityMent6,
                    HeroLrCapacityMent7
                };
            }
            return list_hero_lr_capacity_ment;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        hero_capacity_ment_1 = reader.ReadInt32();
        hero_capacity_ment_2 = reader.ReadInt32();
        hero_capacity_ment_3 = reader.ReadInt32();
        hero_capacity_ment_4 = reader.ReadInt32();
        hero_capacity_ment_5 = reader.ReadInt32();
        hero_capacity_ment_6 = reader.ReadInt32();
        hero_capacity_ment_7 = reader.ReadInt32();
        hero_lr_capacity_ment_1 = reader.ReadInt32();
        hero_lr_capacity_ment_2 = reader.ReadInt32();
        hero_lr_capacity_ment_3 = reader.ReadInt32();
        hero_lr_capacity_ment_4 = reader.ReadInt32();
        hero_lr_capacity_ment_5 = reader.ReadInt32();
        hero_lr_capacity_ment_6 = reader.ReadInt32();
        hero_lr_capacity_ment_7 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int hero_capacity_ment_1;

    private int hero_capacity_ment_2;

    private int hero_capacity_ment_3;

    private int hero_capacity_ment_4;

    private int hero_capacity_ment_5;

    private int hero_capacity_ment_6;

    private int hero_capacity_ment_7;

    private int hero_lr_capacity_ment_1;

    private int hero_lr_capacity_ment_2;

    private int hero_lr_capacity_ment_3;

    private int hero_lr_capacity_ment_4;

    private int hero_lr_capacity_ment_5;

    private int hero_lr_capacity_ment_6;

    private int hero_lr_capacity_ment_7;

    private List<string> list_hero_capacity_ment;

    private List<string> list_hero_lr_capacity_ment;
}
