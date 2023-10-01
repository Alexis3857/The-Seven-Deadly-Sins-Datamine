public class DBArtifactCardRow : ITableRowIndexer
{
    public int ArtifactId
    {
        get
        {
            return artifact_id;
        }
    }

    public string ArtifactIconSRoute
    {
        get
        {
            return artifact_icon_s_route;
        }
    }

    public string ArtifactIconS
    {
        get
        {
            return artifact_icon_s;
        }
    }

    public string ArtifactIconMRoute
    {
        get
        {
            return artifact_icon_m_route;
        }
    }

    public string ArtifactIconM
    {
        get
        {
            return artifact_icon_m;
        }
    }

    public string FullSizeImageRoute
    {
        get
        {
            return full_size_image_route;
        }
    }

    public string FullSizeImage
    {
        get
        {
            return full_size_image;
        }
    }

    public int ArtifactCategoryId
    {
        get
        {
            return artifact_category_id;
        }
    }

    public byte ArtifactType
    {
        get
        {
            return artifact_type;
        }
    }

    public int ArtifactTypeId
    {
        get
        {
            return artifact_type_id;
        }
    }

    public byte ArtifactRating
    {
        get
        {
            return artifact_rating;
        }
    }

    public int ArtifactAtk
    {
        get
        {
            return artifact_atk;
        }
    }

    public int ArtifactDef
    {
        get
        {
            return artifact_def;
        }
    }

    public int ArtifactHp
    {
        get
        {
            return artifact_hp;
        }
    }

    public int ReplaceId
    {
        get
        {
            return replace_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        artifact_id = reader.ReadInt32();
        artifact_icon_s_route = reader.ReadString();
        artifact_icon_s = reader.ReadString();
        artifact_icon_m_route = reader.ReadString();
        artifact_icon_m = reader.ReadString();
        full_size_image_route = reader.ReadString();
        full_size_image = reader.ReadString();
        artifact_category_id = reader.ReadInt32();
        artifact_type = reader.ReadByte();
        artifact_type_id = reader.ReadInt32();
        artifact_rating = reader.ReadByte();
        artifact_atk = reader.ReadInt32();
        artifact_def = reader.ReadInt32();
        artifact_hp = reader.ReadInt32();
        replace_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return ArtifactId;
    }

    private int artifact_id;

    private string artifact_icon_s_route;

    private string artifact_icon_s;

    private string artifact_icon_m_route;

    private string artifact_icon_m;

    private string full_size_image_route;

    private string full_size_image;

    private int artifact_category_id;

    private byte artifact_type;

    private int artifact_type_id;

    private byte artifact_rating;

    private int artifact_atk;

    private int artifact_def;

    private int artifact_hp;

    private int replace_id;
}
