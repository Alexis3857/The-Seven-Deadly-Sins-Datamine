public class DBSkinExclusivePassiveRow : ITableRowIndexer
{
    public int HeroId
    {
        get
        {
            return hero_id;
        }
    }

    public int MemorialStageId1
    {
        get
        {
            return memorial_stage_id_1;
        }
    }

    public int ExclusivePassiveId1
    {
        get
        {
            return exclusive_passive_id_1;
        }
    }

    public int MemorialStageId2
    {
        get
        {
            return memorial_stage_id_2;
        }
    }

    public int ExclusivePassiveId2
    {
        get
        {
            return exclusive_passive_id_2;
        }
    }

    public int MemorialStageId3
    {
        get
        {
            return memorial_stage_id_3;
        }
    }

    public int ExclusivePassiveId3
    {
        get
        {
            return exclusive_passive_id_3;
        }
    }

    public byte TabooChangeGift
    {
        get
        {
            return taboo_change_gift;
        }
    }

    public byte TabooNumberCheck
    {
        get
        {
            return taboo_number_check;
        }
    }

    public int TabooExclusivePassiveId
    {
        get
        {
            return taboo_exclusive_passive_id;
        }
    }

    public int GraceExclusivePassiveId
    {
        get
        {
            return grace_exclusive_passive_id;
        }
    }

    public string GraceExclusivePassiveGroup
    {
        get
        {
            return grace_exclusive_passive_group;
        }
    }

    public int SolidarityExclusivePassiveId
    {
        get
        {
            return solidarity_exclusive_passive_id;
        }
    }

    public string SolidarityExclusivePassiveGroup
    {
        get
        {
            return solidarity_exclusive_passive_group;
        }
    }

    public List<int> ListArrayAttributeExclusivePassiveId
    {
        get
        {
            return list_array_attribute_exclusive_passive_id;
        }
    }

    public List<byte> ListArrayAttributeExclusivePassiveRule
    {
        get
        {
            return list_array_attribute_exclusive_passive_rule;
        }
    }

    public List<int> ListMemorialStageId
    {
        get
        {
            if (list_memorial_stage_id == null)
            {
                list_memorial_stage_id = new List<int>
                {
                    MemorialStageId1,
                    MemorialStageId2,
                    MemorialStageId3
                };
            }
            return list_memorial_stage_id;
        }
    }

    public List<int> ListExclusivePassiveId
    {
        get
        {
            if (list_exclusive_passive_id == null)
            {
                list_exclusive_passive_id = new List<int>
                {
                    ExclusivePassiveId1,
                    ExclusivePassiveId2,
                    ExclusivePassiveId3
                };
            }
            return list_exclusive_passive_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        hero_id = reader.ReadInt32();
        memorial_stage_id_1 = reader.ReadInt32();
        exclusive_passive_id_1 = reader.ReadInt32();
        memorial_stage_id_2 = reader.ReadInt32();
        exclusive_passive_id_2 = reader.ReadInt32();
        memorial_stage_id_3 = reader.ReadInt32();
        exclusive_passive_id_3 = reader.ReadInt32();
        taboo_change_gift = reader.ReadByte();
        taboo_number_check = reader.ReadByte();
        taboo_exclusive_passive_id = reader.ReadInt32();
        grace_exclusive_passive_id = reader.ReadInt32();
        grace_exclusive_passive_group = reader.ReadString();
        solidarity_exclusive_passive_id = reader.ReadInt32();
        solidarity_exclusive_passive_group = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_attribute_exclusive_passive_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_attribute_exclusive_passive_id.Add(reader.ReadInt32());
        }
        int num2 = reader.ReadInt32();
        list_array_attribute_exclusive_passive_rule = new List<byte>();
        for (int j = 0; j < num2; j++)
        {
            list_array_attribute_exclusive_passive_rule.Add(reader.ReadByte());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return HeroId;
    }

    private int hero_id;

    private int memorial_stage_id_1;

    private int exclusive_passive_id_1;

    private int memorial_stage_id_2;

    private int exclusive_passive_id_2;

    private int memorial_stage_id_3;

    private int exclusive_passive_id_3;

    private byte taboo_change_gift;

    private byte taboo_number_check;

    private int taboo_exclusive_passive_id;

    private int grace_exclusive_passive_id;

    private string grace_exclusive_passive_group;

    private int solidarity_exclusive_passive_id;

    private string solidarity_exclusive_passive_group;

    private List<int> list_array_attribute_exclusive_passive_id;

    private List<byte> list_array_attribute_exclusive_passive_rule;

    private List<int> list_memorial_stage_id;

    private List<int> list_exclusive_passive_id;
}
