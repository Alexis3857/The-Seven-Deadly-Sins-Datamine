public class DBQuestEventStepupGroupRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string QuestClass
    {
        get
        {
            return quest_class;
        }
    }

    public string StepupMissionQuestTitle
    {
        get
        {
            return stepup_mission_quest_title.Localize();
        }
    }

    public List<int> ListArrayStepupMissionQuestGroupList
    {
        get
        {
            return list_array_stepup_mission_quest_group_list;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        quest_class = reader.ReadString();
        stepup_mission_quest_title = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_stepup_mission_quest_group_list = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_stepup_mission_quest_group_list.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string quest_class;

    private int stepup_mission_quest_title;

    private List<int> list_array_stepup_mission_quest_group_list;
}
