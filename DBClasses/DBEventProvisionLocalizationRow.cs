public class DBEventProvisionLocalizationRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public string ProvisionEventPrefab
    {
        get
        {
            return provision_event_prefab;
        }
    }

    public string ProvisionEventGuidePrefab
    {
        get
        {
            return provision_event_guide_prefab;
        }
    }

    public string NoticeNotSelectedItem
    {
        get
        {
            return notice_not_selected_item.Localize();
        }
    }

    public string NoticeNotEnoughItem
    {
        get
        {
            return notice_not_enough_item.Localize();
        }
    }

    public string NoticeSectionClear
    {
        get
        {
            return notice_section_clear.Localize();
        }
    }

    public string NoticeContentLink
    {
        get
        {
            return notice_content_link.Localize();
        }
    }

    public string NoticeSectionOpenCondition
    {
        get
        {
            return notice_section_open_condition.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        provision_event_prefab = reader.ReadString();
        provision_event_guide_prefab = reader.ReadString();
        notice_not_selected_item = reader.ReadInt32();
        notice_not_enough_item = reader.ReadInt32();
        notice_section_clear = reader.ReadInt32();
        notice_content_link = reader.ReadInt32();
        notice_section_open_condition = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private string provision_event_prefab;

    private string provision_event_guide_prefab;

    private int notice_not_selected_item;

    private int notice_not_enough_item;

    private int notice_section_clear;

    private int notice_content_link;

    private int notice_section_open_condition;
}
