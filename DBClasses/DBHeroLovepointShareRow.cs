public class DBHeroLovepointShareRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int HeroGroup
    {
        get
        {
            return hero_group;
        }
    }

    public int ShareConditionCount
    {
        get
        {
            return share_condition_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        hero_group = reader.ReadInt32();
        share_condition_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int hero_group;

    private int share_condition_count;
}
