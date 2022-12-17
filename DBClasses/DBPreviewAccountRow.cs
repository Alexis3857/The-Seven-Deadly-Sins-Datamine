﻿public class DBPreviewAccountRow
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string Name
    {
        get
        {
            return name;
        }
    }

    public string Password
    {
        get
        {
            return password;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        name = reader.ReadString();
        password = reader.ReadString();
        return true;
    }

    private int id;

    private string name;

    private string password;
}
