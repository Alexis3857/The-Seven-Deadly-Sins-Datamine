﻿public class DBAiCustomizingEtcRow
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EtcName
    {
        get
        {
            return etc_name;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        etc_name = reader.ReadInt32();
        return true;
    }

    private int id;

    private int etc_name;
}
