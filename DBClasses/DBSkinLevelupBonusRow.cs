public class DBSkinLevelupBonusRow : ITableRowIndexer
{
    public int Id => id;

    public int BonusLevel => bonus_level;

    public int BonusItemId => bonus_item_id;

    public int BonusItemCount => bonus_item_count;

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        bonus_level = reader.ReadInt32();
        bonus_item_id = reader.ReadInt32();
        bonus_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int bonus_level;

    private int bonus_item_id;

    private int bonus_item_count;
}