public class DBSetCostumeRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string SetCostumeName
    {
        get
        {
            return set_costume_name.Localize();
        }
    }

    public int HeroGroup
    {
        get
        {
            return hero_group;
        }
    }

    public int SetCostumeBase
    {
        get
        {
            return set_costume_base;
        }
    }

    public int SetCostumeWeapon
    {
        get
        {
            return set_costume_weapon;
        }
    }

    public int SetCostumeHead
    {
        get
        {
            return set_costume_head;
        }
    }

    public int NormalAttackSfxId
    {
        get
        {
            return normal_attack_sfx_id;
        }
    }

    public int CriticalAttackSfxId
    {
        get
        {
            return critical_attack_sfx_id;
        }
    }

    public string SetPassiveType
    {
        get
        {
            return set_passive_type;
        }
    }

    public int SetPassiveId
    {
        get
        {
            return set_passive_id;
        }
    }

    public List<int> ListArrayEventSpecialHeroId
    {
        get
        {
            return list_array_event_special_hero_id;
        }
    }

    public string EventSpecialAniName
    {
        get
        {
            return event_special_ani_name;
        }
    }

    public int EventSpecialId1
    {
        get
        {
            return event_special_id_1;
        }
    }

    public int EventSpecialId2
    {
        get
        {
            return event_special_id_2;
        }
    }

    public int EventSpecialId3
    {
        get
        {
            return event_special_id_3;
        }
    }

    public int EventSpecialId4
    {
        get
        {
            return event_special_id_4;
        }
    }

    public int EventSpecialId5
    {
        get
        {
            return event_special_id_5;
        }
    }

    public int EventSpecialId6
    {
        get
        {
            return event_special_id_6;
        }
    }

    public List<int> ListEventSpecialId
    {
        get
        {
            if (list_event_special_id == null)
            {
                list_event_special_id = new List<int>
                {
                    EventSpecialId1,
                    EventSpecialId2,
                    EventSpecialId3,
                    EventSpecialId4,
                    EventSpecialId5,
                    EventSpecialId6
                };
            }
            return list_event_special_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        set_costume_name = reader.ReadInt32();
        hero_group = reader.ReadInt32();
        set_costume_base = reader.ReadInt32();
        set_costume_weapon = reader.ReadInt32();
        set_costume_head = reader.ReadInt32();
        normal_attack_sfx_id = reader.ReadInt32();
        critical_attack_sfx_id = reader.ReadInt32();
        set_passive_type = reader.ReadString();
        set_passive_id = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_event_special_hero_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_event_special_hero_id.Add(reader.ReadInt32());
        }
        event_special_ani_name = reader.ReadString();
        event_special_id_1 = reader.ReadInt32();
        event_special_id_2 = reader.ReadInt32();
        event_special_id_3 = reader.ReadInt32();
        event_special_id_4 = reader.ReadInt32();
        event_special_id_5 = reader.ReadInt32();
        event_special_id_6 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int set_costume_name;

    private int hero_group;

    private int set_costume_base;

    private int set_costume_weapon;

    private int set_costume_head;

    private int normal_attack_sfx_id;

    private int critical_attack_sfx_id;

    private string set_passive_type;

    private int set_passive_id;

    private List<int> list_array_event_special_hero_id;

    private string event_special_ani_name;

    private int event_special_id_1;

    private int event_special_id_2;

    private int event_special_id_3;

    private int event_special_id_4;

    private int event_special_id_5;

    private int event_special_id_6;

    private List<int> list_event_special_id;
}
