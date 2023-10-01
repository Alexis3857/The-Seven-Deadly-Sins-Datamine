public class DBGambleRotationSetRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GambleGroup
    {
        get
        {
            return gamble_group;
        }
    }

    public int SkinId
    {
        get
        {
            return skin_id;
        }
    }

    public string HeroIconFileName
    {
        get
        {
            return hero_icon_file_name;
        }
    }

    public string HeroIconName
    {
        get
        {
            return hero_icon_name;
        }
    }

    public int RotationGroup
    {
        get
        {
            return rotation_group;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        gamble_group = reader.ReadInt32();
        skin_id = reader.ReadInt32();
        hero_icon_file_name = reader.ReadString();
        hero_icon_name = reader.ReadString();
        rotation_group = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int gamble_group;

    private int skin_id;

    private string hero_icon_file_name;

    private string hero_icon_name;

    private int rotation_group;
}
