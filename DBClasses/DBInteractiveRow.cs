public class DBInteractiveRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GuestId
    {
        get
        {
            return guest_id;
        }
    }

    public int NpcType
    {
        get
        {
            return npc_type;
        }
    }

    public int UseSubCostume
    {
        get
        {
            return use_sub_costume;
        }
    }

    public string Type
    {
        get
        {
            return type;
        }
    }

    public int Level
    {
        get
        {
            return level;
        }
    }

    public string Question
    {
        get
        {
            return question;
        }
    }

    public string PlayerGoodAnswer
    {
        get
        {
            return player_good_answer;
        }
    }

    public int GoodAnswerValue
    {
        get
        {
            return good_answer_value;
        }
    }

    public string GoodFeedback
    {
        get
        {
            return good_feedback;
        }
    }

    public string PlayerNormalAnswer
    {
        get
        {
            return player_normal_answer;
        }
    }

    public int NormalAnswerValue
    {
        get
        {
            return normal_answer_value;
        }
    }

    public string NormalFeedback
    {
        get
        {
            return normal_feedback;
        }
    }

    public string PlayerBadAnswer
    {
        get
        {
            return player_bad_answer;
        }
    }

    public int BadAnswerValue
    {
        get
        {
            return bad_answer_value;
        }
    }

    public string BadFeedback
    {
        get
        {
            return bad_feedback;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        guest_id = reader.ReadInt32();
        npc_type = reader.ReadInt32();
        use_sub_costume = reader.ReadInt32();
        type = reader.ReadString();
        level = reader.ReadInt32();
        question = reader.ReadString();
        player_good_answer = reader.ReadString();
        good_answer_value = reader.ReadInt32();
        good_feedback = reader.ReadString();
        player_normal_answer = reader.ReadString();
        normal_answer_value = reader.ReadInt32();
        normal_feedback = reader.ReadString();
        player_bad_answer = reader.ReadString();
        bad_answer_value = reader.ReadInt32();
        bad_feedback = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int guest_id;

    private int npc_type;

    private int use_sub_costume;

    private string type;

    private int level;

    private string question;

    private string player_good_answer;

    private int good_answer_value;

    private string good_feedback;

    private string player_normal_answer;

    private int normal_answer_value;

    private string normal_feedback;

    private string player_bad_answer;

    private int bad_answer_value;

    private string bad_feedback;
}
