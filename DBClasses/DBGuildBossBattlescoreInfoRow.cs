public class DBGuildBossBattlescoreInfoRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int SeasonId
    {
        get
        {
            return season_id;
        }
    }

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public int StageId
    {
        get
        {
            return stage_id;
        }
    }

    public string ChecklistName
    {
        get
        {
            return checklist_name.Localize();
        }
    }

    public string BattlescoreType
    {
        get
        {
            return BattleScore_type;
        }
    }

    public int ClientVisible
    {
        get
        {
            return client_visible;
        }
    }

    public float ChecklistValue
    {
        get
        {
            return checklist_value;
        }
    }

    public List<int> ListArrayTypeId
    {
        get
        {
            return list_array_type_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        season_id = reader.ReadInt32();
        group_id = reader.ReadInt32();
        stage_id = reader.ReadInt32();
        checklist_name = reader.ReadInt32();
        BattleScore_type = reader.ReadString();
        client_visible = reader.ReadInt32();
        checklist_value = reader.ReadSingle();
        int num = reader.ReadInt32();
        list_array_type_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_type_id.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int season_id;

    private int group_id;

    private int stage_id;

    private int checklist_name;

    private string BattleScore_type;

    private int client_visible;

    private float checklist_value;

    private List<int> list_array_type_id;
}
