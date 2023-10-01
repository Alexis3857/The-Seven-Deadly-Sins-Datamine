public class DBPassMissionRankRow : ITableRowIndexer
{
    public int MissionRank
    {
        get
        {
            return mission_rank;
        }
    }

    public int NeedMissionPoint
    {
        get
        {
            return need_mission_point;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        mission_rank = reader.ReadInt32();
        need_mission_point = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return MissionRank;
    }

    private int mission_rank;

    private int need_mission_point;
}
