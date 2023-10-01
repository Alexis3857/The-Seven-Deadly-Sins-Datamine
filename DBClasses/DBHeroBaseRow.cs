public class DBHeroBaseRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 658U;
        }
    }

    public int Id
    {
        get
        {
            return base.DecryptInt32(id);
        }
    }

    public int HeroList
    {
        get
        {
            return base.DecryptInt32(hero_list);
        }
    }

    public byte HeroWantedDisplay
    {
        get
        {
            return hero_wanted_display;
        }
    }

    public int HeroDisplay
    {
        get
        {
            return base.DecryptInt32(hero_display);
        }
    }

    public string OpenStartDate
    {
        get
        {
            return open_start_date;
        }
    }

    public int HeroGroup
    {
        get
        {
            return base.DecryptInt32(hero_group);
        }
    }

    public List<int> ListArrayHeroGroupCheck
    {
        get
        {
            return list_array_hero_group_check;
        }
    }

    public int NpcType
    {
        get
        {
            return base.DecryptInt32(npc_type);
        }
    }

    public int Kind
    {
        get
        {
            return base.DecryptInt32(kind);
        }
    }

    public byte SubKindCheck
    {
        get
        {
            return sub_kind_check;
        }
    }

    public int SubKind
    {
        get
        {
            return base.DecryptInt32(sub_kind);
        }
    }

    public int BaseSkin
    {
        get
        {
            return base.DecryptInt32(base_skin);
        }
    }

    public int WeaponIdleStart
    {
        get
        {
            return base.DecryptInt32(weapon_idle_start);
        }
    }

    public byte WeaponHideActive
    {
        get
        {
            return weapon_hide_active;
        }
    }

    public byte NeckDmyNoneActive
    {
        get
        {
            return neck_dmy_none_active;
        }
    }

    public string HeroCategory
    {
        get
        {
            return hero_category;
        }
    }

    public string MainHeroType
    {
        get
        {
            return main_hero_type;
        }
    }

    public List<int> ListArrayHeroJobGroup
    {
        get
        {
            return list_array_hero_job_group;
        }
    }

    public string CollaborationName
    {
        get
        {
            return collaboration_name.Localize();
        }
    }

    public string HeroGender
    {
        get
        {
            return hero_gender.Localize();
        }
    }

    public int EventMissionGender
    {
        get
        {
            return base.DecryptInt32(event_mission_gender);
        }
    }

    public string HeroAge
    {
        get
        {
            return hero_age.Localize();
        }
    }

    public string HeroBirth
    {
        get
        {
            return hero_birth.Localize();
        }
    }

    public string HeroHeight
    {
        get
        {
            return hero_height;
        }
    }

    public string HeroWeight
    {
        get
        {
            return hero_weight;
        }
    }

    public string HeroBlood
    {
        get
        {
            return hero_blood;
        }
    }

    public string HeroVoice
    {
        get
        {
            return hero_voice.Localize();
        }
    }

    public int HeroAction1
    {
        get
        {
            return base.DecryptInt32(hero_action_1);
        }
    }

    public int HeroAction2
    {
        get
        {
            return base.DecryptInt32(hero_action_2);
        }
    }

    public int HeroAction3
    {
        get
        {
            return base.DecryptInt32(hero_action_3);
        }
    }

    public int HeroAction4
    {
        get
        {
            return base.DecryptInt32(hero_action_4);
        }
    }

    public int HeroAction5
    {
        get
        {
            return base.DecryptInt32(hero_action_5);
        }
    }

    public int HeroAction6
    {
        get
        {
            return base.DecryptInt32(hero_action_6);
        }
    }

    public string HeroSpecial
    {
        get
        {
            return hero_special.Localize();
        }
    }

    public string HeroLrSpecial
    {
        get
        {
            return hero_lr_special.Localize();
        }
    }

    public string HeroCoopMain
    {
        get
        {
            return hero_coop_main.Localize();
        }
    }

    public string HeroCoopSub
    {
        get
        {
            return hero_coop_sub.Localize();
        }
    }

    public string FameAnim
    {
        get
        {
            return fame_anim;
        }
    }

    public byte HeroAwakenPackageActive
    {
        get
        {
            return hero_awaken_package_active;
        }
    }

    public List<int> ListHeroAction
    {
        get
        {
            if (list_hero_action == null)
            {
                list_hero_action = new List<int>
                {
                    HeroAction1,
                    HeroAction2,
                    HeroAction3,
                    HeroAction4,
                    HeroAction5,
                    HeroAction6
                };
            }
            return list_hero_action;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadBytes(4);
        hero_list = reader.ReadBytes(4);
        hero_wanted_display = reader.ReadByte();
        hero_display = reader.ReadBytes(4);
        open_start_date = reader.ReadString();
        hero_group = reader.ReadBytes(4);
        int num = reader.ReadInt32();
        list_array_hero_group_check = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_hero_group_check.Add(reader.ReadInt32());
        }
        npc_type = reader.ReadBytes(4);
        kind = reader.ReadBytes(4);
        sub_kind_check = reader.ReadByte();
        sub_kind = reader.ReadBytes(4);
        base_skin = reader.ReadBytes(4);
        weapon_idle_start = reader.ReadBytes(4);
        weapon_hide_active = reader.ReadByte();
        neck_dmy_none_active = reader.ReadByte();
        hero_category = reader.ReadString();
        main_hero_type = reader.ReadString();
        int num2 = reader.ReadInt32();
        list_array_hero_job_group = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_hero_job_group.Add(reader.ReadInt32());
        }
        collaboration_name = reader.ReadInt32();
        hero_gender = reader.ReadInt32();
        event_mission_gender = reader.ReadBytes(4);
        hero_age = reader.ReadInt32();
        hero_birth = reader.ReadInt32();
        hero_height = reader.ReadString();
        hero_weight = reader.ReadString();
        hero_blood = reader.ReadString();
        hero_voice = reader.ReadInt32();
        hero_action_1 = reader.ReadBytes(4);
        hero_action_2 = reader.ReadBytes(4);
        hero_action_3 = reader.ReadBytes(4);
        hero_action_4 = reader.ReadBytes(4);
        hero_action_5 = reader.ReadBytes(4);
        hero_action_6 = reader.ReadBytes(4);
        hero_special = reader.ReadInt32();
        hero_lr_special = reader.ReadInt32();
        hero_coop_main = reader.ReadInt32();
        hero_coop_sub = reader.ReadInt32();
        fame_anim = reader.ReadString();
        hero_awaken_package_active = reader.ReadByte();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private byte[] id;

    private byte[] hero_list;

    private byte hero_wanted_display;

    private byte[] hero_display;

    private string open_start_date;

    private byte[] hero_group;

    private List<int> list_array_hero_group_check;

    private byte[] npc_type;

    private byte[] kind;

    private byte sub_kind_check;

    private byte[] sub_kind;

    private byte[] base_skin;

    private byte[] weapon_idle_start;

    private byte weapon_hide_active;

    private byte neck_dmy_none_active;

    private string hero_category;

    private string main_hero_type;

    private List<int> list_array_hero_job_group;

    private int collaboration_name;

    private int hero_gender;

    private byte[] event_mission_gender;

    private int hero_age;

    private int hero_birth;

    private string hero_height;

    private string hero_weight;

    private string hero_blood;

    private int hero_voice;

    private byte[] hero_action_1;

    private byte[] hero_action_2;

    private byte[] hero_action_3;

    private byte[] hero_action_4;

    private byte[] hero_action_5;

    private byte[] hero_action_6;

    private int hero_special;

    private int hero_lr_special;

    private int hero_coop_main;

    private int hero_coop_sub;

    private string fame_anim;

    private byte hero_awaken_package_active;

    private List<int> list_hero_action;
}
