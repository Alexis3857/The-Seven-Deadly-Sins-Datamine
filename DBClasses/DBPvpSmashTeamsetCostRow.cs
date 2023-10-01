public class DBPvpSmashTeamsetCostRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int TeamSetAmount
    {
        get
        {
            return team_set_amount;
        }
    }

    public int NeedItemId
    {
        get
        {
            return need_item_id;
        }
    }

    public int NeedItemCount
    {
        get
        {
            return need_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        team_set_amount = reader.ReadInt32();
        need_item_id = reader.ReadInt32();
        need_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int team_set_amount;

    private int need_item_id;

    private int need_item_count;
}
