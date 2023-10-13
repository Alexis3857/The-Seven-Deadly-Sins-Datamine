public class DBPvpChaosGradeChangeRow : ITableRowIndexer
{
    public int Id { get => id; }
    public int Section { get => section; }
    public int GradeUp { get => grade_up; }
    public int GradeDown { get => grade_down; }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        section = reader.ReadInt32();
        grade_up = reader.ReadInt32();
        grade_down = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int section;

    private int grade_up;

    private int grade_down;
}