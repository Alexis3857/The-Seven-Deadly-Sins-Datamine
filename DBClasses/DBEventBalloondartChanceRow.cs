public class DBEventBalloondartChanceRow
{
    public int Id => id;

    public string ImagePrefab => image_prefab;

    public string ChanceTitle => chance_title.Localize();

    public string ChanceDesc => chance_desc.Localize();

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        image_prefab = reader.ReadString();
        chance_title = reader.ReadInt32();
        chance_desc = reader.ReadInt32();
        return true;
    }

    private int id;

    private string image_prefab;

    private int chance_title;

    private int chance_desc;
}