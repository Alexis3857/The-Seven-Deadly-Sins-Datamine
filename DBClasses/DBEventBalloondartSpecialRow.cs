public class DBEventBalloondartSpecialRow : ITableRowIndexer
{
    public int Id => id;

    public int Stage => stage;

    public int RewardGroup => reward_group;

    public int ScoreItemId => score_item_id;

    public int ScoreItemCount => score_item_count;

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        stage = reader.ReadInt32();
        reward_group = reader.ReadInt32();
        score_item_id = reader.ReadInt32();
        score_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int stage;

    private int reward_group;

    private int score_item_id;

    private int score_item_count;
}