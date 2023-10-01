public class DBSkillRetryRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string MatcingDbName
    {
        get
        {
            return matcing_db_name;
        }
    }

    public int MatcingId1
    {
        get
        {
            return matcing_id_1;
        }
    }

    public int CheckVersion
    {
        get
        {
            return check_version;
        }
    }

    public int RetryOn
    {
        get
        {
            return retry_on;
        }
    }

    public List<int> ListMatcingId
    {
        get
        {
            if (list_matcing_id == null)
            {
                list_matcing_id = new List<int>
                {
                    MatcingId1
                };
            }
            return list_matcing_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        matcing_db_name = reader.ReadString();
        matcing_id_1 = reader.ReadInt32();
        check_version = reader.ReadInt32();
        retry_on = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string matcing_db_name;

    private int matcing_id_1;

    private int check_version;

    private int retry_on;

    private List<int> list_matcing_id;
}
