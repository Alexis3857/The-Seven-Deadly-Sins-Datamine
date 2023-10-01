public class DBMazeShopBuffRow : ITableRowIndexer
{
    public int Id => id;

    public string MazeBuffType => maze_buff_type;

    public int BuffLevel => buff_level;

    public string BuffIconName => buff_icon_name;

    public int PriceId => price_id;

    public int PriceCount => price_count;

    public float AddAtk => add_atk;

    public float AddFixedAtkPer => add_fixed_atk_per;

    public float AddCritPer => add_crit_per;

    public float AddCritAtkPer => add_crit_atk_per;

    public float AddDef => add_def;

    public float AddFixedDefPer => add_fixed_def_per;

    public float AddCritResPer => add_crit_res_per;

    public float AddCritDefPer => add_crit_def_per;

    public float AddHp => add_hp;

    public float AddHpRegenPer => add_hp_regen_per;

    public float AddHpRecoveryPer => add_hp_recovery_per;

    public float AddHpStealPer => add_hp_steal_per;

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        maze_buff_type = reader.ReadString();
        buff_level = reader.ReadInt32();
        buff_icon_name = reader.ReadString();
        price_id = reader.ReadInt32();
        price_count = reader.ReadInt32();
        add_atk = reader.ReadSingle();
        add_fixed_atk_per = reader.ReadSingle();
        add_crit_per = reader.ReadSingle();
        add_crit_atk_per = reader.ReadSingle();
        add_def = reader.ReadSingle();
        add_fixed_def_per = reader.ReadSingle();
        add_crit_res_per = reader.ReadSingle();
        add_crit_def_per = reader.ReadSingle();
        add_hp = reader.ReadSingle();
        add_hp_regen_per = reader.ReadSingle();
        add_hp_recovery_per = reader.ReadSingle();
        add_hp_steal_per = reader.ReadSingle();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string maze_buff_type;

    private int buff_level;

    private string buff_icon_name;

    private int price_id;

    private int price_count;

    private float add_atk;

    private float add_fixed_atk_per;

    private float add_crit_per;

    private float add_crit_atk_per;

    private float add_def;

    private float add_fixed_def_per;

    private float add_crit_res_per;

    private float add_crit_def_per;

    private float add_hp;

    private float add_hp_regen_per;

    private float add_hp_recovery_per;

    private float add_hp_steal_per;
}