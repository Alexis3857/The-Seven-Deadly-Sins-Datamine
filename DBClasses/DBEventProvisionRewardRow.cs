public class DBEventProvisionRewardRow : ITableRowIndexer
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

    public string RewardType
    {
        get
        {
            return reward_type;
        }
    }

    public int RefItemId
    {
        get
        {
            return ref_item_id;
        }
    }

    public int RefSectionId
    {
        get
        {
            return ref_section_id;
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

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        reward_type = reader.ReadString();
        ref_item_id = reader.ReadInt32();
        ref_section_id = reader.ReadInt32();
        reward_item_id = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private string reward_type;

    private int ref_item_id;

    private int ref_section_id;

    private int reward_item_id;

    private int reward_item_count;
}
