public class DBStageTrainingPlayCountRow : ITableRowIndexer
{
    public int HeroSkinRating
    {
        get
        {
            return hero_skin_rating;
        }
    }

    public int PlayCount
    {
        get
        {
            return play_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        hero_skin_rating = reader.ReadInt32();
        play_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return HeroSkinRating;
    }

    private int hero_skin_rating;

    private int play_count;
}
