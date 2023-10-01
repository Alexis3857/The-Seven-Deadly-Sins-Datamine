public class DBUpgradeRatingRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 1172U;
        }
    }

    public int Id
    {
        get
        {
            return base.DecryptInt32(id);
        }
    }

    public int RatingId
    {
        get
        {
            return base.DecryptInt32(rating_id);
        }
    }

    public string RatingName
    {
        get
        {
            return rating_name;
        }
    }

    public int RatingHeroRate
    {
        get
        {
            return base.DecryptInt32(rating_hero_rate);
        }
    }

    public float RatingHeroValue
    {
        get
        {
            return base.DecryptFloat(rating_hero_value);
        }
    }

    public int RatingSkinRate
    {
        get
        {
            return base.DecryptInt32(rating_skin_rate);
        }
    }

    public float RatingSkinValue
    {
        get
        {
            return base.DecryptFloat(rating_skin_value);
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadBytes(4);
        rating_id = reader.ReadBytes(4);
        rating_name = reader.ReadString();
        rating_hero_rate = reader.ReadBytes(4);
        rating_hero_value = reader.ReadBytes(4);
        rating_skin_rate = reader.ReadBytes(4);
        rating_skin_value = reader.ReadBytes(4);
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private byte[] id;

    private byte[] rating_id;

    private string rating_name;

    private byte[] rating_hero_rate;

    private byte[] rating_hero_value;

    private byte[] rating_skin_rate;

    private byte[] rating_skin_value;
}
