public class DBStageCreaturenestInfoRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int StageType
    {
        get
        {
            return stage_type;
        }
    }

    public int StageGroupId
    {
        get
        {
            return stage_group_id;
        }
    }

    public string StageGroupName
    {
        get
        {
            return stage_group_name.Localize();
        }
    }

    public int FirstRewardInitItemId
    {
        get
        {
            return first_reward_Init_Item_id;
        }
    }

    public string FirstRewardInitItemCount
    {
        get
        {
            return first_reward_Init_Item_count;
        }
    }

    public int LobbyRewardItemId
    {
        get
        {
            return lobby_reward_item_id;
        }
    }

    public string LobbyRewardDesc
    {
        get
        {
            return lobby_reward_desc.Localize();
        }
    }

    public string LobbyStoryIcon
    {
        get
        {
            return lobby_story_icon;
        }
    }

    public int StoryCut
    {
        get
        {
            return story_cut;
        }
    }

    public string LobbyPortrait
    {
        get
        {
            return lobby_portrait;
        }
    }

    public string LobbyBg
    {
        get
        {
            return lobby_bg;
        }
    }

    public string TeamsetPortrait
    {
        get
        {
            return teamset_portrait;
        }
    }

    public int ChallengeRewardId
    {
        get
        {
            return challenge_reward_id;
        }
    }

    public int ChallengeRewardValue
    {
        get
        {
            return challenge_reward_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        stage_type = reader.ReadInt32();
        stage_group_id = reader.ReadInt32();
        stage_group_name = reader.ReadInt32();
        first_reward_Init_Item_id = reader.ReadInt32();
        first_reward_Init_Item_count = reader.ReadString();
        lobby_reward_item_id = reader.ReadInt32();
        lobby_reward_desc = reader.ReadInt32();
        lobby_story_icon = reader.ReadString();
        story_cut = reader.ReadInt32();
        lobby_portrait = reader.ReadString();
        lobby_bg = reader.ReadString();
        teamset_portrait = reader.ReadString();
        challenge_reward_id = reader.ReadInt32();
        challenge_reward_value = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int stage_type;

    private int stage_group_id;

    private int stage_group_name;

    private int first_reward_Init_Item_id;

    private string first_reward_Init_Item_count;

    private int lobby_reward_item_id;

    private int lobby_reward_desc;

    private string lobby_story_icon;

    private int story_cut;

    private string lobby_portrait;

    private string lobby_bg;

    private string teamset_portrait;

    private int challenge_reward_id;

    private int challenge_reward_value;
}
