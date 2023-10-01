public class DBArtifactUnionFilterGroupRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string UnionFilterContent
    {
        get
        {
            return union_filter_content.Localize();
        }
    }

    public string ContentIcon
    {
        get
        {
            return content_icon;
        }
    }

    public string UnionFilterKind
    {
        get
        {
            return union_filter_kind.Localize();
        }
    }

    public string KindIcon
    {
        get
        {
            return kind_icon;
        }
    }

    public string UnionFilterJobGroup
    {
        get
        {
            return union_filter_job_group.Localize();
        }
    }

    public string HeroFilterAnother
    {
        get
        {
            return hero_filter_another.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        union_filter_content = reader.ReadInt32();
        content_icon = reader.ReadString();
        union_filter_kind = reader.ReadInt32();
        kind_icon = reader.ReadString();
        union_filter_job_group = reader.ReadInt32();
        hero_filter_another = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int union_filter_content;

    private string content_icon;

    private int union_filter_kind;

    private string kind_icon;

    private int union_filter_job_group;

    private int hero_filter_another;
}