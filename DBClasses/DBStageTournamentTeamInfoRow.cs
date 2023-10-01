public class DBStageTournamentTeamInfoRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int DifficultyCheck
    {
        get
        {
            return difficulty_check;
        }
    }

    public int GroupCheck
    {
        get
        {
            return group_check;
        }
    }

    public int TeamCheck
    {
        get
        {
            return team_check;
        }
    }

    public string DifficultyDesc
    {
        get
        {
            return difficulty_desc.Localize();
        }
    }

    public int DifficultyTeamPower
    {
        get
        {
            return difficulty_team_power;
        }
    }

    public string GroupName
    {
        get
        {
            return group_name.Localize();
        }
    }

    public string GroupResourcePath
    {
        get
        {
            return group_resource_path;
        }
    }

    public string GroupResource
    {
        get
        {
            return group_resource;
        }
    }

    public List<int> ListArrayTeamSkinIdCheck
    {
        get
        {
            return list_array_team_skin_id_check;
        }
    }

    public List<int> ListArrayTeamHeroIdCheck
    {
        get
        {
            return list_array_team_hero_id_check;
        }
    }

    public int ClearFirstRewardId1
    {
        get
        {
            return clear_first_reward_id_1;
        }
    }

    public int ClearFirstRewardValue1
    {
        get
        {
            return clear_first_reward_value_1;
        }
    }

    public int ClearFirstRewardId2
    {
        get
        {
            return clear_first_reward_id_2;
        }
    }

    public int ClearFirstRewardValue2
    {
        get
        {
            return clear_first_reward_value_2;
        }
    }

    public int ClearFirstRewardId3
    {
        get
        {
            return clear_first_reward_id_3;
        }
    }

    public int ClearFirstRewardValue3
    {
        get
        {
            return clear_first_reward_value_3;
        }
    }

    public int WinningTeamRewardId1
    {
        get
        {
            return winning_team_reward_id_1;
        }
    }

    public int WinningTeamRewardValue1
    {
        get
        {
            return winning_team_reward_value_1;
        }
    }

    public List<int> ListArrayTournamentRound16Group
    {
        get
        {
            return list_array_tournament_round_16_group;
        }
    }

    public List<int> ListArrayTournamentRound8Group
    {
        get
        {
            return list_array_tournament_round_8_group;
        }
    }

    public List<int> ListArrayTournamentRound4Group
    {
        get
        {
            return list_array_tournament_round_4_group;
        }
    }

    public List<int> ListArrayTournamentRound2Group
    {
        get
        {
            return list_array_tournament_round_2_group;
        }
    }

    public int TournamentNpcTeamId
    {
        get
        {
            return tournament_npc_team_id;
        }
    }

    public List<int> ListClearFirstRewardId
    {
        get
        {
            if (list_clear_first_reward_id == null)
            {
                list_clear_first_reward_id = new List<int>
                {
                    ClearFirstRewardId1,
                    ClearFirstRewardId2,
                    ClearFirstRewardId3
                };
            }
            return list_clear_first_reward_id;
        }
    }

    public List<int> ListClearFirstRewardValue
    {
        get
        {
            if (list_clear_first_reward_value == null)
            {
                list_clear_first_reward_value = new List<int>
                {
                    ClearFirstRewardValue1,
                    ClearFirstRewardValue2,
                    ClearFirstRewardValue3
                };
            }
            return list_clear_first_reward_value;
        }
    }

    public List<int> ListWinningTeamRewardId
    {
        get
        {
            if (list_winning_team_reward_id == null)
            {
                list_winning_team_reward_id = new List<int>
                {
                    WinningTeamRewardId1
                };
            }
            return list_winning_team_reward_id;
        }
    }

    public List<int> ListWinningTeamRewardValue
    {
        get
        {
            if (list_winning_team_reward_value == null)
            {
                list_winning_team_reward_value = new List<int>
                {
                    WinningTeamRewardValue1
                };
            }
            return list_winning_team_reward_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        difficulty_check = reader.ReadInt32();
        group_check = reader.ReadInt32();
        team_check = reader.ReadInt32();
        difficulty_desc = reader.ReadInt32();
        difficulty_team_power = reader.ReadInt32();
        group_name = reader.ReadInt32();
        group_resource_path = reader.ReadString();
        group_resource = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_team_skin_id_check = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_team_skin_id_check.Add(reader.ReadInt32());
        }
        int num2 = reader.ReadInt32();
        list_array_team_hero_id_check = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_team_hero_id_check.Add(reader.ReadInt32());
        }
        clear_first_reward_id_1 = reader.ReadInt32();
        clear_first_reward_value_1 = reader.ReadInt32();
        clear_first_reward_id_2 = reader.ReadInt32();
        clear_first_reward_value_2 = reader.ReadInt32();
        clear_first_reward_id_3 = reader.ReadInt32();
        clear_first_reward_value_3 = reader.ReadInt32();
        winning_team_reward_id_1 = reader.ReadInt32();
        winning_team_reward_value_1 = reader.ReadInt32();
        int num3 = reader.ReadInt32();
        list_array_tournament_round_16_group = new List<int>();
        for (int k = 0; k < num3; k++)
        {
            list_array_tournament_round_16_group.Add(reader.ReadInt32());
        }
        int num4 = reader.ReadInt32();
        list_array_tournament_round_8_group = new List<int>();
        for (int l = 0; l < num4; l++)
        {
            list_array_tournament_round_8_group.Add(reader.ReadInt32());
        }
        int num5 = reader.ReadInt32();
        list_array_tournament_round_4_group = new List<int>();
        for (int m = 0; m < num5; m++)
        {
            list_array_tournament_round_4_group.Add(reader.ReadInt32());
        }
        int num6 = reader.ReadInt32();
        list_array_tournament_round_2_group = new List<int>();
        for (int n = 0; n < num6; n++)
        {
            list_array_tournament_round_2_group.Add(reader.ReadInt32());
        }
        tournament_npc_team_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int difficulty_check;

    private int group_check;

    private int team_check;

    private int difficulty_desc;

    private int difficulty_team_power;

    private int group_name;

    private string group_resource_path;

    private string group_resource;

    private List<int> list_array_team_skin_id_check;

    private List<int> list_array_team_hero_id_check;

    private int clear_first_reward_id_1;

    private int clear_first_reward_value_1;

    private int clear_first_reward_id_2;

    private int clear_first_reward_value_2;

    private int clear_first_reward_id_3;

    private int clear_first_reward_value_3;

    private int winning_team_reward_id_1;

    private int winning_team_reward_value_1;

    private List<int> list_array_tournament_round_16_group;

    private List<int> list_array_tournament_round_8_group;

    private List<int> list_array_tournament_round_4_group;

    private List<int> list_array_tournament_round_2_group;

    private int tournament_npc_team_id;

    private List<int> list_clear_first_reward_id;

    private List<int> list_clear_first_reward_value;

    private List<int> list_winning_team_reward_id;

    private List<int> list_winning_team_reward_value;
}
