public class DBStageChallengeBossGroupRow : ITableRowIndexer
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

    public int EventBossTitle
    {
        get
        {
            return event_boss_title;
        }
    }

    public int GroupHeroId1
    {
        get
        {
            return group_hero_id_1;
        }
    }

    public int GroupHeroId2
    {
        get
        {
            return group_hero_id_2;
        }
    }

    public int BossPosition
    {
        get
        {
            return boss_position;
        }
    }

    public string GroupString
    {
        get
        {
            return group_string.Localize();
        }
    }

    public string InfoImage1
    {
        get
        {
            return info_image_1;
        }
    }

    public string InfoImage2
    {
        get
        {
            return info_image_2;
        }
    }


    public int DoubleBossTitle
    {
        get
        {
            return double_boss_title;
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

    public List<int> ListGroupHeroId
    {
        get
        {
            if (list_group_hero_id == null)
            {
                list_group_hero_id = new List<int>()
                {
                    GroupHeroId1,
                    GroupHeroId2
                };
            }
            return list_group_hero_id;
        }
    }

    public List<string> ListInfoImage
    {
        get
        {
            if (list_info_image == null)
            {
                list_info_image = new List<string>()
                {
                    InfoImage1,
                    InfoImage2
                };
            }
            return list_info_image;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        group_id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        event_boss_title = reader.ReadInt32();
        group_hero_id_1 = reader.ReadInt32();
        group_hero_id_2 = reader.ReadInt32();
        boss_position = reader.ReadInt32();
        group_string = reader.ReadInt32();
        info_image_1 = reader.ReadString();
        info_image_2 = reader.ReadString();
        double_boss_title = reader.ReadInt32();
        challenge_boss_strong_skill_desc = reader.ReadInt32();
        result_score_list = reader.ReadInt32();
        result_score_name = reader.ReadInt32();
        group_monster_location_z = reader.ReadSingle();
        group_monster_location_y = reader.ReadSingle();
        group_monster_location_x = reader.ReadSingle();
        return true;
    }

    public int GetRowIndex()
    {
        return GroupId;
    }

    private int group_id;

    private int event_sub_index;

    private int event_boss_title;

    private int group_hero_id_1;

    private int group_hero_id_2;

    private int boss_position;

    private int group_string;

    private string info_image_1;

    private string info_image_2;

    private int double_boss_title;

    private int challenge_boss_strong_skill_desc;

    private int result_score_list;

    private int result_score_name;

    private float group_monster_location_z;

    private float group_monster_location_y;

    private float group_monster_location_x;

    private List<int> list_group_hero_id;

    private List<string> list_info_image;
}
