public class DBWeaponAutoSettingRow : ITableRowIndexer
{
    public int SetAutoId
    {
        get
        {
            return set_auto_id;
        }
    }

    public List<int> ListArraySetAutoPriority
    {
        get
        {
            return list_array_set_auto_priority;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        set_auto_id = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_set_auto_priority = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_set_auto_priority.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return SetAutoId;
    }

    private int set_auto_id;

    private List<int> list_array_set_auto_priority;
}
