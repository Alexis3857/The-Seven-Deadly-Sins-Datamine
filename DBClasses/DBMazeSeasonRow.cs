public class DBMazeSeasonRow : ITableRowIndexer
{
    public int SeasonId
    {
        get
        {
            return season_id;
        }
    }

    public int SeasonType
    {
        get
        {
            return season_type;
        }
    }

    public string SeasonTitle
    {
        get
        {
            return season_title.Localize();
        }
    }

    public string SeasonDesc
    {
        get
        {
            return season_desc.Localize();
        }
    }

    public int NeedStaminaItemId
    {
        get
        {
            return need_stamina_item_id;
        }
    }

    public int NeedStaminaCount
    {
        get
        {
            return need_stamina_count;
        }
    }

    public int SeasonPriceID
    {
        get
        {
            return season_price_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        season_id = reader.ReadInt32();
        season_type = reader.ReadInt32();
        season_title = reader.ReadInt32();
        season_desc = reader.ReadInt32();
        need_stamina_item_id = reader.ReadInt32();
        need_stamina_count = reader.ReadInt32();
        season_price_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return SeasonId;
    }

    private int season_id;

    private int season_type;

    private int season_title;

    private int season_desc;

    private int need_stamina_item_id;

    private int need_stamina_count;

    private int season_price_id;
}
