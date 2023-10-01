public class DBEventBalloondartScoreRow : ITableRowIndexer
{
    public int Id => id;

    public int RewardGroup => reward_group;

    public int RewardOrder => reward_order;

    public int ScoreItemId => score_item_id;

    public int ScoreItemCount => score_item_count;

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        reward_group = reader.ReadInt32();
        reward_order = reader.ReadInt32();
        score_item_id = reader.ReadInt32();
        score_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int reward_group;

    private int reward_order;

    private int score_item_id;

    private int score_item_count;
}