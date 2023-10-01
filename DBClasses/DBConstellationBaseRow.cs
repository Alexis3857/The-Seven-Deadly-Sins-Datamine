public class DBConstellationBaseRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string ConstellationName
    {
        get
        {
            return constellation_name.Localize();
        }
    }

    public string ConstellationIcon
    {
        get
        {
            return constellation_icon;
        }
    }

    public int ConstellationGroupId
    {
        get
        {
            return constellation_group_id;
        }
    }

    public int ResetItemId
    {
        get
        {
            return reset_item_id;
        }
    }

    public int ResetItemValue
    {
        get
        {
            return reset_item_value;
        }
    }

    public int ItemChargeLimit
    {
        get
        {
            return item_charge_limit;
        }
    }

    public int ResetPartsItemId
    {
        get
        {
            return reset_parts_item_id;
        }
    }

    public int ResetPartsItemValue
    {
        get
        {
            return reset_parts_item_value;
        }
    }

    public int LockItemId
    {
        get
        {
            return lock_item_id;
        }
    }

    public int LockItemValue1
    {
        get
        {
            return lock_item_value_1;
        }
    }

    public int LockItemValue2
    {
        get
        {
            return lock_item_value_2;
        }
    }

    public int LockItemValue3
    {
        get
        {
            return lock_item_value_3;
        }
    }

    public int LockItemValue4
    {
        get
        {
            return lock_item_value_4;
        }
    }

    public int LockManastoneLimit
    {
        get
        {
            return lock_manastone_limit;
        }
    }

    public int OpenConditonId
    {
        get
        {
            return open_conditon_id;
        }
    }

    public int ConstellationLock
    {
        get
        {
            return constellation_lock;
        }
    }

    public int Atk
    {
        get
        {
            return atk;
        }
    }

    public int Def
    {
        get
        {
            return def;
        }
    }

    public int Hp
    {
        get
        {
            return hp;
        }
    }

    public List<int> ListArrayChaosConstellatiion
    {
        get
        {
            return list_array_chaos_constellation;
        }
    }

    public string IconSymbol
    {
        get
        {
            return icon_symbol;
        }
    }

    public string IconNextSymbol
    {
        get
        {
            return icon_next_symbol;
        }
    }

    public int ChaosEnable
    {
        get
        {
            return chaos_enable;
        }
    }

    public List<int> ListLockItemValue
    {
        get
        {
            if (list_lock_item_value == null)
            {
                list_lock_item_value = new List<int>
                {
                    LockItemValue1,
                    LockItemValue2,
                    LockItemValue3,
                    LockItemValue4
                };
            }
            return list_lock_item_value;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        constellation_name = reader.ReadInt32();
        constellation_icon = reader.ReadString();
        constellation_group_id = reader.ReadInt32();
        reset_item_id = reader.ReadInt32();
        reset_item_value = reader.ReadInt32();
        item_charge_limit = reader.ReadInt32();
        reset_parts_item_id = reader.ReadInt32();
        reset_parts_item_value = reader.ReadInt32();
        lock_item_id = reader.ReadInt32();
        lock_item_value_1 = reader.ReadInt32();
        lock_item_value_2 = reader.ReadInt32();
        lock_item_value_3 = reader.ReadInt32();
        lock_item_value_4 = reader.ReadInt32();
        lock_manastone_limit = reader.ReadInt32();
        open_conditon_id = reader.ReadInt32();
        constellation_lock = reader.ReadInt32();
        atk = reader.ReadInt32();
        def = reader.ReadInt32();
        hp = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_chaos_constellation = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_chaos_constellation.Add(reader.ReadInt32());
        }
        icon_symbol = reader.ReadString();
        icon_next_symbol = reader.ReadString();
        chaos_enable = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int constellation_name;

    private string constellation_icon;

    private int constellation_group_id;

    private int reset_item_id;

    private int reset_item_value;

    private int item_charge_limit;

    private int reset_parts_item_id;

    private int reset_parts_item_value;

    private int lock_item_id;

    private int lock_item_value_1;

    private int lock_item_value_2;

    private int lock_item_value_3;

    private int lock_item_value_4;

    private int lock_manastone_limit;

    private int open_conditon_id;

    private int constellation_lock;

    private int atk;

    private int def;

    private int hp;

    private List<int> list_array_chaos_constellation;

    private string icon_symbol;

    private string icon_next_symbol;

    private int chaos_enable;

    private List<int> list_lock_item_value;
}
