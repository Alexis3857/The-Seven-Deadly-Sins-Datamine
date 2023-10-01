public class DBEventConquestProductionRow : ITableRowIndexer
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

    public string ProductionName
    {
        get
        {
            return production_name.Localize();
        }
    }

    public string ProductionIcon
    {
        get
        {
            return production_icon;
        }
    }

    public string ProductionIconRenderer
    {
        get
        {
            return production_icon_renderer;
        }
    }

    public int ProductionPosition
    {
        get
        {
            return production_position;
        }
    }

    public int ProductionIndex
    {
        get
        {
            return production_index;
        }
    }

    public int ProductionLevel
    {
        get
        {
            return production_level;
        }
    }

    public int LevelUpItemId
    {
        get
        {
            return level_up_item_id;
        }
    }

    public int LevelUpItemCount
    {
        get
        {
            return level_up_item_count;
        }
    }

    public int ProductItemId
    {
        get
        {
            return product_item_id;
        }
    }

    public int ProductItemCount
    {
        get
        {
            return product_item_count;
        }
    }

    public int ProductItemTime
    {
        get
        {
            return product_item_time;
        }
    }

    public int ProductItemSaveMax
    {
        get
        {
            return product_item_save_max;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        production_name = reader.ReadInt32();
        production_icon = reader.ReadString();
        production_icon_renderer = reader.ReadString();
        production_position = reader.ReadInt32();
        production_index = reader.ReadInt32();
        production_level = reader.ReadInt32();
        level_up_item_id = reader.ReadInt32();
        level_up_item_count = reader.ReadInt32();
        product_item_id = reader.ReadInt32();
        product_item_count = reader.ReadInt32();
        product_item_time = reader.ReadInt32();
        product_item_save_max = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int production_name;

    private string production_icon;

    private string production_icon_renderer;

    private int production_position;

    private int production_index;

    private int production_level;

    private int level_up_item_id;

    private int level_up_item_count;

    private int product_item_id;

    private int product_item_count;

    private int product_item_time;

    private int product_item_save_max;
}