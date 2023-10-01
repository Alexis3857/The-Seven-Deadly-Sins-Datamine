public class DBMonsterSkillRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 870U;
        }
    }

    public int Id
    {
        get
        {
            return base.DecryptInt32(id);
        }
    }

    public int SkillA1Id
    {
        get
        {
            return base.DecryptInt32(skill_a_1_id);
        }
    }

    public int SkillA2Id
    {
        get
        {
            return base.DecryptInt32(skill_a_2_id);
        }
    }

    public int SkillA3Id
    {
        get
        {
            return base.DecryptInt32(skill_a_3_id);
        }
    }

    public byte SkillADrawPer
    {
        get
        {
            return skill_a_draw_per;
        }
    }

    public byte SkillA2LogicCam
    {
        get
        {
            return skill_a_2_logic_cam;
        }
    }

    public byte SkillA3LogicCam
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
            return base.DecryptInt32(skill_b_1_id);
        }
    }

    public int SkillB2Id
    {
        get
        {
            return base.DecryptInt32(skill_b_2_id);
        }
    }

    public int SkillB3Id
    {
        get
        {
            return base.DecryptInt32(skill_b_3_id);
        }
    }

    public byte SkillBDrawPer
    {
        get
        {
            return skill_b_draw_per;
        }
    }

    public byte SkillB2LogicCam
    {
        get
        {
            return skill_b_2_logic_cam;
        }
    }

    public byte SkillB3LogicCam
    {
        get
        {
            return skill_b_3_logic_cam;
        }
    }

    public int SkillExclusiveAId
    {
        get
        {
            return base.DecryptInt32(skill_exclusive_a_id);
        }
    }

    public int SkillExclusiveBId
    {
        get
        {
            return base.DecryptInt32(skill_exclusive_b_id);
        }
    }

    public int CounterAttack1Id
    {
        get
        {
            return base.DecryptInt32(counter_attack_1_id);
        }
    }

    public int CounterAttack2Id
    {
        get
        {
            return base.DecryptInt32(counter_attack_2_id);
        }
    }

    public int CounterAttack3Id
    {
        get
        {
            return base.DecryptInt32(counter_attack_3_id);
        }
    }

    public int SpecialId
    {
        get
        {
            return base.DecryptInt32(special_id);
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadBytes(4);
        skill_a_1_id = reader.ReadBytes(4);
        skill_a_2_id = reader.ReadBytes(4);
        skill_a_3_id = reader.ReadBytes(4);
        skill_a_draw_per = reader.ReadByte();
        skill_a_2_logic_cam = reader.ReadByte();
        skill_a_3_logic_cam = reader.ReadByte();
        skill_b_1_id = reader.ReadBytes(4);
        skill_b_2_id = reader.ReadBytes(4);
        skill_b_3_id = reader.ReadBytes(4);
        skill_b_draw_per = reader.ReadByte();
        skill_b_2_logic_cam = reader.ReadByte();
        skill_b_3_logic_cam = reader.ReadByte();
        skill_exclusive_a_id = reader.ReadBytes(4);
        skill_exclusive_b_id = reader.ReadBytes(4);
        counter_attack_1_id = reader.ReadBytes(4);
        counter_attack_2_id = reader.ReadBytes(4);
        counter_attack_3_id = reader.ReadBytes(4);
        special_id = reader.ReadBytes(4);
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private byte[] id;

    private byte[] skill_a_1_id;

    private byte[] skill_a_2_id;

    private byte[] skill_a_3_id;

    private byte skill_a_draw_per;

    private byte skill_a_2_logic_cam;

    private byte skill_a_3_logic_cam;

    private byte[] skill_b_1_id;

    private byte[] skill_b_2_id;

    private byte[] skill_b_3_id;

    private byte skill_b_draw_per;

    private byte skill_b_2_logic_cam;

    private byte skill_b_3_logic_cam;

    private byte[] skill_exclusive_a_id;

    private byte[] skill_exclusive_b_id;

    private byte[] counter_attack_1_id;

    private byte[] counter_attack_2_id;

    private byte[] counter_attack_3_id;

    private byte[] special_id;
}
