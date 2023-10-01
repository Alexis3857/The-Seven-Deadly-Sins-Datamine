public class DBBasepointNpcTalkRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int CheckId
    {
        get
        {
            return check_id;
        }
    }

    public int NpcId
    {
        get
        {
            return npc_id;
        }
    }

    public string OpenType
    {
        get
        {
            return open_type;
        }
    }

    public int InteractiveTalkNpcGroup
    {
        get
        {
            return interactive_talk_npc_group;
        }
    }

    public string StartQuestStep
    {
        get
        {
            return start_quest_step;
        }
    }

    public int StartQuestId
    {
        get
        {
            return start_quest_id;
        }
    }

    public string EndQuestStep
    {
        get
        {
            return end_quest_step;
        }
    }

    public int EndQuestId
    {
        get
        {
            return end_quest_id;
        }
    }

    public string TalkString
    {
        get
        {
            return talk_string.Localize();
        }
    }

    public string Animation
    {
        get
        {
            return animation;
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
        check_id = reader.ReadInt32();
        npc_id = reader.ReadInt32();
        open_type = reader.ReadString();
        interactive_talk_npc_group = reader.ReadInt32();
        start_quest_step = reader.ReadString();
        start_quest_id = reader.ReadInt32();
        end_quest_step = reader.ReadString();
        end_quest_id = reader.ReadInt32();
        talk_string = reader.ReadInt32();
        animation = reader.ReadString();
        voice_sound_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int check_id;

    private int npc_id;

    private string open_type;

    private int interactive_talk_npc_group;

    private string start_quest_step;

    private int start_quest_id;

    private string end_quest_step;

    private int end_quest_id;

    private int talk_string;

    private string animation;

    private int voice_sound_id;
}
