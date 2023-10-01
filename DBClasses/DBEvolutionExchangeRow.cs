public class DBEvolutionExchangeRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ItemId
    {
        get
        {
            return item_id;
        }
    }

    public int NeedItemNumber
    {
        get
        {
            return need_item_number;
        }
    }

    public int ExchangeItemId1
    {
        get
        {
            return exchange_item_id_1;
        }
    }

    public int ExchangeItemId2
    {
        get
        {
            return exchange_item_id_2;
        }
    }

    public int ExchangeItemId3
    {
        get
        {
            return exchange_item_id_3;
        }
    }

    public List<int> ListExchangeItemId
    {
        get
        {
            if (list_exchange_item_id == null)
            {
                list_exchange_item_id = new List<int>
                {
                    ExchangeItemId1,
                    ExchangeItemId2,
                    ExchangeItemId3
                };
            }
            return list_exchange_item_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        item_id = reader.ReadInt32();
        need_item_number = reader.ReadInt32();
        exchange_item_id_1 = reader.ReadInt32();
        exchange_item_id_2 = reader.ReadInt32();
        exchange_item_id_3 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int item_id;

    private int need_item_number;

    private int exchange_item_id_1;

    private int exchange_item_id_2;

    private int exchange_item_id_3;

    private List<int> list_exchange_item_id;
}
