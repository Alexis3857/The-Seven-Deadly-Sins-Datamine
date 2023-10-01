public class DBEventDiceMissionRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int MissionId
    {
        get
        {
            return mission_id;
        }
    }

    public List<int> ListArrayMatchingDiceCombo
    {
        get
        {
            return list_array_matching_dice_combo;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        mission_id = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_matching_dice_combo = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_matching_dice_combo.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int mission_id;

    private List<int> list_array_matching_dice_combo;
}
