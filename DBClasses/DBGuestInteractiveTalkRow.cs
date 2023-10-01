public class DBGuestInteractiveTalkRow : ITableRowIndexer
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

    public int GiftIndex
    {
        get
        {
            return gift_index;
        }
    }

    public int GuestType
    {
        get
        {
            return guest_type;
        }
    }

    public string Question1
    {
        get
        {
            return question_1.Localize();
        }
    }

    public string Answer1
    {
        get
        {
            return answer_1.Localize();
        }
    }

    public string Answer2
    {
        get
        {
            return answer_2.Localize();
        }
    }

    public string Answer3
    {
        get
        {
            return answer_3.Localize();
        }
    }

    public string AnswerReaction1
    {
        get
        {
            return answer_reaction_1.Localize();
        }
    }

    public string AnswerReaction2
    {
        get
        {
            return answer_reaction_2.Localize();
        }
    }

    public string AnswerReaction3
    {
        get
        {
            return answer_reaction_3.Localize();
        }
    }

    public int AnswerFellowCount1
    {
        get
        {
            return answer_fellow_count_1;
        }
    }

    public int AnswerFellowCount2
    {
        get
        {
            return answer_fellow_count_2;
        }
    }

    public int AnswerFellowCount3
    {
        get
        {
            return answer_fellow_count_3;
        }
    }

    public List<string> ListQuestion
    {
        get
        {
            if (list_question == null)
            {
                list_question = new List<string>
                {
                    Question1
                };
            }
            return list_question;
        }
    }

    public List<string> ListAnswer
    {
        get
        {
            if (list_answer == null)
            {
                list_answer = new List<string>
                {
                    Answer1,
                    Answer2,
                    Answer3
                };
            }
            return list_answer;
        }
    }

    public List<string> ListAnswerReaction
    {
        get
        {
            if (list_answer_reaction == null)
            {
                list_answer_reaction = new List<string>
                {
                    AnswerReaction1,
                    AnswerReaction2,
                    AnswerReaction3
                };
            }
            return list_answer_reaction;
        }
    }

    public List<int> ListAnswerFellowCount
    {
        get
        {
            if (list_answer_fellow_count == null)
            {
                list_answer_fellow_count = new List<int>
                {
                    AnswerFellowCount1,
                    AnswerFellowCount2,
                    AnswerFellowCount3
                };
            }
            return list_answer_fellow_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        guest_id = reader.ReadInt32();
        gift_index = reader.ReadInt32();
        guest_type = reader.ReadInt32();
        question_1 = reader.ReadInt32();
        answer_1 = reader.ReadInt32();
        answer_2 = reader.ReadInt32();
        answer_3 = reader.ReadInt32();
        answer_reaction_1 = reader.ReadInt32();
        answer_reaction_2 = reader.ReadInt32();
        answer_reaction_3 = reader.ReadInt32();
        answer_fellow_count_1 = reader.ReadInt32();
        answer_fellow_count_2 = reader.ReadInt32();
        answer_fellow_count_3 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int guest_id;

    private int gift_index;

    private int guest_type;

    private int question_1;

    private int answer_1;

    private int answer_2;

    private int answer_3;

    private int answer_reaction_1;

    private int answer_reaction_2;

    private int answer_reaction_3;

    private int answer_fellow_count_1;

    private int answer_fellow_count_2;

    private int answer_fellow_count_3;

    private List<string> list_question;

    private List<string> list_answer;

    private List<string> list_answer_reaction;

    private List<int> list_answer_fellow_count;
}
