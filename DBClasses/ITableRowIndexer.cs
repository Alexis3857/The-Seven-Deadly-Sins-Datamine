public interface ITableRowIndexer
{
    int GetRowIndex();

    bool ReadToStream(BinaryReader reader);
}
