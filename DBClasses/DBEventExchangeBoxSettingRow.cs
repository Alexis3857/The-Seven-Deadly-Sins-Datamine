public class DBEventExchangeBoxSettingRow : ITableRowIndexer
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

    public int GambleCount1
    {
        get
        {
            return gamble_count_1;
        }
    }

    public int GambleDiaId
    {
        get
        {
            return gamble_dia_id;
        }
    }

    public int GambleItemCount1
    {
        get
        {
            return gamble_item_count_1;
        }
    }

    public int GambleDiaCount1
    {
        get
        {
            return gamble_dia_count_1;
        }
    }

    public int GambleCount2
    {
        get
        {
            return gamble_count_2;
        }
    }

    public int GambleItemCount2
    {
        get
        {
            return gamble_item_count_2;
        }
    }

    public int GambleDiaCount2
    {
        get
        {
            return gamble_dia_count_2;
        }
    }

    public string EventStart
    {
        get
        {
            return event_start;
        }
    }

    public int EventReset
    {
        get
        {
            return event_reset;
        }
    }

    public List<int> ListGambleCount
    {
        get
        {
            if (list_gamble_count == null)
            {
                list_gamble_count = new List<int>
                {
                    GambleCount1,
                    GambleCount2
                };
            }
            return list_gamble_count;
        }
    }

    public List<int> ListGambleItemCount
    {
        get
        {
            if (list_gamble_item_count == null)
            {
                list_gamble_item_count = new List<int>
                {
                    GambleItemCount1,
                    GambleItemCount2
                };
            }
            return list_gamble_item_count;
        }
    }

    public List<int> ListGambleDiaCount
    {
        get
        {
            if (list_gamble_dia_count == null)
            {
                list_gamble_dia_count = new List<int>
                {
                    GambleDiaCount1,
                    GambleDiaCount2
                };
            }
            return list_gamble_dia_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        list_reset_count = reader.ReadInt32();
        gamble_item_id = reader.ReadInt32();
        gamble_count_1 = reader.ReadInt32();
        gamble_dia_id = reader.ReadInt32();
        gamble_item_count_1 = reader.ReadInt32();
        gamble_dia_count_1 = reader.ReadInt32();
        gamble_count_2 = reader.ReadInt32();
        gamble_item_count_2 = reader.ReadInt32();
        gamble_dia_count_2 = reader.ReadInt32();
        event_start = reader.ReadString();
        event_reset = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int list_reset_count;

    private int gamble_item_id;

    private int gamble_count_1;

    private int gamble_dia_id;

    private int gamble_item_count_1;

    private int gamble_dia_count_1;

    private int gamble_count_2;

    private int gamble_item_count_2;

    private int gamble_dia_count_2;

    private string event_start;

    private int event_reset;

    private List<int> list_gamble_count;

    private List<int> list_gamble_item_count;

    private List<int> list_gamble_dia_count;
}
