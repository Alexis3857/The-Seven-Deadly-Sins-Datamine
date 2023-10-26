public class DBEventTimeMissionSettingRow : ITableRowIndexer
{
    public int Id => id;

    public int TargetEventType => target_event_type;

    public int TargetEventSubIndex => target_event_sub_index;

    public int EventSubIndex => event_sub_index;

    public string TimeMissionEventPrefab => time_mission_event_prefab;

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        target_event_type = reader.ReadInt32();
        target_event_sub_index = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        time_mission_event_prefab = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int target_event_type;

    private int target_event_sub_index;

    private int event_sub_index;

    private string time_mission_event_prefab;
}