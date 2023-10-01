public class DBSoundRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string Path
    {
        get
        {
            return path;
        }
    }

    public string SubPath
    {
        get
        {
            return sub_path;
        }
    }

    public string Filename
    {
        get
        {
            return filename;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        path = reader.ReadString();
        sub_path = reader.ReadString();
        filename = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string path;

    private string sub_path;

    private string filename;
}
