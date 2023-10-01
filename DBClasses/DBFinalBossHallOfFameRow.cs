public class DBFinalBossHallOfFameRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int HallOfFameDataId
    {
        get
        {
            return hall_of_fame_data_id;
        }
    }

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public string BossName
    {
        get
        {
            return boss_name.Localize();
        }
    }

    public string ChecklistName
    {
        get
        {
            return checklist_name.Localize();
        }
    }

    public string ChecklistDesc
    {
        get
        {
            return checklist_desc.Localize();
        }
    }

    public int ChecklistType
    {
        get
        {
            return checklist_type;
        }
    }

    public string ChecklistCount
    {
        get
        {
            return checklist_count.Localize();
        }
    }

    public int RankUse
    {
        get
        {
            return rank_use;
        }
    }

    public int RankSort
    {
        get
        {
            return rank_sort;
        }
    }

    public int ClearValue
    {
        get
        {
            return clear_value;
        }
    }

    public int ClearItemId1
    {
        get
        {
            return clear_item_id_1;
        }
    }

    public int ClearItemCount1
    {
        get
        {
            return clear_item_count_1;
        }
    }

    public int ClearItemId2
    {
        get
        {
            return clear_item_id_2;
        }
    }

    public int ClearItemCount2
    {
        get
        {
            return clear_item_count_2;
        }
    }

    public int RankRewardItemId1
    {
        get
        {
            return rank_reward_item_id_1;
        }
    }

    public int RankRewardItemCount1
    {
        get
        {
            return rank_reward_item_count_1;
        }
    }

    public int RankRewardItemId2
    {
        get
        {
            return rank_reward_item_id_2;
        }
    }

    public int RankRewardItemCount2
    {
        get
        {
            return rank_reward_item_count_2;
        }
    }

    public int RankRewardItemId3
    {
        get
        {
            return rank_reward_item_id_3;
        }
    }

    public int RankRewardItemCount3
    {
        get
        {
            return rank_reward_item_count_3;
        }
    }

    public List<int> ListClearItemId
    {
        get
        {
            if (list_clear_item_id == null)
            {
                list_clear_item_id = new List<int>
                {
                    ClearItemId1,
                    ClearItemId2
                };
            }
            return list_clear_item_id;
        }
    }

    public List<int> ListClearItemCount
    {
        get
        {
            if (list_clear_item_count == null)
            {
                list_clear_item_count = new List<int>
                {
                    ClearItemCount1,
                    ClearItemCount2
                };
            }
            return list_clear_item_count;
        }
    }

    public List<int> ListRankRewardItemId
    {
        get
        {
            if (list_rank_reward_item_id == null)
            {
                list_rank_reward_item_id = new List<int>
                {
                    RankRewardItemId1,
                    RankRewardItemId2,
                    RankRewardItemId3
                };
            }
            return list_rank_reward_item_id;
        }
    }

    public List<int> ListRankRewardItemCount
    {
        get
        {
            if (list_rank_reward_item_count == null)
            {
                list_rank_reward_item_count = new List<int>
                {
                    RankRewardItemCount1,
                    RankRewardItemCount2,
                    RankRewardItemCount3
                };
            }
            return list_rank_reward_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        hall_of_fame_data_id = reader.ReadInt32();
        group_id = reader.ReadInt32();
        boss_name = reader.ReadInt32();
        checklist_name = reader.ReadInt32();
        checklist_desc = reader.ReadInt32();
        checklist_type = reader.ReadInt32();
        checklist_count = reader.ReadInt32();
        rank_use = reader.ReadInt32();
        rank_sort = reader.ReadInt32();
        clear_value = reader.ReadInt32();
        clear_item_id_1 = reader.ReadInt32();
        clear_item_count_1 = reader.ReadInt32();
        clear_item_id_2 = reader.ReadInt32();
        clear_item_count_2 = reader.ReadInt32();
        rank_reward_item_id_1 = reader.ReadInt32();
        rank_reward_item_count_1 = reader.ReadInt32();
        rank_reward_item_id_2 = reader.ReadInt32();
        rank_reward_item_count_2 = reader.ReadInt32();
        rank_reward_item_id_3 = reader.ReadInt32();
        rank_reward_item_count_3 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int hall_of_fame_data_id;

    private int group_id;

    private int boss_name;

    private int checklist_name;

    private int checklist_desc;

    private int checklist_type;

    private int checklist_count;

    private int rank_use;

    private int rank_sort;

    private int clear_value;

    private int clear_item_id_1;

    private int clear_item_count_1;

    private int clear_item_id_2;

    private int clear_item_count_2;

    private int rank_reward_item_id_1;

    private int rank_reward_item_count_1;

    private int rank_reward_item_id_2;

    private int rank_reward_item_count_2;

    private int rank_reward_item_id_3;

    private int rank_reward_item_count_3;

    private List<int> list_clear_item_id;

    private List<int> list_clear_item_count;

    private List<int> list_rank_reward_item_id;

    private List<int> list_rank_reward_item_count;
}
