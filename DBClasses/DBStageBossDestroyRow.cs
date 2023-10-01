public class DBStageBossDestroyRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int Region
    {
        get
        {
            return region;
        }
    }

    public int LimitCount
    {
        get
        {
            return limit_count;
        }
    }

    public List<int> ListArrayDestroyGroup
    {
        get
        {
            return list_array_destroy_group;
        }
    }

    public List<int> ListArrayDestroyGroupRate
    {
        get
        {
            return list_array_destroy_group_rate;
        }
    }

    public List<int> ListArrayHighRankDestroyGroup
    {
        get
        {
            return list_array_high_rank_destroy_group;
        }
    }

    public List<int> ListArrayHighRankDestroyGroupRate
    {
        get
        {
            return list_array_high_rank_destroy_group_rate;
        }
    }

    public List<int> ListArrayArea
    {
        get
        {
            return list_array_area;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        region = reader.ReadInt32();
        limit_count = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_destroy_group = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_destroy_group.Add(reader.ReadInt32());
        }
        int num2 = reader.ReadInt32();
        list_array_destroy_group_rate = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_destroy_group_rate.Add(reader.ReadInt32());
        }
        int num3 = reader.ReadInt32();
        list_array_high_rank_destroy_group = new List<int>();
        for (int k = 0; k < num3; k++)
        {
            list_array_high_rank_destroy_group.Add(reader.ReadInt32());
        }
        int num4 = reader.ReadInt32();
        list_array_high_rank_destroy_group_rate = new List<int>();
        for (int l = 0; l < num4; l++)
        {
            list_array_high_rank_destroy_group_rate.Add(reader.ReadInt32());
        }
        int num5 = reader.ReadInt32();
        list_array_area = new List<int>();
        for (int m = 0; m < num5; m++)
        {
            list_array_area.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int region;

    private int limit_count;

    private List<int> list_array_destroy_group;

    private List<int> list_array_destroy_group_rate;

    private List<int> list_array_high_rank_destroy_group;

    private List<int> list_array_high_rank_destroy_group_rate;

    private List<int> list_array_area;
}
