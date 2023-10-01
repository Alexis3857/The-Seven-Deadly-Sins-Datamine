public class DBPvpShowRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int RankType
    {
        get
        {
            return rank_type;
        }
    }

    public string TypeIcon
    {
        get
        {
            return type_icon;
        }
    }

    public string TypeLocalize
    {
        get
        {
            return type_localize.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        rank_type = reader.ReadInt32();
        type_icon = reader.ReadString();
        type_localize = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int rank_type;

    private string type_icon;

    private int type_localize;
}
