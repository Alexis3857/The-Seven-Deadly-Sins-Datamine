public class DBEventProvisionCutsceneRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public int ProgressRate
    {
        get
        {
            return progress_rate;
        }
    }

    public int StoryCutsceneId
    {
        get
        {
            return story_cutscene_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        progress_rate = reader.ReadInt32();
        story_cutscene_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int progress_rate;

    private int story_cutscene_id;
}
