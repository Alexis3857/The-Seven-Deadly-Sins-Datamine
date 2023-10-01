public class DBStageSubdueBossRewardRow : ITableRowIndexer
{
    public int Index
    {
        get
        {
            return index;
        }
    }

    public string RewardType
    {
        get
        {
            return reward_type;
        }
    }

    public int RewardSubdueBossGroupId
    {
        get
        {
            return reward_subdue_boss_group_id;
        }
    }

    public int RewardItemId4P1
    {
        get
        {
            return reward_item_id_4p_1;
        }
    }

    public int RewardItemCount4P1
    {
        get
        {
            return reward_item_count_4p_1;
        }
    }

    public int DropItemBox4P1
    {
        get
        {
            return drop_item_box_4p_1;
        }
    }

    public int RewardItemId4P2
    {
        get
        {
            return reward_item_id_4p_2;
        }
    }

    public int RewardItemCount4P2
    {
        get
        {
            return reward_item_count_4p_2;
        }
    }

    public int DropItemBox4P2
    {
        get
        {
            return drop_item_box_4p_2;
        }
    }

    public int RewardItemId3P1
    {
        get
        {
            return reward_item_id_3p_1;
        }
    }

    public int RewardItemCount3P1
    {
        get
        {
            return reward_item_count_3p_1;
        }
    }

    public int DropItemBox3P1
    {
        get
        {
            return drop_item_box_3p_1;
        }
    }

    public int RewardItemId3P2
    {
        get
        {
            return reward_item_id_3p_2;
        }
    }

    public int RewardItemCount3P2
    {
        get
        {
            return reward_item_count_3p_2;
        }
    }

    public int DropItemBox3P2
    {
        get
        {
            return drop_item_box_3p_2;
        }
    }

    public int RewardItemId2P1
    {
        get
        {
            return reward_item_id_2p_1;
        }
    }

    public int RewardItemCount2P1
    {
        get
        {
            return reward_item_count_2p_1;
        }
    }

    public int DropItemBox2P1
    {
        get
        {
            return drop_item_box_2p_1;
        }
    }

    public int RewardItemId2P2
    {
        get
        {
            return reward_item_id_2p_2;
        }
    }

    public int RewardItemCount2P2
    {
        get
        {
            return reward_item_count_2p_2;
        }
    }

    public int DropItemBox2P2
    {
        get
        {
            return drop_item_box_2p_2;
        }
    }

    public int RewardItemId1P1
    {
        get
        {
            return reward_item_id_1p_1;
        }
    }

    public int RewardItemCount1P1
    {
        get
        {
            return reward_item_count_1p_1;
        }
    }

    public int DropItemBox1P1
    {
        get
        {
            return drop_item_box_1p_1;
        }
    }

    public int RewardItemId1P2
    {
        get
        {
            return reward_item_id_1p_2;
        }
    }

    public int RewardItemCount1P2
    {
        get
        {
            return reward_item_count_1p_2;
        }
    }

    public int DropItemBox1P2
    {
        get
        {
            return drop_item_box_1p_2;
        }
    }

    public List<int> ListRewardItemId4P
    {
        get
        {
            if (list_reward_item_id_4p == null)
            {
                list_reward_item_id_4p = new List<int>
                {
                    RewardItemId4P1,
                    RewardItemId4P2
                };
            }
            return list_reward_item_id_4p;
        }
    }

    public List<int> ListRewardItemCount4P
    {
        get
        {
            if (list_reward_item_count_4p == null)
            {
                list_reward_item_count_4p = new List<int>
                {
                    RewardItemCount4P1,
                    RewardItemCount4P2
                };
            }
            return list_reward_item_count_4p;
        }
    }

    public List<int> ListDropItemBox4P
    {
        get
        {
            if (list_drop_item_box_4p == null)
            {
                list_drop_item_box_4p = new List<int>
                {
                    DropItemBox4P1,
                    DropItemBox4P2
                };
            }
            return list_drop_item_box_4p;
        }
    }

    public List<int> ListRewardItemId3P
    {
        get
        {
            if (list_reward_item_id_3p == null)
            {
                list_reward_item_id_3p = new List<int>
                {
                    RewardItemId3P1,
                    RewardItemId3P2
                };
            }
            return list_reward_item_id_3p;
        }
    }

    public List<int> ListRewardItemCount3P
    {
        get
        {
            if (list_reward_item_count_3p == null)
            {
                list_reward_item_count_3p = new List<int>
                {
                    RewardItemCount3P1,
                    RewardItemCount3P2
                };
            }
            return list_reward_item_count_3p;
        }
    }

    public List<int> ListDropItemBox3P
    {
        get
        {
            if (list_drop_item_box_3p == null)
            {
                list_drop_item_box_3p = new List<int>
                {
                    DropItemBox3P1,
                    DropItemBox3P2
                };
            }
            return list_drop_item_box_3p;
        }
    }

    public List<int> ListRewardItemId2P
    {
        get
        {
            if (list_reward_item_id_2p == null)
            {
                list_reward_item_id_2p = new List<int>
                {
                    RewardItemId2P1,
                    RewardItemId2P2
                };
            }
            return list_reward_item_id_2p;
        }
    }

    public List<int> ListRewardItemCount2P
    {
        get
        {
            if (list_reward_item_count_2p == null)
            {
                list_reward_item_count_2p = new List<int>
                {
                    RewardItemCount2P1,
                    RewardItemCount2P2
                };
            }
            return list_reward_item_count_2p;
        }
    }

    public List<int> ListDropItemBox2P
    {
        get
        {
            if (list_drop_item_box_2p == null)
            {
                list_drop_item_box_2p = new List<int>
                {
                    DropItemBox2P1,
                    DropItemBox2P2
                };
            }
            return list_drop_item_box_2p;
        }
    }

    public List<int> ListRewardItemId1P
    {
        get
        {
            if (list_reward_item_id_1p == null)
            {
                list_reward_item_id_1p = new List<int>
                {
                    RewardItemId1P1,
                    RewardItemId1P2
                };
            }
            return list_reward_item_id_1p;
        }
    }

    public List<int> ListRewardItemCount1P
    {
        get
        {
            if (list_reward_item_count_1p == null)
            {
                list_reward_item_count_1p = new List<int>
                {
                    RewardItemCount1P1,
                    RewardItemCount1P2
                };
            }
            return list_reward_item_count_1p;
        }
    }

    public List<int> ListDropItemBox1P
    {
        get
        {
            if (list_drop_item_box_1p == null)
            {
                list_drop_item_box_1p = new List<int>
                {
                    DropItemBox1P1,
                    DropItemBox1P2
                };
            }
            return list_drop_item_box_1p;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        index = reader.ReadInt32();
        reward_type = reader.ReadString();
        reward_subdue_boss_group_id = reader.ReadInt32();
        reward_item_id_4p_1 = reader.ReadInt32();
        reward_item_count_4p_1 = reader.ReadInt32();
        drop_item_box_4p_1 = reader.ReadInt32();
        reward_item_id_4p_2 = reader.ReadInt32();
        reward_item_count_4p_2 = reader.ReadInt32();
        drop_item_box_4p_2 = reader.ReadInt32();
        reward_item_id_3p_1 = reader.ReadInt32();
        reward_item_count_3p_1 = reader.ReadInt32();
        drop_item_box_3p_1 = reader.ReadInt32();
        reward_item_id_3p_2 = reader.ReadInt32();
        reward_item_count_3p_2 = reader.ReadInt32();
        drop_item_box_3p_2 = reader.ReadInt32();
        reward_item_id_2p_1 = reader.ReadInt32();
        reward_item_count_2p_1 = reader.ReadInt32();
        drop_item_box_2p_1 = reader.ReadInt32();
        reward_item_id_2p_2 = reader.ReadInt32();
        reward_item_count_2p_2 = reader.ReadInt32();
        drop_item_box_2p_2 = reader.ReadInt32();
        reward_item_id_1p_1 = reader.ReadInt32();
        reward_item_count_1p_1 = reader.ReadInt32();
        drop_item_box_1p_1 = reader.ReadInt32();
        reward_item_id_1p_2 = reader.ReadInt32();
        reward_item_count_1p_2 = reader.ReadInt32();
        drop_item_box_1p_2 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Index;
    }

    private int index;

    private string reward_type;

    private int reward_subdue_boss_group_id;

    private int reward_item_id_4p_1;

    private int reward_item_count_4p_1;

    private int drop_item_box_4p_1;

    private int reward_item_id_4p_2;

    private int reward_item_count_4p_2;

    private int drop_item_box_4p_2;

    private int reward_item_id_3p_1;

    private int reward_item_count_3p_1;

    private int drop_item_box_3p_1;

    private int reward_item_id_3p_2;

    private int reward_item_count_3p_2;

    private int drop_item_box_3p_2;

    private int reward_item_id_2p_1;

    private int reward_item_count_2p_1;

    private int drop_item_box_2p_1;

    private int reward_item_id_2p_2;

    private int reward_item_count_2p_2;

    private int drop_item_box_2p_2;

    private int reward_item_id_1p_1;

    private int reward_item_count_1p_1;

    private int drop_item_box_1p_1;

    private int reward_item_id_1p_2;

    private int reward_item_count_1p_2;

    private int drop_item_box_1p_2;

    private List<int> list_reward_item_id_4p;

    private List<int> list_reward_item_count_4p;

    private List<int> list_drop_item_box_4p;

    private List<int> list_reward_item_id_3p;

    private List<int> list_reward_item_count_3p;

    private List<int> list_drop_item_box_3p;

    private List<int> list_reward_item_id_2p;

    private List<int> list_reward_item_count_2p;

    private List<int> list_drop_item_box_2p;

    private List<int> list_reward_item_id_1p;

    private List<int> list_reward_item_count_1p;

    private List<int> list_drop_item_box_1p;
}
