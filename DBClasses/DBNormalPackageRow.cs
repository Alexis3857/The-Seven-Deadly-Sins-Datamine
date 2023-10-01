public class DBNormalPackageRow : ITableRowIndexer
{
    public int ProductId
    {
        get
        {
            return product_id;
        }
    }

    public int RewardItemId1
    {
        get
        {
            return reward_item_id_1;
        }
    }

    public int RewardItemCount1
    {
        get
        {
            return reward_item_count_1;
        }
    }

    public int SkinLevel1
    {
        get
        {
            return skin_level_1;
        }
    }

    public int SkinAwaken1
    {
        get
        {
            return skin_awaken_1;
        }
    }

    public int RewardItemId2
    {
        get
        {
            return reward_item_id_2;
        }
    }

    public int RewardItemCount2
    {
        get
        {
            return reward_item_count_2;
        }
    }

    public int SkinLevel2
    {
        get
        {
            return skin_level_2;
        }
    }

    public int SkinAwaken2
    {
        get
        {
            return skin_awaken_2;
        }
    }

    public int RewardItemId3
    {
        get
        {
            return reward_item_id_3;
        }
    }

    public int RewardItemCount3
    {
        get
        {
            return reward_item_count_3;
        }
    }

    public int SkinLevel3
    {
        get
        {
            return skin_level_3;
        }
    }

    public int SkinAwaken3
    {
        get
        {
            return skin_awaken_3;
        }
    }

    public int RewardItemId4
    {
        get
        {
            return reward_item_id_4;
        }
    }

    public int RewardItemCount4
    {
        get
        {
            return reward_item_count_4;
        }
    }

    public int SkinLevel4
    {
        get
        {
            return skin_level_4;
        }
    }

    public int SkinAwaken4
    {
        get
        {
            return skin_awaken_4;
        }
    }

    public int RewardItemId5
    {
        get
        {
            return reward_item_id_5;
        }
    }

    public int RewardItemCount5
    {
        get
        {
            return reward_item_count_5;
        }
    }

    public int SkinLevel5
    {
        get
        {
            return skin_level_5;
        }
    }

    public int SkinAwaken5
    {
        get
        {
            return skin_awaken_5;
        }
    }

    public int RewardItemId6
    {
        get
        {
            return reward_item_id_6;
        }
    }

    public int RewardItemCount6
    {
        get
        {
            return reward_item_count_6;
        }
    }

    public int SkinLevel6
    {
        get
        {
            return skin_level_6;
        }
    }

    public int SkinAwaken6
    {
        get
        {
            return skin_awaken_6;
        }
    }

    public int RewardItemId7
    {
        get
        {
            return reward_item_id_7;
        }
    }

    public int RewardItemCount7
    {
        get
        {
            return reward_item_count_7;
        }
    }

    public int SkinLevel7
    {
        get
        {
            return skin_level_7;
        }
    }

    public int SkinAwaken7
    {
        get
        {
            return skin_awaken_7;
        }
    }

    public int RewardItemId8
    {
        get
        {
            return reward_item_id_8;
        }
    }

    public int RewardItemCount8
    {
        get
        {
            return reward_item_count_8;
        }
    }

    public int SkinLevel8
    {
        get
        {
            return skin_level_8;
        }
    }

    public int SkinAwaken8
    {
        get
        {
            return skin_awaken_8;
        }
    }

    public int RewardItemId9
    {
        get
        {
            return reward_item_id_9;
        }
    }

    public int RewardItemCount9
    {
        get
        {
            return reward_item_count_9;
        }
    }

    public int SkinLevel9
    {
        get
        {
            return skin_level_9;
        }
    }

    public int SkinAwaken9
    {
        get
        {
            return skin_awaken_9;
        }
    }

    public int RewardItemId10
    {
        get
        {
            return reward_item_id_10;
        }
    }

    public int RewardItemCount10
    {
        get
        {
            return reward_item_count_10;
        }
    }

    public int SkinLevel10
    {
        get
        {
            return skin_level_10;
        }
    }

    public int SkinAwaken10
    {
        get
        {
            return skin_awaken_10;
        }
    }

    public List<int> ListRewardItemId
    {
        get
        {
            if (list_reward_item_id == null)
            {
                list_reward_item_id = new List<int>
                {
                    RewardItemId1,
                    RewardItemId2,
                    RewardItemId3,
                    RewardItemId4,
                    RewardItemId5,
                    RewardItemId6,
                    RewardItemId7,
                    RewardItemId8,
                    RewardItemId9,
                    RewardItemId10
                };
            }
            return list_reward_item_id;
        }
    }

    public List<int> ListRewardItemCount
    {
        get
        {
            if (list_reward_item_count == null)
            {
                list_reward_item_count = new List<int>
                {
                    RewardItemCount1,
                    RewardItemCount2,
                    RewardItemCount3,
                    RewardItemCount4,
                    RewardItemCount5,
                    RewardItemCount6,
                    RewardItemCount7,
                    RewardItemCount8,
                    RewardItemCount9,
                    RewardItemCount10
                };
            }
            return list_reward_item_count;
        }
    }

    public List<int> ListSkinLevel
    {
        get
        {
            if (list_skin_level == null)
            {
                list_skin_level = new List<int>
                {
                    SkinLevel1,
                    SkinLevel2,
                    SkinLevel3,
                    SkinLevel4,
                    SkinLevel5,
                    SkinLevel6,
                    SkinLevel7,
                    SkinLevel8,
                    SkinLevel9,
                    SkinLevel10
                };
            }
            return list_skin_level;
        }
    }

    public List<int> ListSkinAwaken
    {
        get
        {
            if (list_skin_awaken == null)
            {
                list_skin_awaken = new List<int>
                {
                    SkinAwaken1,
                    SkinAwaken2,
                    SkinAwaken3,
                    SkinAwaken4,
                    SkinAwaken5,
                    SkinAwaken6,
                    SkinAwaken7,
                    SkinAwaken8,
                    SkinAwaken9,
                    SkinAwaken10
                };
            }
            return list_skin_awaken;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        product_id = reader.ReadInt32();
        reward_item_id_1 = reader.ReadInt32();
        reward_item_count_1 = reader.ReadInt32();
        skin_level_1 = reader.ReadInt32();
        skin_awaken_1 = reader.ReadInt32();
        reward_item_id_2 = reader.ReadInt32();
        reward_item_count_2 = reader.ReadInt32();
        skin_level_2 = reader.ReadInt32();
        skin_awaken_2 = reader.ReadInt32();
        reward_item_id_3 = reader.ReadInt32();
        reward_item_count_3 = reader.ReadInt32();
        skin_level_3 = reader.ReadInt32();
        skin_awaken_3 = reader.ReadInt32();
        reward_item_id_4 = reader.ReadInt32();
        reward_item_count_4 = reader.ReadInt32();
        skin_level_4 = reader.ReadInt32();
        skin_awaken_4 = reader.ReadInt32();
        reward_item_id_5 = reader.ReadInt32();
        reward_item_count_5 = reader.ReadInt32();
        skin_level_5 = reader.ReadInt32();
        skin_awaken_5 = reader.ReadInt32();
        reward_item_id_6 = reader.ReadInt32();
        reward_item_count_6 = reader.ReadInt32();
        skin_level_6 = reader.ReadInt32();
        skin_awaken_6 = reader.ReadInt32();
        reward_item_id_7 = reader.ReadInt32();
        reward_item_count_7 = reader.ReadInt32();
        skin_level_7 = reader.ReadInt32();
        skin_awaken_7 = reader.ReadInt32();
        reward_item_id_8 = reader.ReadInt32();
        reward_item_count_8 = reader.ReadInt32();
        skin_level_8 = reader.ReadInt32();
        skin_awaken_8 = reader.ReadInt32();
        reward_item_id_9 = reader.ReadInt32();
        reward_item_count_9 = reader.ReadInt32();
        skin_level_9 = reader.ReadInt32();
        skin_awaken_9 = reader.ReadInt32();
        reward_item_id_10 = reader.ReadInt32();
        reward_item_count_10 = reader.ReadInt32();
        skin_level_10 = reader.ReadInt32();
        skin_awaken_10 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return ProductId;
    }

    private int product_id;

    private int reward_item_id_1;

    private int reward_item_count_1;

    private int skin_level_1;

    private int skin_awaken_1;

    private int reward_item_id_2;

    private int reward_item_count_2;

    private int skin_level_2;

    private int skin_awaken_2;

    private int reward_item_id_3;

    private int reward_item_count_3;

    private int skin_level_3;

    private int skin_awaken_3;

    private int reward_item_id_4;

    private int reward_item_count_4;

    private int skin_level_4;

    private int skin_awaken_4;

    private int reward_item_id_5;

    private int reward_item_count_5;

    private int skin_level_5;

    private int skin_awaken_5;

    private int reward_item_id_6;

    private int reward_item_count_6;

    private int skin_level_6;

    private int skin_awaken_6;

    private int reward_item_id_7;

    private int reward_item_count_7;

    private int skin_level_7;

    private int skin_awaken_7;

    private int reward_item_id_8;

    private int reward_item_count_8;

    private int skin_level_8;

    private int skin_awaken_8;

    private int reward_item_id_9;

    private int reward_item_count_9;

    private int skin_level_9;

    private int skin_awaken_9;

    private int reward_item_id_10;

    private int reward_item_count_10;

    private int skin_level_10;

    private int skin_awaken_10;

    private List<int> list_reward_item_id;

    private List<int> list_reward_item_count;

    private List<int> list_skin_level;

    private List<int> list_skin_awaken;
}
