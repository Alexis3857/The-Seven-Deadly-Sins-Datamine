public class DBInteractiveVrRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string ObjectName
    {
        get
        {
            return object_name;
        }
    }

    public int Floor
    {
        get
        {
            return floor;
        }
    }

    public int NeedItem
    {
        get
        {
            return need_item;
        }
    }

    public int NeedItemCount
    {
        get
        {
            return need_item_count;
        }
    }

    public int RewardPer
    {
        get
        {
            return reward_per;
        }
    }

    public int RewardGroupId
    {
        get
        {
            return reward_group_id;
        }
    }

    public string Effect
    {
        get
        {
            return effect;
        }
    }

    public int SoundEffect
    {
        get
        {
            return sound_effect;
        }
    }

    public string TextEffect
    {
        get
        {
            return text_effect.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        object_name = reader.ReadString();
        floor = reader.ReadInt32();
        need_item = reader.ReadInt32();
        need_item_count = reader.ReadInt32();
        reward_per = reader.ReadInt32();
        reward_group_id = reader.ReadInt32();
        effect = reader.ReadString();
        sound_effect = reader.ReadInt32();
        text_effect = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string object_name;

    private int floor;

    private int need_item;

    private int need_item_count;

    private int reward_per;

    private int reward_group_id;

    private string effect;

    private int sound_effect;

    private int text_effect;
}
