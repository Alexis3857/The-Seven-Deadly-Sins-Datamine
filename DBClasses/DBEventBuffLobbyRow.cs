﻿public class DBEventBuffLobbyRow
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string PassiveType
    {
        get
        {
            return passive_type;
        }
    }

    public int PassiveId
    {
        get
        {
            return passive_id;
        }
    }

    public int Point
    {
        get
        {
            return point;
        }
    }

    public int ApplyType
    {
        get
        {
            return apply_type;
        }
    }

    public int ApplyTypeValue
    {
        get
        {
            return apply_type_value;
        }
    }

    public int Group
    {
        get
        {
            return group;
        }
    }

    public int LevelGroup
    {
        get
        {
            return level_group;
        }
    }

    public int ExpGroup
    {
        get
        {
            return exp_group;
        }
    }

    public string BuffActivationDate
    {
        get
        {
            return buff_activation_date;
        }
    }

    public string BuffDeactivationDate
    {
        get
        {
            return buff_deactivation_date;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        passive_type = reader.ReadString();
        passive_id = reader.ReadInt32();
        point = reader.ReadInt32();
        apply_type = reader.ReadInt32();
        apply_type_value = reader.ReadInt32();
        group = reader.ReadInt32();
        level_group = reader.ReadInt32();
        exp_group = reader.ReadInt32();
        buff_activation_date = reader.ReadString();
        buff_deactivation_date = reader.ReadString();
        return true;
    }

    private int id;

    private string passive_type;

    private int passive_id;

    private int point;

    private int apply_type;

    private int apply_type_value;

    private int group;

    private int level_group;

    private int exp_group;

    private string buff_activation_date;

    private string buff_deactivation_date;
}
