public class DBEventPredictNpcActRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public int ConditionTotalScore
    {
        get
        {
            return condition_total_score;
        }
    }

    public string NpcAnim
    {
        get
        {
            return npc_anim;
        }
    }

    public string NpcTalk1
    {
        get
        {
            return npc_talk_1.Localize();
        }
    }

    public string NpcTalk2
    {
        get
        {
            return npc_talk_2.Localize();
        }
    }

    public string NpcTalk3
    {
        get
        {
            return npc_talk_3.Localize();
        }
    }

    public List<string> ListNpcTalk
    {
        get
        {
            if (list_npc_talk == null)
            {
                list_npc_talk = new List<string>
                {
                    NpcTalk1,
                    NpcTalk2,
                    NpcTalk3
                };
            }
            return list_npc_talk;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        condition_total_score = reader.ReadInt32();
        npc_anim = reader.ReadString();
        npc_talk_1 = reader.ReadInt32();
        npc_talk_2 = reader.ReadInt32();
        npc_talk_3 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int condition_total_score;

    private string npc_anim;

    private int npc_talk_1;

    private int npc_talk_2;

    private int npc_talk_3;

    private List<string> list_npc_talk;
}
