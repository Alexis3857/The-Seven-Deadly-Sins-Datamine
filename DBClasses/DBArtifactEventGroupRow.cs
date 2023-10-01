public class DBArtifactEventGroupRow : ITableRowIndexer
{
    public int EventId
    {
        get
        {
            return event_id;
        }
    }

    public string GroupName
    {
        get
        {
            return group_name.Localize();
        }
    }

    public int ArtifactId1
    {
        get
        {
            return artifact_id_1;
        }
    }

    public int ArtifactId2
    {
        get
        {
            return artifact_id_2;
        }
    }

    public int ArtifactId3
    {
        get
        {
            return artifact_id_3;
        }
    }

    public int ArtifactId4
    {
        get
        {
            return artifact_id_4;
        }
    }

    public int ArtifactId5
    {
        get
        {
            return artifact_id_5;
        }
    }

    public List<int> ListArtifactId
    {
        get
        {
            if (list_artifact_id == null)
            {
                list_artifact_id = new List<int>
                {
                    ArtifactId1,
                    ArtifactId2,
                    ArtifactId3,
                    ArtifactId4,
                    ArtifactId5
                };
            }
            return list_artifact_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        event_id = reader.ReadInt32();
        group_name = reader.ReadInt32();
        artifact_id_1 = reader.ReadInt32();
        artifact_id_2 = reader.ReadInt32();
        artifact_id_3 = reader.ReadInt32();
        artifact_id_4 = reader.ReadInt32();
        artifact_id_5 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return EventId;
    }

    private int event_id;

    private int group_name;

    private int artifact_id_1;

    private int artifact_id_2;

    private int artifact_id_3;

    private int artifact_id_4;

    private int artifact_id_5;

    private List<int> list_artifact_id;
}
