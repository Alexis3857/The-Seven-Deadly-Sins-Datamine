public class DBPassMissionRankRewardRow : ITableRowIndexer
{
    public int Index
    {
        get
        {
            return index;
        }
    }

    public int SettingId
    {
        get
        {
            return setting_id;
        }
    }

    public int MissionRank
    {
        get
        {
            return mission_rank;
        }
    }

    public int GroundIconType
    {
        get
        {
            return ground_icon_type;
        }
    }

    public int NormalRewardItemId
    {
        get
        {
            return normal_reward_item_id;
        }
    }

    public int NormalRewardItemCount
    {
        get
        {
            return normal_reward_item_count;
        }
    }

    public int SpecialRewardItemId1
    {
        get
        {
            return special_reward_item_id_1;
        }
    }

    public int SpecialRewardItemCount1
    {
        get
        {
            return special_reward_item_count_1;
        }
    }

    public int SpecialRewardItemId2
    {
        get
        {
            return special_reward_item_id_2;
        }
    }

    public int SpecialRewardItemCount2
    {
        get
        {
            return special_reward_item_count_2;
        }
    }

    public List<int> ListSpecialRewardItemId
    {
        get
        {
            if (list_special_reward_item_id == null)
            {
                list_special_reward_item_id = new List<int>
                {
                    SpecialRewardItemId1,
                    SpecialRewardItemId2
                };
            }
            return list_special_reward_item_id;
        }
    }

    public List<int> ListSpecialRewardItemCount
    {
        get
        {
            if (list_special_reward_item_count == null)
            {
                list_special_reward_item_count = new List<int>
                {
                    SpecialRewardItemCount1,
                    SpecialRewardItemCount2
                };
            }
            return list_special_reward_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        index = reader.ReadInt32();
        setting_id = reader.ReadInt32();
        mission_rank = reader.ReadInt32();
        ground_icon_type = reader.ReadInt32();
        normal_reward_item_id = reader.ReadInt32();
        normal_reward_item_count = reader.ReadInt32();
        special_reward_item_id_1 = reader.ReadInt32();
        special_reward_item_count_1 = reader.ReadInt32();
        special_reward_item_id_2 = reader.ReadInt32();
        special_reward_item_count_2 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Index;
    }

    private int index;

    private int setting_id;

    private int mission_rank;

    private int ground_icon_type;

    private int normal_reward_item_id;

    private int normal_reward_item_count;

    private int special_reward_item_id_1;

    private int special_reward_item_count_1;

    private int special_reward_item_id_2;

    private int special_reward_item_count_2;

    private List<int> list_special_reward_item_id;

    private List<int> list_special_reward_item_count;
}
