public class DBEventRandomBoxMileageRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public int GetOrder
    {
        get
        {
            return get_order;
        }
    }

    public int BoxType
    {
        get
        {
            return box_type;
        }
    }

    public int GetMileageValue
    {
        get
        {
            return get_mileage_value;
        }
    }

    public int GetSpecialStraight
    {
        get
        {
            return get_special_straight;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        get_order = reader.ReadInt32();
        box_type = reader.ReadInt32();
        get_mileage_value = reader.ReadInt32();
        get_special_straight = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int get_order;

    private int box_type;

    private int get_mileage_value;

    private int get_special_straight;
}
