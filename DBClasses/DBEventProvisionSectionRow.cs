public class DBEventProvisionSectionRow : ITableRowIndexer
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

    public string SectionName
    {
        get
        {
            return section_name.Localize();
        }
    }

    public string SectionIcon
    {
        get
        {
            return section_icon;
        }
    }

    public string SectionIconComplete
    {
        get
        {
            return section_icon_complete;
        }
    }

    public string SectionRoomComplete
    {
        get
        {
            return section_room_complete;
        }
    }

    public string SectionNpcTalk
    {
        get
        {
            return section_npc_talk.Localize();
        }
    }

    public string SectionNpcTalkProvide
    {
        get
        {
            return section_npc_talk_provide.Localize();
        }
    }

    public string SectionNpcTalkComplete
    {
        get
        {
            return section_npc_talk_complete.Localize();
        }
    }

    public List<int> ListArrayNeedClearSection
    {
        get
        {
            return list_array_need_clear_section;
        }
    }

    public string ProvideType
    {
        get
        {
            return provide_type;
        }
    }

    public int AnyNeedItemCount
    {
        get
        {
            return any_need_item_count;
        }
    }

    public int NeedItemId1
    {
        get
        {
            return need_item_id_1;
        }
    }

    public int NeedItemCount1
    {
        get
        {
            return need_item_count_1;
        }
    }

    public int NeedItemId2
    {
        get
        {
            return need_item_id_2;
        }
    }

    public int NeedItemCount2
    {
        get
        {
            return need_item_count_2;
        }
    }

    public int NeedItemId3
    {
        get
        {
            return need_item_id_3;
        }
    }

    public int NeedItemCount3
    {
        get
        {
            return need_item_count_3;
        }
    }

    public int ContentLinkId
    {
        get
        {
            return content_link_id;
        }
    }

    public List<int> ListNeedItemId
    {
        get
        {
            if (list_need_item_id == null)
            {
                list_need_item_id = new List<int>
                {
                    NeedItemId1,
                    NeedItemId2,
                    NeedItemId3
                };
            }
            return list_need_item_id;
        }
    }

    public List<int> ListNeedItemCount
    {
        get
        {
            if (list_need_item_count == null)
            {
                list_need_item_count = new List<int>
                {
                    NeedItemCount1,
                    NeedItemCount2,
                    NeedItemCount3
                };
            }
            return list_need_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        section_name = reader.ReadInt32();
        section_icon = reader.ReadString();
        section_icon_complete = reader.ReadString();
        section_room_complete = reader.ReadString();
        section_npc_talk = reader.ReadInt32();
        section_npc_talk_provide = reader.ReadInt32();
        section_npc_talk_complete = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_need_clear_section = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_need_clear_section.Add(reader.ReadInt32());
        }
        provide_type = reader.ReadString();
        any_need_item_count = reader.ReadInt32();
        need_item_id_1 = reader.ReadInt32();
        need_item_count_1 = reader.ReadInt32();
        need_item_id_2 = reader.ReadInt32();
        need_item_count_2 = reader.ReadInt32();
        need_item_id_3 = reader.ReadInt32();
        need_item_count_3 = reader.ReadInt32();
        content_link_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int section_name;

    private string section_icon;

    private string section_icon_complete;

    private string section_room_complete;

    private int section_npc_talk;

    private int section_npc_talk_provide;

    private int section_npc_talk_complete;

    private List<int> list_array_need_clear_section;

    private string provide_type;

    private int any_need_item_count;

    private int need_item_id_1;

    private int need_item_count_1;

    private int need_item_id_2;

    private int need_item_count_2;

    private int need_item_id_3;

    private int need_item_count_3;

    private int content_link_id;

    private List<int> list_need_item_id;

    private List<int> list_need_item_count;
}
