public class DBEvolutionBreakMaxRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int NeedQuestId
    {
        get
        {
            return need_quest_id;
        }
    }

    public int NeedMainStageId
    {
        get
        {
            return need_main_stage_id;
        }
    }

    public int RedEvolutionBreakMax
    {
        get
        {
            return red_evolution_break_max;
        }
    }

    public int GreenEvolutionBreakMax
    {
        get
        {
            return green_evolution_break_max;
        }
    }

    public int BlueEvolutionBreakMax
    {
        get
        {
            return blue_evolution_break_max;
        }
    }

    public int YellowEvolutionBreakMax
    {
        get
        {
            return yellow_evolution_break_max;
        }
    }

    public int PurpleEvolutionBreakMax
    {
        get
        {
            return purple_evolution_break_max;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        need_quest_id = reader.ReadInt32();
        need_main_stage_id = reader.ReadInt32();
        red_evolution_break_max = reader.ReadInt32();
        green_evolution_break_max = reader.ReadInt32();
        blue_evolution_break_max = reader.ReadInt32();
        yellow_evolution_break_max = reader.ReadInt32();
        purple_evolution_break_max = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int need_quest_id;

    private int need_main_stage_id;

    private int red_evolution_break_max;

    private int green_evolution_break_max;

    private int blue_evolution_break_max;

    private int yellow_evolution_break_max;

    private int purple_evolution_break_max;
}
