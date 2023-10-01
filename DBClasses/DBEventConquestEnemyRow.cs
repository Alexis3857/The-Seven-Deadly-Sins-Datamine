public class DBEventConquestEnemyRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public int EnemyGroup
    {
        get
        {
            return enemy_group;
        }
    }

    public string EnemyName
    {
        get
        {
            return enemy_name.Localize();
        }
    }

    public string EnemyIcon
    {
        get
        {
            return enemy_icon;
        }
    }

    public string EnemyIconComplete
    {
        get
        {
            return enemy_icon_complete;
        }
    }

    public int EnemyPortraitType
    {
        get
        {
            return enemy_portrait_type;
        }
    }

    public string EnemyPortraitBase
    {
        get
        {
            return enemy_portrait_base;
        }
    }

    public int EnemyType
    {
        get
        {
            return enemy_type;
        }
    }

    public int EnemyPosition
    {
        get
        {
            return enemy_position;
        }
    }

    public int EnemyOpenType
    {
        get
        {
            return enemy_open_type;
        }
    }

    public List<int> ListArrayOpenEnemyPosition
    {
        get
        {
            return list_array_open_enemy_position;
        }
    }

    public int RecommendRoute
    {
        get
        {
            return recommend_route;
        }
    }

    public int EnemyHp
    {
        get
        {
            return enemy_hp;
        }
    }

    public int StageId
    {
        get
        {
            return stage_id;
        }
    }

    public int OpenCutInIndex
    {
        get
        {
            return open_cut_in_index;
        }
    }

    public int CloseCutInIndex
    {
        get
        {
            return close_cut_in_index;
        }
    }

    public int NeedItemId1
    {
        get
        {
            return need_item_id_1;
        }
    }

    public int NeedItemCount1
    {
        get
        {
            return need_item_count_1;
        }
    }

    public int NeedItemId2
    {
        get
        {
            return need_item_id_2;
        }
    }

    public int NeedItemCount2
    {
        get
        {
            return need_item_count_2;
        }
    }

    public int NeedItemId3
    {
        get
        {
            return need_item_id_3;
        }
    }

    public int NeedItemCount3
    {
        get
        {
            return need_item_count_3;
        }
    }

    public int NeedItemId4
    {
        get
        {
            return need_item_id_4;
        }
    }

    public int NeedItemCount4
    {
        get
        {
            return need_item_count_4;
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

    public List<int> ListNeedItemId
    {
        get
        {
            if (list_need_item_id == null)
            {
                list_need_item_id = new List<int>
                {
                    NeedItemId1,
                    NeedItemId2,
                    NeedItemId3,
                    NeedItemId4
                };
            }
            return list_need_item_id;
        }
    }

    public List<int> ListNeedItemCount
    {
        get
        {
            if (list_need_item_count == null)
            {
                list_need_item_count = new List<int>
                {
                    need_item_count_1,
                    need_item_count_2,
                    need_item_count_3,
                    need_item_count_4
                };
            }
            return list_need_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        enemy_group = reader.ReadInt32();
        enemy_name = reader.ReadInt32();
        enemy_icon = reader.ReadString();
        enemy_icon_complete = reader.ReadString();
        enemy_portrait_type = reader.ReadInt32();
        enemy_portrait_base = reader.ReadString();
        enemy_type = reader.ReadInt32();
        enemy_position = reader.ReadInt32();
        enemy_open_type = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_open_enemy_position = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_open_enemy_position.Add(reader.ReadInt32());
        }
        recommend_route = reader.ReadInt32();
        enemy_hp = reader.ReadInt32();
        stage_id = reader.ReadInt32();
        open_cut_in_index = reader.ReadInt32();
        close_cut_in_index = reader.ReadInt32();
        need_item_id_1 = reader.ReadInt32();
        need_item_count_1 = reader.ReadInt32();
        need_item_id_2 = reader.ReadInt32();
        need_item_count_2 = reader.ReadInt32();
        need_item_id_3 = reader.ReadInt32();
        need_item_count_3 = reader.ReadInt32();
        need_item_id_4 = reader.ReadInt32();
        need_item_count_4 = reader.ReadInt32();
        reward_item_id = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int enemy_group;

    private int enemy_name;

    private string enemy_icon;

    private string enemy_icon_complete;

    private int enemy_portrait_type;

    private string enemy_portrait_base;

    private int enemy_type;

    private int enemy_position;

    private int enemy_open_type;

    private List<int> list_array_open_enemy_position;

    private int recommend_route;

    private int enemy_hp;

    private int stage_id;

    private int open_cut_in_index;

    private int close_cut_in_index;

    private int need_item_id_1;

    private int need_item_count_1;

    private int need_item_id_2;

    private int need_item_count_2;

    private int need_item_id_3;

    private int need_item_count_3;

    private int need_item_id_4;

    private int need_item_count_4;

    private int reward_item_id;

    private int reward_item_count;

    private List<int> list_need_item_id;

    private List<int> list_need_item_count;
}
