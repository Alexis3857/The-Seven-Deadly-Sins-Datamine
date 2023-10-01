public class DBFirstBuyBonusRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string ShopType
    {
        get
        {
            return shop_type;
        }
    }

    public string FirstBuyBonusMBanner
    {
        get
        {
            return first_buy_bonus_m_banner;
        }
    }

    public string FirstBuyBonusSBanner
    {
        get
        {
            return first_buy_bonus_s_banner;
        }
    }

    public string FirstBuyBonusName
    {
        get
        {
            return first_buy_bonus_name.Localize();
        }
    }

    public string FirstBuyBonusDesc
    {
        get
        {
            return first_buy_bonus_desc.Localize();
        }
    }

    public int BonusItemId1
    {
        get
        {
            return bonus_item_id_1;
        }
    }

    public int BonusItemCount1
    {
        get
        {
            return bonus_item_count_1;
        }
    }

    public int ContentsType
    {
        get
        {
            return contents_type;
        }
    }

    public List<int> ListBonusItemId
    {
        get
        {
            if (list_bonus_item_id == null)
            {
                list_bonus_item_id = new List<int>
                {
                    BonusItemId1
                };
            }
            return list_bonus_item_id;
        }
    }

    public List<int> ListBonusItemCount
    {
        get
        {
            if (list_bonus_item_count == null)
            {
                list_bonus_item_count = new List<int>
                {
                    BonusItemCount1
                };
            }
            return list_bonus_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        shop_type = reader.ReadString();
        first_buy_bonus_m_banner = reader.ReadString();
        first_buy_bonus_s_banner = reader.ReadString();
        first_buy_bonus_name = reader.ReadInt32();
        first_buy_bonus_desc = reader.ReadInt32();
        bonus_item_id_1 = reader.ReadInt32();
        bonus_item_count_1 = reader.ReadInt32();
        contents_type = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string shop_type;

    private string first_buy_bonus_m_banner;

    private string first_buy_bonus_s_banner;

    private int first_buy_bonus_name;

    private int first_buy_bonus_desc;

    private int bonus_item_id_1;

    private int bonus_item_count_1;

    private int contents_type;

    private List<int> list_bonus_item_id;

    private List<int> list_bonus_item_count;
}
