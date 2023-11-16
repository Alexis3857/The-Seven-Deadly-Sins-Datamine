public class DBHeroLeagueScoreRow : ITableRowIndexer
{
    public int Id => id;

    public int RewardIndex => reward_index;

    public int RewardScore => reward_score;

    public int RewardItemId => reward_item_id;

    public int RewardItemCount => reward_item_count;

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        reward_index = reader.ReadInt32();
        reward_score = reader.ReadInt32();
        reward_item_id = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int reward_index;

    private int reward_score;

    private int reward_item_id;

    private int reward_item_count;
}