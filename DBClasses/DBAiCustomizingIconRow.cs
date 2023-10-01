public class DBAiCustomizingIconRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public byte AiIconCheck
    {
        get
        {
            return ai_icon_check;
        }
    }

    public int AiIconNumber
    {
        get
        {
            return ai_icon_number;
        }
    }

    public string AiCustomizingIcon
    {
        get
        {
            return ai_customizing_icon;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        ai_icon_check = reader.ReadByte();
        ai_icon_number = reader.ReadInt32();
        ai_customizing_icon = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private byte ai_icon_check;

    private int ai_icon_number;

    private string ai_customizing_icon;
}
