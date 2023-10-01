public class DBGuildWarLowTierRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int Tier
    {
        get
        {
            return tier;
        }
    }

    public int PercentageMin
    {
        get
        {
            return percentage_min;
        }
    }

    public int PercentageMax
    {
        get
        {
            return percentage_max;
        }
    }

    public string TierName
    {
        get
        {
            return tier_name.Localize();
        }
    }

    public string TierIcon
    {
        get
        {
            return tier_icon;
        }
    }

    public string TierColor
    {
        get
        {
            return tier_color;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        tier = reader.ReadInt32();
        percentage_min = reader.ReadInt32();
        percentage_max = reader.ReadInt32();
        tier_name = reader.ReadInt32();
        tier_icon = reader.ReadString();
        tier_color = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int tier;

    private int percentage_min;

    private int percentage_max;

    private int tier_name;

    private string tier_icon;

    private string tier_color;
}
