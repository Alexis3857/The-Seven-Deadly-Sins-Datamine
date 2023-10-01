public class DBWeaponCarveBaseRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int WeaponRating
    {
        get
        {
            return weapon_rating;
        }
    }

    public int WeaponParts
    {
        get
        {
            return weapon_parts;
        }
    }

    public int CarveItemId1
    {
        get
        {
            return carve_item_id_1;
        }
    }

    public int CarveItemCount1
    {
        get
        {
            return carve_item_count_1;
        }
    }

    public int CarveItemDiscount1
    {
        get
        {
            return carve_item_discount_1;
        }
    }

    public int CarveItemId2
    {
        get
        {
            return carve_item_id_2;
        }
    }

    public int CarveItemCount2
    {
        get
        {
            return carve_item_count_2;
        }
    }

    public int CarveItemDiscount2
    {
        get
        {
            return carve_item_discount_2;
        }
    }

    public int CarvePriceId
    {
        get
        {
            return carve_price_id;
        }
    }

    public int CarvePriceCount
    {
        get
        {
            return carve_price_count;
        }
    }

    public int CarvePriceDiscount
    {
        get
        {
            return carve_price_discount;
        }
    }

    public int CarveClearPriceId
    {
        get
        {
            return carve_clear_price_id;
        }
    }

    public int CarveClearPriceCount
    {
        get
        {
            return carve_clear_price_count;
        }
    }

    public int CarveClearDiscount
    {
        get
        {
            return carve_clear_discount;
        }
    }

    public List<int> ListCarveItemId
    {
        get
        {
            if (list_carve_item_id == null)
            {
                list_carve_item_id = new List<int>
                {
                    CarveItemId1,
                    CarveItemId2
                };
            }
            return list_carve_item_id;
        }
    }

    public List<int> ListCarveItemCount
    {
        get
        {
            if (list_carve_item_count == null)
            {
                list_carve_item_count = new List<int>
                {
                    CarveItemCount1,
                    CarveItemCount2
                };
            }
            return list_carve_item_count;
        }
    }

    public List<int> ListCarveItemDiscount
    {
        get
        {
            if (list_carve_item_discount == null)
            {
                list_carve_item_discount = new List<int>
                {
                    CarveItemDiscount1,
                    CarveItemDiscount2
                };
            }
            return list_carve_item_discount;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        weapon_rating = reader.ReadInt32();
        weapon_parts = reader.ReadInt32();
        carve_item_id_1 = reader.ReadInt32();
        carve_item_count_1 = reader.ReadInt32();
        carve_item_discount_1 = reader.ReadInt32();
        carve_item_id_2 = reader.ReadInt32();
        carve_item_count_2 = reader.ReadInt32();
        carve_item_discount_2 = reader.ReadInt32();
        carve_price_id = reader.ReadInt32();
        carve_price_count = reader.ReadInt32();
        carve_price_discount = reader.ReadInt32();
        carve_clear_price_id = reader.ReadInt32();
        carve_clear_price_count = reader.ReadInt32();
        carve_clear_discount = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int weapon_rating;

    private int weapon_parts;

    private int carve_item_id_1;

    private int carve_item_count_1;

    private int carve_item_discount_1;

    private int carve_item_id_2;

    private int carve_item_count_2;

    private int carve_item_discount_2;

    private int carve_price_id;

    private int carve_price_count;

    private int carve_price_discount;

    private int carve_clear_price_id;

    private int carve_clear_price_count;

    private int carve_clear_discount;

    private List<int> list_carve_item_id;

    private List<int> list_carve_item_count;

    private List<int> list_carve_item_discount;
}
