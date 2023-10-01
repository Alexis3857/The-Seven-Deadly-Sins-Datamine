public class DBCostumeShopRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int CostumeShopType
    {
        get
        {
            return costume_shop_type;
        }
    }

    public int ShowIndex
    {
        get
        {
            return show_index;
        }
    }

    public List<string> ListArrayShowHeroName
    {
        get
        {
            return list_array_show_hero_name;
        }
    }

    public int CostumeShopGroup
    {
        get
        {
            return costume_shop_group;
        }
    }

    public string ShopDisplayImage
    {
        get
        {
            return shop_display_image;
        }
    }

    public string EventBannerImage
    {
        get
        {
            return event_banner_image;
        }
    }

    public int RewardCostumeId
    {
        get
        {
            return reward_costume_id;
        }
    }

    public int PriceId1
    {
        get
        {
            return price_id_1;
        }
    }

    public int PriceCount1
    {
        get
        {
            return price_count_1;
        }
    }

    public int PriceId2
    {
        get
        {
            return price_id_2;
        }
    }

    public int PriceCount2
    {
        get
        {
            return price_count_2;
        }
    }

    public int DiscountCount
    {
        get
        {
            return discount_count;
        }
    }

    public int PriceViewType
    {
        get
        {
            return price_view_type;
        }
    }

    public int BuyLimitedCount
    {
        get
        {
            return buy_limited_count;
        }
    }

    public int ProductType
    {
        get
        {
            return product_type;
        }
    }

    public int ProductCondition
    {
        get
        {
            return product_condition;
        }
    }

    public int NewApparel
    {
        get
        {
            return new_apparel;
        }
    }

    public int NextSaleView
    {
        get
        {
            return next_sale_view;
        }
    }

    public string BuyStartDate
    {
        get
        {
            return buy_start_date;
        }
    }

    public string BuyLimitedDate
    {
        get
        {
            return buy_limited_date;
        }
    }

    public float HeroPortraitRotation
    {
        get
        {
            return hero_portrait_rotation;
        }
    }

    public int ResaleCheck
    {
        get
        {
            return resale_check;
        }
    }

    public List<int> ListPriceId
    {
        get
        {
            if (list_price_id == null)
            {
                list_price_id = new List<int>
                {
                    PriceId1,
                    PriceId2
                };
            }
            return list_price_id;
        }
    }

    public List<int> ListPriceCount
    {
        get
        {
            if (list_price_count == null)
            {
                list_price_count = new List<int>
                {
                    PriceCount1,
                    PriceCount2
                };
            }
            return list_price_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        costume_shop_type = reader.ReadInt32();
        show_index = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_show_hero_name = new List<string>();
        for (int i = 0; i < num; i++)
        {
            list_array_show_hero_name.Add(reader.ReadString());
        }
        costume_shop_group = reader.ReadInt32();
        shop_display_image = reader.ReadString();
        event_banner_image = reader.ReadString();
        reward_costume_id = reader.ReadInt32();
        price_id_1 = reader.ReadInt32();
        price_count_1 = reader.ReadInt32();
        price_id_2 = reader.ReadInt32();
        price_count_2 = reader.ReadInt32();
        discount_count = reader.ReadInt32();
        price_view_type = reader.ReadInt32();
        buy_limited_count = reader.ReadInt32();
        product_type = reader.ReadInt32();
        product_condition = reader.ReadInt32();
        new_apparel = reader.ReadInt32();
        next_sale_view = reader.ReadInt32();
        buy_start_date = reader.ReadString();
        buy_limited_date = reader.ReadString();
        hero_portrait_rotation = reader.ReadSingle();
        resale_check = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int costume_shop_type;

    private int show_index;

    private List<string> list_array_show_hero_name;

    private int costume_shop_group;

    private string shop_display_image;

    private string event_banner_image;

    private int reward_costume_id;

    private int price_id_1;

    private int price_count_1;

    private int price_id_2;

    private int price_count_2;

    private int discount_count;

    private int price_view_type;

    private int buy_limited_count;

    private int product_type;

    private int product_condition;

    private int new_apparel;

    private int next_sale_view;

    private string buy_start_date;

    private string buy_limited_date;

    private float hero_portrait_rotation;

    private int resale_check;

    private List<int> list_price_id;

    private List<int> list_price_count;
}
