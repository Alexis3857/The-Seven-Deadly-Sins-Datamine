public class DBGuildWarAreaBuffRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string MainAreaPassiveType
    {
        get
        {
            return main_area_passive_type;
        }
    }

    public int MainAreaPassiveId
    {
        get
        {
            return main_area_passive_id;
        }
    }

    public string RestAreaPassiveType
    {
        get
        {
            return rest_area_passive_type;
        }
    }

    public int RestAreaPassiveId
    {
        get
        {
            return rest_area_passive_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        main_area_passive_type = reader.ReadString();
        main_area_passive_id = reader.ReadInt32();
        rest_area_passive_type = reader.ReadString();
        rest_area_passive_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string main_area_passive_type;

    private int main_area_passive_id;

    private string rest_area_passive_type;

    private int rest_area_passive_id;
}
