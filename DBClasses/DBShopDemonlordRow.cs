public class DBShopDemonlordRow : ITableRowIndexer
{
    public int Id => id;

    public int ProductCategory => product_category;

    public int ProductId => product_id;

    public int ProductCount => product_count;

    public int PriceId => price_id;

    public int PriceCount => price_count;

    public int BuyLimitedDailyCount => buy_limited_daily_count;

    public int BuyLimitedCount => buy_limited_count;

    public int ViewIndex => view_index;

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        product_category = reader.ReadInt32();
        product_id = reader.ReadInt32();
        product_count = reader.ReadInt32();
        price_id = reader.ReadInt32();
        price_count = reader.ReadInt32();
        buy_limited_daily_count = reader.ReadInt32();
        buy_limited_count = reader.ReadInt32();
        view_index = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int product_category;

    private int product_id;

    private int product_count;

    private int price_id;

    private int price_count;

    private int buy_limited_daily_count;

    private int buy_limited_count;

    private int view_index;
}