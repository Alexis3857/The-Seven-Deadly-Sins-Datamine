public class DBArtifactGroupRow : ITableRowIndexer
{
    public int CardGroupId
    {
        get
        {
            return card_group_id;
        }
    }

    public int GroupIndex
    {
        get
        {
            return group_index;
        }
    }

    public byte ArtifactType
    {
        get
        {
            return artifact_type;
        }
    }

    public string GroupName
    {
        get
        {
            return group_name;
        }
    }

    public string GroupIcon
    {
        get
        {
            return group_icon;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        card_group_id = reader.ReadInt32();
        group_index = reader.ReadInt32();
        artifact_type = reader.ReadByte();
        group_name = reader.ReadString();
        group_icon = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return CardGroupId;
    }

    private int card_group_id;

    private int group_index;

    private byte artifact_type;

    private string group_name;

    private string group_icon;
}
