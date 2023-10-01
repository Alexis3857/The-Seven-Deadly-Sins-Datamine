public class DBEventMissionRewardRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int MissionGroup
    {
        get
        {
            return mission_group;
        }
    }

    public int ItemId1
    {
        get
        {
            return item_id_1;
        }
    }

    public int ItemCount1
    {
        get
        {
            return item_count_1;
        }
    }

    public int SkinLevel1
    {
        get
        {
            return skin_level_1;
        }
    }

    public int SkinAwaken1
    {
        get
        {
            return skin_awaken_1;
        }
    }

    public List<int> ListItemId
    {
        get
        {
            if (list_item_id == null)
            {
                list_item_id = new List<int>
                {
                    ItemId1
                };
            }
            return list_item_id;
        }
    }

    public List<int> ListItemCount
    {
        get
        {
            if (list_item_count == null)
            {
                list_item_count = new List<int>
                {
                    ItemCount1
                };
            }
            return list_item_count;
        }
    }

    public List<int> ListSkinLevel
    {
        get
        {
            if (list_skin_level == null)
            {
                list_skin_level = new List<int>
                {
                    SkinLevel1
                };
            }
            return list_skin_level;
        }
    }

    public List<int> ListSkinAwaken
    {
        get
        {
            if (list_skin_awaken == null)
            {
                list_skin_awaken = new List<int>
                {
                    SkinAwaken1
                };
            }
            return list_skin_awaken;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        mission_group = reader.ReadInt32();
        item_id_1 = reader.ReadInt32();
        item_count_1 = reader.ReadInt32();
        skin_level_1 = reader.ReadInt32();
        skin_awaken_1 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int mission_group;

    private int item_id_1;

    private int item_count_1;

    private int skin_level_1;

    private int skin_awaken_1;

    private List<int> list_item_id;

    private List<int> list_item_count;

    private List<int> list_skin_level;

    private List<int> list_skin_awaken;
}
