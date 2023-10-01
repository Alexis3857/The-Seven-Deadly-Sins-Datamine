public class DBFadeInoutRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string FadeGui
    {
        get
        {
            return fade_gui;
        }
    }

    public string InAnimName
    {
        get
        {
            return in_anim_name;
        }
    }

    public string OutAnimName
    {
        get
        {
            return out_anim_name;
        }
    }

    public int FrameSkipCount
    {
        get
        {
            return frame_skip_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        fade_gui = reader.ReadString();
        in_anim_name = reader.ReadString();
        out_anim_name = reader.ReadString();
        frame_skip_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string fade_gui;

    private string in_anim_name;

    private string out_anim_name;

    private int frame_skip_count;
}
