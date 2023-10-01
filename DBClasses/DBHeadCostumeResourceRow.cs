public class DBHeadCostumeResourceRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int HeadAttachDummy
    {
        get
        {
            return head_attach_dummy;
        }
    }

    public string CharacterBase
    {
        get
        {
            return character_base;
        }
    }

    public string ResourceHead
    {
        get
        {
            return resource_head;
        }
    }

    public string HeadMixerName
    {
        get
        {
            return head_mixer_name;
        }
    }

    public string ErrorCheckHeadResource
    {
        get
        {
            return error_check_head_resource;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        head_attach_dummy = reader.ReadInt32();
        character_base = reader.ReadString();
        resource_head = reader.ReadString();
        head_mixer_name = reader.ReadString();
        error_check_head_resource = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int head_attach_dummy;

    private string character_base;

    private string resource_head;

    private string head_mixer_name;

    private string error_check_head_resource;
}
