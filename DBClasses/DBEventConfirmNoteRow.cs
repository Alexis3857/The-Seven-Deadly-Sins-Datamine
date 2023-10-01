public class DBEventConfirmNoteRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int Group
    {
        get
        {
            return group;
        }
    }

    public int Index
    {
        get
        {
            return index;
        }
    }

    public int BoxType
    {
        get
        {
            return box_type;
        }
    }

    public int GuideLeft
    {
        get
        {
            return guide_left;
        }
    }

    public int GuideRight
    {
        get
        {
            return guide_right;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        group = reader.ReadInt32();
        index = reader.ReadInt32();
        box_type = reader.ReadInt32();
        guide_left = reader.ReadInt32();
        guide_right = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int group;

    private int index;

    private int box_type;

    private int guide_left;

    private int guide_right;
}