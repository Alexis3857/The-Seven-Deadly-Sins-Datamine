﻿public class DBEventBalloondartBalloonRow
{
    public int Id => id;

    public int BalloonScoreHit => balloon_score_hit;

    public int BalloonScoreMatch => balloon_score_match;

    public int BalloonScoreSpecial => balloon_score_special;

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        balloon_score_hit = reader.ReadInt32();
        balloon_score_match = reader.ReadInt32();
        balloon_score_special = reader.ReadInt32();
        return true;
    }

    private int id;

    private int balloon_score_hit;

    private int balloon_score_match;

    private int balloon_score_special;
}