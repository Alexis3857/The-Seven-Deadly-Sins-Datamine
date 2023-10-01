public class DBChapterChangeRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ChapterId
    {
        get
        {
            return chapter_id;
        }
    }

    public int ChangeMatchingId
    {
        get
        {
            return change_matching_id;
        }
    }

    public int ChangeMoveMatchingArea
    {
        get
        {
            return change_move_matching_area;
        }
    }

    public int ChangeCapitalIconMatchingArea
    {
        get
        {
            return change_capital_icon_matching_area;
        }
    }

    public string ChangeChapterName
    {
        get
        {
            return change_chapter_name.Localize();
        }
    }

    public string ChangeChapterResource
    {
        get
        {
            return change_chapter_resource;
        }
    }

    public string OpenType
    {
        get
        {
            return open_type;
        }
    }

    public int OpenValue
    {
        get
        {
            return open_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        chapter_id = reader.ReadInt32();
        change_matching_id = reader.ReadInt32();
        change_move_matching_area = reader.ReadInt32();
        change_capital_icon_matching_area = reader.ReadInt32();
        change_chapter_name = reader.ReadInt32();
        change_chapter_resource = reader.ReadString();
        open_type = reader.ReadString();
        open_value = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int chapter_id;

    private int change_matching_id;

    private int change_move_matching_area;

    private int change_capital_icon_matching_area;

    private int change_chapter_name;

    private string change_chapter_resource;

    private string open_type;

    private int open_value;
}
