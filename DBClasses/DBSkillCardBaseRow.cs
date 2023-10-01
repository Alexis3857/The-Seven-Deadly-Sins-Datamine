public class DBSkillCardBaseRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 613U;
        }
    }

    public int Id
    {
        get
        {
            return base.DecryptInt32(id);
        }
    }

    public string SkillName
    {
        get
        {
            return skill_name.Localize();
        }
    }

    public string SkillExplain
    {
        get
        {
            return skill_explain.Localize();
        }
    }

    public byte RangeType
    {
        get
        {
            return range_type;
        }
    }

    public byte AniEventType
    {
        get
        {
            return ani_event_type;
        }
    }

    public byte AttackType
    {
        get
        {
            return attack_type;
        }
    }

    public byte Target
    {
        get
        {
            return target;
        }
    }

    public int BulletId
    {
        get
        {
            return base.DecryptInt32(bullet_id);
        }
    }

    public float AtkPer
    {
        get
        {
            return base.DecryptFloat(atk_per);
        }
    }

    public float AtkPerAdd
    {
        get
        {
            return base.DecryptFloat(atk_per_add);
        }
    }

    public List<int> ListArrayOptionIdList
    {
        get
        {
            return list_array_option_id_list;
        }
    }

    public List<int> ListArrayBuffIdList
    {
        get
        {
            return list_array_buff_id_list;
        }
    }

    public byte IndicateSkillCard
    {
        get
        {
            return indicate_skill_card;
        }
    }

    public byte ForceRangeType
    {
        get
        {
            return force_range_type;
        }
    }

    public List<int> ListArraySkillSearchTag
    {
        get
        {
            return list_array_skill_search_tag;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadBytes(4);
        skill_name = reader.ReadInt32();
        skill_explain = reader.ReadInt32();
        range_type = reader.ReadByte();
        ani_event_type = reader.ReadByte();
        attack_type = reader.ReadByte();
        target = reader.ReadByte();
        bullet_id = reader.ReadBytes(4);
        atk_per = reader.ReadBytes(4);
        atk_per_add = reader.ReadBytes(4);
        int num = reader.ReadInt32();
        list_array_option_id_list = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_option_id_list.Add(reader.ReadInt32());
        }
        int num2 = reader.ReadInt32();
        list_array_buff_id_list = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_buff_id_list.Add(reader.ReadInt32());
        }
        indicate_skill_card = reader.ReadByte();
        force_range_type = reader.ReadByte();
        int num3 = reader.ReadInt32();
        list_array_skill_search_tag = new List<int>();
        for (int k = 0; k < num3; k++)
        {
            list_array_skill_search_tag.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private byte[] id;

    private int skill_name;

    private int skill_explain;

    private byte range_type;

    private byte ani_event_type;

    private byte attack_type;

    private byte target;

    private byte[] bullet_id;

    private byte[] atk_per;

    private byte[] atk_per_add;

    private List<int> list_array_option_id_list;

    private List<int> list_array_buff_id_list;

    private byte indicate_skill_card;

    private byte force_range_type;

    private List<int> list_array_skill_search_tag;
}
