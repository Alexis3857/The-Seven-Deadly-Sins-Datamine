public class DBArSystemsRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int IsUnlockedLobbyArIos
    {
        get
        {
            return is_unlocked_lobby_ar_ios;
        }
    }

    public int IsUnlockedLobbyArAos
    {
        get
        {
            return is_unlocked_lobby_ar_aos;
        }
    }

    public int IsUnlockedIngameArIos
    {
        get
        {
            return is_unlocked_ingame_ar_ios;
        }
    }

    public int IsUnlockedIngameArAos
    {
        get
        {
            return is_unlocked_ingame_ar_aos;
        }
    }

    public int IsUnlockedLobbyArRecord
    {
        get
        {
            return is_unlocked_lobby_ar_record;
        }
    }

    public int AndroidMinApiLevel
    {
        get
        {
            return android_min_api_level;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        is_unlocked_lobby_ar_ios = reader.ReadInt32();
        is_unlocked_lobby_ar_aos = reader.ReadInt32();
        is_unlocked_ingame_ar_ios = reader.ReadInt32();
        is_unlocked_ingame_ar_aos = reader.ReadInt32();
        is_unlocked_lobby_ar_record = reader.ReadInt32();
        android_min_api_level = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int is_unlocked_lobby_ar_ios;

    private int is_unlocked_lobby_ar_aos;

    private int is_unlocked_ingame_ar_ios;

    private int is_unlocked_ingame_ar_aos;

    private int is_unlocked_lobby_ar_record;

    private int android_min_api_level;
}
