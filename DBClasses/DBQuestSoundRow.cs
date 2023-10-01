public class DBQuestSoundRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int SoundId
    {
        get
        {
            return sound_id;
        }
    }

    public int ContentsId
    {
        get
        {
            return contents_id;
        }
    }

    public string BgmOpenType
    {
        get
        {
            return bgm_open_type;
        }
    }

    public int BgmOpenValue
    {
        get
        {
            return bgm_open_value;
        }
    }

    public string BgmCloseType
    {
        get
        {
            return bgm_close_type;
        }
    }

    public int BgmCloseValue
    {
        get
        {
            return bgm_close_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        sound_id = reader.ReadInt32();
        contents_id = reader.ReadInt32();
        bgm_open_type = reader.ReadString();
        bgm_open_value = reader.ReadInt32();
        bgm_close_type = reader.ReadString();
        bgm_close_value = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int sound_id;

    private int contents_id;

    private string bgm_open_type;

    private int bgm_open_value;

    private string bgm_close_type;

    private int bgm_close_value;
}
