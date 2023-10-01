public class DBMaterialInfoRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int MaterialItemId
    {
        get
        {
            return material_item_id;
        }
    }

    public int FusionValue
    {
        get
        {
            return fusion_value;
        }
    }

    public int FusionPriority
    {
        get
        {
            return fusion_priority;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        material_item_id = reader.ReadInt32();
        fusion_value = reader.ReadInt32();
        fusion_priority = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int material_item_id;

    private int fusion_value;

    private int fusion_priority;
}
