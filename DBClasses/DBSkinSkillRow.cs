public class DBSkinSkillRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int SkillA1Id
    {
        get
        {
            return skill_a_1_id;
        }
    }

    public int SkillA2Id
    {
        get
        {
            return skill_a_2_id;
        }
    }

    public int SkillA3Id
    {
        get
        {
            return skill_a_3_id;
        }
    }

    public int SkillADrawPer
    {
        get
        {
            return skill_a_draw_per;
        }
    }

    public int SkillA2LogicCam
    {
        get
        {
            return skill_a_2_logic_cam;
        }
    }

    public int SkillA3LogicCam
    {
        get
        {
            return skill_a_3_logic_cam;
        }
    }

    public int SkillB1Id
    {
        get
        {
            return skill_b_1_id;
        }
    }

    public int SkillB2Id
    {
        get
        {
            return skill_b_2_id;
        }
    }

    public int SkillB3Id
    {
        get
        {
            return skill_b_3_id;
        }
    }

    public int SkillBDrawPer
    {
        get
        {
            return skill_b_draw_per;
        }
    }

    public int SkillB2LogicCam
    {
        get
        {
            return skill_b_2_logic_cam;
        }
    }

    public int SkillB3LogicCam
    {
        get
        {
            return skill_b_3_logic_cam;
        }
    }

    public int CounterAttack1Id
    {
        get
        {
            return counter_attack_1_id;
        }
    }

    public int CounterAttack2Id
    {
        get
        {
            return counter_attack_2_id;
        }
    }

    public int CounterAttack3Id
    {
        get
        {
            return counter_attack_3_id;
        }
    }

    public int SpecialId1
    {
        get
        {
            return special_id_1;
        }
    }

    public int SpecialId2
    {
        get
        {
            return special_id_2;
        }
    }

    public int SpecialId3
    {
        get
        {
            return special_id_3;
        }
    }

    public int SpecialId4
    {
        get
        {
            return special_id_4;
        }
    }

    public int SpecialId5
    {
        get
        {
            return special_id_5;
        }
    }

    public int SpecialId6
    {
        get
        {
            return special_id_6;
        }
    }

    public List<int> ListSpecialId
    {
        get
        {
            if (list_special_id == null)
            {
                list_special_id = new List<int>
                {
                    SpecialId1,
                    SpecialId2,
                    SpecialId3,
                    SpecialId4,
                    SpecialId5,
                    SpecialId6
                };
            }
            return list_special_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        skill_a_1_id = reader.ReadInt32();
        skill_a_2_id = reader.ReadInt32();
        skill_a_3_id = reader.ReadInt32();
        skill_a_draw_per = reader.ReadInt32();
        skill_a_2_logic_cam = reader.ReadInt32();
        skill_a_3_logic_cam = reader.ReadInt32();
        skill_b_1_id = reader.ReadInt32();
        skill_b_2_id = reader.ReadInt32();
        skill_b_3_id = reader.ReadInt32();
        skill_b_draw_per = reader.ReadInt32();
        skill_b_2_logic_cam = reader.ReadInt32();
        skill_b_3_logic_cam = reader.ReadInt32();
        counter_attack_1_id = reader.ReadInt32();
        counter_attack_2_id = reader.ReadInt32();
        counter_attack_3_id = reader.ReadInt32();
        special_id_1 = reader.ReadInt32();
        special_id_2 = reader.ReadInt32();
        special_id_3 = reader.ReadInt32();
        special_id_4 = reader.ReadInt32();
        special_id_5 = reader.ReadInt32();
        special_id_6 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int skill_a_1_id;

    private int skill_a_2_id;

    private int skill_a_3_id;

    private int skill_a_draw_per;

    private int skill_a_2_logic_cam;

    private int skill_a_3_logic_cam;

    private int skill_b_1_id;

    private int skill_b_2_id;

    private int skill_b_3_id;

    private int skill_b_draw_per;

    private int skill_b_2_logic_cam;

    private int skill_b_3_logic_cam;

    private int counter_attack_1_id;

    private int counter_attack_2_id;

    private int counter_attack_3_id;

    private int special_id_1;

    private int special_id_2;

    private int special_id_3;

    private int special_id_4;

    private int special_id_5;

    private int special_id_6;

    private List<int> list_special_id;
}
