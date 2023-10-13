public class DBPvpChaosBaseRow : ITableRowIndexer
{
    public int Id { get => id; }
    public string SeasonStartData { get => season_start_date; }
    public string SeasonFinishData { get => season_finish_date; }
    public string SeasonSBanner { get => season_s_banner; }
    public string SeasonSBannerTitle { get => season_s_banner_title.Localize(); }
    public string SeasonSBannerDesc { get => season_s_banner_desc.Localize(); }
    public int CombatMenuLabel { get => combat_menu_label; }
    public int ButtonEffect { get => button_effect; }
    public int TeamCostLimit { get => team_cost_limit; }
    public int HeroGradeBasic { get => hero_grade_basic; }
    public int HeroCostBasic { get => hero_cost_basic; }
    public int DailyRewardId { get => daily_reward_id; }
    public int DailyRewardCount { get => daily_reward_count; }
    public int DailyRewardLimit { get => daily_reward_limit; }
    public int DailyPlayLimit { get => daily_play_limit; }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        season_start_date = reader.ReadString();
        season_finish_date = reader.ReadString();
        season_s_banner = reader.ReadString();
        season_s_banner_title = reader.ReadInt32();
        season_s_banner_desc = reader.ReadInt32();
        combat_menu_label = reader.ReadInt32();
        button_effect = reader.ReadInt32();
        team_cost_limit = reader.ReadInt32();
        hero_grade_basic = reader.ReadInt32();
        hero_cost_basic = reader.ReadInt32();
        daily_reward_id = reader.ReadInt32();
        daily_reward_count = reader.ReadInt32();
        daily_reward_limit = reader.ReadInt32();
        daily_play_limit = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string season_start_date;

    private string season_finish_date;

    private string season_s_banner;

    private int season_s_banner_title;

    private int season_s_banner_desc;

    private int combat_menu_label;

    private int button_effect;

    private int team_cost_limit;

    private int hero_grade_basic;

    private int hero_cost_basic;

    private int daily_reward_id;

    private int daily_reward_count;

    private int daily_reward_limit;

    private int daily_play_limit;
}