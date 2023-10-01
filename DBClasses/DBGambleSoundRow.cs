public class DBGambleSoundRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int HeroId
    {
        get
        {
            return hero_id;
        }
    }

    public int GetSound1
    {
        get
        {
            return get_sound_1;
        }
    }

    public int GetSound2
    {
        get
        {
            return get_sound_2;
        }
    }

    public int DpSound1
    {
        get
        {
            return dp_sound_1;
        }
    }

    public List<int> ListGetSound
    {
        get
        {
            if (list_get_sound == null)
            {
                list_get_sound = new List<int>
                {
                    GetSound1,
                    GetSound2
                };
            }
            return list_get_sound;
        }
    }

    public List<int> ListDpSound
    {
        get
        {
            if (list_dp_sound == null)
            {
                list_dp_sound = new List<int>
                {
                    DpSound1
                };
            }
            return list_dp_sound;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        hero_id = reader.ReadInt32();
        get_sound_1 = reader.ReadInt32();
        get_sound_2 = reader.ReadInt32();
        dp_sound_1 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int hero_id;

    private int get_sound_1;

    private int get_sound_2;

    private int dp_sound_1;

    private List<int> list_get_sound;

    private List<int> list_dp_sound;
}
