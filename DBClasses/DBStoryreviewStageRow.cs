public class DBStoryreviewStageRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int RootId
    {
        get
        {
            return root_id;
        }
    }

    public string RootName
    {
        get
        {
            return root_name;
        }
    }

    public List<int> ListArrayMainStageId
    {
        get
        {
            return list_array_main_stage_id;
        }
    }

    public List<int> ListArrayQuestStageId
    {
        get
        {
            return list_array_quest_stage_id;
        }
    }

    public List<int> ListArrayLimitedStageId
    {
        get
        {
            return list_array_limited_stage_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        root_id = reader.ReadInt32();
        root_name = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_main_stage_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_main_stage_id.Add(reader.ReadInt32());
        }
        int num2 = reader.ReadInt32();
        list_array_quest_stage_id = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_quest_stage_id.Add(reader.ReadInt32());
        }
        int num3 = reader.ReadInt32();
        list_array_limited_stage_id = new List<int>();
        for (int k = 0; k < num3; k++)
        {
            list_array_limited_stage_id.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int root_id;

    private string root_name;

    private List<int> list_array_main_stage_id;

    private List<int> list_array_quest_stage_id;

    private List<int> list_array_limited_stage_id;
}
