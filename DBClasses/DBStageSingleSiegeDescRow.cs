public class DBStageSingleSiegeDescRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string DestroyStrongTribeDesc
    {
        get
        {
            return destroy_strong_tribe_desc;
        }
    }

    public string DestroyWeakTribeDesc
    {
        get
        {
            return destroy_weak_tribe_desc;
        }
    }

    public string DestroyStrongSkillDesc
    {
        get
        {
            return destroy_strong_skill_desc;
        }
    }

    public string DestroyPatternDesc
    {
        get
        {
            return destroy_pattern_desc;
        }
    }

    public string DestroySkillDesc
    {
        get
        {
            return destroy_skill_desc;
        }
    }

    public string DestroyPassiveDesc
    {
        get
        {
            return destroy_passive_desc;
        }
    }

    public string DestroyIdlePath
    {
        get
        {
            return destroy_idle_path;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        destroy_strong_tribe_desc = reader.ReadString();
        destroy_weak_tribe_desc = reader.ReadString();
        destroy_strong_skill_desc = reader.ReadString();
        destroy_pattern_desc = reader.ReadString();
        destroy_skill_desc = reader.ReadString();
        destroy_passive_desc = reader.ReadString();
        destroy_idle_path = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string destroy_strong_tribe_desc;

    private string destroy_weak_tribe_desc;

    private string destroy_strong_skill_desc;

    private string destroy_pattern_desc;

    private string destroy_skill_desc;

    private string destroy_passive_desc;

    private string destroy_idle_path;
}
