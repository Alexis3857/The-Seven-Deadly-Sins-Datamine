public class DBAreaRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int Region
    {
        get
        {
            return region;
        }
    }

    public int Area
    {
        get
        {
            return area;
        }
    }

    public int Side
    {
        get
        {
            return side;
        }
    }

    public int IndexBasepoint
    {
        get
        {
            return index_basepoint;
        }
    }

    public string AreaName
    {
        get
        {
            return area_name.Localize();
        }
    }

    public string AreaType
    {
        get
        {
            return area_type;
        }
    }

    public int BasepointInfoUiindex
    {
        get
        {
            return basepoint_Info_UIIndex;
        }
    }

    public List<int> ListArrayExtraGroupId
    {
        get
        {
            return list_array_extra_group_id;
        }
    }

    public int EndExtraGroupId
    {
        get
        {
            return end_extra_group_id;
        }
    }

    public int WarpRegionId
    {
        get
        {
            return warp_region_id;
        }
    }

    public int WarpAreaIndex
    {
        get
        {
            return warp_area_index;
        }
    }

    public string AreaIcon
    {
        get
        {
            return area_icon;
        }
    }

    public int AreaLargeIcon
    {
        get
        {
            return area_large_icon;
        }
    }

    public string ChangeAreaIcon
    {
        get
        {
            return change_area_icon;
        }
    }

    public string ChangeAreaName
    {
        get
        {
            return change_area_name.Localize();
        }
    }

    public int ChangeQuestId
    {
        get
        {
            return change_quest_id;
        }
    }

    public string MapResourcePath
    {
        get
        {
            return map_resource_path;
        }
    }

    public string MapResource
    {
        get
        {
            return map_resource;
        }
    }

    public string ChangeMapResource
    {
        get
        {
            return change_map_resource;
        }
    }

    public int GroupClearStageId
    {
        get
        {
            return group_clear_stage_id;
        }
    }

    public int NeedStartQuestId
    {
        get
        {
            return need_start_quest_id;
        }
    }

    public int NeedEndQuestId
    {
        get
        {
            return need_end_quest_id;
        }
    }

    public int NeedBaseFellowId
    {
        get
        {
            return need_base_fellow_id;
        }
    }

    public int NeedBaseFellowLevel
    {
        get
        {
            return need_base_fellow_level;
        }
    }

    public int PlayQuestId
    {
        get
        {
            return play_quest_id;
        }
    }

    public int NeedStartItemId
    {
        get
        {
            return need_start_item_id;
        }
    }

    public string AreaOpenNotice
    {
        get
        {
            return area_open_notice.Localize();
        }
    }

    public int NeedStageSide
    {
        get
        {
            return need_stage_side;
        }
    }

    public int NeedAreaId
    {
        get
        {
            return need_area_id;
        }
    }

    public int NeedStageId
    {
        get
        {
            return need_stage_id;
        }
    }

    public int StartStoryCut
    {
        get
        {
            return start_story_cut;
        }
    }

    public int ChangeStoryCut
    {
        get
        {
            return change_story_cut;
        }
    }

    public int EndStoryCut
    {
        get
        {
            return end_story_cut;
        }
    }

    public int EndAcquireStoryCut
    {
        get
        {
            return end_acquire_story_cut;
        }
    }

    public int BeforeLoadingTip
    {
        get
        {
            return before_loading_tip;
        }
    }

    public int AfterLoadingTip
    {
        get
        {
            return after_loading_tip;
        }
    }

    public string TownEmblem
    {
        get
        {
            return town_emblem;
        }
    }

    public int BasepointFellowOpen
    {
        get
        {
            return basepoint_fellow_open;
        }
    }

    public string TownMinimapResource
    {
        get
        {
            return town_minimap_resource;
        }
    }

    public int RootBasepointId
    {
        get
        {
            return root_basepoint_id;
        }
    }

    public int BgmSoundId
    {
        get
        {
            return bgm_sound_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        region = reader.ReadInt32();
        area = reader.ReadInt32();
        side = reader.ReadInt32();
        index_basepoint = reader.ReadInt32();
        area_name = reader.ReadInt32();
        area_type = reader.ReadString();
        basepoint_Info_UIIndex = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_extra_group_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_extra_group_id.Add(reader.ReadInt32());
        }
        end_extra_group_id = reader.ReadInt32();
        warp_region_id = reader.ReadInt32();
        warp_area_index = reader.ReadInt32();
        area_icon = reader.ReadString();
        area_large_icon = reader.ReadInt32();
        change_area_icon = reader.ReadString();
        change_area_name = reader.ReadInt32();
        change_quest_id = reader.ReadInt32();
        map_resource_path = reader.ReadString();
        map_resource = reader.ReadString();
        change_map_resource = reader.ReadString();
        group_clear_stage_id = reader.ReadInt32();
        need_start_quest_id = reader.ReadInt32();
        need_end_quest_id = reader.ReadInt32();
        need_base_fellow_id = reader.ReadInt32();
        need_base_fellow_level = reader.ReadInt32();
        play_quest_id = reader.ReadInt32();
        need_start_item_id = reader.ReadInt32();
        area_open_notice = reader.ReadInt32();
        need_stage_side = reader.ReadInt32();
        need_area_id = reader.ReadInt32();
        need_stage_id = reader.ReadInt32();
        start_story_cut = reader.ReadInt32();
        change_story_cut = reader.ReadInt32();
        end_story_cut = reader.ReadInt32();
        end_acquire_story_cut = reader.ReadInt32();
        before_loading_tip = reader.ReadInt32();
        after_loading_tip = reader.ReadInt32();
        town_emblem = reader.ReadString();
        basepoint_fellow_open = reader.ReadInt32();
        town_minimap_resource = reader.ReadString();
        root_basepoint_id = reader.ReadInt32();
        bgm_sound_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int region;

    private int area;

    private int side;

    private int index_basepoint;

    private int area_name;

    private string area_type;

    private int basepoint_Info_UIIndex;

    private List<int> list_array_extra_group_id;

    private int end_extra_group_id;

    private int warp_region_id;

    private int warp_area_index;

    private string area_icon;

    private int area_large_icon;

    private string change_area_icon;

    private int change_area_name;

    private int change_quest_id;

    private string map_resource_path;

    private string map_resource;

    private string change_map_resource;

    private int group_clear_stage_id;

    private int need_start_quest_id;

    private int need_end_quest_id;

    private int need_base_fellow_id;

    private int need_base_fellow_level;

    private int play_quest_id;

    private int need_start_item_id;

    private int area_open_notice;

    private int need_stage_side;

    private int need_area_id;

    private int need_stage_id;

    private int start_story_cut;

    private int change_story_cut;

    private int end_story_cut;

    private int end_acquire_story_cut;

    private int before_loading_tip;

    private int after_loading_tip;

    private string town_emblem;

    private int basepoint_fellow_open;

    private string town_minimap_resource;

    private int root_basepoint_id;

    private int bgm_sound_id;
}
