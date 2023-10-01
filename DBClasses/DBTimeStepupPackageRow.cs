public class DBTimeStepupPackageRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int StepGroup
    {
        get
        {
            return step_group;
        }
    }

    public string StepEventIcon
    {
        get
        {
            return step_event_icon;
        }
    }

    public int ProductId
    {
        get
        {
            return product_id;
        }
    }

    public int LimitTime
    {
        get
        {
            return limit_time;
        }
    }

    public int ProductReset
    {
        get
        {
            return product_reset;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        step_group = reader.ReadInt32();
        step_event_icon = reader.ReadString();
        product_id = reader.ReadInt32();
        limit_time = reader.ReadInt32();
        product_reset = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int step_group;

    private string step_event_icon;

    private int product_id;

    private int limit_time;

    private int product_reset;
}
