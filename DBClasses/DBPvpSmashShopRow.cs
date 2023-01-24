﻿public class DBPvpSmashShopRow
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int BasepointId
    {
        get
        {
            return basepoint_id;
        }
    }

    public int NpcId
    {
        get
        {
            return npc_id;
        }
    }

    public int TabIndex
    {
        get
        {
            return tab_index;
        }
    }

    public int PvpSmashBuyGrade
    {
        get
        {
            return pvp_smash_buy_grade;
        }
    }

    public int ShopItemId
    {
        get
        {
            return shop_item_id;
        }
    }

    public int ProductCount
    {
        get
        {
            return product_count;
        }
    }

    public int BuyLimitedCount
    {
        get
        {
            return buy_limited_count;
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

    public List<int> ListPriceId
    {
        get
        {
            if (list_price_id == null)
            {
                list_price_id = new List<int>
                {
                    PriceId1
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
                    PriceCount1
                };
            }
            return list_price_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        basepoint_id = reader.ReadInt32();
        npc_id = reader.ReadInt32();
        tab_index = reader.ReadInt32();
        pvp_smash_buy_grade = reader.ReadInt32();
        shop_item_id = reader.ReadInt32();
        product_count = reader.ReadInt32();
        buy_limited_count = reader.ReadInt32();
        price_id_1 = reader.ReadInt32();
        price_count_1 = reader.ReadInt32();
        return true;
    }

    private int id;

    private int basepoint_id;

    private int npc_id;

    private int tab_index;

    private int pvp_smash_buy_grade;

    private int shop_item_id;

    private int product_count;

    private int buy_limited_count;

    private int price_id_1;

    private int price_count_1;

    private List<int> list_price_id;

    private List<int> list_price_count;
}