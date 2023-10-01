public class DBCostumeCraftRow : ITableRowIndexer
{
    public int CostumeId
    {
        get
        {
            return costume_id;
        }
    }

    public List<int> ListArrayCreatureNestBossGroup
    {
        get
        {
            return list_array_creaturenest_boss_group;
        }
    }

    public int NeedGoldId
    {
        get
        {
            return need_gold_id;
        }
    }

    public int NeedGold
    {
        get
        {
            return need_gold;
        }
    }

    public int NeedItem1
    {
        get
        {
            return need_item_1;
        }
    }

    public int NeedItemCount1
    {
        get
        {
            return need_item_count_1;
        }
    }

    public int NeedItem2
    {
        get
        {
            return need_item_2;
        }
    }

    public int NeedItemCount2
    {
        get
        {
            return need_item_count_2;
        }
    }

    public int NeedItem3
    {
        get
        {
            return need_item_3;
        }
    }

    public int NeedItemCount3
    {
        get
        {
            return need_item_count_3;
        }
    }

    public int NeedItem4
    {
        get
        {
            return need_item_4;
        }
    }

    public int NeedItemCount4
    {
        get
        {
            return need_item_count_4;
        }
    }

    public List<int> ListNeedItem
    {
        get
        {
            if (list_need_item == null)
            {
                list_need_item = new List<int>
                {
                    NeedItem1,
                    NeedItem2,
                    NeedItem3,
                    NeedItem4
                };
            }
            return list_need_item;
        }
    }

    public List<int> ListNeedItemCount
    {
        get
        {
            if (list_need_item_count == null)
            {
                list_need_item_count = new List<int>
                {
                    NeedItemCount1,
                    NeedItemCount2,
                    NeedItemCount3,
                    NeedItemCount4
                };
            }
            return list_need_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        costume_id = reader.ReadInt32();
        list_array_creaturenest_boss_group = new List<int>();
        int num = reader.ReadInt32();
        for (int i = 0; i < num; i++)
        {
            list_array_creaturenest_boss_group.Add(reader.ReadInt32());
        }
        need_gold_id = reader.ReadInt32();
        need_gold = reader.ReadInt32();
        need_item_1 = reader.ReadInt32();
        need_item_count_1 = reader.ReadInt32();
        need_item_2 = reader.ReadInt32();
        need_item_count_2 = reader.ReadInt32();
        need_item_3 = reader.ReadInt32();
        need_item_count_3 = reader.ReadInt32();
        need_item_4 = reader.ReadInt32();
        need_item_count_4 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return CostumeId;
    }

    private int costume_id;

    private List<int> list_array_creaturenest_boss_group;

    private int need_gold_id;

    private int need_gold;

    private int need_item_1;

    private int need_item_count_1;

    private int need_item_2;

    private int need_item_count_2;

    private int need_item_3;

    private int need_item_count_3;

    private int need_item_4;

    private int need_item_count_4;

    private List<int> list_need_item;

    private List<int> list_need_item_count;
}
