public class DBStageFinalBossBattlescoreRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int BattlescoreGroupId
    {
        get
        {
            return battlescore_group_id;
        }
    }

    public string ChecklistName
    {
        get
        {
            return checklist_name.Localize();
        }
    }

    public int BattlescoreCategory
    {
        get
        {
            return battlescore_category;
        }
    }

    public string BattlescoreType
    {
        get
        {
            return battlescore_type;
        }
    }

    public int ClientVisible
    {
        get
        {
            return client_visible;
        }
    }

    public float ChecklistValue
    {
        get
        {
            return checklist_value;
        }
    }

    public List<int> ListArrayTypeId
    {
        get
        {
            return list_array_type_id;
        }
    }

    public int IngameBsNotice
    {
        get
        {
            return ingame_bs_notice;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        battlescore_group_id = reader.ReadInt32();
        checklist_name = reader.ReadInt32();
        battlescore_category = reader.ReadInt32();
        battlescore_type = reader.ReadString();
        client_visible = reader.ReadInt32();
        checklist_value = reader.ReadSingle();
        int num = reader.ReadInt32();
        list_array_type_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_type_id.Add(reader.ReadInt32());
        }
        ingame_bs_notice = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int battlescore_group_id;

    private int checklist_name;

    private int battlescore_category;

    private string battlescore_type;

    private int client_visible;

    private float checklist_value;

    private List<int> list_array_type_id;

    private int ingame_bs_notice;
}
