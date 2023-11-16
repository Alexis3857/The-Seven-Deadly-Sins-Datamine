public class DBStageDemonlordDescRow : ITableRowIndexer
{
    public int Id => id;

    public string DemonlordStrongTribeDesc => demonlord_strong_tribe_desc;

    public string DemonlordWeakTribeDesc => demonlord_weak_tribe_desc;

    public string DemonlordStrongSkillDesc => demonlord_strong_skill_desc;

    public string DemonlordPatternDesc => demonlord_pattern_desc;

    public string DemonlordIdlePath => demonlord_idle_path;

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        demonlord_strong_tribe_desc = reader.ReadString();
        demonlord_weak_tribe_desc = reader.ReadString();
        demonlord_strong_skill_desc = reader.ReadString();
        demonlord_pattern_desc = reader.ReadString();
        demonlord_idle_path = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string demonlord_strong_tribe_desc;

    private string demonlord_weak_tribe_desc;

    private string demonlord_strong_skill_desc;

    private string demonlord_pattern_desc;

    private string demonlord_idle_path;
}