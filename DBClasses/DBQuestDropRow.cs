public class DBQuestDropRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int QuestId
    {
        get
        {
            return quest_id;
        }
    }

    public int PropIndex
    {
        get
        {
            return prop_index;
        }
    }

    public string StageType
    {
        get
        {
            return stage_type;
        }
    }

    public int DropMonsterId
    {
        get
        {
            return drop_monster_id;
        }
    }

    public int DropItemId
    {
        get
        {
            return drop_item_id;
        }
    }

    public int DropPercent
    {
        get
        {
            return drop_percent;
        }
    }

    public int DropCountMin
    {
        get
        {
            return drop_count_min;
        }
    }

    public int DropCountMax
    {
        get
        {
            return drop_count_max;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        quest_id = reader.ReadInt32();
        prop_index = reader.ReadInt32();
        stage_type = reader.ReadString();
        drop_monster_id = reader.ReadInt32();
        drop_item_id = reader.ReadInt32();
        drop_percent = reader.ReadInt32();
        drop_count_min = reader.ReadInt32();
        drop_count_max = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int quest_id;

    private int prop_index;

    private string stage_type;

    private int drop_monster_id;

    private int drop_item_id;

    private int drop_percent;

    private int drop_count_min;

    private int drop_count_max;
}
