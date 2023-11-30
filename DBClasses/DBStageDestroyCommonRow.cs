public class DBStageDestroyCommonRow : ITableRowIndexer
{
    public int BossId
    {
        get
        {
            return boss_id;
        }
    }

    public int TeamIndex
    {
        get
        {
            return team_index;
        }
    }

    public int ChangeHellTeamIndex
    {
        get
        {
            return change_hell_team_index;
        }
    }

    public int EventType
    {
        get
        {
            return event_type;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public int RepulseDropItemId
    {
        get
        {
            return repulse_drop_item_id;
        }
    }

    public int RepulseDropItemValue
    {
        get
        {
            return repulse_drop_item_value;
        }
    }

    public int RepulseDropItemBox
    {
        get
        {
            return repulse_drop_item_box;
        }
    }

    public int AddRepulseDropItemId
    {
        get
        {
            return add_repulse_drop_item_id;
        }
    }

    public int AddRepulseDropItemValue
    {
        get
        {
            return add_repulse_drop_item_value;
        }
    }

    public int AddRepulseDropItemBox
    {
        get
        {
            return add_repulse_drop_item_box;
        }
    }

    public int StartCut
    {
        get
        {
            return start_cut;
        }
    }

    public float ModelScale
    {
        get
        {
            return model_scale;
        }
    }

    public float MonsterInfoLocationX
    {
        get
        {
            return monster_info_location_x;
        }
    }

    public float MonsterInfoLocationY
    {
        get
        {
            return monster_info_location_y;
        }
    }

    public string UIDestroyLiveJoinBtnLink
    {
        get
        {
            return UI_destroy_live_join_btn_link;
        }
    }

    public string UIDestroyLiveJoinBtnFile
    {
        get
        {
            return UI_destroy_live_join_btn_file;
        }
    }

    public int DestroyOnestepClear
    {
        get
        {
            return destroy_onestep_clear;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        boss_id = reader.ReadInt32();
        team_index = reader.ReadInt32();
        change_hell_team_index = reader.ReadInt32();
        event_type = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        repulse_drop_item_id = reader.ReadInt32();
        repulse_drop_item_value = reader.ReadInt32();
        repulse_drop_item_box = reader.ReadInt32();
        add_repulse_drop_item_id = reader.ReadInt32();
        add_repulse_drop_item_value = reader.ReadInt32();
        add_repulse_drop_item_box = reader.ReadInt32();
        start_cut = reader.ReadInt32();
        model_scale = reader.ReadSingle();
        monster_info_location_x = reader.ReadSingle();
        monster_info_location_y = reader.ReadSingle();
        UI_destroy_live_join_btn_link = reader.ReadString();
        UI_destroy_live_join_btn_file = reader.ReadString();
        destroy_onestep_clear = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return BossId;
    }

    private int boss_id;

    private int team_index;

    private int change_hell_team_index;

    private int event_type;

    private int event_sub_index;

    private int repulse_drop_item_id;

    private int repulse_drop_item_value;

    private int repulse_drop_item_box;

    private int add_repulse_drop_item_id;

    private int add_repulse_drop_item_value;

    private int add_repulse_drop_item_box;

    private int start_cut;

    private float model_scale;

    private float monster_info_location_x;

    private float monster_info_location_y;

    private string UI_destroy_live_join_btn_link;

    private string UI_destroy_live_join_btn_file;

    private int destroy_onestep_clear;
}
