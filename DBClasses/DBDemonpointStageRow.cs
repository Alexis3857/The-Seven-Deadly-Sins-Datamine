public class DBDemonpointStageRow : ITableRowIndexer
{
    public int Id => id;

    public string ControlType => control_type;

    public int DemonlordPoint => demonlord_point;

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        control_type = reader.ReadString();
        demonlord_point = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string control_type;

    private int demonlord_point;
}