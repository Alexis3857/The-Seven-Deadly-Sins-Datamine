public class DBAiCustomizingBasicPresetRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public byte AiPresetGroup
    {
        get
        {
            return ai_preset_group;
        }
    }

    public byte AiGroup
    {
        get
        {
            return ai_group;
        }
    }

    public byte AiCost
    {
        get
        {
            return ai_cost;
        }
    }

    public byte AiSkillType
    {
        get
        {
            return ai_skill_type;
        }
    }

    public byte AiSkillTarget
    {
        get
        {
            return ai_skill_target;
        }
    }

    public byte AiCondition1
    {
        get
        {
            return ai_condition_1;
        }
    }

    public byte AiCondition2
    {
        get
        {
            return ai_condition_2;
        }
    }

    public byte AiCondition3
    {
        get
        {
            return ai_condition_3;
        }
    }

    public byte AiCustomizingEtc
    {
        get
        {
            return ai_customizing_etc;
        }
    }

    public byte AiMoveType
    {
        get
        {
            return ai_move_type;
        }
    }

    public byte AiMoveCondition
    {
        get
        {
            return ai_move_condition;
        }
    }

    public List<byte> ListAiCondition
    {
        get
        {
            if (list_ai_condition == null)
            {
                list_ai_condition = new List<byte>
                {
                    AiCondition1,
                    AiCondition2,
                    AiCondition3
                };
            }
            return list_ai_condition;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        ai_preset_group = reader.ReadByte();
        ai_group = reader.ReadByte();
        ai_cost = reader.ReadByte();
        ai_skill_type = reader.ReadByte();
        ai_skill_target = reader.ReadByte();
        ai_condition_1 = reader.ReadByte();
        ai_condition_2 = reader.ReadByte();
        ai_condition_3 = reader.ReadByte();
        ai_customizing_etc = reader.ReadByte();
        ai_move_type = reader.ReadByte();
        ai_move_condition = reader.ReadByte();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private byte ai_preset_group;

    private byte ai_group;

    private byte ai_cost;

    private byte ai_skill_type;

    private byte ai_skill_target;

    private byte ai_condition_1;

    private byte ai_condition_2;

    private byte ai_condition_3;

    private byte ai_customizing_etc;

    private byte ai_move_type;

    private byte ai_move_condition;

    private List<byte> list_ai_condition;
}
