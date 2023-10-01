public class DBGrimBookContentRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int CategoryId
    {
        get
        {
            return category_id;
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

    public string ListName
    {
        get
        {
            return list_name;
        }
    }

    public int StoryCut
    {
        get
        {
            return story_cut;
        }
    }

    public int RewardIndex
    {
        get
        {
            return reward_index;
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
        category_id = reader.ReadInt32();
        open_type = reader.ReadString();
        open_value = reader.ReadInt32();
        list_name = reader.ReadString();
        story_cut = reader.ReadInt32();
        reward_index = reader.ReadInt32();
        reward_item_id = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int category_id;

    private string open_type;

    private int open_value;

    private string list_name;

    private int story_cut;

    private int reward_index;

    private int reward_item_id;

    private int reward_item_count;
}
