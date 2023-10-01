public class DBGamblePaybackRow : ITableRowIndexer
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

    public List<int> ListArrayGambleGroup
    {
        get
        {
            return list_array_gamble_group;
        }
    }

    public int PaybackPointMax
    {
        get
        {
            return payback_point_max;
        }
    }

    public string PaybackTitleName
    {
        get
        {
            return payback_title_name;
        }
    }

    public string PaybackTitleProp
    {
        get
        {
            return payback_title_prop;
        }
    }

    public int RewardKeyItem
    {
        get
        {
            return reward_key_item;
        }
    }

    public int FeverTargetDisplayId
    {
        get
        {
            return fever_target_display_id;
        }
    }

    public int TargetDisplayId
    {
        get
        {
            return target_display_id;
        }
    }

    public int PaybackPointReset
    {
        get
        {
            return payback_point_reset;
        }
    }

    public int PaybackPointResetCount
    {
        get
        {
            return payback_point_reset_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_gamble_group = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_gamble_group.Add(reader.ReadInt32());
        }
        payback_point_max = reader.ReadInt32();
        payback_title_name = reader.ReadString();
        payback_title_prop = reader.ReadString();
        reward_key_item = reader.ReadInt32();
        fever_target_display_id = reader.ReadInt32();
        target_display_id = reader.ReadInt32();
        payback_point_reset = reader.ReadInt32();
        payback_point_reset_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private List<int> list_array_gamble_group;

    private int payback_point_max;

    private string payback_title_name;

    private string payback_title_prop;

    private int reward_key_item;

    private int fever_target_display_id;

    private int target_display_id;

    private int payback_point_reset;

    private int payback_point_reset_count;
}
