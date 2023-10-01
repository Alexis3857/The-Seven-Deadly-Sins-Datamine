public class DBStageEventTowerSeasonRow : ITableRowIndexer
{
    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public int TowerGroupCutin
    {
        get
        {
            return tower_group_cutin;
        }
    }

    public string BgEventTowerLobbyRoute
    {
        get
        {
            return bg_event_tower_lobby_route;
        }
    }

    public string BgEventTowerLobby
    {
        get
        {
            return bg_event_tower_lobby;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        group_id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        tower_group_cutin = reader.ReadInt32();
        bg_event_tower_lobby_route = reader.ReadString();
        bg_event_tower_lobby = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return GroupId;
    }

    private int group_id;

    private int event_sub_index;

    private int tower_group_cutin;

    private string bg_event_tower_lobby_route;

    private string bg_event_tower_lobby;
}
