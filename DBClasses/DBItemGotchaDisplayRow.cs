public class DBItemGotchaDisplayRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int UiGroup
    {
        get
        {
            return ui_group;
        }
    }

    public int GotchaType
    {
        get
        {
            return gotcha_type;
        }
    }

    public int GotchaControl
    {
        get
        {
            return gotcha_control;
        }
    }

    public int GotchaGroup
    {
        get
        {
            return gotcha_group;
        }
    }

    public int GotchaFreeCount
    {
        get
        {
            return gotcha_free_count;
        }
    }

    public int GotchaLimitCount
    {
        get
        {
            return gotcha_limit_count;
        }
    }

    public int GotchaCount1
    {
        get
        {
            return gotcha_count_1;
        }
    }

    public int GotchaMoneyId1
    {
        get
        {
            return gotcha_money_id_1;
        }
    }

    public int GotchaMoneyCount1
    {
        get
        {
            return gotcha_money_count_1;
        }
    }

    public int MoneyRaisingvalue1
    {
        get
        {
            return money_raisingvalue_1;
        }
    }

    public int MoneyRaiseMax1
    {
        get
        {
            return money_raise_max_1;
        }
    }

    public int GotchaCount2
    {
        get
        {
            return gotcha_count_2;
        }
    }

    public int GotchaMoneyId2
    {
        get
        {
            return gotcha_money_id_2;
        }
    }

    public int GotchaMoneyCount2
    {
        get
        {
            return gotcha_money_count_2;
        }
    }

    public int MoneyRaisingvalue2
    {
        get
        {
            return money_raisingvalue_2;
        }
    }

    public int MoneyRaiseMax2
    {
        get
        {
            return money_raise_max_2;
        }
    }

    public int GotchaCount3
    {
        get
        {
            return gotcha_count_3;
        }
    }

    public int GotchaMoneyId3
    {
        get
        {
            return gotcha_money_id_3;
        }
    }

    public int GotchaMoneyCount3
    {
        get
        {
            return gotcha_money_count_3;
        }
    }

    public int MoneyRaisingvalue3
    {
        get
        {
            return money_raisingvalue_3;
        }
    }

    public int MoneyRaiseMax3
    {
        get
        {
            return money_raise_max_3;
        }
    }

    public string GotchaBGName
    {
        get
        {
            return gotcha_BG_name;
        }
    }

    public string GotchaDesc
    {
        get
        {
            return gotcha_desc.Localize();
        }
    }

    public string GotchaResource
    {
        get
        {
            return gotcha_resource;
        }
    }

    public List<int> ListGotchaCount
    {
        get
        {
            if (list_gotcha_count == null)
            {
                list_gotcha_count = new List<int>
                {
                    GotchaCount1,
                    GotchaCount2,
                    GotchaCount3
                };
            }
            return list_gotcha_count;
        }
    }

    public List<int> ListGotchaMoneyId
    {
        get
        {
            if (list_gotcha_money_id == null)
            {
                list_gotcha_money_id = new List<int>
                {
                    GotchaMoneyId1,
                    GotchaMoneyId2,
                    GotchaMoneyId3
                };
            }
            return list_gotcha_money_id;
        }
    }

    public List<int> ListGotchaMoneyCount
    {
        get
        {
            if (list_gotcha_money_count == null)
            {
                list_gotcha_money_count = new List<int>
                {
                    GotchaMoneyCount1,
                    GotchaMoneyCount2,
                    GotchaMoneyCount3
                };
            }
            return list_gotcha_money_count;
        }
    }

    public List<int> ListMoneyRaisingvalue
    {
        get
        {
            if (list_money_raisingvalue == null)
            {
                list_money_raisingvalue = new List<int>
                {
                    MoneyRaisingvalue1,
                    MoneyRaisingvalue2,
                    MoneyRaisingvalue3
                };
            }
            return list_money_raisingvalue;
        }
    }

    public List<int> ListMoneyRaiseMax
    {
        get
        {
            if (list_money_raise_max == null)
            {
                list_money_raise_max = new List<int>
                {
                    MoneyRaiseMax1,
                    MoneyRaiseMax2,
                    MoneyRaiseMax3
                };
            }
            return list_money_raise_max;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        ui_group = reader.ReadInt32();
        gotcha_type = reader.ReadInt32();
        gotcha_control = reader.ReadInt32();
        gotcha_group = reader.ReadInt32();
        gotcha_free_count = reader.ReadInt32();
        gotcha_limit_count = reader.ReadInt32();
        gotcha_count_1 = reader.ReadInt32();
        gotcha_money_id_1 = reader.ReadInt32();
        gotcha_money_count_1 = reader.ReadInt32();
        money_raisingvalue_1 = reader.ReadInt32();
        money_raise_max_1 = reader.ReadInt32();
        gotcha_count_2 = reader.ReadInt32();
        gotcha_money_id_2 = reader.ReadInt32();
        gotcha_money_count_2 = reader.ReadInt32();
        money_raisingvalue_2 = reader.ReadInt32();
        money_raise_max_2 = reader.ReadInt32();
        gotcha_count_3 = reader.ReadInt32();
        gotcha_money_id_3 = reader.ReadInt32();
        gotcha_money_count_3 = reader.ReadInt32();
        money_raisingvalue_3 = reader.ReadInt32();
        money_raise_max_3 = reader.ReadInt32();
        gotcha_BG_name = reader.ReadString();
        gotcha_desc = reader.ReadInt32();
        gotcha_resource = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int ui_group;

    private int gotcha_type;

    private int gotcha_control;

    private int gotcha_group;

    private int gotcha_free_count;

    private int gotcha_limit_count;

    private int gotcha_count_1;

    private int gotcha_money_id_1;

    private int gotcha_money_count_1;

    private int money_raisingvalue_1;

    private int money_raise_max_1;

    private int gotcha_count_2;

    private int gotcha_money_id_2;

    private int gotcha_money_count_2;

    private int money_raisingvalue_2;

    private int money_raise_max_2;

    private int gotcha_count_3;

    private int gotcha_money_id_3;

    private int gotcha_money_count_3;

    private int money_raisingvalue_3;

    private int money_raise_max_3;

    private string gotcha_BG_name;

    private int gotcha_desc;

    private string gotcha_resource;

    private List<int> list_gotcha_count;

    private List<int> list_gotcha_money_id;

    private List<int> list_gotcha_money_count;

    private List<int> list_money_raisingvalue;

    private List<int> list_money_raise_max;
}
