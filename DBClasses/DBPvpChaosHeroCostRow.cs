public class DBPvpChaosHeroCostRow : ITableRowIndexer
{
    public int Id { get => id; }
    public int Rank { get => rank; }
    public int Grade { get => grade; }
    public int HeroCost { get => hero_cost; }
    public int HeroId { get => hero_id; }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        rank = reader.ReadInt32();
        grade = reader.ReadInt32();
        hero_cost = reader.ReadInt32();
        hero_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int rank;

    private int grade;

    private int hero_cost;

    private int hero_id;
}