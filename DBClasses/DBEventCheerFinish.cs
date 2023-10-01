public class DBEventCheerFinishRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int SubIndex
    {
        get
        {
            return sub_index;
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

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        sub_index = reader.ReadInt32();
        item_id_1 = reader.ReadInt32();
        item_count_1 = reader.ReadInt32();
        item_id_2 = reader.ReadInt32();
        item_count_2 = reader.ReadInt32();
        item_id_3 = reader.ReadInt32();
        item_count_3 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int sub_index;

    private int item_id_1;

    private int item_count_1;

    private int item_id_2;

    private int item_count_2;

    private int item_id_3;

    private int item_count_3;
}
