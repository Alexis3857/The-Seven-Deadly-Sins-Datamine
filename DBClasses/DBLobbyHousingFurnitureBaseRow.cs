public class DBLobbyHousingFurnitureBaseRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string LobbyType
    {
        get
        {
            return lobby_type;
        }
    }

    public int DefaultCheck
    {
        get
        {
            return default_check;
        }
    }

    public int FurnitureGroup
    {
        get
        {
            return furniture_group;
        }
    }

    public string FurniturePath
    {
        get
        {
            return furniture_path;
        }
    }

    public string FurnitureResource
    {
        get
        {
            return furniture_resource;
        }
    }

    public string FurnitureAni
    {
        get
        {
            return furniture_ani;
        }
    }

    public int UseNight
    {
        get
        {
            return use_night;
        }
    }

    public List<int> ListArrayFurnitureCamera
    {
        get
        {
            return list_array_furniture_camera;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        lobby_type = reader.ReadString();
        default_check = reader.ReadInt32();
        furniture_group = reader.ReadInt32();
        furniture_path = reader.ReadString();
        furniture_resource = reader.ReadString();
        furniture_ani = reader.ReadString();
        use_night = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_furniture_camera = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_furniture_camera.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string lobby_type;

    private int default_check;

    private int furniture_group;

    private string furniture_path;

    private string furniture_resource;

    private string furniture_ani;

    private int use_night;

    private List<int> list_array_furniture_camera;
}
