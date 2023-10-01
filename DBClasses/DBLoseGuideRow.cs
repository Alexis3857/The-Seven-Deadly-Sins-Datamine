public class DBLoseGuideRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string ControlType
    {
        get
        {
            return control_type;
        }
    }

    public int StageId
    {
        get
        {
            return stage_id;
        }
    }

    public int GuidePageIndex
    {
        get
        {
            return guide_page_index;
        }
    }

    public int PackIndex
    {
        get
        {
            return pack_index;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        control_type = reader.ReadString();
        stage_id = reader.ReadInt32();
        guide_page_index = reader.ReadInt32();
        pack_index = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string control_type;

    private int stage_id;

    private int guide_page_index;

    private int pack_index;
}
