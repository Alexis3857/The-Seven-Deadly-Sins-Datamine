public class DBMazeNeedHeroRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public byte NpcUse
    {
        get
        {
            return npc_use;
        }
    }

    public int HeroId
    {
        get
        {
            return hero_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        group_id = reader.ReadInt32();
        npc_use = reader.ReadByte();
        hero_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int group_id;

    private byte npc_use;

    private int hero_id;
}
