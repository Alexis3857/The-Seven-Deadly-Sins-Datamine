public class DBCraftCostumeUpgradeRow : ITableRowIndexer
{
    public int Id { get => id; }
    public int CraftCostumeGroup { get => craft_costume_group; }
    public int UpgradeType { get => upgrade_type; }
    public int UpgradeLevel { get => upgrade_level; }
    public int UpgradeStatusValue { get => upgrade_status_value; }
    public int UpgradePriceId { get => upgrade_price_id; }
    public int UpgradePriceCount { get => upgrade_price_count; }
    public int UpgradeMaterialId { get => upgrade_material_id; }
    public int UpgradeMaterialCount { get => upgrade_material_count; }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        craft_costume_group = reader.ReadInt32();
        upgrade_type = reader.ReadInt32();
        upgrade_level = reader.ReadInt32();
        upgrade_status_value = reader.ReadInt32();
        upgrade_price_id = reader.ReadInt32();
        upgrade_price_count = reader.ReadInt32();
        upgrade_material_id = reader.ReadInt32();
        upgrade_material_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int craft_costume_group;

    private int upgrade_type;

    private int upgrade_level;

    private int upgrade_status_value;

    private int upgrade_price_id;

    private int upgrade_price_count;

    private int upgrade_material_id;

    private int upgrade_material_count;
}