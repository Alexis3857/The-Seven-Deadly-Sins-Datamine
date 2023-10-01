public class DBGambleTimeSwitchRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int MainGambleID
    {
        get
        {
            return main_gamble_ID;
        }
    }

    public int TargetGambleID
    {
        get
        {
            return target_gamble_ID;
        }
    }

    public int SwitchStartDate
    {
        get
        {
            return switch_start_date;
        }
    }

    public int SwitchEndDate
    {
        get
        {
            return switch_end_date;
        }
    }

    public string LobbyEventIconName
    {
        get
        {
            return lobby_event_icon_name;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        main_gamble_ID = reader.ReadInt32();
        target_gamble_ID = reader.ReadInt32();
        switch_start_date = reader.ReadInt32();
        switch_end_date = reader.ReadInt32();
        lobby_event_icon_name = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int main_gamble_ID;

    private int target_gamble_ID;

    private int switch_start_date;

    private int switch_end_date;

    private string lobby_event_icon_name;
}
