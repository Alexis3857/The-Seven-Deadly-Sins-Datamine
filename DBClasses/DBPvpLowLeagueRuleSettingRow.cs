public class DBPvpLowLeagueRuleSettingRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string LowLeagueStartDate
    {
        get
        {
            return low_league_start_date;
        }
    }

    public int PvpLowLeaguePassiveId
    {
        get
        {
            return pvp_low_league_passive_id;
        }
    }

    public string PvpLowLeaguePassiveIcon
    {
        get
        {
            return pvp_low_league_passive_icon;
        }
    }

    public int PvpLowLeagueModeId
    {
        get
        {
            return pvp_low_league_mode_id;
        }
    }

    public int LowLeagueRewardGroup
    {
        get
        {
            return low_league_reward_group;
        }
    }

    public int NpcId
    {
        get
        {
            return npc_id;
        }
    }

    public string AddCombatMenuLabel
    {
        get
        {
            return add_combat_menu_label;
        }
    }

    public string ChangeSpeechBubbleIcon
    {
        get
        {
            return change_speech_bubble_icon;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        low_league_start_date = reader.ReadString();
        pvp_low_league_passive_id = reader.ReadInt32();
        pvp_low_league_passive_icon = reader.ReadString();
        pvp_low_league_mode_id = reader.ReadInt32();
        low_league_reward_group = reader.ReadInt32();
        npc_id = reader.ReadInt32();
        add_combat_menu_label = reader.ReadString();
        change_speech_bubble_icon = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string low_league_start_date;

    private int pvp_low_league_passive_id;

    private string pvp_low_league_passive_icon;

    private int pvp_low_league_mode_id;

    private int low_league_reward_group;

    private int npc_id;

    private string add_combat_menu_label;

    private string change_speech_bubble_icon;
}
