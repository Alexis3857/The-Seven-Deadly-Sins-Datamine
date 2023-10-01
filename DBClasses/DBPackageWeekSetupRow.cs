public class DBPackageWeekSetupRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ProductId
    {
        get
        {
            return product_id;
        }
    }

    public int Sunday
    {
        get
        {
            return sunday;
        }
    }

    public int Monday
    {
        get
        {
            return monday;
        }
    }

    public int Tuesday
    {
        get
        {
            return tuesday;
        }
    }

    public int Wednesday
    {
        get
        {
            return wednesday;
        }
    }

    public int Thursday
    {
        get
        {
            return thursday;
        }
    }

    public int Friday
    {
        get
        {
            return friday;
        }
    }

    public int Saturday
    {
        get
        {
            return saturday;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        product_id = reader.ReadInt32();
        sunday = reader.ReadInt32();
        monday = reader.ReadInt32();
        tuesday = reader.ReadInt32();
        wednesday = reader.ReadInt32();
        thursday = reader.ReadInt32();
        friday = reader.ReadInt32();
        saturday = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int product_id;

    private int sunday;

    private int monday;

    private int tuesday;

    private int wednesday;

    private int thursday;

    private int friday;

    private int saturday;
}
