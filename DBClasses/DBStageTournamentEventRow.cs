public class DBStageTournamentEventRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int Difficulty
    {
        get
        {
            return difficulty;
        }
    }

    public List<int> ListArrayLinkStageTournamentId
    {
        get
        {
            return list_array_link_stage_tournament_id;
        }
    }

    public List<int> ListArrayStageTournamentRate
    {
        get
        {
            return list_array_stage_tournament_rate;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        difficulty = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_link_stage_tournament_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_link_stage_tournament_id.Add(reader.ReadInt32());
        }
        int num2 = reader.ReadInt32();
        list_array_stage_tournament_rate = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_stage_tournament_rate.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int difficulty;

    private List<int> list_array_link_stage_tournament_id;

    private List<int> list_array_stage_tournament_rate;
}
