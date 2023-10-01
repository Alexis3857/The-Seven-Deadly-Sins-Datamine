public class DBChapterRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ChapterGroup
    {
        get
        {
            return chapter_group;
        }
    }

    public string ChapterTitleInfo
    {
        get
        {
            return chapter_title_info.Localize();
        }
    }

    public string ChapterName
    {
        get
        {
            return chapter_name.Localize();
        }
    }

    public string ChapterResource
    {
        get
        {
            return chapter_resource;
        }
    }

    public string ChapterType
    {
        get
        {
            return chapter_type;
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

    public int MatchingId
    {
        get
        {
            return matching_id;
        }
    }

    public int ChapterSeason
    {
        get
        {
            return chapter_season;
        }
    }

    public int MatchingRegion
    {
        get
        {
            return matching_region;
        }
    }

    public List<int> ListArrayMatchingIdLink
    {
        get
        {
            return list_array_matching_id_link;
        }
    }

    public int FirstMatchingArea
    {
        get
        {
            return first_matching_area;
        }
    }

    public int OpenMatchingArea
    {
        get
        {
            return open_matching_area;
        }
    }

    public int MoveMatchingArea
    {
        get
        {
            return move_matching_area;
        }
    }

    public int CapitalIconMatchingArea
    {
        get
        {
            return capital_icon_matching_area;
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

    public int ChapterClearIndex
    {
        get
        {
            return chapter_clear_index;
        }
    }

    public int RewardItemId
    {
        get
        {
            return reward_item_id;
        }
    }

    public int RewardItemCount
    {
        get
        {
            return reward_item_count;
        }
    }

    public int RegionBgm
    {
        get
        {
            return region_bgm;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        chapter_group = reader.ReadInt32();
        chapter_title_info = reader.ReadInt32();
        chapter_name = reader.ReadInt32();
        chapter_resource = reader.ReadString();
        chapter_type = reader.ReadString();
        blind_open_type = reader.ReadString();
        blind_open_value = reader.ReadInt32();
        matching_id = reader.ReadInt32();
        chapter_season = reader.ReadInt32();
        matching_region = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_matching_id_link = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_matching_id_link.Add(reader.ReadInt32());
        }
        first_matching_area = reader.ReadInt32();
        open_matching_area = reader.ReadInt32();
        move_matching_area = reader.ReadInt32();
        capital_icon_matching_area = reader.ReadInt32();
        open_type = reader.ReadString();
        open_value = reader.ReadInt32();
        close_type = reader.ReadString();
        close_value = reader.ReadInt32();
        chapter_clear_index = reader.ReadInt32();
        reward_item_id = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        region_bgm = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int chapter_group;

    private int chapter_title_info;

    private int chapter_name;

    private string chapter_resource;

    private string chapter_type;

    private string blind_open_type;

    private int blind_open_value;

    private int matching_id;

    private int chapter_season;

    private int matching_region;

    private List<int> list_array_matching_id_link;

    private int first_matching_area;

    private int open_matching_area;

    private int move_matching_area;

    private int capital_icon_matching_area;

    private string open_type;

    private int open_value;

    private string close_type;

    private int close_value;

    private int chapter_clear_index;

    private int reward_item_id;

    private int reward_item_count;

    private int region_bgm;
}
