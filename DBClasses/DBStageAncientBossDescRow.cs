public class DBStageAncientBossDescRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string AncientBossStrongSkillDesc
    {
        get
        {
            return ancient_boss_strong_skill_desc;
        }
    }

    public string AncientBossPatternDesc
    {
        get
        {
            return ancient_boss_pattern_desc;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        ancient_boss_strong_skill_desc = reader.ReadString();
        ancient_boss_pattern_desc = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string ancient_boss_strong_skill_desc;

    private string ancient_boss_pattern_desc;
}
