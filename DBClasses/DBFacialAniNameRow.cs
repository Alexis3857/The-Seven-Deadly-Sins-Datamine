public class DBFacialAniNameRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int Type
    {
        get
        {
            return type;
        }
    }

    public string FacialTypeName
    {
        get
        {
            return facial_type_name;
        }
    }

    public string FacialNameLocal
    {
        get
        {
            return facial_name_local.Localize();
        }
    }

    public int SoundId
    {
        get
        {
            return sound_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        type = reader.ReadInt32();
        facial_type_name = reader.ReadString();
        facial_name_local = reader.ReadInt32();
        sound_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int type;

    private string facial_type_name;

    private int facial_name_local;

    private int sound_id;
}
