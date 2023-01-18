public class DBStageChallengeBossGroupRow
{
    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public int GroupHeroId
    {
        get
        {
            return group_hero_id;
        }
    }

    public string GroupString
    {
        get
        {
            return group_string.Localize();
        }
    }

    public string InfoImage
    {
        get
        {
            return info_image;
        }
    }

    public string ChallengeBossStrongSkillDesc
    {
        get
        {
            return challenge_boss_strong_skill_desc.Localize();
        }
    }

    public int ResultScoreList
    {
        get
        {
            return result_score_list;
        }
    }

    public string ResultScoreName
    {
        get
        {
            return result_score_name.Localize();
        }
    }

    public float GroupMonsterLocationZ
    {
        get
        {
            return group_monster_location_z;
        }
    }

    public float GroupMonsterLocationY
    {
        get
        {
            return group_monster_location_y;
        }
    }

    public float GroupMonsterLocationX
    {
        get
        {
            return group_monster_location_x;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        group_id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        group_hero_id = reader.ReadInt32();
        group_string = reader.ReadInt32();
        info_image = reader.ReadString();
        challenge_boss_strong_skill_desc = reader.ReadInt32();
        result_score_list = reader.ReadInt32();
        result_score_name = reader.ReadInt32();
        group_monster_location_z = reader.ReadSingle();
        group_monster_location_y = reader.ReadSingle();
        group_monster_location_x = reader.ReadSingle();
        return true;
    }

    private int group_id;

    private int event_sub_index;

    private int group_hero_id;

    private int group_string;

    private string info_image;

    private int challenge_boss_strong_skill_desc;

    private int result_score_list;

    private int result_score_name;

    private float group_monster_location_z;

    private float group_monster_location_y;

    private float group_monster_location_x;
}
