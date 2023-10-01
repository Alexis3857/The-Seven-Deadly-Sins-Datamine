public class DBStageAncientMissionBuffRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int StageId
    {
        get
        {
            return stage_id;
        }
    }

    public int MissionClearValue
    {
        get
        {
            return mission_clear_value;
        }
    }

    public List<int> ListArrayAllyUseBuffId
    {
        get
        {
            return list_array_ally_use_buff_id;
        }
    }

    public List<int> ListArrayEnemyUseBuffId
    {
        get
        {
            return list_array_enemy_use_buff_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        stage_id = reader.ReadInt32();
        mission_clear_value = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_ally_use_buff_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_ally_use_buff_id.Add(reader.ReadInt32());
        }
        int num2 = reader.ReadInt32();
        list_array_enemy_use_buff_id = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_enemy_use_buff_id.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int stage_id;

    private int mission_clear_value;

    private List<int> list_array_ally_use_buff_id;

    private List<int> list_array_enemy_use_buff_id;
}
