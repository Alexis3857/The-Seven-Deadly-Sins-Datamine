public class DBInteractiveTalkRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string Type
    {
        get
        {
            return type;
        }
    }

    public string Animation
    {
        get
        {
            return animation;
        }
    }

    public string AnswerString
    {
        get
        {
            return answer_string.Localize();
        }
    }

    public int VoiceSoundId
    {
        get
        {
            return voice_sound_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        type = reader.ReadString();
        animation = reader.ReadString();
        answer_string = reader.ReadInt32();
        voice_sound_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string type;

    private string animation;

    private int answer_string;

    private int voice_sound_id;
}
