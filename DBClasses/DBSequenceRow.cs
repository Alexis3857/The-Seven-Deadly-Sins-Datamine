public class DBSequenceRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public List<int> ListArrayBasepointNpcId
    {
        get
        {
            return list_array_Basepoint_npc_id;
        }
    }

    public List<int> ListArrayMoveOriginBasepointNpcId
    {
        get
        {
            return list_array_move_origin_Basepoint_npc_id;
        }
    }

    public string EventSpawnPointType
    {
        get
        {
            return event_spawn_point_type;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_Basepoint_npc_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_Basepoint_npc_id.Add(reader.ReadInt32());
        }
        int num2 = reader.ReadInt32();
        list_array_move_origin_Basepoint_npc_id = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_move_origin_Basepoint_npc_id.Add(reader.ReadInt32());
        }
        event_spawn_point_type = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private List<int> list_array_Basepoint_npc_id;

    private List<int> list_array_move_origin_Basepoint_npc_id;

    private string event_spawn_point_type;
}
