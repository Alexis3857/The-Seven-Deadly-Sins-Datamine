public class DBArtifactCategoryRow : ITableRowIndexer
{
    public int CardCategoryId
    {
        get
        {
            return card_category_id;
        }
    }

    public byte ArtifactType
    {
        get
        {
            return artifact_type;
        }
    }

    public string CategoryName
    {
        get
        {
            return category_name.Localize();
        }
    }

    public byte CategoryType
    {
        get
        {
            return category_type;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        card_category_id = reader.ReadInt32();
        artifact_type = reader.ReadByte();
        category_name = reader.ReadInt32();
        category_type = reader.ReadByte();
        return true;
    }

    public int GetRowIndex()
    {
        return CardCategoryId;
    }

    private int card_category_id;

    private byte artifact_type;

    private int category_name;

    private byte category_type;
}
