public class DBHeroLeagueStageRow : ITableRowIndexer
{
    public int Id { get => id; }
    public string Type { get => type; }
    public string ControlType { get => control_type; }

    public int Tier { get => tier; }
    public int UserGroup { get => user_group; }
    public int TeamPower { get => team_power; }
    public string StageString { get => stage_string.Localize(); }
    public int MatchTeamNumber { get => match_team_number; }
    public int IsTurnPivot { get => is_turn_pivot; }
    public int PlayBossSpawn { get => play_boss_spawn; }
    public string BossEntryType { get => boss_entry_type; }
    public string MapFilename { get => map_filename; }
    public int BgmSoundId { get => bgm_sound_id; }
    public int BossSoundId { get => boss_sound_id; }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        type = reader.ReadString();
        control_type = reader.ReadString();
        tier = reader.ReadInt32();
        user_group = reader.ReadInt32();
        team_power = reader.ReadInt32();
        stage_string = reader.ReadInt32();
        match_team_number = reader.ReadInt32();
        is_turn_pivot = reader.ReadInt32();
        play_boss_spawn = reader.ReadInt32();
        boss_entry_type = reader.ReadString();
        map_filename = reader.ReadString();
        bgm_sound_id = reader.ReadInt32();
        boss_sound_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string type;

    private string control_type;

    private int tier;

    private int user_group;

    private int team_power;

    private int stage_string;

    private int match_team_number;

    private int is_turn_pivot;

    private int play_boss_spawn;

    private string boss_entry_type;

    private string map_filename;

    private int bgm_sound_id;

    private int boss_sound_id;
}