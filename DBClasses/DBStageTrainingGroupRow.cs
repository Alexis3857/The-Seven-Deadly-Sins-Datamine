public class DBStageTrainingGroupRow : ITableRowIndexer
{
    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public int StageTrainingType
    {
        get
        {
            return stage_training_type;
        }
    }

    public int StageId1
    {
        get
        {
            return stage_id_1;
        }
    }

    public int StageId2
    {
        get
        {
            return stage_id_2;
        }
    }

    public int StageId3
    {
        get
        {
            return stage_id_3;
        }
    }

    public int StageId4
    {
        get
        {
            return stage_id_4;
        }
    }

    public int StageRate
    {
        get
        {
            return stage_rate;
        }
    }

    public List<int> ListStageId
    {
        get
        {
            if (list_stage_id == null)
            {
                list_stage_id = new List<int>
                {
                    StageId1,
                    StageId2,
                    StageId3,
                    StageId4
                };
            }
            return list_stage_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        group_id = reader.ReadInt32();
        stage_training_type = reader.ReadInt32();
        stage_id_1 = reader.ReadInt32();
        stage_id_2 = reader.ReadInt32();
        stage_id_3 = reader.ReadInt32();
        stage_id_4 = reader.ReadInt32();
        stage_rate = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return GroupId;
    }

    private int group_id;

    private int stage_training_type;

    private int stage_id_1;

    private int stage_id_2;

    private int stage_id_3;

    private int stage_id_4;

    private int stage_rate;

    private List<int> list_stage_id;
}
