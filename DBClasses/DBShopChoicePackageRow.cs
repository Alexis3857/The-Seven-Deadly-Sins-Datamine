public class DBShopChoicePackageRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ChoiceGroup
    {
        get
        {
            return choice_group;
        }
    }

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public int ItemId1
    {
        get
        {
            return item_id_1;
        }
    }

    public int ItemCount1
    {
        get
        {
            return item_count_1;
        }
    }

    public int ItemId2
    {
        get
        {
            return item_id_2;
        }
    }

    public int ItemCount2
    {
        get
        {
            return item_count_2;
        }
    }

    public int ItemId3
    {
        get
        {
            return item_id_3;
        }
    }

    public int ItemCount3
    {
        get
        {
            return item_count_3;
        }
    }

    public int ItemId4
    {
        get
        {
            return item_id_4;
        }
    }

    public int ItemCount4
    {
        get
        {
            return item_count_4;
        }
    }

    public int ItemId5
    {
        get
        {
            return item_id_5;
        }
    }

    public int ItemCount5
    {
        get
        {
            return item_count_5;
        }
    }

    public int ItemId6
    {
        get
        {
            return item_id_6;
        }
    }

    public int ItemCount6
    {
        get
        {
            return item_count_6;
        }
    }

    public int ItemId7
    {
        get
        {
            return item_id_7;
        }
    }

    public int ItemCount7
    {
        get
        {
            return item_count_7;
        }
    }

    public int ItemId8
    {
        get
        {
            return item_id_8;
        }
    }

    public int ItemCount8
    {
        get
        {
            return item_count_8;
        }
    }

    public List<int> ListItemId
    {
        get
        {
            if (list_item_id == null)
            {
                list_item_id = new List<int>
                {
                    ItemId1,
                    ItemId2,
                    ItemId3,
                    ItemId4,
                    ItemId5,
                    ItemId6,
                    ItemId7,
                    ItemId8
                };
            }
            return list_item_id;
        }
    }

    public List<int> ListItemCount
    {
        get
        {
            if (list_item_count == null)
            {
                list_item_count = new List<int>
                {
                    ItemCount1,
                    ItemCount2,
                    ItemCount3,
                    ItemCount4,
                    ItemCount5,
                    ItemCount6,
                    ItemCount7,
                    ItemCount8
                };
            }
            return list_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        choice_group = reader.ReadInt32();
        group_id = reader.ReadInt32();
        item_id_1 = reader.ReadInt32();
        item_count_1 = reader.ReadInt32();
        item_id_2 = reader.ReadInt32();
        item_count_2 = reader.ReadInt32();
        item_id_3 = reader.ReadInt32();
        item_count_3 = reader.ReadInt32();
        item_id_4 = reader.ReadInt32();
        item_count_4 = reader.ReadInt32();
        item_id_5 = reader.ReadInt32();
        item_count_5 = reader.ReadInt32();
        item_id_6 = reader.ReadInt32();
        item_count_6 = reader.ReadInt32();
        item_id_7 = reader.ReadInt32();
        item_count_7 = reader.ReadInt32();
        item_id_8 = reader.ReadInt32();
        item_count_8 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int choice_group;

    private int group_id;

    private int item_id_1;

    private int item_count_1;

    private int item_id_2;

    private int item_count_2;

    private int item_id_3;

    private int item_count_3;

    private int item_id_4;

    private int item_count_4;

    private int item_id_5;

    private int item_count_5;

    private int item_id_6;

    private int item_count_6;

    private int item_id_7;

    private int item_count_7;

    private int item_id_8;

    private int item_count_8;

    private List<int> list_item_id;

    private List<int> list_item_count;
}
