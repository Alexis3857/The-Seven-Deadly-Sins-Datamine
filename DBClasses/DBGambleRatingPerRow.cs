public class DBGambleRatingPerRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GambleGroup
    {
        get
        {
            return gamble_group;
        }
    }

    public int Rating1
    {
        get
        {
            return rating_1;
        }
    }

    public int Rating2
    {
        get
        {
            return rating_2;
        }
    }

    public int Rating3
    {
        get
        {
            return rating_3;
        }
    }

    public int Rating4
    {
        get
        {
            return rating_4;
        }
    }

    public int Rating5
    {
        get
        {
            return rating_5;
        }
    }

    public List<int> ListRating
    {
        get
        {
            if (list_rating == null)
            {
                list_rating = new List<int>
                {
                    Rating1,
                    Rating2,
                    Rating3,
                    Rating4,
                    Rating5
                };
            }
            return list_rating;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        gamble_group = reader.ReadInt32();
        rating_1 = reader.ReadInt32();
        rating_2 = reader.ReadInt32();
        rating_3 = reader.ReadInt32();
        rating_4 = reader.ReadInt32();
        rating_5 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int gamble_group;

    private int rating_1;

    private int rating_2;

    private int rating_3;

    private int rating_4;

    private int rating_5;

    private List<int> list_rating;
}
