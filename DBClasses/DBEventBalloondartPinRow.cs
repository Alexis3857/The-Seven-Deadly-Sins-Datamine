public class DBEventBalloondartPinRow
{
    public int Id => id;

    public string DartType => dart_type;

    public string DartPrefab => dart_prefab;

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        dart_type = reader.ReadString();
        dart_prefab = reader.ReadString();
        return true;
    }

    private int id;

    private string dart_type;

    private string dart_prefab;
}