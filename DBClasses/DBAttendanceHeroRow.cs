public class DBAttendanceHeroRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ListNumber
    {
        get
        {
            return list_number;
        }
    }

    public int Type
    {
        get
        {
            return type;
        }
    }

    public string HeroIcon
    {
        get
        {
            return hero_icon;
        }
    }

    public string Resource
    {
        get
        {
            return resource;
        }
    }

    public string HeadResource
    {
        get
        {
            return head_resource;
        }
    }

    public string BodyResource
    {
        get
        {
            return body_resource;
        }
    }

    public string WeaponResource
    {
        get
        {
            return weapon_resource;
        }
    }

    public int WeaponModelType
    {
        get
        {
            return weapon_model_type;
        }
    }

    public string AnimResource
    {
        get
        {
            return anim_resource;
        }
    }

    public string ActiveStart
    {
        get
        {
            return active_start;
        }
    }

    public string ActiveEnd
    {
        get
        {
            return active_end;
        }
    }

    public string Idle1
    {
        get
        {
            return idle1;
        }
    }

    public string Idle2
    {
        get
        {
            return idle2;
        }
    }

    public string AttendanceEvent1
    {
        get
        {
            return attendance_event_1;
        }
    }

    public string AttendanceEvent1Idle
    {
        get
        {
            return attendance_event_1_idle;
        }
    }

    public string AttendanceSpecialevent1
    {
        get
        {
            return attendance_specialevent_1;
        }
    }

    public string AttendanceSpecialevent1Idle
    {
        get
        {
            return attendance_specialevent_1_idle;
        }
    }

    public float CameraHeight
    {
        get
        {
            return camera_height;
        }
    }

    public List<int> ListArrayHideNpcId
    {
        get
        {
            return list_array_hide_npc_id;
        }
    }

    public List<string> ListAttendanceEvent
    {
        get
        {
            if (list_attendance_event == null)
            {
                list_attendance_event = new List<string>
                {
                    AttendanceEvent1
                };
            }
            return list_attendance_event;
        }
    }

    public List<string> ListAttendanceSpecialevent
    {
        get
        {
            if (list_attendance_specialevent == null)
            {
                list_attendance_specialevent = new List<string>
                {
                    AttendanceSpecialevent1
                };
            }
            return list_attendance_specialevent;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        list_number = reader.ReadInt32();
        type = reader.ReadInt32();
        hero_icon = reader.ReadString();
        resource = reader.ReadString();
        head_resource = reader.ReadString();
        body_resource = reader.ReadString();
        weapon_resource = reader.ReadString();
        weapon_model_type = reader.ReadInt32();
        anim_resource = reader.ReadString();
        active_start = reader.ReadString();
        active_end = reader.ReadString();
        idle1 = reader.ReadString();
        idle2 = reader.ReadString();
        attendance_event_1 = reader.ReadString();
        attendance_event_1_idle = reader.ReadString();
        attendance_specialevent_1 = reader.ReadString();
        attendance_specialevent_1_idle = reader.ReadString();
        camera_height = reader.ReadSingle();
        int num = reader.ReadInt32();
        list_array_hide_npc_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_hide_npc_id.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int list_number;

    private int type;

    private string hero_icon;

    private string resource;

    private string head_resource;

    private string body_resource;

    private string weapon_resource;

    private int weapon_model_type;

    private string anim_resource;

    private string active_start;

    private string active_end;

    private string idle1;

    private string idle2;

    private string attendance_event_1;

    private string attendance_event_1_idle;

    private string attendance_specialevent_1;

    private string attendance_specialevent_1_idle;

    private float camera_height;

    private List<int> list_array_hide_npc_id;

    private List<string> list_attendance_event;

    private List<string> list_attendance_specialevent;
}
