public class DBNetmarbleRewardRow : ITableRowIndexer
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

    public int ItemCount
    {
        get
        {
            return item_count;
        }
    }

    public string NetmarbleRewardId
    {
        get
        {
            return netmarble_reward_id;
        }
    }

    public int ContentsType
    {
        get
        {
            return contents_type;
        }
    }

    public string GoodsName
    {
        get
        {
            return goods_name.Localize();
        }
    }

    public string GoodsExplain
    {
        get
        {
            return goods_explain.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        item_id = reader.ReadInt32();
        item_count = reader.ReadInt32();
        netmarble_reward_id = reader.ReadString();
        contents_type = reader.ReadInt32();
        goods_name = reader.ReadInt32();
        goods_explain = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int item_id;

    private int item_count;

    private string netmarble_reward_id;

    private int contents_type;

    private int goods_name;

    private int goods_explain;
}
