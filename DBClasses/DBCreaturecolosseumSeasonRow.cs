public class DBCreaturecolosseumSeasonRow : ITableRowIndexer
{
    public int Id { get => id; }

    public string SeasonStartData { get => season_start_date; }

    public string SeasonLimitedData { get => season_limited_date; }

    public string SeasonBannerS { get => season_banner_s; }

    public string SeasonBannerSTitle { get => season_banner_s_title.Localize(); }

    public string SeasonBannerSDesc { get => season_banner_s_desc.Localize(); }

    public int CombatMenuLabel { get => combat_menu_label; }

    public int ButtonEffect { get => button_effect; }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        season_start_date = reader.ReadString();
        season_limited_date = reader.ReadString();
        season_banner_s = reader.ReadString();
        season_banner_s_title = reader.ReadInt32();
        season_banner_s_desc = reader.ReadInt32();
        combat_menu_label = reader.ReadInt32();
        button_effect = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string season_start_date;

    private string season_limited_date;

    private string season_banner_s;

    private int season_banner_s_title;

    private int season_banner_s_desc;

    private int combat_menu_label;

    private int button_effect;
}