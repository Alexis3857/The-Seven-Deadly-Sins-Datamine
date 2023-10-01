public class DBTownDonationValueConfigRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int TownDonationValueConfig
    {
        get
        {
            return town_donation_value_config;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        town_donation_value_config = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int town_donation_value_config;
}
