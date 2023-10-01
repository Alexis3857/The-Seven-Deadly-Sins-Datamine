public class DBQuestTalkRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int QuestId
    {
        get
        {
            return quest_id;
        }
    }

    public string QuestStep
    {
        get
        {
            return quest_step;
        }
    }

    public int TalkNpcId
    {
        get
        {
            return talk_npc_id;
        }
    }

    public string TalkType
    {
        get
        {
            return talk_type;
        }
    }

    public string TalkString
    {
        get
        {
            return talk_string.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        quest_id = reader.ReadInt32();
        quest_step = reader.ReadString();
        talk_npc_id = reader.ReadInt32();
        talk_type = reader.ReadString();
        talk_string = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int quest_id;

    private string quest_step;

    private int talk_npc_id;

    private string talk_type;

    private int talk_string;
}
