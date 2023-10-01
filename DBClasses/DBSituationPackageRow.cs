public class DBSituationPackageRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string SituationType
    {
        get
        {
            return situation_type;
        }
    }

    public int ChainId
    {
        get
        {
            return chain_id;
        }
    }

    public int SituationTargetValue
    {
        get
        {
            return situation_target_value;
        }
    }

    public int SituationTargetCount
    {
        get
        {
            return situation_target_count;
        }
    }

    public int ProductId
    {
        get
        {
            return product_id;
        }
    }

    public int SituationActiveType
    {
        get
        {
            return situation_active_type;
        }
    }

    public int SituationActiveCount
    {
        get
        {
            return situation_active_count;
        }
    }

    public string SituationResetType
    {
        get
        {
            return situation_reset_type;
        }
    }

    public int SituationResetCount
    {
        get
        {
            return situation_reset_count;
        }
    }

    public int SituationPriority
    {
        get
        {
            return situation_priority;
        }
    }

    public string PackageImageNameB
    {
        get
        {
            return package_image_name_b;
        }
    }

    public int PackageImageRewardType
    {
        get
        {
            return package_image_reward_type;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        situation_type = reader.ReadString();
        chain_id = reader.ReadInt32();
        situation_target_value = reader.ReadInt32();
        situation_target_count = reader.ReadInt32();
        product_id = reader.ReadInt32();
        situation_active_type = reader.ReadInt32();
        situation_active_count = reader.ReadInt32();
        situation_reset_type = reader.ReadString();
        situation_reset_count = reader.ReadInt32();
        situation_priority = reader.ReadInt32();
        package_image_name_b = reader.ReadString();
        package_image_reward_type = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string situation_type;

    private int chain_id;

    private int situation_target_value;

    private int situation_target_count;

    private int product_id;

    private int situation_active_type;

    private int situation_active_count;

    private string situation_reset_type;

    private int situation_reset_count;

    private int situation_priority;

    private string package_image_name_b;

    private int package_image_reward_type;
}
