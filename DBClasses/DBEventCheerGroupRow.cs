public class DBEventCheerGroupRow : ITableRowIndexer
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

    public string HeroName
    {
        get
        {
            return hero_name;
        }
    }

    public string StampItem
    {
        get
        {
            return stamp_item;
        }
    }

    public string CheerCompleteIcon
    {
        get
        {
            return cheer_complete_icon;
        }
    }

    public int RewardGroup
    {
        get
        {
            return reward_group;
        }
    }

    public int ExchangeLimit
    {
        get
        {
            return exchange_limit;
        }
    }

    public int ItemCheer
    {
        get
        {
            return item_cheer;
        }
    }
    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        hero_name = reader.ReadString();
        stamp_item = reader.ReadString();
        cheer_complete_icon = reader.ReadString();
        reward_group = reader.ReadInt32();
        exchange_limit = reader.ReadInt32();
        item_cheer = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private string hero_name;

    private string stamp_item;

    private string cheer_complete_icon;

    private int reward_group;

    private int exchange_limit;

    private int item_cheer;
}
