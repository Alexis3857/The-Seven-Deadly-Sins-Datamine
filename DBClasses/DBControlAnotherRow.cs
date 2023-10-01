public class DBControlAnotherRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int NeedStoryQuestId
    {
        get
        {
            return need_story_quest_id;
        }
    }

    public string QuestAlarmName
    {
        get
        {
            return quest_alarm_name.Localize();
        }
    }

    public string QuestAlarmDesc
    {
        get
        {
            return quest_alarm_desc.Localize();
        }
    }

    public string LargePopupName
    {
        get
        {
            return large_popup_name;
        }
    }

    public int DirectSelectorId
    {
        get
        {
            return direct_selector_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        need_story_quest_id = reader.ReadInt32();
        quest_alarm_name = reader.ReadInt32();
        quest_alarm_desc = reader.ReadInt32();
        large_popup_name = reader.ReadString();
        direct_selector_id = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int need_story_quest_id;

    private int quest_alarm_name;

    private int quest_alarm_desc;

    private string large_popup_name;

    private int direct_selector_id;
}
