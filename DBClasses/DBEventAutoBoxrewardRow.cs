public class DBEventAutoBoxrewardRow : ITableRowIndexer
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

    public int BoxGrade
    {
        get
        {
            return box_grade;
        }
    }

    public int RewardId
    {
        get
        {
            return reward_id;
        }
    }

    public int RewardCount
    {
        get
        {
            return reward_count;
        }
    }

    public int Rate
    {
        get
        {
            return rate;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        box_grade = reader.ReadInt32();
        reward_id = reader.ReadInt32();
        reward_count = reader.ReadInt32();
        rate = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int box_grade;

    private int reward_id;

    private int reward_count;

    private int rate;
}
