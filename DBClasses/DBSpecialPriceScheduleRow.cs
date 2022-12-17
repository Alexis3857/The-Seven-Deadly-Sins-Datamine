public class DBSpecialPriceScheduleRow
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int SpecialPriceGroup
    {
        get
        {
            return special_price_group;
        }
    }

    public int SpecialPriceGroupIndex
    {
        get
        {
            return special_price_group_index;
        }
    }

    public int SpecialPricePackageId
    {
        get
        {
            return special_price_package_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        special_price_group = reader.ReadInt32();
        special_price_group_index = reader.ReadInt32();
        special_price_package_id = reader.ReadInt32();
        return true;
    }

    private int id;

    private int special_price_group;

    private int special_price_group_index;

    private int special_price_package_id;
}
