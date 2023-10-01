public class DBCraftCostumeUpgradeFinishRow : ITableRowIndexer
{
    public int Id { get => id; }
    public int CraftCostumeGroup { get => craft_costume_group; }
    public int BonusStatusType { get => bonus_status_type; }
    public int BonusStatusValue { get => bonus_status_value; }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        craft_costume_group = reader.ReadInt32();
        bonus_status_value = reader.ReadInt32();
        bonus_status_value = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int craft_costume_group;

    private int bonus_status_type;

    private int bonus_status_value;
}