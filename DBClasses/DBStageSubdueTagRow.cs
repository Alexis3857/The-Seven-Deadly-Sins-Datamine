public class DBStageSubdueTagRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string TagIconFileName
    {
        get
        {
            return tag_icon_file_name;
        }
    }

    public List<int> ListArrayTagGaugeColorcode
    {
        get
        {
            return list_array_tag_gauge_colorcode;
        }
    }

    public string TagChangeType1
    {
        get
        {
            return tag_change_type_1;
        }
    }

    public int TagChangeValue1
    {
        get
        {
            return tag_change_value_1;
        }
    }

    public string TagChangeBoss1
    {
        get
        {
            return tag_change_boss_1;
        }
    }

    public string TagChangeAni1
    {
        get
        {
            return tag_change_ani_1;
        }
    }

    public int TagChangeEffect1
    {
        get
        {
            return tag_change_effect_1;
        }
    }

    public string TagChangeType2
    {
        get
        {
            return tag_change_type_2;
        }
    }

    public int TagChangeValue2
    {
        get
        {
            return tag_change_value_2;
        }
    }

    public string TagChangeBoss2
    {
        get
        {
            return tag_change_boss_2;
        }
    }

    public string TagChangeAni2
    {
        get
        {
            return tag_change_ani_2;
        }
    }

    public int TagChangeEffect2
    {
        get
        {
            return tag_change_effect_2;
        }
    }

    public List<string> ListTagChangeType
    {
        get
        {
            if (list_tag_change_type == null)
            {
                list_tag_change_type = new List<string>
                {
                    TagChangeType1,
                    TagChangeType2
                };
            }
            return list_tag_change_type;
        }
    }

    public List<int> ListTagChangeValue
    {
        get
        {
            if (list_tag_change_value == null)
            {
                list_tag_change_value = new List<int>
                {
                    TagChangeValue1,
                    TagChangeValue2
                };
            }
            return list_tag_change_value;
        }
    }

    public List<string> ListTagChangeBoss
    {
        get
        {
            if (list_tag_change_boss == null)
            {
                list_tag_change_boss = new List<string>
                {
                    TagChangeBoss1,
                    TagChangeBoss2
                };
            }
            return list_tag_change_boss;
        }
    }

    public List<string> ListTagChangeAni
    {
        get
        {
            if (list_tag_change_ani == null)
            {
                list_tag_change_ani = new List<string>
                {
                    TagChangeAni1,
                    TagChangeAni2
                };
            }
            return list_tag_change_ani;
        }
    }

    public List<int> ListTagChangeEffect
    {
        get
        {
            if (list_tag_change_effect == null)
            {
                list_tag_change_effect = new List<int>
                {
                    TagChangeEffect1,
                    TagChangeEffect2
                };
            }
            return list_tag_change_effect;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        tag_icon_file_name = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_tag_gauge_colorcode = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_tag_gauge_colorcode.Add(reader.ReadInt32());
        }
        tag_change_type_1 = reader.ReadString();
        tag_change_value_1 = reader.ReadInt32();
        tag_change_boss_1 = reader.ReadString();
        tag_change_ani_1 = reader.ReadString();
        tag_change_effect_1 = reader.ReadInt32();
        tag_change_type_2 = reader.ReadString();
        tag_change_value_2 = reader.ReadInt32();
        tag_change_boss_2 = reader.ReadString();
        tag_change_ani_2 = reader.ReadString();
        tag_change_effect_2 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string tag_icon_file_name;

    private List<int> list_array_tag_gauge_colorcode;

    private string tag_change_type_1;

    private int tag_change_value_1;

    private string tag_change_boss_1;

    private string tag_change_ani_1;

    private int tag_change_effect_1;

    private string tag_change_type_2;

    private int tag_change_value_2;

    private string tag_change_boss_2;

    private string tag_change_ani_2;

    private int tag_change_effect_2;

    private List<string> list_tag_change_type;

    private List<int> list_tag_change_value;

    private List<string> list_tag_change_boss;

    private List<string> list_tag_change_ani;

    private List<int> list_tag_change_effect;
}
