public class DBSkinAniRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string AniSelect
    {
        get
        {
            return ani_select;
        }
    }

    public string AniLevelup1
    {
        get
        {
            return ani_levelup_1;
        }
    }

    public string AniLevelup2
    {
        get
        {
            return ani_levelup_2;
        }
    }

    public string AniAwaken1
    {
        get
        {
            return ani_awaken_1;
        }
    }

    public string AniAwaken2
    {
        get
        {
            return ani_awaken_2;
        }
    }

    public string AniCapacityup1
    {
        get
        {
            return ani_capacityup_1;
        }
    }

    public string AniCapacityup2
    {
        get
        {
            return ani_capacityup_2;
        }
    }

    public string AniResearch1
    {
        get
        {
            return ani_research_1;
        }
    }

    public string AniResearch2
    {
        get
        {
            return ani_research_2;
        }
    }

    public string AniItem1
    {
        get
        {
            return ani_item_1;
        }
    }

    public string AniItem2
    {
        get
        {
            return ani_item_2;
        }
    }

    public int AwakenNeckAniCheck
    {
        get
        {
            return awaken_neck_ani_check;
        }
    }

    public List<string> ListAniLevelup
    {
        get
        {
            if (list_ani_levelup == null)
            {
                list_ani_levelup = new List<string>
                {
                    AniLevelup1,
                    AniLevelup2
                };
            }
            return list_ani_levelup;
        }
    }

    public List<string> ListAniAwaken
    {
        get
        {
            if (list_ani_awaken == null)
            {
                list_ani_awaken = new List<string>
                {
                    AniAwaken1,
                    AniAwaken2
                };
            }
            return list_ani_awaken;
        }
    }

    public List<string> ListAniCapacityup
    {
        get
        {
            if (list_ani_capacityup == null)
            {
                list_ani_capacityup = new List<string>
                {
                    AniCapacityup1,
                    AniCapacityup2
                };
            }
            return list_ani_capacityup;
        }
    }

    public List<string> ListAniResearch
    {
        get
        {
            if (list_ani_research == null)
            {
                list_ani_research = new List<string>
                {
                    AniResearch1,
                    AniResearch2
                };
            }
            return list_ani_research;
        }
    }

    public List<string> ListAniItem
    {
        get
        {
            if (list_ani_item == null)
            {
                list_ani_item = new List<string>
                {
                    AniItem1,
                    AniItem2
                };
            }
            return list_ani_item;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        ani_select = reader.ReadString();
        ani_levelup_1 = reader.ReadString();
        ani_levelup_2 = reader.ReadString();
        ani_awaken_1 = reader.ReadString();
        ani_awaken_2 = reader.ReadString();
        ani_capacityup_1 = reader.ReadString();
        ani_capacityup_2 = reader.ReadString();
        ani_research_1 = reader.ReadString();
        ani_research_2 = reader.ReadString();
        ani_item_1 = reader.ReadString();
        ani_item_2 = reader.ReadString();
        awaken_neck_ani_check = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string ani_select;

    private string ani_levelup_1;

    private string ani_levelup_2;

    private string ani_awaken_1;

    private string ani_awaken_2;

    private string ani_capacityup_1;

    private string ani_capacityup_2;

    private string ani_research_1;

    private string ani_research_2;

    private string ani_item_1;

    private string ani_item_2;

    private int awaken_neck_ani_check;

    private List<string> list_ani_levelup;

    private List<string> list_ani_awaken;

    private List<string> list_ani_capacityup;

    private List<string> list_ani_research;

    private List<string> list_ani_item;
}
