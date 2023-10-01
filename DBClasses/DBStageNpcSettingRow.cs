public class DBStageNpcSettingRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string EventType
    {
        get
        {
            return event_type;
        }
    }

    public int StageNpcSlot1
    {
        get
        {
            return stage_npc_slot_1;
        }
    }

    public int StageNpcSlot2
    {
        get
        {
            return stage_npc_slot_2;
        }
    }

    public int StageNpcSlot3
    {
        get
        {
            return stage_npc_slot_3;
        }
    }

    public int StageNpcSlot4
    {
        get
        {
            return stage_npc_slot_4;
        }
    }

    public string NpcTeamName
    {
        get
        {
            return npc_team_name.Localize();
        }
    }

    public int MainHeroId1
    {
        get
        {
            return main_hero_id_1;
        }
    }

    public int MainHeroId2
    {
        get
        {
            return main_hero_id_2;
        }
    }

    public int MainHeroId3
    {
        get
        {
            return main_hero_id_3;
        }
    }

    public int MainHeroId4
    {
        get
        {
            return main_hero_id_4;
        }
    }

    public List<int> ListStageNpcSlot
    {
        get
        {
            if (list_stage_npc_slot == null)
            {
                list_stage_npc_slot = new List<int>
                {
                    StageNpcSlot1,
                    StageNpcSlot2,
                    StageNpcSlot3,
                    StageNpcSlot4
                };
            }
            return list_stage_npc_slot;
        }
    }

    public List<int> ListMainHeroId
    {
        get
        {
            if (list_main_hero_id == null)
            {
                list_main_hero_id = new List<int>
                {
                    MainHeroId1,
                    MainHeroId2,
                    MainHeroId3,
                    MainHeroId4
                };
            }
            return list_main_hero_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_type = reader.ReadString();
        stage_npc_slot_1 = reader.ReadInt32();
        stage_npc_slot_2 = reader.ReadInt32();
        stage_npc_slot_3 = reader.ReadInt32();
        stage_npc_slot_4 = reader.ReadInt32();
        npc_team_name = reader.ReadInt32();
        main_hero_id_1 = reader.ReadInt32();
        main_hero_id_2 = reader.ReadInt32();
        main_hero_id_3 = reader.ReadInt32();
        main_hero_id_4 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string event_type;

    private int stage_npc_slot_1;

    private int stage_npc_slot_2;

    private int stage_npc_slot_3;

    private int stage_npc_slot_4;

    private int npc_team_name;

    private int main_hero_id_1;

    private int main_hero_id_2;

    private int main_hero_id_3;

    private int main_hero_id_4;

    private List<int> list_stage_npc_slot;

    private List<int> list_main_hero_id;
}
