public class DBStageDemonlordGroupRow : ITableRowIndexer
{
    public int GroupId => group_id;

    public int EventSubIndex => event_sub_index;

    public int GroupMonsterId1 => group_monster_id_1;

    public int GroupMonsterId2 => group_monster_id_2;

    public int GroupMonsterId3 => group_monster_id_3;

    public string GroupString => group_string.Localize();

    public string InfoImage1 => info_image_1;

    public string InfoImage2 => info_image_2;

    public string InfoImage3 => info_image_3;

    public string DescentBossStrongSkillDesc => descent_boss_strong_skill_desc.Localize();

    public string DescentBossPatternPhase01Desc => descent_boss_pattern_phase01_desc.Localize();

    public string DescentBossPatternPhase02Desc => descent_boss_pattern_phase02_desc.Localize();

    public string DescentBossPatternPhase03Desc => descent_boss_pattern_phase03_desc.Localize();

    public float GroupMonsterLocationZ => group_monster_location_z;

    public float GroupMonsterLocationY => group_monster_location_y;

    public float GroupMonsterLocationX => group_monster_location_x;

    public List<int> ListGroupMonsterId
    {
        get
        {
            if (list_group_monster_id == null)
            {
                list_group_monster_id = new List<int>()
                {
                    GroupMonsterId1,
                    GroupMonsterId2,
                    GroupMonsterId3
                };
            }
            return list_group_monster_id;
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
        event_sub_index = reader.ReadInt32();
        group_monster_id_1 = reader.ReadInt32();
        group_monster_id_2 = reader.ReadInt32();
        group_monster_id_3 = reader.ReadInt32();
        group_string = reader.ReadInt32();
        info_image_1 = reader.ReadString();
        info_image_2 = reader.ReadString();
        info_image_3 = reader.ReadString();
        descent_boss_strong_skill_desc = reader.ReadInt32();
        descent_boss_pattern_phase01_desc = reader.ReadInt32();
        descent_boss_pattern_phase02_desc = reader.ReadInt32();
        descent_boss_pattern_phase03_desc = reader.ReadInt32();
        group_monster_location_z = reader.ReadInt32();
        group_monster_location_y = reader.ReadInt32();
        group_monster_location_x = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return GroupId;
    }

    private int group_id;

    private int event_sub_index;

    private int group_monster_id_1;

    private int group_monster_id_2;

    private int group_monster_id_3;

    private int group_string;

    private string info_image_1;

    private string info_image_2;

    private string info_image_3;

    private int descent_boss_strong_skill_desc;

    private int descent_boss_pattern_phase01_desc;

    private int descent_boss_pattern_phase02_desc;

    private int descent_boss_pattern_phase03_desc;

    private float group_monster_location_z;

    private float group_monster_location_y;

    private float group_monster_location_x;

    private List<int> list_group_monster_id;

    private List<string> list_info_image;
}