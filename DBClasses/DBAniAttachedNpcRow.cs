public class DBAniAttachedNpcRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int BaseNpcId
    {
        get
        {
            return base_npc_id;
        }
    }

    public List<int> ListArrayAttachedNpcId
    {
        get
        {
            return list_array_attached_npc_id;
        }
    }

    public int BaseAniId
    {
        get
        {
            return base_ani_id;
        }
    }

    public List<int> ListArrayAttachedAniId
    {
        get
        {
            return list_array_attached_ani_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        base_npc_id = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_attached_npc_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_attached_npc_id.Add(reader.ReadInt32());
        }
        base_ani_id = reader.ReadInt32();
        int num2 = reader.ReadInt32();
        list_array_attached_ani_id = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_attached_ani_id.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int base_npc_id;

    private List<int> list_array_attached_npc_id;

    private int base_ani_id;

    private List<int> list_array_attached_ani_id;
}
