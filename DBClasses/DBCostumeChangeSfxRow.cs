public class DBCostumeChangeSfxRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int CostumeId
    {
        get
        {
            return costume_id;
        }
    }

    public int SfxId
    {
        get
        {
            return sfx_id;
        }
    }

    public string ChangeEffectFilename
    {
        get
        {
            return change_effect_filename;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        costume_id = reader.ReadInt32();
        sfx_id = reader.ReadInt32();
        change_effect_filename = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int costume_id;

    private int sfx_id;

    private string change_effect_filename;
}
