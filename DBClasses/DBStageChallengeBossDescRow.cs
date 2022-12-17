public class DBStageChallengeBossDescRow
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string ChallengeBossStrongSkillDesc
    {
        get
        {
            return challenge_boss_strong_skill_desc;
        }
    }

    public string ChallengeBossPatternDesc
    {
        get
        {
            return challenge_boss_pattern_desc;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        challenge_boss_strong_skill_desc = reader.ReadString();
        challenge_boss_pattern_desc = reader.ReadString();
        return true;
    }

    private int id;

    private string challenge_boss_strong_skill_desc;

    private string challenge_boss_pattern_desc;
}
