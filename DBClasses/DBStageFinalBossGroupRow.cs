public class DBStageFinalBossGroupRow : ITableRowIndexer
{
    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public int EventCheck
    {
        get
        {
            return event_check;
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

    public int GroupHeroId3
    {
        get
        {
            return group_hero_id_3;
        }
    }

    public string GroupString
    {
        get
        {
            return group_string.Localize();
        }
    }

    public string StageString
    {
        get
        {
            return stage_string.Localize();
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

    public string InfoImage3
    {
        get
        {
            return info_image_3;
        }
    }

    public List<int> ListArrayFinalBossStrongHero
    {
        get
        {
            return list_array_final_boss_strong_hero;
        }
    }

    public string FinalBossPatternPhase01Desc
    {
        get
        {
            return final_boss_pattern_phase01_desc.Localize();
        }
    }

    public string FinalBossPatternPhase02Desc
    {
        get
        {
            return final_boss_pattern_phase02_desc.Localize();
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
                list_group_hero_id = new List<int>
                {
                    GroupHeroId1,
                    GroupHeroId2,
                    GroupHeroId3
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
                list_info_image = new List<string>
                {
                    InfoImage1,
                    InfoImage2,
                    InfoImage3
                };
            }
            return list_info_image;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        group_id = reader.ReadInt32();
        event_check = reader.ReadInt32();
        group_hero_id_1 = reader.ReadInt32();
        group_hero_id_2 = reader.ReadInt32();
        group_hero_id_3 = reader.ReadInt32();
        group_string = reader.ReadInt32();
        stage_string = reader.ReadInt32();
        info_image_1 = reader.ReadString();
        info_image_2 = reader.ReadString();
        info_image_3 = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_final_boss_strong_hero = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_final_boss_strong_hero.Add(reader.ReadInt32());
        }
        final_boss_pattern_phase01_desc = reader.ReadInt32();
        final_boss_pattern_phase02_desc = reader.ReadInt32();
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

    private int event_check;

    private int group_hero_id_1;

    private int group_hero_id_2;

    private int group_hero_id_3;

    private int group_string;

    private int stage_string;

    private string info_image_1;

    private string info_image_2;

    private string info_image_3;

    private List<int> list_array_final_boss_strong_hero;

    private int final_boss_pattern_phase01_desc;

    private int final_boss_pattern_phase02_desc;

    private float group_monster_location_z;

    private float group_monster_location_y;

    private float group_monster_location_x;

    private List<int> list_group_hero_id;

    private List<string> list_info_image;
}
