public class DBEventConfirmImageRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ImageSubIndex
    {
        get
        {
            return image_sub_index;
        }
    }

    public string ImageIdle
    {
        get
        {
            return image_idle;
        }
    }

    public string ImageMiss
    {
        get
        {
            return image_miss;
        }
    }

    public string ImageSuccess1
    {
        get
        {
            return image_success_1;
        }
    }

    public string ImageSuccess2
    {
        get
        {
            return image_success_2;
        }
    }

    public string ImageSuccess3
    {
        get
        {
            return image_success_3;
        }
    }

    public string ImageSuccess4
    {
        get
        {
            return image_success_4;
        }
    }

    public string ImageSuccess5
    {
        get
        {
            return image_success_5;
        }
    }

    public string ImageSuccess6
    {
        get
        {
            return image_success_6;
        }
    }

    public string ImageHold
    {
        get
        {
            return image_hold;
        }
    }

    public string ImageDown
    {
        get
        {
            return image_down;
        }
    }

    public List<string> ListImageSuccess
    {
        get
        {
            if (list_image_success == null)
            {
                list_image_success = new List<string>
                {
                    ImageSuccess1,
                    ImageSuccess2,
                    ImageSuccess3,
                    ImageSuccess4,
                    ImageSuccess5,
                    ImageSuccess6
                };
            }
            return list_image_success;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        image_sub_index = reader.ReadInt32();
        image_idle = reader.ReadString();
        image_miss = reader.ReadString();
        image_success_1 = reader.ReadString();
        image_success_2 = reader.ReadString();
        image_success_3 = reader.ReadString();
        image_success_4 = reader.ReadString();
        image_success_5 = reader.ReadString();
        image_success_6 = reader.ReadString();
        image_hold = reader.ReadString();
        image_down = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int image_sub_index;

    private string image_idle;

    private string image_miss;

    private string image_success_1;

    private string image_success_2;

    private string image_success_3;

    private string image_success_4;

    private string image_success_5;

    private string image_success_6;

    private string image_hold;

    private string image_down;

    private List<string> list_image_success;
}