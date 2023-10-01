public class DBGambleChoiceRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int ChoiceGroup
    {
        get
        {
            return choice_group;
        }
    }

    public int SkinId
    {
        get
        {
            return skin_id;
        }
    }

    public int ChoiceCheck
    {
        get
        {
            return choice_check;
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
        choice_group = reader.ReadInt32();
        skin_id = reader.ReadInt32();
        choice_check = reader.ReadInt32();
        skin_level = reader.ReadInt32();
        skin_awaken = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int choice_group;

    private int skin_id;

    private int choice_check;

    private int skin_level;

    private int skin_awaken;
}
