public class DBShopPackageRow : ITableRowIndexer
{
    public int ProductId
    {
        get
        {
            return product_id;
        }
    }

    public int PackageIndex
    {
        get
        {
            return package_index;
        }
    }

    public string Type
    {
        get
        {
            return type;
        }
    }

    public string SubType
    {
        get
        {
            return sub_type;
        }
    }

    public int ChoiceGroup
    {
        get
        {
            return choice_group;
        }
    }

    public int StepGroup
    {
        get
        {
            return step_group;
        }
    }

    public int ContentsType
    {
        get
        {
            return contents_type;
        }
    }

    public int PackageActive
    {
        get
        {
            return package_active;
        }
    }

    public int PackageCategory
    {
        get
        {
            return package_category;
        }
    }

    public int PackageView
    {
        get
        {
            return package_view;
        }
    }

    public int PackageViewIndex
    {
        get
        {
            return package_view_index;
        }
    }

    public string ConditionType
    {
        get
        {
            return condition_type;
        }
    }

    public int ConditionValue
    {
        get
        {
            return condition_value;
        }
    }

    public int ConditionRank
    {
        get
        {
            return condition_rank;
        }
    }

    public string CloseType
    {
        get
        {
            return close_type;
        }
    }

    public int CloseValue
    {
        get
        {
            return close_value;
        }
    }

    public int CloseRank
    {
        get
        {
            return close_rank;
        }
    }

    public int PackageType
    {
        get
        {
            return package_type;
        }
    }

    public int GiveType
    {
        get
        {
            return give_type;
        }
    }

    public int ProductSetup
    {
        get
        {
            return product_setup;
        }
    }

    public string PriceType
    {
        get
        {
            return price_type;
        }
    }

    public int PriceCount
    {
        get
        {
            return price_count;
        }
    }

    public int BuyLimit
    {
        get
        {
            return buy_limit;
        }
    }

    public string ResetType
    {
        get
        {
            return reset_type;
        }
    }

    public int ResetCount
    {
        get
        {
            return reset_count;
        }
    }

    public int RewardPackage
    {
        get
        {
            return reward_package;
        }
    }

    public int RewardMailType
    {
        get
        {
            return reward_mail_type;
        }
    }

    public string PackageImageName
    {
        get
        {
            return package_image_name;
        }
    }

    public string PackageImageNameS
    {
        get
        {
            return package_image_name_s;
        }
    }

    public string PackageLargePopupName
    {
        get
        {
            return package_large_popup_name;
        }
    }

    public string PackageIconName
    {
        get
        {
            return package_icon_name;
        }
    }

    public string PackageBannerName
    {
        get
        {
            return package_banner_name.Localize();
        }
    }

    public string PackageBannerNameGb
    {
        get
        {
            return package_banner_name_gb.Localize();
        }
    }

    public string PackageName
    {
        get
        {
            return package_name.Localize();
        }
    }

    public string PackageDesc
    {
        get
        {
            return package_desc.Localize();
        }
    }

    public int DateCheck
    {
        get
        {
            return date_check;
        }
    }

    public string BuyStartDate
    {
        get
        {
            return buy_start_date;
        }
    }

    public string BuyEndDate
    {
        get
        {
            return buy_end_date;
        }
    }

    public int PlatformType
    {
        get
        {
            return platform_type;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        product_id = reader.ReadInt32();
        package_index = reader.ReadInt32();
        type = reader.ReadString();
        sub_type = reader.ReadString();
        choice_group = reader.ReadInt32();
        step_group = reader.ReadInt32();
        contents_type = reader.ReadInt32();
        package_active = reader.ReadInt32();
        package_category = reader.ReadInt32();
        package_view = reader.ReadInt32();
        package_view_index = reader.ReadInt32();
        condition_type = reader.ReadString();
        condition_value = reader.ReadInt32();
        condition_rank = reader.ReadInt32();
        close_type = reader.ReadString();
        close_value = reader.ReadInt32();
        close_rank = reader.ReadInt32();
        package_type = reader.ReadInt32();
        give_type = reader.ReadInt32();
        product_setup = reader.ReadInt32();
        price_type = reader.ReadString();
        price_count = reader.ReadInt32();
        buy_limit = reader.ReadInt32();
        reset_type = reader.ReadString();
        reset_count = reader.ReadInt32();
        reward_package = reader.ReadInt32();
        reward_mail_type = reader.ReadInt32();
        package_image_name = reader.ReadString();
        package_image_name_s = reader.ReadString();
        package_large_popup_name = reader.ReadString();
        package_icon_name = reader.ReadString();
        package_banner_name = reader.ReadInt32();
        package_banner_name_gb = reader.ReadInt32();
        package_name = reader.ReadInt32();
        package_desc = reader.ReadInt32();
        date_check = reader.ReadInt32();
        buy_start_date = reader.ReadString();
        buy_end_date = reader.ReadString();
        platform_type = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return ProductId;
    }

    private int product_id;

    private int package_index;

    private string type;

    private string sub_type;

    private int choice_group;

    private int step_group;

    private int contents_type;

    private int package_active;

    private int package_category;

    private int package_view;

    private int package_view_index;

    private string condition_type;

    private int condition_value;

    private int condition_rank;

    private string close_type;

    private int close_value;

    private int close_rank;

    private int package_type;

    private int give_type;

    private int product_setup;

    private string price_type;

    private int price_count;

    private int buy_limit;

    private string reset_type;

    private int reset_count;

    private int reward_package;

    private int reward_mail_type;

    private string package_image_name;

    private string package_image_name_s;

    private string package_large_popup_name;

    private string package_icon_name;

    private int package_banner_name;

    private int package_banner_name_gb;

    private int package_name;

    private int package_desc;

    private int date_check;

    private string buy_start_date;

    private string buy_end_date;

    private int platform_type;
}
