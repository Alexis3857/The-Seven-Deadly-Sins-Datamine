public class DBInteractiveLinkRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int QuestionId1
    {
        get
        {
            return question_id_1;
        }
    }

    public int QuestionId2
    {
        get
        {
            return question_id_2;
        }
    }

    public int QuestionId3
    {
        get
        {
            return question_id_3;
        }
    }

    public int GiftItem
    {
        get
        {
            return gift_item;
        }
    }

    public int GiftItemValue1
    {
        get
        {
            return gift_item_value_1;
        }
    }

    public int GiftItemValue2
    {
        get
        {
            return gift_item_value_2;
        }
    }

    public int GiftItemValue3
    {
        get
        {
            return gift_item_value_3;
        }
    }

    public List<int> ListQuestionId
    {
        get
        {
            if (list_question_id == null)
            {
                list_question_id = new List<int>
                {
                    QuestionId1,
                    QuestionId2,
                    QuestionId3
                };
            }
            return list_question_id;
        }
    }

    public List<int> ListGiftItemValue
    {
        get
        {
            if (list_gift_item_value == null)
            {
                list_gift_item_value = new List<int>
                {
                    GiftItemValue1,
                    GiftItemValue2,
                    GiftItemValue3
                };
            }
            return list_gift_item_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        question_id_1 = reader.ReadInt32();
        question_id_2 = reader.ReadInt32();
        question_id_3 = reader.ReadInt32();
        gift_item = reader.ReadInt32();
        gift_item_value_1 = reader.ReadInt32();
        gift_item_value_2 = reader.ReadInt32();
        gift_item_value_3 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int question_id_1;

    private int question_id_2;

    private int question_id_3;

    private int gift_item;

    private int gift_item_value_1;

    private int gift_item_value_2;

    private int gift_item_value_3;

    private List<int> list_question_id;

    private List<int> list_gift_item_value;
}
