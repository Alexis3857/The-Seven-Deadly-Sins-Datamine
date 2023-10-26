public class DBEventBalloondartChanceRow : ITableRowIndexer
{
    public int Id => id;

    public int ChancePer => chance_per;

    public string ImagePrefab => image_prefab;

    public string ChanceTitle => chance_title.Localize();

    public string ChanceDesc => chance_desc.Localize();

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        chance_per = reader.ReadInt32();
        image_prefab = reader.ReadString();
        chance_title = reader.ReadInt32();
        chance_desc = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int chance_per;

    private string image_prefab;

    private int chance_title;

    private int chance_desc;
}