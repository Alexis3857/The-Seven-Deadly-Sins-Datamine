public class DBEventRandomBoxDrawRateRow : ITableRowIndexer
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

    public int BoxType
    {
        get
        {
            return box_type;
        }
    }

    public int CheckFixDraw
    {
        get
        {
            return check_fix_draw;
        }
    }

    public int DrawCountPerPlay
    {
        get
        {
            return draw_count_per_play;
        }
    }

    public int DrawRate
    {
        get
        {
            return draw_rate;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        box_type = reader.ReadInt32();
        check_fix_draw = reader.ReadInt32();
        draw_count_per_play = reader.ReadInt32();
        draw_rate = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int box_type;

    private int check_fix_draw;

    private int draw_count_per_play;

    private int draw_rate;
}
