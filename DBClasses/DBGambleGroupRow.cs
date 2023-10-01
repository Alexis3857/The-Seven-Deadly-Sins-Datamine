public class DBGambleGroupRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GambleGroup
    {
        get
        {
            return gamble_group;
        }
    }

    public int SkinId
    {
        get
        {
            return skin_id;
        }
    }

    public int GambleRate
    {
        get
        {
            return gamble_rate;
        }
    }

    public int PickUpCheck
    {
        get
        {
            return pick_up_check;
        }
    }

    public int SkinLevel
    {
        get
        {
            return skin_level;
        }
    }

    public int SkinAwaken
    {
        get
        {
            return skin_awaken;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        gamble_group = reader.ReadInt32();
        skin_id = reader.ReadInt32();
        gamble_rate = reader.ReadInt32();
        pick_up_check = reader.ReadInt32();
        skin_level = reader.ReadInt32();
        skin_awaken = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int gamble_group;

    private int skin_id;

    private int gamble_rate;

    private int pick_up_check;

    private int skin_level;

    private int skin_awaken;
}
