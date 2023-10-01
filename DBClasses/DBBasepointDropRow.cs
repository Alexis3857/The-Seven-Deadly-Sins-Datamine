public class DBBasepointDropRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int DropNpcId
    {
        get
        {
            return drop_npc_id;
        }
    }

    public int BoxSpawnMin
    {
        get
        {
            return box_spawn_min;
        }
    }

    public string DropType
    {
        get
        {
            return drop_type;
        }
    }

    public int DropPercent1
    {
        get
        {
            return drop_percent_1;
        }
    }

    public int DropItemId1
    {
        get
        {
            return drop_item_id_1;
        }
    }

    public int DropCountMin1
    {
        get
        {
            return drop_count_min_1;
        }
    }

    public int DropCountMax1
    {
        get
        {
            return drop_count_max_1;
        }
    }

    public int DropPercent2
    {
        get
        {
            return drop_percent_2;
        }
    }

    public int DropItemId2
    {
        get
        {
            return drop_item_id_2;
        }
    }

    public int DropCountMin2
    {
        get
        {
            return drop_count_min_2;
        }
    }

    public int DropCountMax2
    {
        get
        {
            return drop_count_max_2;
        }
    }

    public int DropPercent3
    {
        get
        {
            return drop_percent_3;
        }
    }

    public int DropItemId3
    {
        get
        {
            return drop_item_id_3;
        }
    }

    public int DropCountMin3
    {
        get
        {
            return drop_count_min_3;
        }
    }

    public int DropCountMax3
    {
        get
        {
            return drop_count_max_3;
        }
    }

    public List<int> ListDropPercent
    {
        get
        {
            if (list_drop_percent == null)
            {
                list_drop_percent = new List<int>
                {
                    DropPercent1,
                    DropPercent2,
                    DropPercent3
                };
            }
            return list_drop_percent;
        }
    }

    public List<int> ListDropItemId
    {
        get
        {
            if (list_drop_item_id == null)
            {
                list_drop_item_id = new List<int>
                {
                    DropItemId1,
                    DropItemId2,
                    DropItemId3
                };
            }
            return list_drop_item_id;
        }
    }

    public List<int> ListDropCountMin
    {
        get
        {
            if (list_drop_count_min == null)
            {
                list_drop_count_min = new List<int>
                {
                    DropCountMin1,
                    DropCountMin2,
                    DropCountMin3
                };
            }
            return list_drop_count_min;
        }
    }

    public List<int> ListDropCountMax
    {
        get
        {
            if (list_drop_count_max == null)
            {
                list_drop_count_max = new List<int>
                {
                    DropCountMax1,
                    DropCountMax2,
                    DropCountMax3
                };
            }
            return list_drop_count_max;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        drop_npc_id = reader.ReadInt32();
        box_spawn_min = reader.ReadInt32();
        drop_type = reader.ReadString();
        drop_percent_1 = reader.ReadInt32();
        drop_item_id_1 = reader.ReadInt32();
        drop_count_min_1 = reader.ReadInt32();
        drop_count_max_1 = reader.ReadInt32();
        drop_percent_2 = reader.ReadInt32();
        drop_item_id_2 = reader.ReadInt32();
        drop_count_min_2 = reader.ReadInt32();
        drop_count_max_2 = reader.ReadInt32();
        drop_percent_3 = reader.ReadInt32();
        drop_item_id_3 = reader.ReadInt32();
        drop_count_min_3 = reader.ReadInt32();
        drop_count_max_3 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int drop_npc_id;

    private int box_spawn_min;

    private string drop_type;

    private int drop_percent_1;

    private int drop_item_id_1;

    private int drop_count_min_1;

    private int drop_count_max_1;

    private int drop_percent_2;

    private int drop_item_id_2;

    private int drop_count_min_2;

    private int drop_count_max_2;

    private int drop_percent_3;

    private int drop_item_id_3;

    private int drop_count_min_3;

    private int drop_count_max_3;

    private List<int> list_drop_percent;

    private List<int> list_drop_item_id;

    private List<int> list_drop_count_min;

    private List<int> list_drop_count_max;
}
