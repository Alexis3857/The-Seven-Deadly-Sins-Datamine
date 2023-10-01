public class DBLobbyNpcRewardRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int HeroId
    {
        get
        {
            return hero_id;
        }
    }

    public int Level
    {
        get
        {
            return level;
        }
    }

    public string RewardType
    {
        get
        {
            return reward_type;
        }
    }

    public int RewardIndex
    {
        get
        {
            return reward_index;
        }
    }

    public string RewardIcon
    {
        get
        {
            return reward_icon;
        }
    }

    public string RewardTitle
    {
        get
        {
            return reward_title.Localize();
        }
    }

    public string RewardDesc
    {
        get
        {
            return reward_desc.Localize();
        }
    }

    public string DetailRewardDesc
    {
        get
        {
            return detail_reward_desc.Localize();
        }
    }

    public List<int> ListArraySoundId
    {
        get
        {
            return list_array_sound_id;
        }
    }

    public string Illust
    {
        get
        {
            return illust;
        }
    }

    public int RewardItem
    {
        get
        {
            return reward_item;
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
        hero_id = reader.ReadInt32();
        level = reader.ReadInt32();
        reward_type = reader.ReadString();
        reward_index = reader.ReadInt32();
        reward_icon = reader.ReadString();
        reward_title = reader.ReadInt32();
        reward_desc = reader.ReadInt32();
        detail_reward_desc = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_sound_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_sound_id.Add(reader.ReadInt32());
        }
        illust = reader.ReadString();
        reward_item = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int hero_id;

    private int level;

    private string reward_type;

    private int reward_index;

    private string reward_icon;

    private int reward_title;

    private int reward_desc;

    private int detail_reward_desc;

    private List<int> list_array_sound_id;

    private string illust;

    private int reward_item;

    private int reward_item_count;
}
