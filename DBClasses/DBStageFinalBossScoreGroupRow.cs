public class DBStageFinalBossScoreGroupRow : ITableRowIndexer
{
    public int FinalBossScoreGroupId
    {
        get
        {
            return final_boss_score_group_id;
        }
    }

    public List<int> ListArrayMissionGroupId
    {
        get
        {
            return list_array_mission_group_id;
        }
    }

    public List<int> ListArrayBattlescoreGroupId
    {
        get
        {
            return list_array_battlescore_group_id;
        }
    }

    public List<int> ListArrayVowGroupId
    {
        get
        {
            return list_array_vow_group_id;
        }
    }

    public List<int> ListArrayVowSelectMax
    {
        get
        {
            return list_array_vow_select_max;
        }
    }

    public int LotationPeriod
    {
        get
        {
            return lotation_period;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        final_boss_score_group_id = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_mission_group_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_mission_group_id.Add(reader.ReadInt32());
        }
        int num2 = reader.ReadInt32();
        list_array_battlescore_group_id = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_battlescore_group_id.Add(reader.ReadInt32());
        }
        int num3 = reader.ReadInt32();
        list_array_vow_group_id = new List<int>();
        for (int k = 0; k < num3; k++)
        {
            list_array_vow_group_id.Add(reader.ReadInt32());
        }
        int num4 = reader.ReadInt32();
        list_array_vow_select_max = new List<int>();
        for (int l = 0; l < num4; l++)
        {
            list_array_vow_select_max.Add(reader.ReadInt32());
        }
        lotation_period = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return FinalBossScoreGroupId;
    }

    private int final_boss_score_group_id;

    private List<int> list_array_mission_group_id;

    private List<int> list_array_battlescore_group_id;

    private List<int> list_array_vow_group_id;

    private List<int> list_array_vow_select_max;

    private int lotation_period;
}
