public class DBPvpChaosRankRewardRow : ITableRowIndexer
{
    public int Id { get => id; }
    public int Season { get => season; }
    public string RankType { get => rank_type; }
    public int RankMin { get => rank_min; }
    public int RankMax { get => rank_max; }
    public string RankIcon { get => rank_icon; }
    public int RewardId1 { get => reward_id_1; }
    public int RewardCount1 { get => reward_count_1; }
    public int RewardId2 { get => reward_id_2; }
    public int RewardCount2 { get => reward_count_2; }
    public int RewardId3 { get => reward_id_3; }
    public int RewardCount3 { get => reward_count_3; }
    public List<int> ListRewardId
    {
        get
        {
            if (list_reward_id == null)
            {
                list_reward_id = new List<int>()
                {
                    RewardId1,
                    RewardId2,
                    RewardId3
                };
            }
            return list_reward_id;
        }
    }

    public List<int> ListRewardCount
    {
        get
        {
            if (list_reward_count == null)
            {
                list_reward_count = new List<int>()
                {
                    RewardCount1,
                    RewardCount2,
                    RewardCount3
                };
            }
            return list_reward_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        season = reader.ReadInt32();
        rank_type = reader.ReadString();
        rank_min = reader.ReadInt32();
        rank_max = reader.ReadInt32();
        rank_icon = reader.ReadString();
        reward_id_1 = reader.ReadInt32();
        reward_count_1 = reader.ReadInt32();
        reward_id_2 = reader.ReadInt32();
        reward_count_2 = reader.ReadInt32();
        reward_id_3 = reader.ReadInt32();
        reward_count_3 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int season;

    private string rank_type;

    private int rank_min;

    private int rank_max;

    private string rank_icon;

    private int reward_id_1;

    private int reward_count_1;

    private int reward_id_2;

    private int reward_count_2;

    private int reward_id_3;

    private int reward_count_3;

    private List<int> list_reward_id;

    private List<int> list_reward_count;
}