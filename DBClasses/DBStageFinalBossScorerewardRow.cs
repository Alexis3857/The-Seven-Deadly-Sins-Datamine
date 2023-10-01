public class DBStageFinalBossScorerewardRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int BossSettingId
    {
        get
        {
            return boss_setting_id;
        }
    }

    public int RewardOrder
    {
        get
        {
            return reward_order;
        }
    }

    public int RewardScore
    {
        get
        {
            return reward_score;
        }
    }

    public int RewardItemId
    {
        get
        {
            return reward_item_id;
        }
    }

    public int RewardItemCount
    {
        get
        {
            return reward_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        boss_setting_id = reader.ReadInt32();
        reward_order = reader.ReadInt32();
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

    private int boss_setting_id;

    private int reward_order;

    private int reward_score;

    private int reward_item_id;

    private int reward_item_count;
}
