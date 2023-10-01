public class DBAniLocalizeRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string MatchingDbName
    {
        get
        {
            return matching_db_name;
        }
    }

    public List<int> ListArrayMatchingId
    {
        get
        {
            return list_array_matching_id;
        }
    }

    public int WeaponOn
    {
        get
        {
            return weapon_on;
        }
    }

    public int PropOn
    {
        get
        {
            return prop_on;
        }
    }

    public string AniPath1
    {
        get
        {
            return ani_path_1;
        }
    }

    public string AniPath2
    {
        get
        {
            return ani_path_2;
        }
    }

    public int AniOn
    {
        get
        {
            return ani_on;
        }
    }

    public string FacialOn
    {
        get
        {
            return facial_on;
        }
    }

    public string AniLocalName
    {
        get
        {
            return ani_local_name.Localize();
        }
    }

    public string AniClip1
    {
        get
        {
            return ani_clip_1;
        }
    }

    public string AniClip2
    {
        get
        {
            return ani_clip_2;
        }
    }

    public string AniClip3
    {
        get
        {
            return ani_clip_3;
        }
    }

    public string AniClip4
    {
        get
        {
            return ani_clip_4;
        }
    }

    public string AniClip5
    {
        get
        {
            return ani_clip_5;
        }
    }

    public string AniClip6
    {
        get
        {
            return ani_clip_6;
        }
    }

    public List<string> ListAniPath
    {
        get
        {
            if (list_ani_path == null)
            {
                list_ani_path = new List<string>
                {
                    AniPath1,
                    AniPath2
                };
            }
            return list_ani_path;
        }
    }

    public List<string> ListAniClip
    {
        get
        {
            if (list_ani_clip == null)
            {
                list_ani_clip = new List<string>
                {
                    AniClip1,
                    AniClip2,
                    AniClip3,
                    AniClip4,
                    AniClip5,
                    AniClip6
                };
            }
            return list_ani_clip;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        matching_db_name = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_matching_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_matching_id.Add(reader.ReadInt32());
        }
        weapon_on = reader.ReadInt32();
        prop_on = reader.ReadInt32();
        ani_path_1 = reader.ReadString();
        ani_path_2 = reader.ReadString();
        ani_on = reader.ReadInt32();
        facial_on = reader.ReadString();
        ani_local_name = reader.ReadInt32();
        ani_clip_1 = reader.ReadString();
        ani_clip_2 = reader.ReadString();
        ani_clip_3 = reader.ReadString();
        ani_clip_4 = reader.ReadString();
        ani_clip_5 = reader.ReadString();
        ani_clip_6 = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string matching_db_name;

    private List<int> list_array_matching_id;

    private int weapon_on;

    private int prop_on;

    private string ani_path_1;

    private string ani_path_2;

    private int ani_on;

    private string facial_on;

    private int ani_local_name;

    private string ani_clip_1;

    private string ani_clip_2;

    private string ani_clip_3;

    private string ani_clip_4;

    private string ani_clip_5;

    private string ani_clip_6;

    private List<string> list_ani_path;

    private List<string> list_ani_clip;
}
