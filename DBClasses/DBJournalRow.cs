public class DBJournalRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string JournalName
    {
        get
        {
            return journal_name.Localize();
        }
    }

    public string JournalResource
    {
        get
        {
            return journal_resource;
        }
    }

    public int JournalTapIndex
    {
        get
        {
            return journal_tap_index;
        }
    }

    public string JournalType
    {
        get
        {
            return journal_type;
        }
    }

    public string JournalQuestClass
    {
        get
        {
            return journal_quest_class;
        }
    }

    public int JournalRootGroup
    {
        get
        {
            return journal_root_group;
        }
    }

    public int JournalValue
    {
        get
        {
            return journal_value;
        }
    }

    public int DisplayLinkId
    {
        get
        {
            return display_link_id;
        }
    }

    public string BlindOpenType
    {
        get
        {
            return blind_open_type;
        }
    }

    public int BlindOpenValue
    {
        get
        {
            return blind_open_value;
        }
    }

    public string CloseType
    {
        get
        {
            return close_type;
        }
    }

    public int CloseValue
    {
        get
        {
            return close_value;
        }
    }

    public int ChapterTotalRewardTab
    {
        get
        {
            return chapter_total_reward_tab;
        }
    }

    public List<int> ListArrayChapterTotalMainReward
    {
        get
        {
            return list_array_chapter_total_main_reward;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        journal_name = reader.ReadInt32();
        journal_resource = reader.ReadString();
        journal_tap_index = reader.ReadInt32();
        journal_type = reader.ReadString();
        journal_quest_class = reader.ReadString();
        journal_root_group = reader.ReadInt32();
        journal_value = reader.ReadInt32();
        display_link_id = reader.ReadInt32();
        blind_open_type = reader.ReadString();
        blind_open_value = reader.ReadInt32();
        close_type = reader.ReadString();
        close_value = reader.ReadInt32();
        chapter_total_reward_tab = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_chapter_total_main_reward = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_chapter_total_main_reward.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int journal_name;

    private string journal_resource;

    private int journal_tap_index;

    private string journal_type;

    private string journal_quest_class;

    private int journal_root_group;

    private int journal_value;

    private int display_link_id;

    private string blind_open_type;

    private int blind_open_value;

    private string close_type;

    private int close_value;

    private int chapter_total_reward_tab;

    private List<int> list_array_chapter_total_main_reward;
}
