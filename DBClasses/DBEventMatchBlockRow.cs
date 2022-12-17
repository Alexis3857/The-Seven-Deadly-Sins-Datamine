public class DBEventMatchBlockRow
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string BlockIcon
    {
        get
        {
            return block_icon;
        }
    }

    public string BlockBg
    {
        get
        {
            return block_bg;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        block_icon = reader.ReadString();
        block_bg = reader.ReadString();
        return true;
    }

    private int id;

    private string block_icon;

    private string block_bg;
}
