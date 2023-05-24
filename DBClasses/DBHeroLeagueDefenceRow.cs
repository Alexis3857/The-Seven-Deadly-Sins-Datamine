public class DBHeroLeagueDefenceRow
{
    public int Index { get => index; }
    public int LeagueTypeGroup { get => league_type_group; }
    public int UserGroup { get => user_group; }
    public int UserNickname { get => user_nickname; }
    public int TeamNumber { get => team_number; }
    public int TeamSlot { get => team_slot; }
    public int StageId { get => stage_id; }
    public float Balance { get => balance; }
    public int FakePower { get => fake_power; }
    public int HeroId { get => hero_id; }
    public int SkinId { get => skin_id; }
    public int HeroLevel { get => hero_level; }
    public int HeroAwaken { get => hero_awaken; }
    public int HeroTranscend { get => hero_transcend; }
    public int HeroSkillLevel { get => hero_skill_level; }
    public int SkinCostume { get => skin_costume; }
    public int HeadCostume { get => head_costume; }
    public int WeaponCostume { get => weapon_costume; }
    public int CostumeCraft { get => costume_craft; }
    public int FateHeroId { get => fate_hero_id; }
    public int FateSkinId { get => fate_skin_id; }
    public int UnionId { get => union_id; }
    public int UnionExp { get => union_exp; }
    public float Atk { get => atk; }
    public float Def { get => def; }
    public float Hp { get => hp; }
    public float FixedAtkPer { get => fixed_atk_per; }
    public float CritPer { get => crit_per; }
    public float CritAtkPer { get => crit_atk_per; }
    public float FixedDefPer { get => fixed_def_per; }
    public float CritResPer { get => crit_res_per; }
    public float CritDefPer { get => crit_def_per; }
    public float HpRegenPer { get => hp_regen_per; }
    public float HpRecoveryPer { get => hp_recovery_per; }
    public float HpStealPer { get => hp_steal_per; }

    public bool ReadToStream(BinaryReader reader)
    {
        index = reader.ReadInt32();
        league_type_group = reader.ReadInt32();
        user_group = reader.ReadInt32();
        user_nickname = reader.ReadInt32();
        team_number = reader.ReadInt32();
        team_slot = reader.ReadInt32();
        stage_id = reader.ReadInt32();
        balance = reader.ReadSingle();
        fake_power = reader.ReadInt32();
        hero_id = reader.ReadInt32();
        skin_id = reader.ReadInt32();
        hero_level = reader.ReadInt32();
        hero_awaken = reader.ReadInt32();
        hero_transcend = reader.ReadInt32();
        hero_skill_level = reader.ReadInt32();
        skin_costume = reader.ReadInt32();
        head_costume = reader.ReadInt32();
        weapon_costume = reader.ReadInt32();
        costume_craft = reader.ReadInt32();
        fate_hero_id = reader.ReadInt32();
        fate_skin_id = reader.ReadInt32();
        union_id = reader.ReadInt32();
        union_exp = reader.ReadInt32();
        atk = reader.ReadSingle();
        def = reader.ReadSingle();
        hp = reader.ReadSingle();
        fixed_atk_per = reader.ReadSingle();
        crit_per = reader.ReadSingle();
        crit_atk_per = reader.ReadSingle();
        fixed_def_per = reader.ReadSingle();
        crit_res_per = reader.ReadSingle();
        crit_def_per = reader.ReadSingle();
        hp_regen_per = reader.ReadSingle();
        hp_recovery_per = reader.ReadSingle();
        hp_steal_per = reader.ReadSingle();
        return true;
    }

    private int index;

    private int league_type_group;

    private int user_group;

    private int user_nickname;

    private int team_number;

    private int team_slot;

    private int stage_id;

    private float balance;

    private int fake_power;

    private int hero_id;

    private int skin_id;

    private int hero_level;

    private int hero_awaken;

    private int hero_transcend;

    private int hero_skill_level;

    private int skin_costume;

    private int head_costume;

    private int weapon_costume;

    private int costume_craft;

    private int fate_hero_id;

    private int fate_skin_id;

    private int union_id;

    private int union_exp;

    private float atk;

    private float def;

    private float hp;

    private float fixed_atk_per;

    private float crit_per;

    private float crit_atk_per;

    private float fixed_def_per;

    private float crit_res_per;

    private float crit_def_per;

    private float hp_regen_per;

    private float hp_recovery_per;

    private float hp_steal_per;
}