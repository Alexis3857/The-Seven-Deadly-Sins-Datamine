public class DBGuidelistRewardRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int QuestPhase
    {
        get
        {
            return quest_phase;
        }
    }

    public string QuestPhaseBanner
    {
        get
        {
            return quest_phase_banner;
        }
    }

    public int QuestGroupRewardIndex
    {
        get
        {
            return quest_group_reward_index;
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

    public int SkinLevel
    {
        get
        {
            return skin_level;
        }
    }

    public int SkinAwaken
    {
        get
        {
            return skin_awaken;
        }
    }

    public string QuestPhaseLocalize
    {
        get
        {
            return quest_phase_localize.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        quest_phase = reader.ReadInt32();
        quest_phase_banner = reader.ReadString();
        quest_group_reward_index = reader.ReadInt32();
        reward_item_id = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        skin_level = reader.ReadInt32();
        skin_awaken = reader.ReadInt32();
        quest_phase_localize = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int quest_phase;

    private string quest_phase_banner;

    private int quest_group_reward_index;

    private int reward_item_id;

    private int reward_item_count;

    private int skin_level;

    private int skin_awaken;

    private int quest_phase_localize;
}
