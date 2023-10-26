public class DBEventBingoRandomRow : ITableRowIndexer
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

    public int BingoEventType
    {
        get
        {
            return bingo_event_type;
        }
    }

    public int HighlightNumbers
    {
        get
        {
            return highlight_numbers;
        }
    }

    public int BingoEventBoardViewNumber
    {
        get
        {
            return bingo_event_board_view_number;
        }
    }

    public int BingoEventNumberitem
    {
        get
        {
            return bingo_event_numberitem;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        bingo_event_type = reader.ReadInt32();
        highlight_numbers = reader.ReadInt32();
        bingo_event_board_view_number = reader.ReadInt32();
        bingo_event_numberitem = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int bingo_event_type;

    private int highlight_numbers;

    private int bingo_event_board_view_number;

    private int bingo_event_numberitem;
}
