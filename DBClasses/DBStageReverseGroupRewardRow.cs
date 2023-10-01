public class DBStageReverseGroupRewardRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int SeasonId
    {
        get
        {
            return season_id;
        }
    }

    public int ServerRewardIndex
    {
        get
        {
            return server_reward_index;
        }
    }

    public List<int> ListArrayGroupClearCheck
    {
        get
        {
            return list_array_group_clear_check;
        }
    }

    public int RewardId
    {
        get
        {
            return reward_id;
        }
    }

    public int RewardValue
    {
        get
        {
            return reward_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        season_id = reader.ReadInt32();
        server_reward_index = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_group_clear_check = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_group_clear_check.Add(reader.ReadInt32());
        }
        reward_id = reader.ReadInt32();
        reward_value = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int season_id;

    private int server_reward_index;

    private List<int> list_array_group_clear_check;

    private int reward_id;

    private int reward_value;
}
