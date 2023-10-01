public class DBHeroFilterGroupRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string HeroFilterAttributeName
    {
        get
        {
            return hero_filter_attribute_name.Localize();
        }
    }

    public string AttributeIcon
    {
        get
        {
            return attribute_icon;
        }
    }

    public string HeroFilterKindName
    {
        get
        {
            return hero_filter_kind_name.Localize();
        }
    }

    public string KindIcon
    {
        get
        {
            return kind_icon;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        hero_filter_attribute_name = reader.ReadInt32();
        attribute_icon = reader.ReadString();
        hero_filter_kind_name = reader.ReadInt32();
        kind_icon = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int hero_filter_attribute_name;

    private string attribute_icon;

    private int hero_filter_kind_name;

    private string kind_icon;
}
