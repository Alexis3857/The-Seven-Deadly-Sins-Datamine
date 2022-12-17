public class DBEventBingoRandomRow
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

    public int HighlightNumbers
    {
        get
        {
            return Highlight_numbers;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        bingo_event_type = reader.ReadInt32();
        bingo_event_board_view_number = reader.ReadInt32();
        bingo_event_numberitem = reader.ReadInt32();
        Highlight_numbers = reader.ReadInt32();
        return true;
    }

    private int id;

    private int event_sub_index;

    private int bingo_event_type;

    private int bingo_event_board_view_number;

    private int bingo_event_numberitem;

    private int Highlight_numbers;
}
