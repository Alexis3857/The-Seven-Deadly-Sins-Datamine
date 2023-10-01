public class DBArDevicesRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string DeviceModelName
    {
        get
        {
            return device_model_name;
        }
    }

    public int DeviceMinApiLevel
    {
        get
        {
            return device_min_api_level;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        device_model_name = reader.ReadString();
        device_min_api_level = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string device_model_name;

    private int device_min_api_level;
}
