public class DBRestBonusRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int BonusItemId1
    {
        get
        {
            return bonus_item_id_1;
        }
    }

    public int BonusItemCount1
    {
        get
        {
            return bonus_item_count_1;
        }
    }

    public int BonusItemId2
    {
        get
        {
            return bonus_item_id_2;
        }
    }

    public int BonusItemCount2
    {
        get
        {
            return bonus_item_count_2;
        }
    }

    public int BonusItemId3
    {
        get
        {
            return bonus_item_id_3;
        }
    }

    public int BonusItemCount3
    {
        get
        {
            return bonus_item_count_3;
        }
    }

    public List<int> ListBonusItemId
    {
        get
        {
            if (list_bonus_item_id == null)
            {
                list_bonus_item_id = new List<int>
                {
                    BonusItemId1,
                    BonusItemId2,
                    BonusItemId3
                };
            }
            return list_bonus_item_id;
        }
    }

    public List<int> ListBonusItemCount
    {
        get
        {
            if (list_bonus_item_count == null)
            {
                list_bonus_item_count = new List<int>
                {
                    BonusItemCount1,
                    BonusItemCount2,
                    BonusItemCount3
                };
            }
            return list_bonus_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        bonus_item_id_1 = reader.ReadInt32();
        bonus_item_count_1 = reader.ReadInt32();
        bonus_item_id_2 = reader.ReadInt32();
        bonus_item_count_2 = reader.ReadInt32();
        bonus_item_id_3 = reader.ReadInt32();
        bonus_item_count_3 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int bonus_item_id_1;

    private int bonus_item_count_1;

    private int bonus_item_id_2;

    private int bonus_item_count_2;

    private int bonus_item_id_3;

    private int bonus_item_count_3;

    private List<int> list_bonus_item_id;

    private List<int> list_bonus_item_count;
}
