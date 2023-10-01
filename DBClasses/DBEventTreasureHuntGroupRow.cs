public class DBEventTreasureHuntGroupRow : ITableRowIndexer
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

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public int MapIndex
    {
        get
        {
            return map_index;
        }
    }

    public int RestartCount
    {
        get
        {
            return restart_count;
        }
    }

    public int RestartItemId
    {
        get
        {
            return restart_item_id;
        }
    }

    public int RestartItemCount
    {
        get
        {
            return restart_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        sub_index = reader.ReadInt32();
        group_id = reader.ReadInt32();
        map_index = reader.ReadInt32();
        restart_count = reader.ReadInt32();
        restart_item_id = reader.ReadInt32();
        restart_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int sub_index;

    private int group_id;

    private int map_index;

    private int restart_count;

    private int restart_item_id;

    private int restart_item_count;
}
