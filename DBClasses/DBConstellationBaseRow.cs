﻿public class DBConstellationBaseRow
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

    public int LockItemId
    {
        get
        {
            return lock_item_id;
        }
    }

    public int LockItemValue
    {
        get
        {
            return lock_item_value;
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

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        constellation_name = reader.ReadInt32();
        constellation_icon = reader.ReadString();
        constellation_group_id = reader.ReadInt32();
        reset_item_id = reader.ReadInt32();
        reset_item_value = reader.ReadInt32();
        lock_item_id = reader.ReadInt32();
        lock_item_value = reader.ReadInt32();
        open_conditon_id = reader.ReadInt32();
        constellation_lock = reader.ReadInt32();
        atk = reader.ReadInt32();
        def = reader.ReadInt32();
        hp = reader.ReadInt32();
        icon_symbol = reader.ReadString();
        icon_next_symbol = reader.ReadString();
        chaos_enable = reader.ReadInt32();
        return true;
    }

    private int id;

    private int constellation_name;

    private string constellation_icon;

    private int constellation_group_id;

    private int reset_item_id;

    private int reset_item_value;

    private int lock_item_id;

    private int lock_item_value;

    private int open_conditon_id;

    private int constellation_lock;

    private int atk;

    private int def;

    private int hp;

    private string icon_symbol;

    private string icon_next_symbol;

    private int chaos_enable;
}
