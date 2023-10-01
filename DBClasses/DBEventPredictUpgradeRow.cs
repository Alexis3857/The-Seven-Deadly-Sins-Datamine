public class DBEventPredictUpgradeRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public int UpgradeGrade
    {
        get
        {
            return upgrade_grade;
        }
    }

    public int UpgradeItemId
    {
        get
        {
            return upgrade_item_id;
        }
    }

    public int UpgradeItemCount
    {
        get
        {
            return upgrade_item_count;
        }
    }

    public int GetScore
    {
        get
        {
            return get_score;
        }
    }

    public string IconName
    {
        get
        {
            return icon_name;
        }
    }

    public string SideNpcAnim
    {
        get
        {
            return side_npc_anim;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        upgrade_grade = reader.ReadInt32();
        upgrade_item_id = reader.ReadInt32();
        upgrade_item_count = reader.ReadInt32();
        get_score = reader.ReadInt32();
        icon_name = reader.ReadString();
        side_npc_anim = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int upgrade_grade;

    private int upgrade_item_id;

    private int upgrade_item_count;

    private int get_score;

    private string icon_name;

    private string side_npc_anim;
}
