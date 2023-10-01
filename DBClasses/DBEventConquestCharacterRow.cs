public class DBEventConquestCharacterRow : ITableRowIndexer
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

    public string CharacterName
    {
        get
        {
            return character_name.Localize();
        }
    }

    public int OpeningCharacterPosition
    {
        get
        {
            return opening_character_position;
        }
    }

    public int EndingCharacterPosition
    {
        get
        {
            return ending_character_position;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        character_name = reader.ReadInt32();
        character_icon_renderer = reader.ReadString();
        opening_character_position = reader.ReadInt32();
        ending_character_position = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int character_name;

    private string character_icon_renderer;

    private int opening_character_position;

    private int ending_character_position;
}