public class DBMazeSeasonShopGradeRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int NeedBuyPoint
    {
        get
        {
            return need_buy_point;
        }
    }

    public string GradeShopName
    {
        get
        {
            return grade_shop_name.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        need_buy_point = reader.ReadInt32();
        grade_shop_name = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int need_buy_point;

    private int grade_shop_name;
}