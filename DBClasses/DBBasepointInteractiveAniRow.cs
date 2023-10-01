public class DBBasepointInteractiveAniRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int BasepointId
    {
        get
        {
            return basepoint_id;
        }
    }

    public int QuestCharacterId
    {
        get
        {
            return quest_character_id;
        }
    }

    public string OpenType
    {
        get
        {
            return open_type;
        }
    }

    public int OpenValue
    {
        get
        {
            return open_value;
        }
    }

    public string CloseType
    {
        get
        {
            return close_type;
        }
    }

    public int CloseValue
    {
        get
        {
            return close_value;
        }
    }

    public string BasepointActionAni
    {
        get
        {
            return basepoint_action_ani;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        basepoint_id = reader.ReadInt32();
        quest_character_id = reader.ReadInt32();
        open_type = reader.ReadString();
        open_value = reader.ReadInt32();
        close_type = reader.ReadString();
        close_value = reader.ReadInt32();
        basepoint_action_ani = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int basepoint_id;

    private int quest_character_id;

    private string open_type;

    private int open_value;

    private string close_type;

    private int close_value;

    private string basepoint_action_ani;
}
