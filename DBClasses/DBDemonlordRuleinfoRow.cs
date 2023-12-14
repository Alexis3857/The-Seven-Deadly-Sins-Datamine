public class DBDemonlordRuleinfoRow : ITableRowIndexer
{
    public int Id => id;
    public string IconName => icon_name;
    public string RuleName => rule_name.Localize();

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        icon_name = reader.ReadString();
        rule_name = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string icon_name;

    private int rule_name;
}