public class DBCostumeShopPackageRow : ITableRowIndexer
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

    public int CostumeShopGroup
    {
        get
        {
            return costume_shop_group;
        }
    }

    public int ProductId1
    {
        get
        {
            return product_id_1;
        }
    }

    public int ProductId2
    {
        get
        {
            return product_id_2;
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

    public List<int> ListProductId
    {
        get
        {
            if (list_product_id == null)
            {
                list_product_id = new List<int>
                {
                    ProductId1,
                    ProductId2
                };
            }
            return list_product_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        costume_shop_type = reader.ReadInt32();
        costume_shop_group = reader.ReadInt32();
        product_id_1 = reader.ReadInt32();
        product_id_2 = reader.ReadInt32();
        price_id = reader.ReadInt32();
        price_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int costume_shop_type;

    private int costume_shop_group;

    private int product_id_1;

    private int product_id_2;

    private int price_id;

    private int price_count;

    private List<int> list_product_id;
}
