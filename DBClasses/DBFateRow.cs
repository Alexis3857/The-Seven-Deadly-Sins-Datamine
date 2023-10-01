public class DBFateRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 636U;
        }
    }

    public int Id
    {
        get
        {
            return base.DecryptInt32(id);
        }
    }

    public int MainHeroId
    {
        get
        {
            return base.DecryptInt32(main_hero_id);
        }
    }

    public int FateHeroId
    {
        get
        {
            return base.DecryptInt32(fate_hero_id);
        }
    }

    public int RLvPassiveId
    {
        get
        {
            return base.DecryptInt32(r_lv_passive_id);
        }
    }

    public int SrLvPassiveId
    {
        get
        {
            return base.DecryptInt32(sr_lv_passive_id);
        }
    }

    public int SsrLvPassiveId
    {
        get
        {
            return base.DecryptInt32(ssr_lv_passive_id);
        }
    }

    public int UrLvPassiveId
    {
        get
        {
            return base.DecryptInt32(ur_lv_passive_id);
        }
    }

    public int LrLvPassiveId
    {
        get
        {
            return base.DecryptInt32(lr_lv_passive_id);
        }
    }

    public int SpecialCoopCardId1
    {
        get
        {
            return base.DecryptInt32(special_coop_card_id_1);
        }
    }

    public int SpecialCoopCardId2
    {
        get
        {
            return base.DecryptInt32(special_coop_card_id_2);
        }
    }

    public int SpecialCoopCardId3
    {
        get
        {
            return base.DecryptInt32(special_coop_card_id_3);
        }
    }

    public int SpecialCoopCardId4
    {
        get
        {
            return base.DecryptInt32(special_coop_card_id_4);
        }
    }

    public int SpecialCoopCardId5
    {
        get
        {
            return base.DecryptInt32(special_coop_card_id_5);
        }
    }

    public int SpecialCoopCardId6
    {
        get
        {
            return base.DecryptInt32(special_coop_card_id_6);
        }
    }

    public List<int> ListArrayLrGradeSpecialCoopCardId
    {
        get
        {
            return list_array_lr_grade_special_coop_card_id;
        }
    }

    public string SpecialCoopAniFolder
    {
        get
        {
            return special_coop_ani_folder;
        }
    }

    public string SpecialCoopDesc
    {
        get
        {
            return special_coop_desc.Localize();
        }
    }

    public string FateName
    {
        get
        {
            return fate_name.Localize();
        }
    }

    public string FateDesc
    {
        get
        {
            return fate_desc.Localize();
        }
    }

    public List<int> ListSpecialCoopCardId
    {
        get
        {
            if (list_special_coop_card_id == null)
            {
                list_special_coop_card_id = new List<int>
                {
                    SpecialCoopCardId1,
                    SpecialCoopCardId2,
                    SpecialCoopCardId3,
                    SpecialCoopCardId4,
                    SpecialCoopCardId5,
                    SpecialCoopCardId6
                };
            }
            return list_special_coop_card_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadBytes(4);
        main_hero_id = reader.ReadBytes(4);
        fate_hero_id = reader.ReadBytes(4);
        r_lv_passive_id = reader.ReadBytes(4);
        sr_lv_passive_id = reader.ReadBytes(4);
        ssr_lv_passive_id = reader.ReadBytes(4);
        ur_lv_passive_id = reader.ReadBytes(4);
        lr_lv_passive_id = reader.ReadBytes(4);
        special_coop_card_id_1 = reader.ReadBytes(4);
        special_coop_card_id_2 = reader.ReadBytes(4);
        special_coop_card_id_3 = reader.ReadBytes(4);
        special_coop_card_id_4 = reader.ReadBytes(4);
        special_coop_card_id_5 = reader.ReadBytes(4);
        special_coop_card_id_6 = reader.ReadBytes(4);
        int num = reader.ReadInt32();
        list_array_lr_grade_special_coop_card_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_lr_grade_special_coop_card_id.Add(reader.ReadInt32());
        }
        special_coop_ani_folder = reader.ReadString();
        special_coop_desc = reader.ReadInt32();
        fate_name = reader.ReadInt32();
        fate_desc = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private byte[] id;

    private byte[] main_hero_id;

    private byte[] fate_hero_id;

    private byte[] r_lv_passive_id;

    private byte[] sr_lv_passive_id;

    private byte[] ssr_lv_passive_id;

    private byte[] ur_lv_passive_id;

    private byte[] lr_lv_passive_id;

    private byte[] special_coop_card_id_1;

    private byte[] special_coop_card_id_2;

    private byte[] special_coop_card_id_3;

    private byte[] special_coop_card_id_4;

    private byte[] special_coop_card_id_5;

    private byte[] special_coop_card_id_6;

    private List<int> list_array_lr_grade_special_coop_card_id;

    private string special_coop_ani_folder;

    private int special_coop_desc;

    private int fate_name;

    private int fate_desc;

    private List<int> list_special_coop_card_id;
}
