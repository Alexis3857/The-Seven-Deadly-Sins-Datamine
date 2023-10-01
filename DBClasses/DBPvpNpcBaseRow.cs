public class DBPvpNpcBaseRow : ITableRowIndexer
{
    public int NpcId
    {
        get
        {
            return npc_id;
        }
    }

    public int SkinId
    {
        get
        {
            return skin_id;
        }
    }

    public int TeamGroupId
    {
        get
        {
            return team_group_id;
        }
    }

    public int NpcExp
    {
        get
        {
            return npc_exp;
        }
    }

    public int WeaponCostumeId
    {
        get
        {
            return weapon_costume_id;
        }
    }

    public int WeaponCostumeHold
    {
        get
        {
            return weapon_costume_hold;
        }
    }

    public int SkinCostumeId
    {
        get
        {
            return skin_costume_id;
        }
    }

    public int SkinCostumeHold
    {
        get
        {
            return skin_costume_hold;
        }
    }

    public int AwakenCount
    {
        get
        {
            return awaken_count;
        }
    }

    public int SpecialSkillLevel
    {
        get
        {
            return special_skill_level;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        npc_id = reader.ReadInt32();
        skin_id = reader.ReadInt32();
        team_group_id = reader.ReadInt32();
        npc_exp = reader.ReadInt32();
        weapon_costume_id = reader.ReadInt32();
        weapon_costume_hold = reader.ReadInt32();
        skin_costume_id = reader.ReadInt32();
        skin_costume_hold = reader.ReadInt32();
        awaken_count = reader.ReadInt32();
        special_skill_level = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return NpcId;
    }

    private int npc_id;

    private int skin_id;

    private int team_group_id;

    private int npc_exp;

    private int weapon_costume_id;

    private int weapon_costume_hold;

    private int skin_costume_id;

    private int skin_costume_hold;

    private int awaken_count;

    private int special_skill_level;
}
