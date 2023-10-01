public class DBMonsterAiRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string BossTeamAi1
    {
        get
        {
            return boss_team_ai_1;
        }
    }

    public string BossTeamAi2
    {
        get
        {
            return boss_team_ai_2;
        }
    }

    public string BossTeamAi3
    {
        get
        {
            return boss_team_ai_3;
        }
    }

    public string BossTeamAi4
    {
        get
        {
            return boss_team_ai_4;
        }
    }

    public string BossTeamAi5
    {
        get
        {
            return boss_team_ai_5;
        }
    }

    public string BossTeamAi6
    {
        get
        {
            return boss_team_ai_6;
        }
    }

    public string NormalTeamAi1
    {
        get
        {
            return normal_team_ai_1;
        }
    }

    public string NormalTeamAi2
    {
        get
        {
            return normal_team_ai_2;
        }
    }

    public string NormalTeamAi3
    {
        get
        {
            return normal_team_ai_3;
        }
    }

    public List<string> ListBossTeamAi
    {
        get
        {
            if (list_boss_team_ai == null)
            {
                list_boss_team_ai = new List<string>
                {
                    BossTeamAi1,
                    BossTeamAi2,
                    BossTeamAi3,
                    BossTeamAi4,
                    BossTeamAi5,
                    BossTeamAi6
                };
            }
            return list_boss_team_ai;
        }
    }

    public List<string> ListNormalTeamAi
    {
        get
        {
            if (list_normal_team_ai == null)
            {
                list_normal_team_ai = new List<string>
                {
                    NormalTeamAi1,
                    NormalTeamAi2,
                    NormalTeamAi3
                };
            }
            return list_normal_team_ai;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        boss_team_ai_1 = reader.ReadString();
        boss_team_ai_2 = reader.ReadString();
        boss_team_ai_3 = reader.ReadString();
        boss_team_ai_4 = reader.ReadString();
        boss_team_ai_5 = reader.ReadString();
        boss_team_ai_6 = reader.ReadString();
        normal_team_ai_1 = reader.ReadString();
        normal_team_ai_2 = reader.ReadString();
        normal_team_ai_3 = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string boss_team_ai_1;

    private string boss_team_ai_2;

    private string boss_team_ai_3;

    private string boss_team_ai_4;

    private string boss_team_ai_5;

    private string boss_team_ai_6;

    private string normal_team_ai_1;

    private string normal_team_ai_2;

    private string normal_team_ai_3;

    private List<string> list_boss_team_ai;

    private List<string> list_normal_team_ai;
}
