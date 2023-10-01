public class DBContentsPassiveRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int RewardMark
    {
        get
        {
            return reward_mark;
        }
    }

    public string Icon
    {
        get
        {
            return icon;
        }
    }

    public string Name
    {
        get
        {
            return name.Localize();
        }
    }

    public string Explain
    {
        get
        {
            return explain.Localize();
        }
    }

    public string ExplainGuest
    {
        get
        {
            return explain_guest.Localize();
        }
    }

    public string EffectKeyword
    {
        get
        {
            return effect_keyword;
        }
    }

    public int EffectPer
    {
        get
        {
            return effect_per;
        }
    }

    public int UseTimeMin
    {
        get
        {
            return use_time_min;
        }
    }

    public int TargetItemId
    {
        get
        {
            return target_item_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        reward_mark = reader.ReadInt32();
        icon = reader.ReadString();
        name = reader.ReadInt32();
        explain = reader.ReadInt32();
        explain_guest = reader.ReadInt32();
        effect_keyword = reader.ReadString();
        effect_per = reader.ReadInt32();
        use_time_min = reader.ReadInt32();
        target_item_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int reward_mark;

    private string icon;

    private int name;

    private int explain;

    private int explain_guest;

    private string effect_keyword;

    private int effect_per;

    private int use_time_min;

    private int target_item_id;
}
