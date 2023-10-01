public class DBEventMoleGameNoteRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int HawkRate1
    {
        get
        {
            return hawk_rate_1;
        }
    }

    public int HawkRate2
    {
        get
        {
            return hawk_rate_2;
        }
    }

    public int HawkRate3
    {
        get
        {
            return hawk_rate_3;
        }
    }

    public int HawkRate4
    {
        get
        {
            return hawk_rate_4;
        }
    }

    public int HawkRate5
    {
        get
        {
            return hawk_rate_5;
        }
    }

    public int TriggrHawkId
    {
        get
        {
            return triggr_hawk_id;
        }
    }

    public int TunnelOutTimeMin
    {
        get
        {
            return tunnel_out_time_min;
        }
    }

    public int TunnelOutTimeMax
    {
        get
        {
            return tunnel_out_time_max;
        }
    }

    public float TunnelOutTime
    {
        get
        {
            return tunnel_out_time;
        }
    }

    public float AnimationSpeed
    {
        get
        {
            return animation_speed;
        }
    }

    public int ReadyTime
    {
        get
        {
            return ready_time;
        }
    }

    public float WaitTime
    {
        get
        {
            return wait_time;
        }
    }

    public int DevilMantaSpeed
    {
        get
        {
            return devil_manta_speed;
        }
    }

    public List<int> ListHawkRate
    {
        get
        {
            if (list_hawk_rate == null)
            {
                list_hawk_rate = new List<int>
                {
                    HawkRate1,
                    HawkRate2,
                    HawkRate3,
                    HawkRate4,
                    HawkRate5
                };
            }
            return list_hawk_rate;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        hawk_rate_1 = reader.ReadInt32();
        hawk_rate_2 = reader.ReadInt32();
        hawk_rate_3 = reader.ReadInt32();
        hawk_rate_4 = reader.ReadInt32();
        hawk_rate_5 = reader.ReadInt32();
        triggr_hawk_id = reader.ReadInt32();
        tunnel_out_time_min = reader.ReadInt32();
        tunnel_out_time_max = reader.ReadInt32();
        tunnel_out_time = reader.ReadSingle();
        animation_speed = reader.ReadSingle();
        ready_time = reader.ReadInt32();
        wait_time = reader.ReadSingle();
        devil_manta_speed = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int hawk_rate_1;

    private int hawk_rate_2;

    private int hawk_rate_3;

    private int hawk_rate_4;

    private int hawk_rate_5;

    private int triggr_hawk_id;

    private int tunnel_out_time_min;

    private int tunnel_out_time_max;

    private float tunnel_out_time;

    private float animation_speed;

    private int ready_time;

    private float wait_time;

    private int devil_manta_speed;

    private List<int> list_hawk_rate;
}
