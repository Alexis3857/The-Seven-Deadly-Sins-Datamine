public class DBStageFinalBossVowRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int VowGroupId
    {
        get
        {
            return vow_group_id;
        }
    }

    public string VowName
    {
        get
        {
            return vow_name.Localize();
        }
    }

    public string VowType
    {
        get
        {
            return vow_type;
        }
    }

    public int VowTypeValue
    {
        get
        {
            return vow_type_value;
        }
    }

    public int LocalizeDisplayType
    {
        get
        {
            return localize_display_type;
        }
    }

    public float VowRewardValue
    {
        get
        {
            return vow_reward_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        vow_group_id = reader.ReadInt32();
        vow_name = reader.ReadInt32();
        vow_type = reader.ReadString();
        vow_type_value = reader.ReadInt32();
        localize_display_type = reader.ReadInt32();
        vow_reward_value = reader.ReadSingle();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int vow_group_id;

    private int vow_name;

    private string vow_type;

    private int vow_type_value;

    private int localize_display_type;

    private float vow_reward_value;
}
