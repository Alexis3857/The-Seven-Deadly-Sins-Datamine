public class DBStageWeekSetupRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string WeekSetup
    {
        get
        {
            return week_setup;
        }
    }

    public int Materialstage1
    {
        get
        {
            return materialstage_1;
        }
    }

    public int Materialstage2
    {
        get
        {
            return materialstage_2;
        }
    }

    public int Materialstage3
    {
        get
        {
            return materialstage_3;
        }
    }

    public int Materialstage4
    {
        get
        {
            return materialstage_4;
        }
    }

    public int Materialstage5
    {
        get
        {
            return materialstage_5;
        }
    }

    public int Materialstage6
    {
        get
        {
            return materialstage_6;
        }
    }

    public int Materialstage7
    {
        get
        {
            return materialstage_7;
        }
    }

    public int Materialstage8
    {
        get
        {
            return materialstage_8;
        }
    }

    public int Materialstage9
    {
        get
        {
            return materialstage_9;
        }
    }

    public int OpenTime1
    {
        get
        {
            return open_time_1;
        }
    }

    public int CloseTime1
    {
        get
        {
            return close_time_1;
        }
    }

    public int OpenTime2
    {
        get
        {
            return open_time_2;
        }
    }

    public int CloseTime2
    {
        get
        {
            return close_time_2;
        }
    }

    public int OpenTime3
    {
        get
        {
            return open_time_3;
        }
    }

    public int CloseTime3
    {
        get
        {
            return close_time_3;
        }
    }

    public List<int> ListMaterialstage
    {
        get
        {
            if (list_materialstage == null)
            {
                list_materialstage = new List<int>
                {
                    Materialstage1,
                    Materialstage2,
                    Materialstage3,
                    Materialstage4,
                    Materialstage5,
                    Materialstage6,
                    Materialstage7,
                    Materialstage8,
                    Materialstage9
                };
            }
            return list_materialstage;
        }
    }

    public List<int> ListOpenTime
    {
        get
        {
            if (list_open_time == null)
            {
                list_open_time = new List<int>
                {
                    OpenTime1,
                    OpenTime2,
                    OpenTime3
                };
            }
            return list_open_time;
        }
    }

    public List<int> ListCloseTime
    {
        get
        {
            if (list_close_time == null)
            {
                list_close_time = new List<int>
                {
                    CloseTime1,
                    CloseTime2,
                    CloseTime3
                };
            }
            return list_close_time;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        week_setup = reader.ReadString();
        materialstage_1 = reader.ReadInt32();
        materialstage_2 = reader.ReadInt32();
        materialstage_3 = reader.ReadInt32();
        materialstage_4 = reader.ReadInt32();
        materialstage_5 = reader.ReadInt32();
        materialstage_6 = reader.ReadInt32();
        materialstage_7 = reader.ReadInt32();
        materialstage_8 = reader.ReadInt32();
        materialstage_9 = reader.ReadInt32();
        open_time_1 = reader.ReadInt32();
        close_time_1 = reader.ReadInt32();
        open_time_2 = reader.ReadInt32();
        close_time_2 = reader.ReadInt32();
        open_time_3 = reader.ReadInt32();
        close_time_3 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string week_setup;

    private int materialstage_1;

    private int materialstage_2;

    private int materialstage_3;

    private int materialstage_4;

    private int materialstage_5;

    private int materialstage_6;

    private int materialstage_7;

    private int materialstage_8;

    private int materialstage_9;

    private int open_time_1;

    private int close_time_1;

    private int open_time_2;

    private int close_time_2;

    private int open_time_3;

    private int close_time_3;

    private List<int> list_materialstage;

    private List<int> list_open_time;

    private List<int> list_close_time;
}
