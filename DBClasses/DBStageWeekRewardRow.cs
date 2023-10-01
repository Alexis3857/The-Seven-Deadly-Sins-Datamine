public class DBStageWeekRewardRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string StageType
    {
        get
        {
            return stage_type;
        }
    }

    public int Group
    {
        get
        {
            return group;
        }
    }

    public int NeedExp
    {
        get
        {
            return need_exp;
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

    public List<int> ListItemId
    {
        get
        {
            if (list_item_id == null)
            {
                list_item_id = new List<int>
                {
                    ItemId1
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
                    ItemCount1
                };
            }
            return list_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        stage_type = reader.ReadString();
        group = reader.ReadInt32();
        need_exp = reader.ReadInt32();
        item_id_1 = reader.ReadInt32();
        item_count_1 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string stage_type;

    private int group;

    private int need_exp;

    private int item_id_1;

    private int item_count_1;

    private List<int> list_item_id;

    private List<int> list_item_count;
}
