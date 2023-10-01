public class DBCardpackArtifactEventRow : ITableRowIndexer
{
    public int CardpackId
    {
        get
        {
            return cardpack_id;
        }
    }

    public int CardpackGroupId
    {
        get
        {
            return cardpack_group_id;
        }
    }

    public int ArtifactId
    {
        get
        {
            return artifact_id;
        }
    }

    public int ArtifactRate
    {
        get
        {
            return artifact_rate;
        }
    }

    public int WishRate
    {
        get
        {
            return wish_rate;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        cardpack_id = reader.ReadInt32();
        cardpack_group_id = reader.ReadInt32();
        artifact_id = reader.ReadInt32();
        artifact_rate = reader.ReadInt32();
        wish_rate = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return CardpackId;
    }

    private int cardpack_id;

    private int cardpack_group_id;

    private int artifact_id;

    private int artifact_rate;

    private int wish_rate;
}
