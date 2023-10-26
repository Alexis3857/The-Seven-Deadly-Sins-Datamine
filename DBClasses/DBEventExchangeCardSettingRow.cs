public class DBEventExchangeCardSettingRow : ITableRowIndexer
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

    public string EventPrefab
    {
        get
        {
            return event_prefab;
        }
    }

    public string EventNameLocalKey
    {
        get
        {
            return event_name_local_key;
        }
    }

    public int CardCount
    {
        get
        {
            return card_count;
        }
    }

    public int ListResetCount
    {
        get
        {
            return list_reset_count;
        }
    }

    public int GambleItemId
    {
        get
        {
            return gamble_item_id;
        }
    }

    public int GambleItemCount
    {
        get
        {
            return gamble_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        event_prefab = reader.ReadString();
        event_name_local_key = reader.ReadString();
        card_count = reader.ReadInt32();
        list_reset_count = reader.ReadInt32();
        gamble_item_id = reader.ReadInt32();
        gamble_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private string event_prefab;

    private string event_name_local_key;

    private int card_count;

    private int list_reset_count;

    private int gamble_item_id;

    private int gamble_item_count;
}
