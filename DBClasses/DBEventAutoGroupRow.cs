public class DBEventAutoGroupRow
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string BackgroundName
    {
        get
        {
            return background_name;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        background_name = reader.ReadString();
        return true;
    }

    private int id;

    private string background_name;
}
