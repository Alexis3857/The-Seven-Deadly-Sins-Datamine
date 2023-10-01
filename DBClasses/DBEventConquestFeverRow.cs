public class DBEventConquestFeverRow : ITableRowIndexer
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

    public string CutInBase
    {
        get
        {
            return cut_in_base;
        }
    }

    public string CutInPortrait
    {
        get
        {
            return cut_in_portrait;
        }
    }

    public int FeverItemId
    {
        get
        {
            return fever_item_id;
        }
    }

    public int FeverItemCount
    {
        get
        {
            return fever_item_count;
        }
    }

    public int FeverAtk
    {
        get
        {
            return fever_atk;
        }
    }

    public int ReplaceFeverItemId1
    {
        get
        {
            return replace_fever_item_id_1;
        }
    }

    public int ReplaceFeverItemCount1
    {
        get
        {
            return replace_fever_item_count_1;
        }
    }

    public int ReplaceFeverItemId2
    {
        get
        {
            return replace_fever_item_id_2;
        }
    }

    public int ReplaceFeverItemCount2
    {
        get
        {
            return replace_fever_item_count_2;
        }
    }

    public int ReplaceFeverItemId3
    {
        get
        {
            return replace_fever_item_id_3;
        }
    }

    public int ReplaceFeverItemCount3
    {
        get
        {
            return replace_fever_item_count_3;
        }
    }

    public int ReplaceFeverItemId4
    {
        get
        {
            return replace_fever_item_id_4;
        }
    }

    public int ReplaceFeverItemCount4
    {
        get
        {
            return replace_fever_item_count_4;
        }
    }

    public List<int> ListReplaceFeverItemId
    {
        get
        {
            if (list_replace_fever_item_id == null)
            {
                list_replace_fever_item_id = new List<int>
                {
                    replace_fever_item_id_1,
                    replace_fever_item_id_2,
                    replace_fever_item_id_3,
                    replace_fever_item_id_4
                };
            }
            return list_replace_fever_item_id;
        }
    }

    public List<int> ListReplaceFeverItemCount
    {
        get
        {
            if (list_replace_fever_item == null)
            {
                list_replace_fever_item = new List<int>
                {
                    replace_fever_item_count_1,
                    replace_fever_item_count_2,
                    replace_fever_item_count_3,
                    replace_fever_item_count_4
                };
            }
            return list_replace_fever_item;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        cut_in_base = reader.ReadString();
        cut_in_portrait = reader.ReadString();
        fever_item_id = reader.ReadInt32();
        fever_item_count = reader.ReadInt32();
        fever_atk = reader.ReadInt32();
        replace_fever_item_id_1 = reader.ReadInt32();
        replace_fever_item_count_1 = reader.ReadInt32();
        replace_fever_item_id_2 = reader.ReadInt32();
        replace_fever_item_count_2 = reader.ReadInt32();
        replace_fever_item_id_3 = reader.ReadInt32();
        replace_fever_item_count_3 = reader.ReadInt32();
        replace_fever_item_id_4 = reader.ReadInt32();
        replace_fever_item_count_4 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private string cut_in_base;

    private string cut_in_portrait;

    private int fever_item_id;

    private int fever_item_count;

    private int fever_atk;

    private int replace_fever_item_id_1;

    private int replace_fever_item_count_1;

    private int replace_fever_item_id_2;

    private int replace_fever_item_count_2;

    private int replace_fever_item_id_3;

    private int replace_fever_item_count_3;

    private int replace_fever_item_id_4;

    private int replace_fever_item_count_4;

    private List<int> list_replace_fever_item_id;

    private List<int> list_replace_fever_item;
}
