public class DBDemonlordPassiveRow : ITableRowIndexer
{
    public int Id => id;

    public int PassiveGroupId => passive_group_id;

    public int PassiveStep => passive_step;

    public int SkillPassiveId => skill_passive_id;

    public string DemonlordPassiveNotify => demonlord_passive_notify.Localize();

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        passive_group_id = reader.ReadInt32();
        passive_step = reader.ReadInt32();
        skill_passive_id = reader.ReadInt32();
        demonlord_passive_notify = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int passive_group_id;

    private int passive_step;

    private int skill_passive_id;

    private int demonlord_passive_notify;
}