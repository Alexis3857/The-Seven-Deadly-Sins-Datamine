public class DBCreaturePassiveRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int PassiveGroupId
    {
        get
        {
            return passive_group_id;
        }
    }

    public int PassivePhase
    {
        get
        {
            return passive_Phase;
        }
    }

    public int SkillPassiveId
    {
        get
        {
            return skill_passive_id;
        }
    }

    public string CreatureMent
    {
        get
        {
            return creature_ment.Localize();
        }
    }

    public string CreaturePassiveAni
    {
        get
        {
            return creature_passive_ani;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        passive_group_id = reader.ReadInt32();
        passive_Phase = reader.ReadInt32();
        skill_passive_id = reader.ReadInt32();
        creature_ment = reader.ReadInt32();
        creature_passive_ani = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int passive_group_id;

    private int passive_Phase;

    private int skill_passive_id;

    private int creature_ment;

    private string creature_passive_ani;
}
